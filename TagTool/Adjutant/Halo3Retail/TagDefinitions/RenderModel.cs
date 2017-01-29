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
	[TagStructure(Class = "mode", Size = 0x1CC)]
	public class RenderModel
	{
		public StringID Name;
		public FlagsValue Flags;
		public short Unknown;
		public int ModelChecksum;
		public List<Region> Regions;
		public uint Unknown2;
		public int InstanceStartingMeshIndex;
		public List<Instance> Instances;
		public uint Unknown3;
		public List<Node> Nodes;
		public List<MarkerGroup> MarkerGroups;
		public List<Material> Materials;
		public uint Unknown4;
		public uint Unknown5;
		public uint Unknown6;
		public uint Unknown7;
		public int Unknown8;
		public List<Mesh> Meshes;
		public List<CompressionInfoBlock> CompressionInfo;
		public List<UnknownNodeyBlock> UnknownNodey;
		public List<UnknownBlock> Unknown9;
		public uint Unknown10;
		public uint Unknown11;
		public uint Unknown12;
		public List<UnknownMesh> UnknownMeshes;
		public List<NodeMap> NodeMaps;
		public List<UnknownBlock2> Unknown13;
		public uint Unknown14;
		public uint Unknown15;
		public uint Unknown16;
		public List<UnknownYoBlock> UnknownYo;
		public ushort ZoneAssetSalt;
		public ushort ZoneAssetIndex;
		public int UselessPadding;
		public List<UnknownBlock3> Unknown17;
		public uint UnknownA;
		public uint UnknownA2;
		public uint UnknownA3;
		public uint UnknownA4;
		public uint UnknownA5;
		public uint UnknownA6;
		public uint UnknownA7;
		public uint UnknownA8;
		public uint UnknownA9;
		public uint UnknownA10;
		public uint UnknownA11;
		public uint UnknownA12;
		public uint UnknownA13;
		public uint UnknownA14;
		public uint UnknownA15;
		public uint UnknownA16;
		public uint UnknownB;
		public uint UnknownB2;
		public uint UnknownB3;
		public uint UnknownB4;
		public uint UnknownB5;
		public uint UnknownB6;
		public uint UnknownB7;
		public uint UnknownB8;
		public uint UnknownB9;
		public uint UnknownB10;
		public uint UnknownB11;
		public uint UnknownB12;
		public uint UnknownB13;
		public uint UnknownB14;
		public uint UnknownB15;
		public uint UnknownB16;
		public uint UnknownC;
		public uint UnknownC2;
		public uint UnknownC3;
		public uint UnknownC4;
		public uint UnknownC5;
		public uint UnknownC6;
		public uint UnknownC7;
		public uint UnknownC8;
		public uint UnknownC9;
		public uint UnknownC10;
		public uint UnknownC11;
		public uint UnknownC12;
		public uint UnknownC13;
		public uint UnknownC14;
		public uint UnknownC15;
		public uint UnknownC16;
		public List<UnknownBlock4> Unknown18;
		public List<RuntimeNode> RuntimeNodes;

		public enum FlagsValue : ushort
		{
			None,
			Bit0,
			Bit1,
			ForceNodeMaps = 4,
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

		[TagStructure(Size = 0x10)]
		public class Region
		{
			public StringID Name;
			public List<Permutation> Permutations;

			[TagStructure(Size = 0x10)]
			public class Permutation
			{
				public StringID Name;
				public short MeshIndex;
				public short MeshCount;
				public int Unknown;
				public int Unknown2;
			}
		}

		[TagStructure(Size = 0x3C)]
		public class Instance
		{
			public StringID Name;
			public int NodeIndex;
			public float DefaultScale;
			public float InverseForwardI;
			public float InverseForwardJ;
			public float InverseForwardK;
			public float InverseLeftI;
			public float InverseLeftJ;
			public float InverseLeftK;
			public float InverseUpI;
			public float InverseUpJ;
			public float InverseUpK;
			public float InversePositionX;
			public float InversePositionY;
			public float InversePositionZ;
		}

		[TagStructure(Size = 0x60)]
		public class Node
		{
			public StringID Name;
			public short ParentNode;
			public short FirstChildNode;
			public short NextSiblingNode;
			public short ImportNodeIndex;
			public float DefaultTranslationX;
			public float DefaultTranslationY;
			public float DefaultTranslationZ;
			public float DefaultRotationI;
			public float DefaultRotationJ;
			public float DefaultRotationK;
			public float DefaultRotationW;
			public float DefaultScale;
			public float InverseForwardI;
			public float InverseForwardJ;
			public float InverseForwardK;
			public float InverseLeftI;
			public float InverseLeftJ;
			public float InverseLeftK;
			public float InverseUpI;
			public float InverseUpJ;
			public float InverseUpK;
			public float InversePositionX;
			public float InversePositionY;
			public float InversePositionZ;
			public float DistanceFromParent;
		}

		[TagStructure(Size = 0x10)]
		public class MarkerGroup
		{
			public StringID Name;
			public List<Marker> Markers;

			[TagStructure(Size = 0x24)]
			public class Marker
			{
				public sbyte RegionIndex;
				public sbyte PermutationIndex;
				public sbyte NodeIndex;
				public sbyte Unknown;
				public float TranslationX;
				public float TranslationY;
				public float TranslationZ;
				public float RotationI;
				public float RotationJ;
				public float RotationK;
				public float RotationW;
				public float Scale;
			}
		}

		[TagStructure(Size = 0x24)]
		public class Material
		{
			public TagInstance Shader;
			public List<Property> Properties;
			public int Unknown;
			public sbyte BreakableSurfaceIndex;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public sbyte Unknown4;

			[TagStructure(Size = 0xC)]
			public class Property
			{
				public short Type;
				public short IntValue;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;
				public sbyte Unknown4;
				public float RealValue;
			}
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

		[TagStructure(Size = 0x1C)]
		public class UnknownBlock3
		{
			public float Unknown;
			public float Unknown2;
			public float Unknown3;
			public float Unknown4;
			public float Unknown5;
			public float Unknown6;
			public float Unknown7;
		}

		[TagStructure(Size = 0x150)]
		public class UnknownBlock4
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
			public uint Unknown51;
			public uint Unknown52;
			public uint Unknown53;
			public uint Unknown54;
			public uint Unknown55;
			public uint Unknown56;
			public uint Unknown57;
			public uint Unknown58;
			public uint Unknown59;
			public uint Unknown60;
			public uint Unknown61;
			public uint Unknown62;
			public uint Unknown63;
			public uint Unknown64;
			public uint Unknown65;
			public uint Unknown66;
			public uint Unknown67;
			public uint Unknown68;
			public uint Unknown69;
			public uint Unknown70;
			public uint Unknown71;
			public uint Unknown72;
			public uint Unknown73;
			public uint Unknown74;
			public uint Unknown75;
			public uint Unknown76;
			public uint Unknown77;
			public uint Unknown78;
			public uint Unknown79;
			public uint Unknown80;
			public uint Unknown81;
			public uint Unknown82;
			public uint Unknown83;
			public uint Unknown84;
		}

		[TagStructure(Size = 0x20)]
		public class RuntimeNode
		{
			public float DefaultRotationI;
			public float DefaultRotationJ;
			public float DefaultRotationK;
			public float DefaultRotationW;
			public float DefaultTranslationX;
			public float DefaultTranslationY;
			public float DefaultTranslationZ;
			public float DefaultScale;
		}
	}
}
