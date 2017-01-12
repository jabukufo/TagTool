using System.Collections.Generic;
using TagTool.Serialization;

namespace TagTool.Geometry
{
    /// <summary>
    /// A 3D mesh which can be rendered.
    /// </summary>
    [TagStructure(Size = 0x4C)]
    public class Mesh
    {
        public List<Part> Parts;
        public List<SubPart> SubParts;
        [TagField(Count = 8)] public ushort[] VertexBuffers;
        [TagField(Count = 2)] public ushort[] IndexBuffers;
        public MeshFlags Flags;
        public sbyte RigidNodeIndex;
        public VertexType Type;
        public PrtType PrtType;
        public PrimitiveType IndexBufferType;
        public List<InstancedGeometryBlock> InstancedGeometry;
        public List<short> Water;

        /// <summary>
        /// Associates geometry with a specific material.
        /// </summary>
        [TagStructure(Size = 0x10)]
        public class Part
        {
            /// <summary>
            /// Gets or sets the index of the material.
            /// </summary>
            public short MaterialIndex;

            public short Unknown2;

            /// <summary>
            /// Gets or sets the index of the first vertex in the index buffer.
            /// </summary>
            public ushort FirstIndex;

            /// <summary>
            /// Gets or sets the number of indexes in the part.
            /// </summary>
            public ushort IndexCount;

            /// <summary>
            /// Gets or sets the index of the first subpart that makes up this part.
            /// </summary>
            public short FirstSubPartIndex;

            /// <summary>
            /// Gets or sets the number of subparts that make up this part.
            /// </summary>
            public short SubPartCount;
            
            public byte UnknownC; // enum
            public byte UnknownD; // flags

            /// <summary>
            /// Gets or sets the number of vertices that the part uses.
            /// </summary>
            public ushort VertexCount;
        }

        /// <summary>
        /// A subpart of a mesh which can be rendered selectively.
        /// </summary>
        [TagStructure(Size = 0x8)]
        public class SubPart
        {
            /// <summary>
            /// Gets or sets the index of the first vertex in the subpart.
            /// </summary>
            public ushort FirstIndex;

            /// <summary>
            /// Gets or sets the number of indexes in the subpart.
            /// </summary>
            public ushort IndexCount;

            /// <summary>
            /// Gets or sets the index of the part which this subpart belongs to.
            /// </summary>
            public short PartIndex;

            /// <summary>
            /// Gets or sets the number of vertices that the part uses.
            /// </summary>
            /// <remarks>
            /// Note that this actually seems to be unused. The value is pulled from
            /// the vertex buffer definition instead.
            /// </remarks>
            public ushort VertexCount;
        }

        [TagStructure(Size = 0x10)]
        public class InstancedGeometryBlock
        {
            public short Section1;
            public short Section2;
            public List<short> Contents;
        }
    }
}
