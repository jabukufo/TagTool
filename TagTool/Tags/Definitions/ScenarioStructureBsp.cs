using System.Collections.Generic;
using TagTool.Common;
using TagTool.Cache;
using TagTool.Geometry;
using TagTool.Serialization;

namespace TagTool.Tags.Definitions
{
    [TagStructure(Name = "scenario_structure_bsp", Class = "sbsp", Size = 0x3AC, MaxVersion = CacheVersion.HaloOnline106708)]
    [TagStructure(Name = "scenario_structure_bsp", Class = "sbsp", Size = 0x3A8, MaxVersion = CacheVersion.HaloOnline235640)]
    [TagStructure(Name = "scenario_structure_bsp", Class = "sbsp", Size = 0x3AC, MaxVersion = CacheVersion.HaloOnline449175)]
    [TagStructure(Name = "scenario_structure_bsp", Class = "sbsp", Size = 0x3B8, MinVersion = CacheVersion.HaloOnline498295)]
    public class ScenarioStructureBsp
    {
        public int BspChecksum;
        public int Unknown;
        public uint Unknown2;
        public uint Unknown3;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public uint Unknown4;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public uint Unknown5;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public uint Unknown6;
        public uint Unknown7;
        public uint Unknown8;
        public uint Unknown9;
        public List<CollisionMaterial> CollisionMaterials;
        public List<byte> UnknownRaw3rd;
        public Range<float> WorldBoundsX;
        public Range<float> WorldBoundsY;
        public Range<float> WorldBoundsZ;
        public uint Unknown10;
        public uint Unknown11;
        public uint Unknown12;
        public uint Unknown13;
        public uint Unknown14;
        public uint Unknown15;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public uint Unknown16;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public uint Unknown17;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public uint Unknown18;
        public List<ClusterPortal> ClusterPortals;
        public List<UnknownBlock> Unknown19;
        public List<FogBlock> Fog;
        public List<CameraEffect> CameraEffects;
        public uint Unknown20;
        public uint Unknown21;
        public uint Unknown22;
        [MinVersion(CacheVersion.HaloOnline498295)]
        public uint Unknown95;
        [MinVersion(CacheVersion.HaloOnline498295)]
        public uint Unknown96;
        [MinVersion(CacheVersion.HaloOnline498295)]
        public uint Unknown97;
        public List<DetailObject> DetailObjects;
        public List<Cluster> Clusters;
        public List<RenderMaterial> Materials;
        public List<short> SkyOwnerCluster;
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
        public List<BackgroundSoundEnvironmentPaletteBlock> BackgroundSoundEnvironmentPalette;
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
        public List<Marker> Markers;
        public List<Light> Lights;
        public List<UnknownBlock2> Unknown46;
        public List<RuntimeDecal> RuntimeDecals;
        public List<EnvironmentObjectPaletteBlock> EnvironmentObjectPalette;
        public List<EnvironmentObject> EnvironmentObjects;
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
        public List<InstancedGeometryInstance> InstancedGeometryInstances;
        public List<Decorator> Decorators;
        public GeometryReference Geometry;
        public List<UnknownSoundClusterBlock> UnknownSoundClustersA;
        public List<UnknownSoundClusterBlock> UnknownSoundClustersB;
        public List<UnknownSoundClusterBlock> UnknownSoundClustersC;
        public List<TransparentPlane> TransparentPlanes;
        public uint Unknown66;
        public uint Unknown67;
        public uint Unknown68;
        public List<CollisionMoppCode> CollisionMoppCodes;
        public uint Unknown69;
        public Range<float> CollisionWorldBoundsX;
        public Range<float> CollisionWorldBoundsY;
        public Range<float> CollisionWorldBoundsZ;
        public List<BreakableSurfaceMoppCode> BreakableSurfaceMoppCodes;
        public List<BreakableSurfaceKeyTableBlock> BreakableSurfaceKeyTable;
        public uint Unknown70;
        public uint Unknown71;
        public uint Unknown72;
        public uint Unknown73;
        public uint Unknown74;
        public uint Unknown75;
        public GeometryReference Geometry2;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public List<LeafSystem> LeafSystems;
        public uint Unknown88;
        public uint Unknown89;
        public uint Unknown90;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public ResourceReference CollisionBspResource;
        public int UselessPading;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public ResourceReference Resource4;
        public int UselessPadding3;
        public int Unknown91;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public uint Unknown92;
        [MinVersion(CacheVersion.HaloOnline106708)]
        public uint Unknown93;
        [MinVersion(CacheVersion.HaloOnline106708)]
        [MaxVersion(CacheVersion.HaloOnline106708)]
        public uint Unknown94;
        [MinVersion(CacheVersion.HaloOnline301003)]
        [MaxVersion(CacheVersion.HaloOnline700123)]
        public uint Unknown98;

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
                public RealPoint3d Centroid;
            }
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

        [TagStructure(Size = 0x28)]
        public class ClusterPortal
        {
            public short BackCluster;
            public short FrontCluster;
            public int PlaneIndex;
            public RealPoint3d Centroid;
            public float BoundingRadius;
            public uint Flags;
            public List<RealPoint3d> Vertices;
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
            public StringId Name;
            public short Unknown;
            public short Unknown2;
        }

        [TagStructure(Size = 0x30)]
        public class CameraEffect
        {
            public StringId Name;
            public TagInstance Effect;
            public sbyte Unknown;
            public sbyte Unknown2;
            public sbyte Unknown3;
            public sbyte Unknown4;
            public uint Unknown5;
            public uint Unknown6;
            public uint Unknown7;
            public uint Unknown8;
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
            [MinVersion(CacheVersion.HaloOnline106708)] public List<UnknownBlock> Unknown8;
            public uint Unknown9;
            public uint Unknown10;
            public uint Unknown11;

            [TagStructure(Size = 0x20)]
            public class UnknownBlock
            {
                public List<UnknownBlock2> Unknown1;
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

        [TagStructure(Size = 0xDC, MaxVersion = CacheVersion.HaloOnline449175)]
        [TagStructure(Size = 0xE0, MinVersion = CacheVersion.HaloOnline498295)]
        public class Cluster
        {
            public Range<float> BoundsX;
            public Range<float> BoundsY;
            public Range<float> BoundsZ;
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
            [MinVersion(CacheVersion.HaloOnline498295)] public short Unknown26;
            [MinVersion(CacheVersion.HaloOnline498295)] public short Unknown27;
            public short RuntimeDecalStartIndex;
            public short RuntimeDecalEntryCount;
            public short Flags;
            public uint Unknown8;
            public uint Unknown9;
            public uint Unknown10;
            public List<short> Portals;
            public int Unknown11;
            public short Size;
            public short Count;
            public int Address;
            public int Unknown12;
            public uint Unknown13;
            public uint Unknown14;
            public TagInstance Bsp;
            public int ClusterIndex;
            public int Unknown15;
            public short Size2;
            public short Count2;
            public int Address2;
            public int Unknown16;
            public uint Unknown17;
            public uint Unknown18;
            public uint Unknown19;
            public List<CollisionMoppCode> CollisionMoppCodes;
            public short MeshIndex;
            public short Unknown20;
            public List<byte> Seams;
            public List<DecoratorGrid> DecoratorGrids;
            public uint Unknown21;
            public uint Unknown22;
            public uint Unknown23;
            public List<UnknownBlock> Unknown24;
            public List<UnknownBlock2> Unknown25;
            
            [TagStructure(Size = 0x34)]
            public class DecoratorGrid
            {
                public short Amount;
                public sbyte DecoratorIndex;
                public sbyte DecoratorIndexScattering;
                public int Unknown;
                public RealPoint3d Position;
                public float Radius;
                public RealPoint3d GridSize;
                public RealPoint3d BoundingSphereOffset;
                public uint Unknown2;
            }
            
            [TagStructure(Size = 0x4)]
            public class UnknownBlock
            {
                public short Unknown;
                public short Unknown2;
            }

            [TagStructure(Size = 0x10, Align = 0x10)]
            public class UnknownBlock2
            {
                public uint Unknown;
                public uint Unknown2;
                public uint Unknown3;
                public short Unknown4;
                public short Unknown5;
            }
        }

        [TagStructure(Size = 0x58)]
        public class BackgroundSoundEnvironmentPaletteBlock
        {
            public StringId Name;
            public TagInstance SoundEnvironment;
            public uint Unknown;
            public float CutoffDistance;
            public float InterpolationSpeed;
            public TagInstance BackgroundSound;
            public TagInstance InsideClusterSound;
            public float CutoffDistance2;
            public uint ScaleFlags;
            public float InteriorScale;
            public float PortalScale;
            public float ExteriorScale;
            public float InterpolationSpeed2;
        }

        [TagStructure(Size = 0x3C)]
        public class Marker
        {
            [TagField(Length = 32)] public string Name;
            public RealQuaternion Rotation;
            public RealPoint3d Position;
        }

        [TagStructure(Size = 0x10)]
        public class Light
        {
            public TagInstance Reference;
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
            public RealQuaternion Rotation;
            public RealPoint3d Position;
            public float Scale;
        }

        [TagStructure(Size = 0x24)]
        public class EnvironmentObjectPaletteBlock
        {
            public TagInstance Definition;
            public TagInstance Model;
            public uint ObjectType;
        }

        [TagStructure(Size = 0x6C)]
        public class EnvironmentObject
        {
            [TagField(Length = 32)] public string Name;
            public RealQuaternion Rotation;
            public RealPoint3d Position;
            public float Scale;
            public short PaletteIndex;
            public short Unknown;
            public int UniqueId;
            [TagField(Length = 32)] public string ScenarioObjectName;
            public uint Unknown2;
        }
        
        [TagStructure(Size = 0x74)]
        public class InstancedGeometryInstance
        {
            public float Scale;
            public Matrix4x3 Matrix;
            public short MeshIndex;
            public ushort Flags;
            public short UnknownYoIndex;
            public short Unknown;
            public uint Unknown2;
            public RealPoint3d BoundingSphereOffset;
            public float BoundingSphereRadius1;
            public float BoundingSphereRadius2;
            public StringId Name;
            public short PathfindingPolicy;
            public short LightmappingPolicy;
            public uint Unknown3;
            public List<CollisionDefinition> CollisionDefinitions;
            public short Unknown4;
            public short Unknown5;
            public short Unknown6;
            public short Unknown7;
            
            [TagStructure(Size = 0x80)]
            public class CollisionDefinition
            {
                public int Unknown;
                public short Size;
                public short Count;
                public int Address;
                public int Unknown2;
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
                public int Unknown15;
                public uint Unknown16;
                [MinVersion(CacheVersion.HaloOnline106708)]
                public uint UnknownPossiblyNewValue;
                public sbyte BspIndex;
                public sbyte Unknown17;
                public short InstancedGeometryIndex;
                public uint Unknown18;
                [MinVersion(CacheVersion.HaloOnline106708)]
                public uint Unknown19;
                [MinVersion(CacheVersion.HaloOnline106708)]
                public uint Unknown20;
                [MinVersion(CacheVersion.HaloOnline106708)]
                public uint Unknown21;
                public uint Unknown22;
                public short Size2;
                public short Count2;
                public int Address2;
                public int Unknown23;
                public uint Unknown24;
                public uint Unknown25;
                public uint Unknown26;
                public uint Unknown27;
            }
        }

        [TagStructure(Size = 0x10)]
        public class Decorator
        {
            public TagInstance Reference;
        }

        [TagStructure(Size = 0x1C)]
        public class UnknownSoundClusterBlock
        {
            public short BackgroundSoundEnvironmentIndex;
            public short Unknown;
            public List<short> PortalDesignators;
            public List<short> InteriorClusterIndices;
        }
        
        [TagStructure(Size = 0x14)]
        public class TransparentPlane
        {
            public short MeshIndex;
            public short PartIndex;
            public RealVector4d Plane;
        }

        [TagStructure(Size = 0x40, Align = 0x10)]
        public class CollisionMoppCode
        {
            public int Unknown;
            public short Size;
            public short Count;
            public int Address;
            public uint Unknown2;
            public RealPoint3d Offset;
            public float OffsetScale;
            public uint Unknown3;
            public int DataSize;
            public uint DataCapacity;
            public sbyte Unknown4;
            public sbyte Unknown5;
            public sbyte Unknown6;
            public sbyte Unknown7;
            public List<byte> Data;
            public uint Unknown8;
        }

        [TagStructure(Size = 0x40, Align = 0x10)]
        public class BreakableSurfaceMoppCode
        {
            public int Unknown;
            public short Size;
            public short Count;
            public int Address;
            public uint Unknown2;
            public RealPoint3d Offset;
            public float OffsetScale;
            public uint Unknown3;
            public int DataSize;
            public uint DataCapacity;
            public sbyte Unknown4;
            public sbyte Unknown5;
            public sbyte Unknown6;
            public sbyte Unknown7;
            public List<byte> Data;
            public uint Unknown8;
        }

        [TagStructure(Size = 0x20)]
        public class BreakableSurfaceKeyTableBlock
        {
            public short InstancedGeometryIndex;
            public sbyte BreakableSurfaceIndex;
            public byte BreakableSurfaceSubIndex;
            public int SeedSurfaceIndex;
            public Range<float> X;
            public Range<float> Y;
            public Range<float> Z;
        }

        [TagStructure(Size = 0x20)]
        public class LeafSystem
        {
            public short Unknown;
            public short Unknown2;
            public TagInstance Reference;
            public uint Unknown3;
            public uint Unknown4;
            public uint Unknown5;
        }
    }
}
