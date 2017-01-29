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
	[TagStructure(Class = "sLdT", Size = 0x58)]
	public class ScenarioLightmap
	{
		public uint Unknown;
		public List<LightmapBlock> Lightmap;
		public uint Unknown2;
		public uint Unknown3;
		public uint Unknown4;
		public uint Unknown5;
		public uint Unknown6;
		public uint Unknown7;
		public List<Airprobe> Airprobes;
		public List<UnknownBlock> Unknown8;
		public List<UnknownBlock2> Unknown9;
		public uint Unknown10;
		public uint Unknown11;
		public uint Unknown12;

		[TagStructure(Size = 0x1B4)]
		public class LightmapBlock
		{
			public short Unknown;
			public short BspIndex;
			public int StructureChecksum;
			public uint Shadows;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Midtones;
			public uint Unknown7;
			public uint Unknown8;
			public uint Unknown9;
			public uint Unknown10;
			public uint Unknown11;
			public uint Highlights;
			public uint Unknown12;
			public uint Unknown13;
			public uint Unknown14;
			public uint Unknown15;
			public uint Unknown16;
			public uint TopDownWhites;
			public uint Unknown17;
			public uint Unknown18;
			public uint Unknown19;
			public uint Unknown20;
			public uint Unknown21;
			public uint TopDownBlacks;
			public uint Unknown22;
			public uint Unknown23;
			public uint Unknown24;
			public uint Unknown25;
			public uint Unknown26;
			public uint Unknown27;
			public uint Unknown28;
			public uint Unknown29;
			public uint Unknown30;
			public uint Unknown31;
			public uint Unknown32;
			public uint Unknown33;
			public uint Unknown34;
			public uint Unknown35;
			public uint Unknown36;
			public uint Unknown37;
			public uint Unknown38;
			public uint Unknown39;
			public uint Unknown40;
			public uint Unknown41;
			public uint Unknown42;
			public uint Unknown43;
			public uint Unknown44;
			public uint Unknown45;
			public uint Unknown46;
			public uint Unknown47;
			public uint Unknown48;
			public uint Unknown49;
			public uint Unknown50;
			public TagInstance PrimaryMap;
			public TagInstance IntensityMap;
			public List<InstancedMesh> InstancedMeshes;
			public List<UnknownBlock> Unknown51;
			public List<InstancedGeometryBlock> InstancedGeometry;
			public List<UnknownBBlock> UnknownB;
			public int Unknown52;
			public List<Mesh> Meshes;
			public List<CompressionInfoBlock> CompressionInfo;
			public List<UnknownNodeyBlock> UnknownNodey;
			public List<UnknownBlock2> Unknown53;
			public uint Unknown54;
			public uint Unknown55;
			public uint Unknown56;
			public List<UnknownMesh> UnknownMeshes;
			public List<NodeMap> NodeMaps;
			public List<UnknownBlock3> Unknown57;
			public uint Unknown58;
			public uint Unknown59;
			public uint Unknown60;
			public List<UnknownYoBlock> UnknownYo;
			public ushort ZoneAssetSalt;
			public ushort ZoneAssetIndex;
			public int UselessPadding;

			[TagStructure(Size = 0x10)]
			public class InstancedMesh
			{
				public uint Unknown;
				public uint Unknown2;
				public uint Unknown3;
				public int UnknownIndex;
			}

			[TagStructure(Size = 0x4)]
			public class UnknownBlock
			{
				public short Unknown;
				public short Unknown2;
			}

			[TagStructure(Size = 0x8)]
			public class InstancedGeometryBlock
			{
				public short Unknown;
				public short InstancedMeshIndex;
				public short UnknownBIndex;
				public short Unknown2;
			}

			[TagStructure(Size = 0x48)]
			public class UnknownBBlock
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
				public uint Unknown13;
				public uint Unknown14;
				public uint Unknown15;
				public uint Unknown16;
				public uint Unknown17;
				public uint Unknown18;
			}

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
			public class UnknownBlock2
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
			public class UnknownBlock3
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
		}

		[TagStructure(Size = 0x5C)]
		public class Airprobe
		{
			public float Unknown;
			public float Unknown2;
			public float Unknown3;
			public StringID Unknown4;
			public UnknownValue Unknown5;
			public short Unknown6;
			public uint Unknown7;
			public uint Unknown8;
			public uint Unknown9;
			public uint Unknown10;
			public uint Unknown11;
			public uint Unknown12;
			public uint Unknown13;
			public uint Unknown14;
			public uint Unknown15;
			public uint Unknown16;
			public uint Unknown17;
			public uint Unknown18;
			public uint Unknown19;
			public uint Unknown20;
			public uint Unknown21;
			public uint Unknown22;
			public uint Unknown23;
			public uint Unknown24;

			public enum UnknownValue : ushort
			{
				None,
				Bit0,
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
			}
		}

		[TagStructure(Size = 0x50)]
		public class UnknownBlock
		{
			public short Unknown;
			public short Unknown2;
			public short Unknown3;
			public short Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
			public uint Unknown9;
			public uint Unknown10;
			public uint Unknown11;
			public uint Unknown12;
			public uint Unknown13;
			public uint Unknown14;
			public uint Unknown15;
			public uint Unknown16;
			public uint Unknown17;
			public uint Unknown18;
			public uint Unknown19;
			public uint Unknown20;
			public uint Unknown21;
			public uint Unknown22;
		}

		[TagStructure(Size = 0x2C)]
		public class UnknownBlock2
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
			public List<UnknownBlock> Unknown9;

			[TagStructure(Size = 0x54)]
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
				public uint Unknown13;
				public uint Unknown14;
				public uint Unknown15;
				public uint Unknown16;
				public uint Unknown17;
				public uint Unknown18;
				public uint Unknown19;
				public uint Unknown20;
				public uint Unknown21;
			}
		}
	}
}
