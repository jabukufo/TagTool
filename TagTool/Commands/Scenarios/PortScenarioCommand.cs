using Adjutant.Library.Definitions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using TagTool.Cache;
using TagTool.Commands.Tags;
using TagTool.Common;
using TagTool.Geometry;
using TagTool.Serialization;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Scenarios
{
    class PortScenarioCommand : Command
    {
        public GameCacheContext CacheContext { get; }
        public CachedTagInstance Tag { get; }
        public Scenario Definition { get; }

        public PortScenarioCommand(GameCacheContext cacheContext, CachedTagInstance tag, Scenario definition)
            : base(CommandFlags.Inherit,

                  "PortScenario",
                  "Ports a scenario from H1PC/H1CE/H2X/H3B/H3/ODST cache files.",

                  "PortScenario <Map File>",

                  "Ports a scenario from H1PC/H1CE/H2X/H3B/H3/ODST cache files.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1)
                return false;

            var blamCacheFile = new FileInfo(args[0]);

            if (!blamCacheFile.Exists)
                throw new FileNotFoundException(blamCacheFile.FullName);

            var blamCache = CacheManager.GetCache(blamCacheFile.FullName);

            var initialStringIDCount = CacheContext.StringIdCache.Strings.Count;
            
            CacheBase.IndexItem blamScnr = null;

            Console.WriteLine("Verifying blam scenario tag...");

            foreach (var indexItem in blamCache.IndexItems)
            {
                if (indexItem.ClassCode == "scnr" && indexItem.Filename == blamCache.Header.scenarioName)
                {
                    blamScnr = indexItem;
                    break;
                }
            }

            if (blamScnr == null)
            {
                Console.WriteLine("Blam scenario tag does not exist: " + args[0]);
                return false;
            }

            //
            // Load the blam scenario tag
            //

            var blamScnrContext = new CacheSerializationContext(CacheContext, blamCache, blamScnr);
            var blamScnrDefinition = CacheContext.Deserializer.Deserialize<Adjutant.Library.Definitions.Halo3Retail.TagDefinitions.Scenario>(blamScnrContext);

            return true;

            /*var mode = DefinitionsManager.mode(cacheFile, blamScnr);
            mode.LoadRaw();

            //
            // Start porting the model
            //

            var builder = new RenderModelBuilder(CacheContext.Version);

            foreach (var node in mode.Nodes)
            {
                var nodeNameId = CacheContext.GetStringId(node.Name);

                builder.AddNode(
                    new RenderModel.Node
                    {
                        Name = nodeNameId.Index == 0 && node.Name != "" ? nodeNameId = CacheContext.StringIdCache.Add(node.Name) : nodeNameId,
                        ParentNode = (short)node.ParentIndex,
                        FirstChildNode = (short)node.FirstChildIndex,
                        NextSiblingNode = (short)node.NextSiblingIndex,
                        ImportNode = 0,
                        DefaultTranslation = new RealPoint3d(node.Position.I, node.Position.J, node.Position.K),
                        DefaultRotation = new RealVector4d(node.Rotation.I, node.Rotation.J, node.Rotation.K, node.Rotation.W),
                        DefaultScale = node.TransformScale,
                        InverseForward = new RealPoint3d(node.TransformMatrix.m11, node.TransformMatrix.m12, node.TransformMatrix.m13),
                        InverseLeft = new RealPoint3d(node.TransformMatrix.m21, node.TransformMatrix.m22, node.TransformMatrix.m23),
                        InverseUp = new RealPoint3d(node.TransformMatrix.m31, node.TransformMatrix.m32, node.TransformMatrix.m33),
                        InversePosition = new RealPoint3d(node.TransformMatrix.m41, node.TransformMatrix.m42, node.TransformMatrix.m43),
                        DistanceFromParent = node.DistanceFromParent
                    });
            }

            //
            // Create empty materials for now...
            //

            foreach (var shader in mode.Shaders)
                builder.AddMaterial(
                    new RenderMaterial
                    {
                        RenderMethod = CacheContext.TagCache.Index[0x101F]
                    });

            //
            // Build the model regions
            //

            foreach (var region in mode.Regions)
            {
                var regionNameId = CacheContext.GetStringId(region.Name);

                builder.BeginRegion(regionNameId.Index == 0 && region.Name != "" ? regionNameId = CacheContext.StringIdCache.Add(region.Name) : regionNameId);

                foreach (var permutation in region.Permutations)
                {
                    if (permutation.PieceCount <= 0 || permutation.PieceIndex == -1)
                        continue;

                    var permutationNameId = CacheContext.GetStringId(permutation.Name);

                    builder.BeginPermutation(permutationNameId.Index == 0 && permutation.Name != "" ? permutationNameId = CacheContext.StringIdCache.Add(permutation.Name) : permutationNameId);

                    for (var i = permutation.PieceIndex; i < permutation.PieceIndex + permutation.PieceCount; i++)
                    {
                        var section = mode.ModelSections[i];

                        if (section.Submeshes.Count == 0 || section.Vertices == null)
                            continue;

                        //
                        // Collect the section's vertices
                        //

                        var skinnedVertices = new List<SkinnedVertex>();
                        var rigidVertices = new List<RigidVertex>();

                        VertexValue v;
                        bool isSkinned = section.Vertices[0].TryGetValue("blendindices", 0, out v) && section.NodeIndex == 255;
                        bool isBoned = section.Vertices[0].FormatName.Contains("rigid_boned");

                        foreach (var vertex in section.Vertices)
                        {
                            vertex.TryGetValue("position", 0, out v);
                            var position = new RealVector4d(v.Data.I, v.Data.J, v.Data.K, 1);

                            vertex.TryGetValue("normal", 0, out v);
                            var normal = new RealPoint3d(v.Data.I, v.Data.J, v.Data.K);

                            vertex.TryGetValue("texcoords", 0, out v);
                            var texcoord = new RealPoint2d(v.Data.I, v.Data.J);

                            vertex.TryGetValue("tangent", 0, out v);
                            var tangent = new RealVector4d(v.Data.I, v.Data.J, v.Data.K, 1);

                            vertex.TryGetValue("binormal", 0, out v);
                            var binormal = new RealPoint3d(v.Data.I, v.Data.J, v.Data.K);

                            rigidVertices.Add(
                                new RigidVertex
                                {
                                    Position = position,
                                    Normal = normal,
                                    Texcoord = texcoord,
                                    Tangent = tangent,
                                    Binormal = binormal
                                });

                            if (isBoned)
                            {
                                var blendIndices = new List<byte>();

                                vertex.TryGetValue("blendindices", 0, out v);

                                blendIndices.Add((byte)v.Data.I);
                                blendIndices.Add((byte)v.Data.J);
                                blendIndices.Add((byte)v.Data.K);
                                blendIndices.Add((byte)v.Data.W);

                                skinnedVertices.Add(new SkinnedVertex
                                {
                                    Position = position,
                                    Normal = normal,
                                    Texcoord = texcoord,
                                    Tangent = tangent,
                                    Binormal = binormal,
                                    BlendIndices = blendIndices.ToArray(),
                                    BlendWeights = new[] { 1.0f, 0.0f, 0.0f, 0.0f }
                                });
                            }
                            else if (isSkinned)
                            {
                                var blendIndices = new List<byte>();
                                var blendWeights = new List<float>();

                                vertex.TryGetValue("blendindices", 0, out v);

                                blendIndices.Add((byte)v.Data.I);
                                blendIndices.Add((byte)v.Data.J);
                                blendIndices.Add((byte)v.Data.K);
                                blendIndices.Add((byte)v.Data.W);

                                vertex.TryGetValue("blendweight", 0, out v);

                                blendWeights.Add(v.Data.I);
                                blendWeights.Add(v.Data.J);
                                blendWeights.Add(v.Data.K);
                                blendWeights.Add(v.Data.W);

                                skinnedVertices.Add(new SkinnedVertex
                                {
                                    Position = position,
                                    Normal = normal,
                                    Texcoord = texcoord,
                                    Tangent = tangent,
                                    Binormal = binormal,
                                    BlendIndices = blendIndices.ToArray(),
                                    BlendWeights = blendWeights.ToArray()
                                });
                            }
                        }

                        bool isRigid = false;

                        if (skinnedVertices.Count == 0)
                            isRigid = rigidVertices.Count != 0;

                        //
                        // Build the section's submeshes
                        //

                        builder.BeginMesh();

                        var indices = new List<ushort>();

                        foreach (var submesh in section.Submeshes)
                        {
                            builder.BeginPart((short)submesh.ShaderIndex, (ushort)submesh.FaceIndex, (ushort)submesh.FaceCount, (ushort)submesh.VertexCount);
                            for (var j = 0; j < submesh.SubsetCount; j++)
                            {
                                var subpart = section.Subsets[submesh.SubsetIndex + j];
                                builder.DefineSubPart((ushort)subpart.FaceIndex, (ushort)subpart.FaceCount, (ushort)subpart.VertexCount);
                            }
                            builder.EndPart();
                        }

                        if (isRigid)
                            builder.BindRigidVertexBuffer(rigidVertices, (sbyte)section.NodeIndex);
                        else if (isSkinned || isBoned)
                            builder.BindSkinnedVertexBuffer(skinnedVertices);
                        builder.BindIndexBuffer(section.Indices.Select(index => (ushort)index), PrimitiveType.TriangleStrip);

                        builder.EndMesh();
                    }

                    builder.EndPermutation();
                }

                builder.EndRegion();
            }

            //
            // Finalize the new render_model tag
            //

            var resourceStream = new MemoryStream();
            var newRenderModel = builder.Build(CacheContext.Serializer, resourceStream);

            var renderModelNameStringID = CacheContext.GetStringId(mode.Name);

            newRenderModel.Name = renderModelNameStringID.Index == -1 ?
                renderModelNameStringID = CacheContext.StringIdCache.Add(mode.Name) :
                renderModelNameStringID;

            //
            // Add the markers to the new render_model
            //

            newRenderModel.MarkerGroups = new List<RenderModel.MarkerGroup>();

            foreach (var markerGroup in mode.MarkerGroups)
            {
                var markerGroupNameId = CacheContext.GetStringId(markerGroup.Name);

                if (markerGroupNameId.Index == -1)
                    markerGroupNameId = CacheContext.StringIdCache.Add(markerGroup.Name);

                newRenderModel.MarkerGroups.Add(
                    new RenderModel.MarkerGroup
                    {
                        Name = markerGroupNameId,
                        Markers = markerGroup.Markers.Select(marker =>
                            new RenderModel.MarkerGroup.Marker
                            {
                                RegionIndex = (sbyte)marker.RegionIndex,
                                PermutationIndex = (sbyte)marker.PermutationIndex,
                                NodeIndex = (sbyte)marker.NodeIndex,
                                Unknown3 = 0,
                                Translation = new RealPoint3d(marker.Position.I, marker.Position.J, marker.Position.K),
                                Rotation = new RealVector4d(marker.Rotation.I, marker.Rotation.J, marker.Rotation.K, marker.Rotation.W),
                                Scale = marker.Scale
                            }).ToList()
                    });
            }

            //
            // Disable rigid nodes on skinned meshes
            //

            foreach (var mesh in newRenderModel.Geometry.Meshes)
                if (mesh.Type == VertexType.Skinned)
                    mesh.RigidNodeIndex = -1;

            //
            // Add a new resource for the model data
            //
            
            Console.WriteLine("Writing resource data...");

            var resources = new ResourceDataManager();
            resources.LoadCachesFromDirectory(CacheContext.TagCacheFile.DirectoryName);
            resourceStream.Position = 0;
            resources.Add(newRenderModel.Geometry.Resource, ResourceLocation.Resources, resourceStream);

            using (var cacheStream = CacheContext.TagCacheFile.Open(FileMode.Open, FileAccess.ReadWrite))
            {
                Console.WriteLine("Writing tag data...");

                newRenderModel.Geometry.Resource.Owner = renderModelTag;

                var context = new TagSerializationContext(cacheStream, CacheContext, renderModelTag);
                CacheContext.Serializer.Serialize(context, newRenderModel);

                context = new TagSerializationContext(cacheStream, CacheContext, Tag);
                CacheContext.Serializer.Serialize(context, Definition);
            }

            resourceStream.Close();

            //
            // Save new string_ids
            //

            if (CacheContext.StringIdCache.Strings.Count != initialStringIDCount)
            {
                Console.WriteLine("Saving string_ids...");

                using (var stringIdStream = CacheContext.OpenStringIdCacheReadWrite())
                    CacheContext.StringIdCache.Save(stringIdStream);
            }

            //
            // Done!
            //

            Console.WriteLine("Ported render_model \"" + renderModelName + "\" successfully!");*/
        }
    }
}
