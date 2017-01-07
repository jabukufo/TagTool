using System.Collections.Generic;
using System.IO;
using HaloOnlineTagTool.Resources;
using HaloOnlineTagTool.Serialization;
using HaloOnlineTagTool.TagStructures;
using HaloOnlineTagTool.Resources.Geometry;

namespace HaloOnlineTagTool.Commands.BSP
{
    class CollisionCommand : Command
    {
        private OpenTagCache Info { get; }
        private TagInstance Tag { get; }
        private ScenarioStructureBsp BSP { get; }

        public CollisionCommand(OpenTagCache info, TagInstance tag, ScenarioStructureBsp bsp)
            : base(CommandFlags.Inherit, "collision", "", "", "")
        {
            Info = info;
            Tag = tag;
            BSP = bsp;
        }

        public override bool Execute(List<string> args)
        {
            var resources = new ResourceDataManager();
            resources.LoadCachesFromDirectory(Info.CacheFile.DirectoryName);

            // Deserialize the definition data
            var resourceContext = new ResourceSerializationContext(BSP.Resource3);
            var definition = Info.Deserializer.Deserialize<CollisionBspResourceDefinition>(resourceContext);

            // Extract the resource data
            var resourceDataStream = new MemoryStream();
            resources.Extract(BSP.Resource3, resourceDataStream);
            
            using (var reader = new BinaryReader(resourceDataStream))
            {
                #region collision bsps

                foreach (var cbsp in definition.CollisionBsps)
                {
                    reader.BaseStream.Position = cbsp.Bsp3DNodes.Address.Offset;
                    for (var i = 0; i < cbsp.Bsp3DNodes.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp3DNode));
                        cbsp.Bsp3DNodes.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp3DNode)element);
                    }

                    reader.BaseStream.Position = cbsp.Planes.Address.Offset;
                    for (var i = 0; i < cbsp.Planes.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Plane));
                        cbsp.Planes.Add((CollisionBspResourceDefinition.CollisionBsp.Plane)element);
                    }

                    reader.BaseStream.Position = cbsp.Leaves.Address.Offset;
                    for (var i = 0; i < cbsp.Leaves.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Leaf));
                        cbsp.Leaves.Add((CollisionBspResourceDefinition.CollisionBsp.Leaf)element);
                    }

                    reader.BaseStream.Position = cbsp.Bsp2DReferences.Address.Offset;
                    for (var i = 0; i < cbsp.Bsp2DReferences.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp2DReference));
                        cbsp.Bsp2DReferences.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp2DReference)element);
                    }

                    reader.BaseStream.Position = cbsp.Bsp2DNodes.Address.Offset;
                    for (var i = 0; i < cbsp.Bsp2DNodes.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp2DNode));
                        cbsp.Bsp2DNodes.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp2DNode)element);
                    }

                    reader.BaseStream.Position = cbsp.Surfaces.Address.Offset;
                    for (var i = 0; i < cbsp.Surfaces.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Surface));
                        cbsp.Surfaces.Add((CollisionBspResourceDefinition.CollisionBsp.Surface)element);
                    }

                    reader.BaseStream.Position = cbsp.Edges.Address.Offset;
                    for (var i = 0; i < cbsp.Edges.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Edge));
                        cbsp.Edges.Add((CollisionBspResourceDefinition.CollisionBsp.Edge)element);
                    }

                    reader.BaseStream.Position = cbsp.Vertices.Address.Offset;
                    for (var i = 0; i < cbsp.Vertices.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Vertex));
                        cbsp.Vertices.Add((CollisionBspResourceDefinition.CollisionBsp.Vertex)element);
                    }
                }

                #endregion

                #region large collision bsps

                foreach (var cbsp in definition.LargeCollisionBsps)
                {
                    reader.BaseStream.Position = cbsp.Bsp3DNodes.Address.Offset;
                    for (var i = 0; i < cbsp.Bsp3DNodes.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp3DNode));
                        cbsp.Bsp3DNodes.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp3DNode)element);
                    }

                    reader.BaseStream.Position = cbsp.Planes.Address.Offset;
                    for (var i = 0; i < cbsp.Planes.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Plane));
                        cbsp.Planes.Add((CollisionBspResourceDefinition.CollisionBsp.Plane)element);
                    }

                    reader.BaseStream.Position = cbsp.Leaves.Address.Offset;
                    for (var i = 0; i < cbsp.Leaves.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Leaf));
                        cbsp.Leaves.Add((CollisionBspResourceDefinition.CollisionBsp.Leaf)element);
                    }

                    reader.BaseStream.Position = cbsp.Bsp2DReferences.Address.Offset;
                    for (var i = 0; i < cbsp.Bsp2DReferences.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp2DReference));
                        cbsp.Bsp2DReferences.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp2DReference)element);
                    }

                    reader.BaseStream.Position = cbsp.Bsp2DNodes.Address.Offset;
                    for (var i = 0; i < cbsp.Bsp2DNodes.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp2DNode));
                        cbsp.Bsp2DNodes.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp2DNode)element);
                    }

                    reader.BaseStream.Position = cbsp.Surfaces.Address.Offset;
                    for (var i = 0; i < cbsp.Surfaces.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Surface));
                        cbsp.Surfaces.Add((CollisionBspResourceDefinition.CollisionBsp.Surface)element);
                    }

                    reader.BaseStream.Position = cbsp.Edges.Address.Offset;
                    for (var i = 0; i < cbsp.Edges.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Edge));
                        cbsp.Edges.Add((CollisionBspResourceDefinition.CollisionBsp.Edge)element);
                    }

                    reader.BaseStream.Position = cbsp.Vertices.Address.Offset;
                    for (var i = 0; i < cbsp.Vertices.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Vertex));
                        cbsp.Vertices.Add((CollisionBspResourceDefinition.CollisionBsp.Vertex)element);
                    }
                }

                #endregion

                #region compressions

                foreach (var comp in definition.Compressions)
                {
                    #region compression's resource data

                    reader.BaseStream.Position = comp.CollisionBsp.Bsp3DNodes.Address.Offset;
                    for (var i = 0; i < comp.CollisionBsp.Bsp3DNodes.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp3DNode));
                        comp.CollisionBsp.Bsp3DNodes.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp3DNode)element);
                    }

                    reader.BaseStream.Position = comp.CollisionBsp.Planes.Address.Offset;
                    for (var i = 0; i < comp.CollisionBsp.Planes.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Plane));
                        comp.CollisionBsp.Planes.Add((CollisionBspResourceDefinition.CollisionBsp.Plane)element);
                    }

                    reader.BaseStream.Position = comp.CollisionBsp.Leaves.Address.Offset;
                    for (var i = 0; i < comp.CollisionBsp.Leaves.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Leaf));
                        comp.CollisionBsp.Leaves.Add((CollisionBspResourceDefinition.CollisionBsp.Leaf)element);
                    }

                    reader.BaseStream.Position = comp.CollisionBsp.Bsp2DReferences.Address.Offset;
                    for (var i = 0; i < comp.CollisionBsp.Bsp2DReferences.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp2DReference));
                        comp.CollisionBsp.Bsp2DReferences.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp2DReference)element);
                    }

                    reader.BaseStream.Position = comp.CollisionBsp.Bsp2DNodes.Address.Offset;
                    for (var i = 0; i < comp.CollisionBsp.Bsp2DNodes.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp2DNode));
                        comp.CollisionBsp.Bsp2DNodes.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp2DNode)element);
                    }

                    reader.BaseStream.Position = comp.CollisionBsp.Surfaces.Address.Offset;
                    for (var i = 0; i < comp.CollisionBsp.Surfaces.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Surface));
                        comp.CollisionBsp.Surfaces.Add((CollisionBspResourceDefinition.CollisionBsp.Surface)element);
                    }

                    reader.BaseStream.Position = comp.CollisionBsp.Edges.Address.Offset;
                    for (var i = 0; i < comp.CollisionBsp.Edges.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Edge));
                        comp.CollisionBsp.Edges.Add((CollisionBspResourceDefinition.CollisionBsp.Edge)element);
                    }

                    reader.BaseStream.Position = comp.CollisionBsp.Vertices.Address.Offset;
                    for (var i = 0; i < comp.CollisionBsp.Vertices.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Vertex));
                        comp.CollisionBsp.Vertices.Add((CollisionBspResourceDefinition.CollisionBsp.Vertex)element);
                    }

                    #endregion
                    
                    #region compression's other resource data

                    foreach (var cbsp in comp.CollisionBsps)
                    {
                        reader.BaseStream.Position = cbsp.Bsp3DNodes.Address.Offset;
                        for (var i = 0; i < cbsp.Bsp3DNodes.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp3DNode));
                            cbsp.Bsp3DNodes.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp3DNode)element);
                        }

                        reader.BaseStream.Position = cbsp.Planes.Address.Offset;
                        for (var i = 0; i < cbsp.Planes.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Plane));
                            cbsp.Planes.Add((CollisionBspResourceDefinition.CollisionBsp.Plane)element);
                        }

                        reader.BaseStream.Position = cbsp.Leaves.Address.Offset;
                        for (var i = 0; i < cbsp.Leaves.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Leaf));
                            cbsp.Leaves.Add((CollisionBspResourceDefinition.CollisionBsp.Leaf)element);
                        }

                        reader.BaseStream.Position = cbsp.Bsp2DReferences.Address.Offset;
                        for (var i = 0; i < cbsp.Bsp2DReferences.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp2DReference));
                            cbsp.Bsp2DReferences.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp2DReference)element);
                        }

                        reader.BaseStream.Position = cbsp.Bsp2DNodes.Address.Offset;
                        for (var i = 0; i < cbsp.Bsp2DNodes.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Bsp2DNode));
                            cbsp.Bsp2DNodes.Add((CollisionBspResourceDefinition.CollisionBsp.Bsp2DNode)element);
                        }

                        reader.BaseStream.Position = cbsp.Surfaces.Address.Offset;
                        for (var i = 0; i < cbsp.Surfaces.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Surface));
                            cbsp.Surfaces.Add((CollisionBspResourceDefinition.CollisionBsp.Surface)element);
                        }

                        reader.BaseStream.Position = cbsp.Edges.Address.Offset;
                        for (var i = 0; i < cbsp.Edges.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Edge));
                            cbsp.Edges.Add((CollisionBspResourceDefinition.CollisionBsp.Edge)element);
                        }

                        reader.BaseStream.Position = cbsp.Vertices.Address.Offset;
                        for (var i = 0; i < cbsp.Vertices.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.CollisionBsp.Vertex));
                            cbsp.Vertices.Add((CollisionBspResourceDefinition.CollisionBsp.Vertex)element);
                        }
                    }

                    #endregion

                    #region Unknown Data

                    for (var i = 0; i < comp.Unknown1.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.Compression.Unknown1Block));
                        comp.Unknown1.Add((CollisionBspResourceDefinition.Compression.Unknown1Block)element);
                    }

                    for (var i = 0; i < comp.Unknown2.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.Compression.Unknown2Block));
                        comp.Unknown2.Add((CollisionBspResourceDefinition.Compression.Unknown2Block)element);
                    }

                    for (var i = 0; i < comp.Unknown3.Count; i++)
                    {
                        var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(CollisionBspResourceDefinition.Compression.Unknown3Block));
                        comp.Unknown3.Add((CollisionBspResourceDefinition.Compression.Unknown3Block)element);
                    }

                    #endregion

                    #region compression's havok collision data

                    foreach (var collision in comp.CollisionMoppCodes)
                    {
                        for (var i = 0; i < collision.Data.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(byte));
                            collision.Data.Add((byte)element);
                        }
                    }

                    foreach (var collision in comp.CollisionMoppCodes2)
                    {
                        for (var i = 0; i < collision.Data.Count; i++)
                        {
                            var element = Info.Deserializer.DeserializeValue(reader, null, null, typeof(byte));
                            collision.Data.Add((byte)element);
                        }
                    }

                    #endregion
                }

                #endregion
            }

            return true;
        }
    }
}
