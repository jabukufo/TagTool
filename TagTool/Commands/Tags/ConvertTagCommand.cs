using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TagTool.Common;
using TagTool.Cache;
using TagTool.IO;
using TagTool.Geometry;
using TagTool.Serialization;
using TagTool.TagDefinitions;
using TagTool.TagResources;

namespace TagTool.Commands.Tags
{
    class ConvertTagCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private bool IsDecalShader { get; set; } = false;

        public ConvertTagCommand(GameCacheContext info)
            : base(CommandFlags.None,

                  "ConvertTag",
                  "Convert a tag and its dependencies to another engine version",

                  "ConvertTag <tag> <input csv> <output csv> <target directory>",

                  "The tag map CSV should be generated using the \"MatchTags\" command.\n" +
                  "If a tag is listed in the CSV file, it will not be converted.\n" +
                  "The output CSV file is used for converting multiple maps.\n" +
                  "Subsequent convert commands should use the new CSV.\n" +
                  "The target directory should be the maps folder for the target engine.")
        {
            CacheContext = info;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 4)
                return false;

            var srcTag = ArgumentParser.ParseTagSpecifier(CacheContext, args[0]);

            if (srcTag == null)
                return false;

            var csvPath = args[1];
            var csvOutPath = args[2];
            var targetDir = args[3];

            // Load the CSV
            Console.WriteLine("Reading {0}...", csvPath);
            TagVersionMap tagMap;

            using (var reader = new StreamReader(File.Exists(csvPath) ? File.OpenRead(csvPath) : File.Create(csvPath)))
                tagMap = TagVersionMap.ParseTagVersionMap(reader);

            // Load destination cache files
            var destCacheContext = new GameCacheContext(new DirectoryInfo(targetDir));
            using (var stream = destCacheContext.OpenTagCacheRead())
                destCacheContext.TagCache = new TagCache(stream);
            
            // Load resources for the target build
            Console.WriteLine("Loading target resources...");
            var destResources = new ResourceDataManager();
            destResources.LoadCachesFromDirectory(destCacheContext.TagCacheFile.DirectoryName);

            // Load resources for our build
            Console.WriteLine("Loading source resources...");
            var srcResources = new ResourceDataManager();
            srcResources.LoadCachesFromDirectory(CacheContext.TagCacheFile.DirectoryName);

            Console.WriteLine();
            Console.WriteLine("CONVERTING FROM VERSION {0} TO {1}", CacheVersionDetection.GetVersionString(CacheContext.Version), CacheVersionDetection.GetVersionString(destCacheContext.Version));
            Console.WriteLine();

            using (var stream = CacheContext.OpenTagCacheReadWrite())
            {
                foreach (var scnr in CacheContext.TagCache.Index.FindAllInGroup("scnr"))
                {
                    var scnrContext = new TagSerializationContext(stream, CacheContext, scnr);
                    var scnrDefinition = CacheContext.Deserializer.Deserialize<Scenario>(scnrContext);

                    foreach (var biped in scnrDefinition.BipedPalette)
                        biped.Biped = null;

                    foreach (var vehicle in scnrDefinition.VehiclePalette)
                        vehicle.Vehicle = null;

                    foreach (var weapon in scnrDefinition.WeaponPalette)
                        weapon.Weapon = null;

                    scnrDefinition.SandboxEquipment.Clear();
                    scnrDefinition.SandboxGoalObjects.Clear();
                    scnrDefinition.SandboxScenery.Clear();
                    scnrDefinition.SandboxSpawning.Clear();
                    scnrDefinition.SandboxTeleporters.Clear();
                    scnrDefinition.SandboxVehicles.Clear();
                    scnrDefinition.SandboxWeapons.Clear();

                    CacheContext.Serializer.Serialize(scnrContext, scnrDefinition);
                }
            }

            CachedTagInstance resultTag;
            using (Stream srcStream = CacheContext.OpenTagCacheRead(), destStream = destCacheContext.OpenTagCacheReadWrite())
                resultTag = ConvertTag(srcTag, CacheContext, srcStream, srcResources, destCacheContext, destStream, destResources, tagMap);

            Console.WriteLine();
            Console.WriteLine("Repairing decal systems...");
            FixDecalSystems(destCacheContext, resultTag.Index);

            Console.WriteLine();
            Console.WriteLine("Saving stringIDs...");
            using (var stream = destCacheContext.StringIdCacheFile.Open(FileMode.Open, FileAccess.ReadWrite))
                destCacheContext.StringIdCache.Save(stream);

            Console.WriteLine("Writing {0}...", csvOutPath);
            using (var stream = new StreamWriter(File.Open(csvOutPath, FileMode.Create, FileAccess.ReadWrite)))
                tagMap.WriteCsv(stream);

            // Uncomment this to add the new tag as a dependency to cfgt to make testing easier
            /*using (var stream = destCacheContext.OpenCacheReadWrite())
            {
                destCacheContext.Cache.Tags[0].Dependencies.Add(resultTag.Index);
                destCacheContext.Cache.UpdateTag(stream, destCacheContext.Cache.Tags[0]);
            }*/

            Console.WriteLine();
            Console.WriteLine("All done! The converted tag is:");
            TagPrinter.PrintTagShort(resultTag);
            return true;
        }

        private CachedTagInstance ConvertTag(CachedTagInstance srcTag, GameCacheContext srcInfo, Stream srcStream, ResourceDataManager srcResources, GameCacheContext destCacheContext, Stream destStream, ResourceDataManager destResources, TagVersionMap tagMap)
        {
            TagPrinter.PrintTagShort(srcTag);

            // Uncomment this to use 0x101F for all shaders
            /*if (srcTag.IsClass("rm  "))
                return destCacheContext.Cache.Tags[0x101F];*/

            // Check if the tag is in the map, and just return the translated tag if so
            var destIndex = tagMap.Translate(srcInfo.Version, srcTag.Index, destCacheContext.Version);
            if (destIndex >= 0)
            {
                Console.WriteLine("- Using already-known index {0:X4}", destIndex);
                return destCacheContext.TagCache.Index[destIndex];
            }

            // Deserialize the tag from the source cache
            var structureType = TagStructureTypes.FindByGroupTag(srcTag.Group.Tag);
            var srcContext = new TagSerializationContext(srcStream, srcInfo, srcTag);
            var tagData = srcInfo.Deserializer.Deserialize(srcContext, structureType);



            // Uncomment this to use 0x101F in place of shaders that need conversion
            /*if (tagData is RenderMethod)
            {
                var rm = (RenderMethod)tagData;
                foreach (var prop in rm.ShaderProperties)
                {
                    if (tagMap.Translate(srcInfo.Version, prop.Template.Index, destCacheContext.Version) < 0)
                        return destCacheContext.Cache.Tags[0x101F];
                }
            }*/

            // Allocate a new tag and create a mapping for it

            CachedTagInstance instance = null;

            for (var i = 0; i < destCacheContext.TagCache.Index.Count; i++)
            {
                if (destCacheContext.TagCache.Index[i] == null)
                {
                    destCacheContext.TagCache.Index[i] = instance = new CachedTagInstance(i, TagGroup.Instances[srcTag.Group.Tag]);
                    break;
                }
            }

            if (instance == null)
                instance = destCacheContext.TagCache.AllocateTag(srcTag.Group);
            tagMap.Add(srcInfo.Version, srcTag.Index, destCacheContext.Version, instance.Index);

            if (srcTag.IsInGroup("decs") || srcTag.IsInGroup("rmd "))
                IsDecalShader = true;

            // Convert it
            tagData = Convert(tagData, srcInfo, srcStream, srcResources, destCacheContext, destStream, destResources, tagMap);

            if (srcTag.IsInGroup("decs") || srcTag.IsInGroup("rmd "))
                IsDecalShader = false;

            // Re-serialize into the destination cache
            var destContext = new TagSerializationContext(destStream, destCacheContext, instance);
            destCacheContext.Serializer.Serialize(destContext, tagData);
            return instance;
        }

        private object Convert(object data, GameCacheContext srcInfo, Stream srcStream, ResourceDataManager srcResources, GameCacheContext destCacheContext, Stream destStream, ResourceDataManager destResources, TagVersionMap tagMap)
        {
            if (data == null)
                return null;
            var type = data.GetType();
            if (type.IsPrimitive)
                return data;
            if (type == typeof(StringId))
                return ConvertStringID((StringId)data, srcInfo, destCacheContext);
            if (type == typeof(CachedTagInstance))
                return ConvertTag((CachedTagInstance)data, srcInfo, srcStream, srcResources, destCacheContext, destStream, destResources, tagMap);
            if (type == typeof(ResourceReference))
                return ConvertResource((ResourceReference)data, srcInfo, srcResources, destCacheContext, destResources);
            if (type == typeof(GeometryReference))
                return ConvertGeometry((GeometryReference)data, srcInfo, srcResources, destCacheContext, destResources);
            if (type.IsArray)
                return ConvertArray((Array)data, srcInfo, srcStream, srcResources, destCacheContext, destStream, destResources, tagMap);
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
                return ConvertList(data, type, srcInfo, srcStream, srcResources, destCacheContext, destStream, destResources, tagMap);
            if (type.GetCustomAttributes(typeof(TagStructureAttribute), false).Length > 0)
                return ConvertStructure(data, type, srcInfo, srcStream, srcResources, destCacheContext, destStream, destResources, tagMap);
            return data;
        }

        private Array ConvertArray(Array array, GameCacheContext srcInfo, Stream srcStream, ResourceDataManager srcResources, GameCacheContext destCacheContext, Stream destStream, ResourceDataManager destResources, TagVersionMap tagMap)
        {
            if (array.GetType().GetElementType().IsPrimitive)
                return array;
            for (var i = 0; i < array.Length; i++)
            {
                var oldValue = array.GetValue(i);
                var newValue = Convert(oldValue, srcInfo, srcStream, srcResources, destCacheContext, destStream, destResources, tagMap);
                array.SetValue(newValue, i);
            }
            return array;
        }

        private object ConvertList(object list, Type type, GameCacheContext srcInfo, Stream srcStream, ResourceDataManager srcResources, GameCacheContext destCacheContext, Stream destStream, ResourceDataManager destResources, TagVersionMap tagMap)
        {
            if (type.GenericTypeArguments[0].IsPrimitive)
                return list;
            var count = (int)type.GetProperty("Count").GetValue(list);
            var getItem = type.GetMethod("get_Item");
            var setItem = type.GetMethod("set_Item");
            for (var i = 0; i < count; i++)
            {
                var oldValue = getItem.Invoke(list, new object[] { i });
                var newValue = Convert(oldValue, srcInfo, srcStream, srcResources, destCacheContext, destStream, destResources, tagMap);
                setItem.Invoke(list, new object[] { i, newValue });
            }
            return list;
        }

        private object ConvertStructure(object data, Type type, GameCacheContext srcInfo, Stream srcStream, ResourceDataManager srcResources, GameCacheContext destCacheContext, Stream destStream, ResourceDataManager destResources, TagVersionMap tagMap)
        {
            // Convert each field
            var enumerator = new TagFieldEnumerator(new TagStructureInfo(type, destCacheContext.Version));
            while (enumerator.Next())
            {
                var oldValue = enumerator.Field.GetValue(data);
                var newValue = Convert(oldValue, srcInfo, srcStream, srcResources, destCacheContext, destStream, destResources, tagMap);
                enumerator.Field.SetValue(data, newValue);
            }

            // Perform fixups
            FixObjectTypes(data, type, srcInfo);
            FixShaders(data);
            var scenario = data as Scenario;
            if (scenario != null)
                FixScenario(scenario);

            return data;
        }

        private StringId ConvertStringID(StringId stringId, GameCacheContext srcInfo, GameCacheContext destCacheContext)
        {
            if (stringId == StringId.Null)
                return stringId;
            var srcString = srcInfo.StringIdCache.GetString(stringId);
            if (srcString == null)
                return StringId.Null;
            var destStringID = destCacheContext.StringIdCache.GetStringId(srcString);
            if (destStringID == StringId.Null)
                destStringID = destCacheContext.StringIdCache.Add(srcString);
            return destStringID;
        }

        private ResourceReference ConvertResource(ResourceReference resource, GameCacheContext srcInfo, ResourceDataManager srcResources, GameCacheContext destCacheContext, ResourceDataManager destResources)
        {
            if (resource == null)
                return null;
            Console.WriteLine("- Copying resource {0} in {1}...", resource.Index, resource.GetLocation());
            var data = srcResources.ExtractRaw(resource);
            var newLocation = FixResourceLocation(resource.GetLocation(), srcInfo.Version, destCacheContext.Version);
            destResources.AddRaw(resource, newLocation, data);
            return resource;
        }

        private ResourceLocation FixResourceLocation(ResourceLocation location, CacheVersion srcVersion, CacheVersion destVersion)
        {
            if (CacheVersionDetection.Compare(destVersion, CacheVersion.HaloOnline235640) >= 0)
                return location;
            switch (location)
            {
                case ResourceLocation.RenderModels:
                    return ResourceLocation.Resources;
                case ResourceLocation.Lightmaps:
                    return ResourceLocation.Textures;
            }
            return location;
        }

        private GeometryReference ConvertGeometry(GeometryReference geometry, GameCacheContext srcInfo, ResourceDataManager srcResources, GameCacheContext destCacheContext, ResourceDataManager destResources)
        {
            if (geometry == null || geometry.Resource == null || geometry.Resource.Index < 0)
                return geometry;

            // The format changed starting with version 1.235640, so if both versions are on the same side then they can be converted normally
            var srcCompare = CacheVersionDetection.Compare(srcInfo.Version, CacheVersion.HaloOnline235640);
            var destCompare = CacheVersionDetection.Compare(destCacheContext.Version, CacheVersion.HaloOnline235640);
            if ((srcCompare < 0 && destCompare < 0) || (srcCompare >= 0 && destCompare >= 0))
            {
                geometry.Resource = ConvertResource(geometry.Resource, srcInfo, srcResources, destCacheContext, destResources);
                return geometry;
            }

            Console.WriteLine("- Rebuilding geometry resource {0} in {1}...", geometry.Resource.Index, geometry.Resource.GetLocation());
            using (MemoryStream inStream = new MemoryStream(), outStream = new MemoryStream())
            {
                // First extract the model data
                srcResources.Extract(geometry.Resource, inStream);

                // Now open source and destination vertex streams
                inStream.Position = 0;
                var inVertexStream = VertexStreamFactory.Create(srcInfo.Version, inStream);
                var outVertexStream = VertexStreamFactory.Create(destCacheContext.Version, outStream);

                // Deserialize the definition data
                var resourceContext = new ResourceSerializationContext(geometry.Resource);
                var definition = srcInfo.Deserializer.Deserialize<RenderGeometryApiResourceDefinition>(resourceContext);

                // Convert each vertex buffer
                foreach (var buffer in definition.VertexBuffers)
                    ConvertVertexBuffer(buffer.Definition, inStream, inVertexStream, outStream, outVertexStream);

                // Copy each index buffer over
                foreach (var buffer in definition.IndexBuffers)
                {
                    if (buffer.Definition.Data.Size == 0)
                        continue;
                    inStream.Position = buffer.Definition.Data.Address.Offset;
                    buffer.Definition.Data.Address = new ResourceAddress(ResourceAddressType.Resource, (int)outStream.Position);
                    var bufferData = new byte[buffer.Definition.Data.Size];
                    inStream.Read(bufferData, 0, bufferData.Length);
                    outStream.Write(bufferData, 0, bufferData.Length);
                    StreamUtil.Align(outStream, 4);
                }

                // Update the definition data
                destCacheContext.Serializer.Serialize(resourceContext, definition);

                // Now inject the new resource data
                var newLocation = FixResourceLocation(geometry.Resource.GetLocation(), srcInfo.Version, destCacheContext.Version);
                outStream.Position = 0;
                destResources.Add(geometry.Resource, newLocation, outStream);
            }
            return geometry;
        }

        private void ConvertVertexBuffer(VertexBufferDefinition buffer, MemoryStream inStream, IVertexStream inVertexStream, MemoryStream outStream, IVertexStream outVertexStream)
        {
            if (buffer.Data.Size == 0)
                return;
            var count = buffer.Count;
            var startPos = (int)outStream.Position;
            inStream.Position = buffer.Data.Address.Offset;
            buffer.Data.Address = new ResourceAddress(ResourceAddressType.Resource, startPos);
            switch (buffer.Format)
            {
                case VertexBufferFormat.World:
                    ConvertVertices(count, inVertexStream.ReadWorldVertex, v =>
                    {
                        v.Binormal = new RealPoint3d(v.Position.W, v.Tangent.W, 0); // Converted shaders use this
                        outVertexStream.WriteWorldVertex(v);
                    });
                    break;
                case VertexBufferFormat.Rigid:
                    ConvertVertices(count, inVertexStream.ReadRigidVertex, v =>
                    {
                        v.Binormal = new RealPoint3d(v.Position.W, v.Tangent.W, 0); // Converted shaders use this
                        outVertexStream.WriteRigidVertex(v);
                    });
                    break;
                case VertexBufferFormat.Skinned:
                    ConvertVertices(count, inVertexStream.ReadSkinnedVertex, v =>
                    {
                        v.Binormal = new RealPoint3d(v.Position.W, v.Tangent.W, 0); // Converted shaders use this
                        outVertexStream.WriteSkinnedVertex(v);
                    });
                    break;
                case VertexBufferFormat.StaticPerPixel:
                    ConvertVertices(count, inVertexStream.ReadStaticPerPixelData, outVertexStream.WriteStaticPerPixelData);
                    break;
                case VertexBufferFormat.StaticPerVertex:
                    ConvertVertices(count, inVertexStream.ReadStaticPerVertexData, outVertexStream.WriteStaticPerVertexData);
                    break;
                case VertexBufferFormat.AmbientPrt:
                    ConvertVertices(count, inVertexStream.ReadAmbientPrtData, outVertexStream.WriteAmbientPrtData);
                    break;
                case VertexBufferFormat.LinearPrt:
                    ConvertVertices(count, inVertexStream.ReadLinearPrtData, outVertexStream.WriteLinearPrtData);
                    break;
                case VertexBufferFormat.QuadraticPrt:
                    ConvertVertices(count, inVertexStream.ReadQuadraticPrtData, outVertexStream.WriteQuadraticPrtData);
                    break;
                case VertexBufferFormat.StaticPerVertexColor:
                    ConvertVertices(count, inVertexStream.ReadStaticPerVertexColorData, outVertexStream.WriteStaticPerVertexColorData);
                    break;
                case VertexBufferFormat.Decorator:
                    ConvertVertices(count, inVertexStream.ReadDecoratorVertex, outVertexStream.WriteDecoratorVertex);
                    break;
                case VertexBufferFormat.World2:
                    buffer.Format = VertexBufferFormat.World;
                    goto default;
                default:
                    // Just copy the raw buffer over and pray that it works...
                    var bufferData = new byte[buffer.Data.Size];
                    inStream.Read(bufferData, 0, bufferData.Length);
                    outStream.Write(bufferData, 0, bufferData.Length);
                    break;
            }
            buffer.Data.Size = (int)outStream.Position - startPos;
            buffer.VertexSize = (short)(buffer.Data.Size / buffer.Count);
        }

        private void ConvertVertices<T>(int count, Func<T> readFunc, Action<T> writeFunc)
        {
            for (var i = 0; i < count; i++)
                writeFunc(readFunc());
        }

        private void FixObjectTypes(object data, Type type, GameCacheContext srcInfo)
        {
            // The object type enum changed in 11.1.498295 because a new armor type was added at value 3.
            // These are a bunch of hacks to fix this in most cases.
            var oldObjectTypeField = type.GetField("ObjectTypeOld");
            var newObjectTypeField = type.GetField("ObjectTypeNew");
            if (oldObjectTypeField != null && newObjectTypeField != null)
            {
                if (CacheVersionDetection.Compare(srcInfo.Version, CacheVersion.HaloOnline498295) < 0)
                {
                    var oldType = (ObjectTypeValueOld)oldObjectTypeField.GetValue(data);
                    newObjectTypeField.SetValue(data, ConvertObjectType(oldType));
                }
                else
                {
                    var newType = (ObjectTypeValueNew)newObjectTypeField.GetValue(data);
                    oldObjectTypeField.SetValue(data, ConvertObjectType(newType));
                }
            }
            var phantom = data as PhysicsModel.PhantomType;
            if (phantom != null)
            {
                // Remove the armor bit added at position 8 in flags
                phantom.Flags = (PhysicsModel.PhantomTypeFlags)(((int)phantom.Flags & ~0x1FFE00) | (((int)phantom.Flags & 0x1FFE00) >> 1));
            }
            var chmt = data as ChocolateMountainNew;
            if (chmt != null && chmt.LightingVariables != null && chmt.LightingVariables.Count > 3)
                chmt.LightingVariables.RemoveAt(3); // Remove armor data from chmt
        }

        private void FixScenario(Scenario data)
        {
            FixSandboxMenu(data.SandboxVehicles);
            FixSandboxMenu(data.SandboxWeapons);
            FixSandboxMenu(data.SandboxEquipment);
            FixSandboxMenu(data.SandboxScenery);
            FixSandboxMenu(data.SandboxTeleporters);
            FixSandboxMenu(data.SandboxGoalObjects);
            FixSandboxMenu(data.SandboxSpawning);
            FixScripts(data);
        }

        private void FixSandboxMenu(List<Scenario.SandboxObject> menu)
        {
            for (var i = 0; i < menu.Count; i++)
            {
                if (menu[i].Object == null || !menu[i].Object.IsInGroup("obje"))
                    menu.RemoveAt(i--);
            }
        }

        private void FixScripts(Scenario data)
        {
            foreach (var expr in data.ScriptExpressions)
            {
                if (expr.ExpressionType == 8 || (expr.ExpressionType == 9 && expr.ValueType == Scenario.ScriptExpression.ValueTypeValue.FunctionName))
                {
                    // Either a function call or a function_name
                    expr.Opcode = FixOpcode(expr.Opcode);
                }
            }
        }

        private ushort FixOpcode(ushort opcode)
        {
            // ZBT -> 1.106708
            // thanks zedd <3
            if (opcode >= 0x685)
                opcode -= 1;
            if (opcode >= 0x5D2)
                opcode += 2;
            if (opcode >= 0x5C6)
                opcode += 3;
            if (opcode >= 0x5AE)
                opcode += 3;
            if (opcode >= 0x527)
                opcode += 4;
            if (opcode >= 0x516)
                opcode += 1;
            if (opcode >= 0x48C)
                opcode += 2;
            if (opcode >= 0x345)
                opcode -= 1;
            if (opcode >= 0x2F2)
                opcode -= 3;
            if (opcode >= 0x15)
                opcode -= 1;
            return opcode;
        }

        private void FixShaders(object data)
        {
            if (CacheContext.Version <= CacheVersion.HaloOnline235640)
                return;

            var template = data as RenderMethodTemplate;
            if (template != null)
                FixRenderMethodTemplate(template);
            var rmdf = data as RenderMethodDefinition;
            if (rmdf != null)
                FixRenderMethodDefinition(rmdf);
            var glps = data as GlobalPixelShader;
            if (glps != null)
                FixGlobalPixelShader(glps);
            var glvs = data as GlobalVertexShader;
            if (glvs != null)
                FixGlobalVertexShader(glvs);
            var ps = data as PixelShader;
            if (ps != null)
                FixPixelShader(ps);
            var vs = data as VertexShader;
            if (vs != null)
                FixVertexShader(vs);
            var property = data as RenderMethod.ShaderProperty;
            if (property != null)
                FixDrawModeList(property.DrawModes);
        }

        private void FixRenderMethodTemplate(RenderMethodTemplate template)
        {
            FixDrawModeList(template.DrawModes);
            if (template.DrawModes.Count > 18)
                template.DrawModes[18].UnknownBlock2Pointer = 0; // Disable z_only

            // Rebuild the bitmask of valid draw modes
            template.DrawModeBitmask = 0;
            for (var i = 0; i < template.DrawModes.Count; i++)
            {
                if (template.DrawModes[i].UnknownBlock2Pointer != 0)
                    template.DrawModeBitmask |= (uint)(1 << i);
            }
        }

        private void FixRenderMethodDefinition(RenderMethodDefinition definition)
        {
            for (var i = definition.DrawModes.Count - 1; i >= 0; i--)
            {
                var mode = definition.DrawModes[i];
                if (mode.Mode == 2 || mode.Mode == 10 || mode.Mode == 11 || mode.Mode == 12)
                    definition.DrawModes.RemoveAt(i);
                else if (mode.Mode > 12)
                    mode.Mode -= 4;
                else if (mode.Mode > 2)
                    mode.Mode -= 1;
            }
        }

        private void FixGlobalPixelShader(GlobalPixelShader glps)
        {
            FixDrawModeList(glps.DrawModes);
            // glps tags don't appear to need recompilation?
        }

        private void FixGlobalVertexShader(GlobalVertexShader glvs)
        {
            var usedShaders = new bool[glvs.VertexShaders.Count];
            for (var i = 0; i < glvs.VertexTypes.Count; i++)
            {
                FixDrawModeList(glvs.VertexTypes[i].DrawModes);
                if (glvs.VertexTypes[i].DrawModes.Count > 18)
                    glvs.VertexTypes[i].DrawModes[18].ShaderIndex = -1; // Disable z_only
                var type = (VertexType)i;
                for (var j = 0; j < glvs.VertexTypes[i].DrawModes.Count; j++)
                {
                    var mode = glvs.VertexTypes[i].DrawModes[j];
                    if (mode.ShaderIndex < 0)
                        continue;
                    Console.WriteLine("- Recompiling vertex shader {0}...", mode.ShaderIndex);
                    var shader = glvs.VertexShaders[mode.ShaderIndex];
                    var newBytecode = ShaderConverter.ConvertNewVertexShaderToOld(shader.Unknown2, j, type);
                    if (newBytecode != null)
                        shader.Unknown2 = newBytecode;
                    usedShaders[mode.ShaderIndex] = true;
                }
            }

            // Null unused shaders
            for (var i = 0; i < glvs.VertexShaders.Count; i++)
            {
                if (!usedShaders[i])
                    glvs.VertexShaders[i].Unknown2 = null;
            }
        }

        private void FixPixelShader(PixelShader ps)
        {
            FixDrawModeList(ps.DrawModes);

            // Disable z_only
            if (ps.DrawModes.Count > 18)
            {
                ps.DrawModes[18].Index = 0;
                ps.DrawModes[18].Count = 0;
            }

            var usedShaders = new bool[ps.PixelShaders.Count];
            for (var i = 0; i < ps.DrawModes.Count; i++)
            {
                var mode = ps.DrawModes[i];
                for (var j = 0; j < mode.Count; j++)
                {
                    if (i != 0 || IsDecalShader)
                    {
                        Console.WriteLine("- Recompiling pixel shader {0}...", mode.Index + j);
                        var shader = ps.PixelShaders[mode.Index + j];
                        var newBytecode = ShaderConverter.ConvertNewPixelShaderToOld(shader.Unknown2, i);
                        if (newBytecode != null)
                            shader.Unknown2 = newBytecode;
                    }
                    usedShaders[mode.Index + j] = true;
                }
            }

            // Null unused shaders
            for (var i = 0; i < ps.PixelShaders.Count; i++)
            {
                if (!usedShaders[i])
                    ps.PixelShaders[i].Unknown2 = null;
            }
        }

        private void FixVertexShader(VertexShader vs)
        {
            foreach (var unk in vs.Unknown2)
                FixDrawModeList(unk.DrawModes);
            // We don't need to recompile these because vtsh tags will never actually be used in a ported map
        }

        private void FixDrawModeList<T>(IList<T> modes)
        {
            if (modes.Count > 12)
                modes.RemoveAt(12);
            if (modes.Count > 11)
                modes.RemoveAt(11);
            if (modes.Count > 10)
                modes.RemoveAt(10);
            if (modes.Count > 2)
                modes.RemoveAt(2);
        }

        private ObjectTypeValueOld ConvertObjectType(ObjectTypeValueNew type)
        {
            switch (type)
            {
                case ObjectTypeValueNew.None: return ObjectTypeValueOld.None;
                case ObjectTypeValueNew.Biped: return ObjectTypeValueOld.Biped;
                case ObjectTypeValueNew.Vehicle: return ObjectTypeValueOld.Vehicle;
                case ObjectTypeValueNew.Weapon: return ObjectTypeValueOld.Weapon;
                case ObjectTypeValueNew.Equipment: return ObjectTypeValueOld.Equipment;
                case ObjectTypeValueNew.ArgDevice: return ObjectTypeValueOld.ArgDevice;
                case ObjectTypeValueNew.Terminal: return ObjectTypeValueOld.Terminal;
                case ObjectTypeValueNew.Projectile: return ObjectTypeValueOld.Projectile;
                case ObjectTypeValueNew.Scenery: return ObjectTypeValueOld.Scenery;
                case ObjectTypeValueNew.Machine: return ObjectTypeValueOld.Machine;
                case ObjectTypeValueNew.Control: return ObjectTypeValueOld.Control;
                case ObjectTypeValueNew.SoundScenery: return ObjectTypeValueOld.SoundScenery;
                case ObjectTypeValueNew.Crate: return ObjectTypeValueOld.Crate;
                case ObjectTypeValueNew.Creature: return ObjectTypeValueOld.Creature;
                case ObjectTypeValueNew.Giant: return ObjectTypeValueOld.Giant;
                case ObjectTypeValueNew.EffectScenery: return ObjectTypeValueOld.EffectScenery;
                default:
                    throw new NotSupportedException("Unsupported object type: " + type);
            }
        }

        private ObjectTypeValueNew ConvertObjectType(ObjectTypeValueOld type)
        {
            switch (type)
            {
                case ObjectTypeValueOld.None: return ObjectTypeValueNew.None;
                case ObjectTypeValueOld.Biped: return ObjectTypeValueNew.Biped;
                case ObjectTypeValueOld.Vehicle: return ObjectTypeValueNew.Vehicle;
                case ObjectTypeValueOld.Weapon: return ObjectTypeValueNew.Weapon;
                case ObjectTypeValueOld.Equipment: return ObjectTypeValueNew.Equipment;
                case ObjectTypeValueOld.ArgDevice: return ObjectTypeValueNew.ArgDevice;
                case ObjectTypeValueOld.Terminal: return ObjectTypeValueNew.Terminal;
                case ObjectTypeValueOld.Projectile: return ObjectTypeValueNew.Projectile;
                case ObjectTypeValueOld.Scenery: return ObjectTypeValueNew.Scenery;
                case ObjectTypeValueOld.Machine: return ObjectTypeValueNew.Machine;
                case ObjectTypeValueOld.Control: return ObjectTypeValueNew.Control;
                case ObjectTypeValueOld.SoundScenery: return ObjectTypeValueNew.SoundScenery;
                case ObjectTypeValueOld.Crate: return ObjectTypeValueNew.Crate;
                case ObjectTypeValueOld.Creature: return ObjectTypeValueNew.Creature;
                case ObjectTypeValueOld.Giant: return ObjectTypeValueNew.Giant;
                case ObjectTypeValueOld.EffectScenery: return ObjectTypeValueNew.EffectScenery;
                default:
                    throw new NotSupportedException("Unsupported object type: " + type);
            }
        }

        private void FixDecalSystems(GameCacheContext destCacheContext, int firstNewIndex)
        {
            // decs tags need to be updated to use the old rmdf for decals,
            // because the decal planes seem to be generated by the engine and
            // therefore need to use the old vertex format.
            //
            // This could probably be done as a post-processing step in
            // ConvertStructure to avoid the extra deserialize-reserialize
            // pass, but we'd have to store the rmdf somewhere and frankly I'm
            // too lazy to do that...

            var firstDecalSystemTag = destCacheContext.TagCache.Index.FindFirstInGroup("decs");
            if (firstDecalSystemTag == null)
                return;
            using (var stream = destCacheContext.OpenTagCacheReadWrite())
            {
                var firstDecalSystemContext = new TagSerializationContext(stream, destCacheContext, firstDecalSystemTag);
                var firstDecalSystem = destCacheContext.Deserializer.Deserialize<DecalSystem>(firstDecalSystemContext);
                foreach (var decalSystemTag in destCacheContext.TagCache.Index.FindAllInGroup("decs").Where(t => t.Index >= firstNewIndex))
                {
                    TagPrinter.PrintTagShort(decalSystemTag);
                    var context = new TagSerializationContext(stream, destCacheContext, decalSystemTag);
                    var decalSystem = destCacheContext.Deserializer.Deserialize<DecalSystem>(context);
                    foreach (var system in decalSystem.DecalSystem2)
                        system.BaseRenderMethod = firstDecalSystem.DecalSystem2[0].BaseRenderMethod;
                    destCacheContext.Serializer.Serialize(context, decalSystem);
                }
            }
        }
    }
}