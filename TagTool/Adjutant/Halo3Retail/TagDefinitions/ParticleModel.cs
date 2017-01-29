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
	[TagStructure(Class = "pmdf", Size = 0x90)]
	public class ParticleModel
	{
		public int Unknown;
		public List<Mesh> Meshes;
		public List<CompressionInfoBlock> CompressionInfo;
		public List<UnknownNodeyBlock> UnknownNodey;
		public List<UnknownBlock> Unknown2;
		public uint Unknown3;
		public uint Unknown4;
		public uint Unknown5;
		public List<UnknownMesh> UnknownMeshes;
		public List<NodeMap> NodeMaps;
		public List<UnknownBlock2> Unknown6;
		public uint Unknown7;
		public uint Unknown8;
		public uint Unknown9;
		public List<UnknownYoBlock> UnknownYo;
		public ushort ZoneAssetSalt;
		public ushort ZoneAssetIndex;
		public int UselessPadding;
		public List<UnknownBlock3> Unknown10;

		[TagStructure(Size = 0x4C)]
		public class Mesh
		{
			public List<Part> Parts;
			public List<Subpart> Subparts;
			public short VertexBufferIndex1;
			public short VertexBufferIndex2;
			public short VertexBufferIndex3;
			public short VertexBufferIndex4;
			public short VertexBufferIndex5;
			public short VertexBufferIndex6;
			public short VertexBufferIndex7;
			public short VertexBufferIndex8;
			public short IndexBufferIndex1;
			public short IndexBufferIndex2;
			public FlagsValue Flags;
			public sbyte RigidNode;
			public VertexTypeValue VertexType;
			public PrtTypeValue PrtType;
			public IndexBufferTypeValue IndexBufferType;
			public sbyte Unknown;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public List<InstancedGeometryIndex> InstancedGeometryIndices;
			public List<UnknownWaterBlock> UnknownWater;

			[TagStructure(Size = 0x10)]
			public class Part
			{
				public short MaterialIndex;
				public short UnknownNodeyIndex;
				public short IndexBufferStart;
				public short IndexBufferCount;
				public short SubpartIndex;
				public short SubpartCount;
				public sbyte UnknownEnum;
				public FlagsValue Flags;
				public short VertexCount;

				public enum FlagsValue : byte
				{
					None,
					Bit0,
					Bit1,
					Bit2 = 4,
					Water = 8,
					Bit4 = 16,
					Bit5 = 32,
					Bit6 = 64,
					Bit7 = 128,
				}
			}

			[TagStructure(Size = 0x8)]
			public class Subpart
			{
				public short IndexBufferStart;
				public short IndexBufferCount;
				public short PartIndex;
				public short VertexCount;
			}

			public enum FlagsValue : byte
			{
				None,
				HasVertexColors,
				Bit1,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
			}

			public enum VertexTypeValue : sbyte
			{
				World,
				Rigid,
				Skinned,
				ParticleModel,
				FlatWorld,
				FlatRigid,
				FlatSkinned,
				Screen,
				Debug,
				Transparent,
				Particle,
				Contrail,
				LightVolume,
				ChudSimple,
				ChudFancy,
				Decorator,
				TinyPosition,
				PatchyFog,
				Water,
				Ripple,
				Implicit,
				Beam,
			}

			public enum PrtTypeValue : sbyte
			{
				None,
				Ambient,
				Linear,
				Quadratic,
			}

			public enum IndexBufferTypeValue : sbyte
			{
				PointList,
				LineList,
				LineStrip,
				TriangeList,
				TriangeFan,
				TriangeStrip,
			}

			[TagStructure(Size = 0x10)]
			public class InstancedGeometryIndex
			{
				public short InstancedGeometryMeshIndex1;
				public short InstancedGeometryMeshIndex2;
				public List<InstancedGeometryMeshContent> InstancedGeometryMeshContents;

				[TagStructure(Size = 0x2)]
				public class InstancedGeometryMeshContent
				{
					public short InstancedGeometryIndex;
				}
			}

			[TagStructure(Size = 0x2)]
			public class UnknownWaterBlock
			{
				public short Unknown;
			}
		}

		[TagStructure(Size = 0x2C)]
		public class CompressionInfoBlock
		{
			public short Unknown;
			public short Unknown2;
			public float PositionBoundsXMin;
			public float PositionBoundsXMax;
			public float PositionBoundsYMin;
			public float PositionBoundsYMax;
			public float PositionBoundsZMin;
			public float PositionBoundsZMax;
			public float TexcoordBoundsXMin;
			public float TexcoordBoundsXMax;
			public float TexcoordBoundsYMin;
			public float TexcoordBoundsYMax;
		}

		[TagStructure(Size = 0x30)]
		public class UnknownNodeyBlock
		{
			public float Unknown;
			public float Unknown2;
			public float Unknown3;
			public float Unknown4;
			public float Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float Unknown8;
			public sbyte NodeIndex;
			public sbyte NodeIndex2;
			public sbyte NodeIndex3;
			public sbyte NodeIndex4;
			public float Unknown9;
			public float Unknown10;
			public float Unknown11;
		}

		[TagStructure(Size = 0x18)]
		public class UnknownBlock
		{
			public short Unknown;
			public short Unknown2;
			public byte[] Unknown3;
		}

		[TagStructure(Size = 0x20)]
		public class UnknownMesh
		{
			public byte[] Unknown;
			public List<UnknownBlock> Unknown2;

			[TagStructure(Size = 0x2)]
			public class UnknownBlock
			{
				public short Unknown;
			}
		}

		[TagStructure(Size = 0xC)]
		public class NodeMap
		{
			public List<UnknownBlock> Unknown;

			[TagStructure(Size = 0x1)]
			public class UnknownBlock
			{
				public byte NodeIndex;
			}
		}

		[TagStructure(Size = 0xC)]
		public class UnknownBlock2
		{
			public List<UnknownBlock> Unknown;

			[TagStructure(Size = 0x30)]
			public class UnknownBlock
			{
				public uint Unknown;
				public uint Unknown2;
				public uint Unknown3;
				public uint Unknown4;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;
				public uint Unknown9;
				public uint Unknown10;
				public uint Unknown11;
				public uint Unknown12;
			}
		}

		[TagStructure(Size = 0x10)]
		public class UnknownYoBlock
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public short UnknownIndex;
			public short Unknown4;
		}

		[TagStructure(Size = 0x10)]
		public class UnknownBlock3
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
		}
	}
}
