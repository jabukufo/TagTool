﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineTagTool.Common;
using HaloOnlineTagTool.Serialization;

namespace HaloOnlineTagTool.Resources.Geometry
{
    [TagStructure(Size = 0x30)]
    public class CollisionBspResourceDefinition
    {
        public List<CollisionBsp> CollisionBsps;
        public List<CollisionBsp> LargeCollisionBsps;
        public List<Compression> Compressions;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;
        
        [TagStructure(Size = 0x5C)]
        public class CollisionBsp
        {
            public ResourceBlockReference<Bsp3DNode> Bsp3DNodes;
            public ResourceBlockReference<Plane> Planes;
            public ResourceBlockReference<Leaf> Leaves;
            public ResourceBlockReference<Bsp2DReference> Bsp2DReferences;
            public ResourceBlockReference<Bsp2DNode> Bsp2DNodes;
            public ResourceBlockReference<Surface> Surfaces;
            public ResourceBlockReference<Edge> Edges;
            public ResourceBlockReference<Vertex> Vertices;

            [TagStructure(Size = 0x8)]
            public class Bsp3DNode
            {
                public byte Unknown;
                public short SecondChild;
                public byte Unknown2;
                public short FirstChild;
                public short Plane;
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
            public enum LeafFlags : byte
            {
                None = 0,
                ContainsDoubleSidedSurfaces = 1 << 0,
                Bit1 = 1 << 1,
                Bit2 = 1 << 2,
                Bit3 = 1 << 3,
                Bit4 = 1 << 4,
                Bit5 = 1 << 5,
                Bit6 = 1 << 6,
                Bit7 = 1 << 7
            }

            [TagStructure(Size = 0x4)]
            public class Leaf
            {
                public LeafFlags Flags;
                public byte Unused;
                public short Bsp2DReferenceCount;
                public int FirstBsp2DReference;
            }

            [TagStructure(Size = 0x4)]
            public class Bsp2DReference
            {
                public short Plane;
                public short Bsp2DNode;
            }

            [TagStructure(Size = 0x10)]
            public class Bsp2DNode
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
                public Vector3 Position;
                public short FirstEdge;
                public short Sink;
            }
        }

        [TagStructure(Size = 0xC8)]
        public class Compression
        {
            public float X;
            public float Y;
            public float Z;
            public float W;
            public float R;
            public CollisionBsp CollisionBsp;
            public int Unknown13;
            public List<CollisionBsp> CollisionBsps;
            public List<CollisionMoppCode> CollisionMoppCodes;
            public ResourceBlockReference<Unknown1Block> Unknown1;
            public ResourceBlockReference<Unknown2Block> Unknown2;
            public ResourceBlockReference<Unknown3Block> Unknown3;
            public short Index01;
            public short Index02;
            public int Unknown10;
            public List<CollisionMoppCode> CollisionMoppCodes2;
            public int Unknown11;

            [TagStructure(Size = 0x40)]
            public class CollisionMoppCode
            {
                public int Unknown1;
                public short Size;
                public short Count;
                public int Address;
                public int Unknown2;
                public Vector3 Offset;
                public float OffsetScale;
                public int Unknown3;
                public int DataSize;
                public uint DataCapacity;
                public sbyte Unknown4;
                public sbyte Unknown5;
                public sbyte Unknown6;
                public sbyte Unknown7;
                public ResourceBlockReference<byte> Data;
                public int Unknown9;
            }

            [TagStructure]
            public class Unknown1Block
            {
                public uint Unknown;
            }

            [TagStructure]
            public class Unknown2Block
            {
                public uint Unknown;
                public uint Unknown2;
            }

            [TagStructure]
            public class Unknown3Block
            {
                public uint Unknown;
            }
        }
    }
}
