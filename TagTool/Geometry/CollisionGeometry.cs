using System;
using System.Collections.Generic;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Geometry
{
    [TagStructure(Size = 0x5C)]
    public class CollisionGeometry
    {
        public List<Bsp3dNode> Bsp3dNodes;
        public List<Plane> Planes;
        public List<Leaf> Leaves;
        public List<Bsp2dReference> Bsp2dReferences;
        public List<Bsp2dNode> Bsp2dNodes;
        public List<Surface> Surfaces;
        public List<Edge> Edges;
        public List<Vertex> Vertices;

        [TagStructure(Size = 0x8)]
        public class Bsp3dNode
        {
            public short Plane;
            public byte BackChildLower;
            public byte BackChildMid;
            public byte BackChildUpper;
            public byte FrontChildLower;
            public byte FrontChildMid;
            public byte FrontChildUpper;
        }

        [TagStructure(Size = 0x10)]
        public class Plane
        {
            public float PlaneI;
            public float PlaneJ;
            public float PlaneK;
            public float PlaneD;
        }

        [Flags]
        public enum LeafFlags : ushort
        {
            None = 0,
            ContainsDoubleSidedSurfaces = 1 << 0
        }

        [TagStructure(Size = 0x4)]
        public class Leaf
        {
            public LeafFlags Flags;
            public short Bsp2dReferenceCount;
            public int FirstBsp2dReference;
        }

        [TagStructure(Size = 0x4)]
        public class Bsp2dReference
        {
            public short PlaneIndex;
            public short Bsp2dNodeIndex;
        }

        [TagStructure(Size = 0x10)]
        public class Bsp2dNode
        {
            public float PlaneI;
            public float PlaneJ;
            public float PlaneD;
            public short LeftChild;
            public short RightChild;
        }

        [Flags]
        public enum SurfaceFlags : byte
        {
            None = 0,
            TwoSided = 1 << 0,
            Invisible = 1 << 1,
            Climbable = 1 << 2,
            Invalid = 1 << 3,
            Conveyor = 1 << 4,
            Slip = 1 << 5,
            PlaneNegated = 1 << 6
        }

        [TagStructure(Size = 0xC)]
        public class Surface
        {
            public short Plane;
            public short FirstEdge;
            public short Material;
            public short Unknown;
            public short BreakableSurface;
            public SurfaceFlags Flags;
            public byte BestPlaneCalculationVertex;
        }

        [TagStructure(Size = 0xC)]
        public class Edge
        {
            public short StartVertex;
            public short EndVertex;
            public short ForwardEdge;
            public short ReverseEdge;
            public short LeftSurface;
            public short RightSurface;
        }

        [TagStructure(Size = 0x10)]
        public class Vertex
        {
            public RealPoint3d Point;
            public short FirstEdge;
            public short Sink;
        }
    }
}
