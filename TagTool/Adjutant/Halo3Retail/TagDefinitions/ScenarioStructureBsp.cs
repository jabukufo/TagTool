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
	[TagStructure(Class = "sbsp", Size = 0x388)]
	public class ScenarioStructureBsp
	{
		public int BspChecksum;
		public int Unknown;
		public uint Unknown2;
		public List<StructureSeam> StructureSeams;
		public List<UnknownRaw7thBlock> UnknownRaw7th;
		public List<CollisionMaterial> CollisionMaterials;
		public List<UnknownRaw3rdBlock> UnknownRaw3rd;
		public float WorldBoundsXMin;
		public float WorldBoundsXMax;
		public float WorldBoundsYMin;
		public float WorldBoundsYMax;
		public float WorldBoundsZMin;
		public float WorldBoundsZMax;
		public List<UnknownRaw6thBlock> UnknownRaw6th;
		public List<Unknown1Block> Unknown1;
		public List<ClusterPortal> ClusterPortals;
		public List<UnknownBlock> Unknown3;
		public List<FogBlock> Fog;
		public List<CameraEffect> CameraEffects;
		public uint Unknown4;
		public uint Unknown5;
		public uint Unknown6;
		public List<DetailObject> DetailObjects;
		public List<Cluster> Clusters;
		public List<Material> Materials;
		public List<SkyOwnerClusterBlock> SkyOwnerCluster;
		public List<ConveyorSurface> ConveyorSurfaces;
		public List<BreakableSurface> BreakableSurfaces;
		public List<PathfindingDatum> PathfindingData;
		public uint Unknown7;
		public uint Unknown8;
		public uint Unknown9;
		public List<BackgroundSoundEnvironmentPaletteBlock> BackgroundSoundEnvironmentPalette;
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
		public List<Marker> Markers;
		public List<Light> Lights;
		public List<UnknownBlock2> Unknown21;
		public List<RuntimeDecal> RuntimeDecals;
		public List<EnvironmentObjectPaletteBlock> EnvironmentObjectPalette;
		public List<EnvironmentObject> EnvironmentObjects;
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
		public List<InstancedGeometryInstance> InstancedGeometryInstances;
		public List<Decorator> Decorators;
		public int Unknown32;
		public List<Mesh> Meshes;
		public List<CompressionInfoBlock> CompressionInfo;
		public List<UnknownNodeyBlock> UnknownNodey;
		public List<UnknownBlock3> Unknown33;
		public uint Unknown34;
		public uint Unknown35;
		public uint Unknown36;
		public List<UnknownMesh> UnknownMeshes;
		public List<NodeMap> NodeMaps;
		public List<UnknownBlock4> Unknown37;
		public uint Unknown38;
		public uint Unknown39;
		public uint Unknown40;
		public List<UnknownYoBlock> UnknownYo;
		public ushort ZoneAssetSalt1;
		public ushort ZoneAssetIndex1;
		public int UselessPadding;
		public List<UnknownSoundClustersABlock> UnknownSoundClustersA;
		public List<UnknownSoundClustersBBlock> UnknownSoundClustersB;
		public List<UnknownSoundClustersCBlock> UnknownSoundClustersC;
		public List<TransparentPlane> TransparentPlanes;
		public uint Unknown41;
		public uint Unknown42;
		public uint Unknown43;
		public List<CollisionMoppCode> CollisionMoppCodes;
		public uint Unknown44;
		public float CollisionWorldBoundsXMin;
		public float CollisionWorldBoundsYMin;
		public float CollisionWorldBoundsZMin;
		public float CollisionWorldBoundsXMax;
		public float CollisionWorldBoundsYMax;
		public float CollisionWorldBoundsZMax;
		public List<BreakableSurfaceMoppCode> BreakableSurfaceMoppCodes;
		public List<BreakableSurfaceKeyTableBlock> BreakableSurfaceKeyTable;
		public uint Unknown45;
		public uint Unknown46;
		public uint Unknown47;
		public uint Unknown48;
		public uint Unknown49;
		public uint Unknown50;
		public int Unknown51;
		public List<Mesh2> Meshes2;
		public List<CompressionInfoBlock2> CompressionInfo2;
		public List<UnknownNodeyBlock2> UnknownNodey2;
		public List<UnknownBlock5> Unknown52;
		public uint Unknown53;
		public uint Unknown54;
		public uint Unknown55;
		public List<UnknownMesh2> UnknownMeshes2;
		public List<NodeMap2> NodeMaps2;
		public List<UnknownBlock6> Unknown56;
		public uint Unknown57;
		public uint Unknown58;
		public uint Unknown59;
		public List<UnknownYoBlock2> UnknownYo2;
		public ushort ZoneAssetSalt2;
		public ushort ZoneAssetIndex2;
		public int UselessPadding2;
		public List<LeafSystem> LeafSystems;
		public uint Unknown60;
		public uint Unknown61;
		public uint Unknown62;
		public ushort ZoneAssetSalt3;
		public ushort ZoneAssetIndex3;
		public int UselessPadding3;
		public int Unknown63;

		[TagStructure(Size = 0x28)]
		public class StructureSeam
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public List<UnknownBlock> Unknown5;
			public List<SeamCluster> SeamClusters;

			[TagStructure(Size = 0x4)]
			public class UnknownBlock
			{
				public int Unknown;
			}

			[TagStructure(Size = 0x10)]
			public class SeamCluster
			{
				public int ClusterIndex;
				public float CentroidX;
				public float CentroidY;
				public float CentroidZ;
			}
		}

		[TagStructure(Size = 0x4)]
		public class UnknownRaw7thBlock
		{
			public short Unknown;
			public short Unknown2;
		}

		[TagStructure(Size = 0x18)]
		public class CollisionMaterial
		{
			public TagInstance Shader;
			public short GlobalMaterialIndex;
			public short ConveyorSurfaceIndex;
			public short SeamIndex;
			public short Unknown;
		}

		[TagStructure(Size = 0x1)]
		public class UnknownRaw3rdBlock
		{
			public sbyte Unknown;
		}

		[TagStructure(Size = 0x4)]
		public class UnknownRaw6thBlock
		{
			public short Unknown1StartIndex;
			public short Unknown1EntryCount;
		}

		[TagStructure(Size = 0x4)]
		public class Unknown1Block
		{
			public ushort Unknown;
			public short Unknown2;
		}

		[TagStructure(Size = 0x28)]
		public class ClusterPortal
		{
			public short BackCluster;
			public short FrontCluster;
			public int PlaneIndex;
			public float CentroidX;
			public float CentroidY;
			public float CentroidZ;
			public float BoundingRadius;
			public FlagsValue Flags;
			public List<Vertex> Vertices;

			public enum FlagsValue : int
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

			[TagStructure(Size = 0xC)]
			public class Vertex
			{
				public float X;
				public float Y;
				public float Z;
			}
		}

		[TagStructure(Size = 0x78)]
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
			public uint Unknown22;
			public uint Unknown23;
			public uint Unknown24;
			public uint Unknown25;
			public uint Unknown26;
			public uint Unknown27;
			public uint Unknown28;
			public uint Unknown29;
			public uint Unknown30;
		}

		[TagStructure(Size = 0x8)]
		public class FogBlock
		{
			public StringID Name;
			public short Unknown;
			public short Unknown2;
		}

		[TagStructure(Size = 0x30)]
		public class CameraEffect
		{
			public StringID Name;
			public TagInstance Effect;
			public sbyte Unknown;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public sbyte Unknown4;
			public uint Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float Unknown8;
			public uint Unknown9;
			public uint Unknown10;
		}

		[TagStructure(Size = 0x34)]
		public class DetailObject
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public List<UnknownBlock> Unknown8;
			public uint Unknown9;
			public uint Unknown10;
			public uint Unknown11;

			[TagStructure(Size = 0x20)]
			public class UnknownBlock
			{
				public List<UnknownBlock2> Unknown;
				public byte[] Unknown2;

				[TagStructure(Size = 0x10)]
				public class UnknownBlock2
				{
					public uint Unknown;
					public uint Unknown2;
					public uint Unknown3;
					public uint Unknown4;
				}
			}
		}

		[TagStructure(Size = 0xDC)]
		public class Cluster
		{
			public float BoundsXMin;
			public float BoundsXMax;
			public float BoundsYMin;
			public float BoundsYMax;
			public float BoundsZMin;
			public float BoundsZMax;
			public sbyte Unknown;
			public sbyte ScenarioSkyIndex;
			public sbyte CameraEffectIndex;
			public sbyte Unknown2;
			public short BackgroundSoundEnvironmentIndex;
			public short SoundClustersAIndex;
			public short Unknown3;
			public short Unknown4;
			public short Unknown5;
			public short Unknown6;
			public short Unknown7;
			public short RuntimeDecalStartIndex;
			public short RuntimeDecalEntryCount;
			public short Flags;
			public uint Unknown8;
			public uint Unknown9;
			public uint Unknown10;
			public List<Portal> Portals;
			public int Unknown11;
			public short Size;
			public short Count;
			public int Offset;
			public int Unknown12;
			public uint Unknown13;
			public uint Unknown14;
			public TagInstance Bsp;
			public int ClusterIndex;
			public int Unknown15;
			public short Size2;
			public short Count2;
			public int Offset2;
			public int Unknown16;
			public uint Unknown17;
			public uint Unknown18;
			public uint Unknown19;
			public List<CollisionMoppCode> CollisionMoppCodes;
			public short MeshIndex;
			public short Unknown20;
			public List<Seam> Seams;
			public List<DecoratorGrid> DecoratorGrids;
			public uint Unknown21;
			public uint Unknown22;
			public uint Unknown23;
			public List<UnknownBlock> Unknown24;
			public List<UnknownBlock2> Unknown25;

			[TagStructure(Size = 0x2)]
			public class Portal
			{
				public short PortalIndex;
			}

			[TagStructure(Size = 0x40)]
			public class CollisionMoppCode
			{
				public int Unknown;
				public short Size;
				public short Count;
				public int Offset;
				public uint Unknown2;
				public float OffsetX;
				public float OffsetY;
				public float OffsetZ;
				public float OffsetScale;
				public uint Unknown3;
				public int DataSize;
				public uint DataCapacity;
				public sbyte Unknown4;
				public sbyte Unknown5;
				public sbyte Unknown6;
				public sbyte Unknown7;
				public List<Datum> Data;
				public uint Unknown8;

				[TagStructure(Size = 0x1)]
				public class Datum
				{
					public byte DataByte;
				}
			}

			[TagStructure(Size = 0x1)]
			public class Seam
			{
				public sbyte SeamIndex;
			}

			[TagStructure(Size = 0x30)]
			public class DecoratorGrid
			{
				public short Amount;
				public sbyte DecoratorIndex;
				public sbyte DecoratorIndexScattering;
				public int Unknown;
				public float PositionX;
				public float PositionY;
				public float PositionZ;
				public float Radius;
				public float GridSizeX;
				public float GridSizeY;
				public float GridSizeZ;
				public float BoundingSphereX;
				public float BoundingSphereY;
				public float BoundingSphereZ;
			}

			[TagStructure(Size = 0x4)]
			public class UnknownBlock
			{
				public short Unknown;
				public short Unknown2;
			}

			[TagStructure(Size = 0x10)]
			public class UnknownBlock2
			{
				public float Unknown;
				public float Unknown2;
				public float Unknown3;
				public short Unknown4;
				public short Unknown5;
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

		[TagStructure(Size = 0x2)]
		public class SkyOwnerClusterBlock
		{
			public short ClusterOwner;
		}

		[TagStructure(Size = 0x18)]
		public class ConveyorSurface
		{
			public uint UI;
			public uint UJ;
			public uint UK;
			public uint VI;
			public uint VJ;
			public uint VK;
		}

		[TagStructure(Size = 0x20)]
		public class BreakableSurface
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0xA0)]
		public class PathfindingDatum
		{
			public List<Sector> Sectors;
			public List<Link> Links;
			public List<Ref> Refs;
			public List<Bsp2dNode> Bsp2dNodes;
			public List<Vertex> Vertices;
			public List<ObjectRef> ObjectRefs;
			public List<PathfindingHint> PathfindingHints;
			public List<InstancedGeometryRef> InstancedGeometryRefs;
			public int StructureChecksum;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public List<UnknownBlock> Unknown4;
			public List<UnknownBlock2> Unknown5;
			public List<UnknownBlock3> Unknown6;
			public List<UnknownBlock4> Unknown7;

			[TagStructure(Size = 0x8)]
			public class Sector
			{
				public PathfindingSectorFlagsValue PathfindingSectorFlags;
				public short HintIndex;
				public int FirstLink;

				public enum PathfindingSectorFlagsValue : ushort
				{
					None,
					SectorWalkable,
					Bit1,
					Bit2 = 4,
					SectorBspSource = 8,
					Floor = 16,
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

			[TagStructure(Size = 0x10)]
			public class Link
			{
				public short Vertex1;
				public short Vertex2;
				public LinkFlagsValue LinkFlags;
				public short HintIndex;
				public short ForwardLink;
				public short ReverseLink;
				public short LeftSector;
				public short RightSector;

				public enum LinkFlagsValue : ushort
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

			[TagStructure(Size = 0x4)]
			public class Ref
			{
				public int NodeOrSectorRef;
			}

			[TagStructure(Size = 0x14)]
			public class Bsp2dNode
			{
				public uint PlaneI;
				public uint PlaneJ;
				public uint PlaneD;
				public int LeftChild;
				public int RightChild;
			}

			[TagStructure(Size = 0xC)]
			public class Vertex
			{
				public uint X;
				public uint Y;
				public uint Z;
			}

			[TagStructure(Size = 0x18)]
			public class ObjectRef
			{
				public uint Unknown;
				public List<UnknownBlock> Unknown2;
				public int Unknown3;
				public short Unknown4;
				public short Unknown5;

				[TagStructure(Size = 0x18)]
				public class UnknownBlock
				{
					public uint Unknown;
					public uint Unknown2;
					public List<UnknownBlock2> Unknown3;
					public int Unknown4;

					[TagStructure(Size = 0x4)]
					public class UnknownBlock2
					{
						public int Unknown;
					}
				}
			}

			[TagStructure(Size = 0x14)]
			public class PathfindingHint
			{
				public short HintType;
				public short NextHintIndex;
				public short HintData0;
				public short HintData1;
				public short HintData2;
				public short HintData3;
				public short HintData4;
				public short HintData5;
				public short HintData6;
				public short HintData7;
			}

			[TagStructure(Size = 0x4)]
			public class InstancedGeometryRef
			{
				public short PathfindingObjectIndex;
				public short Unknown;
			}

			[TagStructure(Size = 0x4)]
			public class UnknownBlock
			{
				public uint Unknown;
			}

			[TagStructure(Size = 0xC)]
			public class UnknownBlock2
			{
				public List<UnknownBlock> Unknown;

				[TagStructure(Size = 0x4)]
				public class UnknownBlock
				{
					public int Unknown;
				}
			}

			[TagStructure(Size = 0x14)]
			public class UnknownBlock3
			{
				public short Unknown;
				public short Unknown2;
				public float Unknown3;
				public List<UnknownBlock> Unknown4;

				[TagStructure(Size = 0x4)]
				public class UnknownBlock
				{
					public short Unknown;
					public short Unknown2;
				}
			}

			[TagStructure(Size = 0x4)]
			public class UnknownBlock4
			{
				public short Unknown;
				public short Unknown2;
			}
		}

		[TagStructure(Size = 0x54)]
		public class BackgroundSoundEnvironmentPaletteBlock
		{
			public StringID Name;
			public TagInstance SoundEnvironment;
			public float CutoffDistance;
			public float InterpolationSpeed;
			public TagInstance BackgroundSound;
			public TagInstance InsideClusterSound;
			public float CutoffDistance2;
			public ScaleFlagsValue ScaleFlags;
			public float InteriorScale;
			public float PortalScale;
			public float ExteriorScale;
			public float InterpolationSpeed2;

			public enum ScaleFlagsValue : int
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
		}

		[TagStructure(Size = 0x3C)]
		public class Marker
		{
			[TagField(Length = 32)] public string Name;
			public float RotationI;
			public float RotationJ;
			public float RotationK;
			public float RotationW;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
		}

		[TagStructure(Size = 0x10)]
		public class Light
		{
			public TagInstance Light2;
		}

		[TagStructure(Size = 0x2)]
		public class UnknownBlock2
		{
			public short Unknown;
		}

		[TagStructure(Size = 0x24)]
		public class RuntimeDecal
		{
			public short PaletteIndex;
			public sbyte Yaw;
			public sbyte Pitch;
			public float I;
			public float J;
			public float K;
			public float W;
			public float X;
			public float Y;
			public float Z;
			public float Scale;
		}

		[TagStructure(Size = 0x24)]
		public class EnvironmentObjectPaletteBlock
		{
			public TagInstance Definition;
			public TagInstance Model;
			public ObjectTypeValue ObjectType;

			public enum ObjectTypeValue : int
			{
				None,
				Biped,
				Vehicle,
				Weapon = 4,
				Equipment = 8,
				Terminal = 16,
				Projectile = 32,
				Scenery = 64,
				Machine = 128,
				Control = 256,
				SoundScenery = 512,
				Crate = 1024,
				Creature = 2048,
				Giant = 4096,
				EffectScenery = 8192,
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
		}

		[TagStructure(Size = 0x6C)]
		public class EnvironmentObject
		{
			[TagField(Length = 32)] public string Name;
			public float RotationI;
			public float RotationJ;
			public float RotationK;
			public float RotationW;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public float Scale;
			public short PaletteIndex;
			public short Unknown;
			public int UniqueId;
			[TagField(Length = 32)] public string ScenarioObjectName;
			public uint Unknown2;
		}

		[TagStructure(Size = 0x78)]
		public class InstancedGeometryInstance
		{
			public float Scale;
			public float ForwardI;
			public float ForwardJ;
			public float ForwardK;
			public float LeftI;
			public float LeftJ;
			public float LeftK;
			public float UpI;
			public float UpJ;
			public float UpK;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public short MeshIndex;
			public FlagsValue Flags;
			public short UnknownYoIndex;
			public short Unknown;
			public uint Unknown2;
			public float BoundingSphereX;
			public float BoundingSphereY;
			public float BoundingSphereZ;
			public float BoundingSphereRadius1;
			public float BoundingSphereRadius2;
			public StringID Name;
			public short PathfindingPolicy;
			public short LightmappingPolicy;
			public uint Unknown3;
			public List<CollisionDefinition> CollisionDefinitions;
			public short Unknown4;
			public short Unknown5;
			public short Unknown6;
			public short Unknown7;
			public uint Unknown8;

			public enum FlagsValue : ushort
			{
				None,
				Bit0,
				NoProjectileCollision,
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

			[TagStructure(Size = 0x70)]
			public class CollisionDefinition
			{
				public int Unknown;
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
				public int Unknown15;
				public uint Unknown16;
				public sbyte BspIndex;
				public sbyte Unknown17;
				public short InstancedGeometryIndex;
				public float Unknown18;
				public int Unknown19;
				public short Size2;
				public short Count2;
				public int Offset2;
				public int Unknown20;
				public uint Unknown21;
				public uint Unknown22;
				public uint Unknown23;
				public float Unknown24;
			}
		}

		[TagStructure(Size = 0x10)]
		public class Decorator
		{
			public TagInstance Decorator2;
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
		public class UnknownBlock3
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
		public class UnknownBlock4
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
		public class UnknownSoundClustersABlock
		{
			public short BackgroundSoundEnvironmentIndex;
			public short Unknown;
			public List<PortalDesignator> PortalDesignators;
			public List<InteriorClusterIndex> InteriorClusterIndices;

			[TagStructure(Size = 0x2)]
			public class PortalDesignator
			{
				public short PortalDesignator2;
			}

			[TagStructure(Size = 0x2)]
			public class InteriorClusterIndex
			{
				public short InteriorClusterIndex2;
			}
		}

		[TagStructure(Size = 0x1C)]
		public class UnknownSoundClustersBBlock
		{
			public short BackgroundSoundEnvironmentIndex;
			public short Unknown;
			public List<PortalDesignator> PortalDesignators;
			public List<InteriorClusterIndex> InteriorClusterIndices;

			[TagStructure(Size = 0x2)]
			public class PortalDesignator
			{
				public short PortalDesignator2;
			}

			[TagStructure(Size = 0x2)]
			public class InteriorClusterIndex
			{
				public short InteriorClusterIndex2;
			}
		}

		[TagStructure(Size = 0x1C)]
		public class UnknownSoundClustersCBlock
		{
			public short BackgroundSoundEnvironmentIndex;
			public short Unknown;
			public List<PortalDesignator> PortalDesignators;
			public List<InteriorClusterIndex> InteriorClusterIndices;

			[TagStructure(Size = 0x2)]
			public class PortalDesignator
			{
				public short PortalDesignator2;
			}

			[TagStructure(Size = 0x2)]
			public class InteriorClusterIndex
			{
				public short InteriorClusterIndex2;
			}
		}

		[TagStructure(Size = 0x14)]
		public class TransparentPlane
		{
			public short MeshIndex;
			public short PartIndex;
			public float PlaneI;
			public float PlaneJ;
			public float PlaneK;
			public float PlaneD;
		}

		[TagStructure(Size = 0x40)]
		public class CollisionMoppCode
		{
			public int Unknown;
			public short Size;
			public short Count;
			public int Offset;
			public uint Unknown2;
			public float OffsetX;
			public float OffsetY;
			public float OffsetZ;
			public float OffsetScale;
			public uint Unknown3;
			public int DataSize;
			public uint DataCapacity;
			public sbyte Unknown4;
			public sbyte Unknown5;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public List<Datum> Data;
			public uint Unknown8;

			[TagStructure(Size = 0x1)]
			public class Datum
			{
				public byte DataByte;
			}
		}

		[TagStructure(Size = 0x40)]
		public class BreakableSurfaceMoppCode
		{
			public int Unknown;
			public short Size;
			public short Count;
			public int Offset;
			public uint Unknown2;
			public float OffsetX;
			public float OffsetY;
			public float OffsetZ;
			public float OffsetScale;
			public uint Unknown3;
			public int DataSize;
			public uint DataCapacity;
			public sbyte Unknown4;
			public sbyte Unknown5;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public List<Datum> Data;
			public uint Unknown8;

			[TagStructure(Size = 0x1)]
			public class Datum
			{
				public byte DataByte;
			}
		}

		[TagStructure(Size = 0x20)]
		public class BreakableSurfaceKeyTableBlock
		{
			public short InstancedGeometryIndex;
			public sbyte BreakableSurfaceIndex;
			public byte BreakableSurfaceSubIndex;
			public int SeedSurfaceIndex;
			public float X0;
			public float X1;
			public float Y0;
			public float Y1;
			public float Z0;
			public float Z1;
		}

		[TagStructure(Size = 0x4C)]
		public class Mesh2
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
		public class CompressionInfoBlock2
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
		public class UnknownNodeyBlock2
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
		public class UnknownBlock5
		{
			public short Unknown;
			public short Unknown2;
			public byte[] Unknown3;
		}

		[TagStructure(Size = 0x20)]
		public class UnknownMesh2
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
		public class NodeMap2
		{
			public List<UnknownBlock> Unknown;

			[TagStructure(Size = 0x1)]
			public class UnknownBlock
			{
				public byte NodeIndex;
			}
		}

		[TagStructure(Size = 0xC)]
		public class UnknownBlock6
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
		public class UnknownYoBlock2
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public short UnknownIndex;
			public short Unknown4;
		}

		[TagStructure(Size = 0x14)]
		public class LeafSystem
		{
			public short Unknown;
			public short Unknown2;
			public TagInstance LeafSystem2;
		}
	}
}
