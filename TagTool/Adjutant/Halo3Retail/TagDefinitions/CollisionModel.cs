using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineTagTool.Common;
using HaloOnlineTagTool.Resources;
using HaloOnlineTagTool.Serialization;

namespace HaloOnlineTagTool.TagStructures
{
	[TagStructure(Class = "coll", Size = 0x44)]
	public class CollisionModel
	{
		public int CollisionModelChecksum;
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public FlagsValue Flags;
		public List<Material> Materials;
		public List<Region> Regions;
		public List<PathfindingSphere> PathfindingSpheres;
		public List<Node> Nodes;

		public enum FlagsValue : int
		{
			None,
			ContainsOpenEdges,
			Bit1,
			Bit2 = 4,
			Bit3 = 8,
			Bit4 = 16,
			Bit5 = 32,
			Bit6 = 64,
			Bit7 = 128,
			Bit8 = 256,
			Bit9 = 512,
			Bit10 = 1024,
			Bit11 = 2048,
			Bit12 = 4096,
			Bit13 = 8192,
			Bit14 = 16384,
			Bit15 = 32768,
			Bit16 = 65536,
			Bit17 = 131072,
			Bit18 = 262144,
			Bit19 = 524288,
			Bit20 = 1048576,
			Bit21 = 2097152,
			Bit22 = 4194304,
			Bit23 = 8388608,
			Bit24 = 16777216,
			Bit25 = 33554432,
			Bit26 = 67108864,
			Bit27 = 134217728,
			Bit28 = 268435456,
			Bit29 = 536870912,
			Bit30 = 1073741824,
			Bit31 = -2147483648,
		}

		[TagStructure(Size = 0x4)]
		public class Material
		{
			public StringID Name;
		}

		[TagStructure(Size = 0x10)]
		public class Region
		{
			public StringID Name;
			public List<Permutation> Permutations;

			[TagStructure(Size = 0x28)]
			public class Permutation
			{
				public StringID Name;
				public List<Bsp> Bsps;
				public List<BspPhysic> BspPhysics;
				public List<BspMoppCode> BspMoppCodes;

				[TagStructure(Size = 0x64)]
				public class Bsp
				{
					public short NodeIndex;
					public short Unknown;
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

					[TagStructure(Size = 0x8)]
					public class Leaf
					{
						public short Flags;
						public short Bsp2dReferenceCount;
						public short Unknown;
						public short FirstBsp2dReference;
					}

					[TagStructure(Size = 0x4)]
					public class Bsp2dReference
					{
						public short Plane;
						public short Bsp2dNode;
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

					[TagStructure(Size = 0xC)]
					public class Surface
					{
						public short Plane;
						public short FirstEdge;
						public short Material;
						public short Unknown;
						public short BreakableSurface;
						public short Unknown2;
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
						public uint PointX;
						public uint PointY;
						public uint PointZ;
						public short FirstEdge;
						public short Unknown;
					}
				}

				[TagStructure(Size = 0x70)]
				public class BspPhysic
				{
					public uint Unknown;
					public short Size;
					public short Count;
					public int Offset;
					public int Unknown2;
					public uint Unknown3;
					public uint Unknown4;
					public uint Unknown5;
					public uint Unknown6;
					public float Unknown7;
					public float Unknown8;
					public float Unknown9;
					public uint Unknown10;
					public float Unknown11;
					public float Unknown12;
					public float Unknown13;
					public uint Unknown14;
					[TagField(Flags = TagFieldFlags.Short)] public TagInstance Model;
					public uint Unknown15;
					public short Unknown16;
					public short Unknown17;
					public uint Unknown18;
					public uint Unknown19;
					public short Size2;
					public short Count2;
					public int Offset2;
					public int Unknown20;
					public int Unknown21;
					public uint Unknown22;
					public uint Unknown23;
					public uint Unknown24;
				}

				[TagStructure(Size = 0x40)]
				public class BspMoppCode
				{
					public int Size;
					public int Count;
					public int Offset;
					public uint Unknown;
					public float OffsetX;
					public float OffsetY;
					public float OffsetZ;
					public float OffsetScale;
					public uint Unknown2;
					public int DataSize;
					public uint DataCapacity;
					public sbyte Unknown3;
					public sbyte Unknown4;
					public sbyte Unknown5;
					public sbyte Unknown6;
					public List<Datum> Data;
					public uint Unknown7;

					[TagStructure(Size = 0x1)]
					public class Datum
					{
						public byte DataByte;
					}
				}
			}
		}

		[TagStructure(Size = 0x14)]
		public class PathfindingSphere
		{
			public short Node;
			public FlagsValue Flags;
			public float CenterX;
			public float CenterY;
			public float CenterZ;
			public float Radius;

			public enum FlagsValue : ushort
			{
				None,
				RemainsWhenOpen,
				VehicleOnly,
				WithSectors = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}
		}

		[TagStructure(Size = 0xC)]
		public class Node
		{
			public StringID Name;
			public short Unknown;
			public short ParentNode;
			public short NextSiblingNode;
			public short FirstChildNode;
		}
	}
}
