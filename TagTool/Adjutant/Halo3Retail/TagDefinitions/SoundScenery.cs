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
	[TagStructure(Class = "ssce", Size = 0x108)]
	public class SoundScenery
	{
		public ObjectTypeValue ObjectType;
		public FlagsValue Flags;
		public float BoundingRadius;
		public float BoundingOffsetX;
		public float BoundingOffsetY;
		public float BoundingOffsetZ;
		public float AccelerationScale;
		public LightmapShadowModeSizeValue LightmapShadowModeSize;
		public SweetenerSizeValue SweetenerSize;
		public WaterDensityValue WaterDensity;
		public int Unknown;
		public float DynamicLightSphereRadius;
		public float DynamicLightSphereOffsetX;
		public float DynamicLightSphereOffsetY;
		public float DynamicLightSphereOffsetZ;
		public StringID DefaultModelVariant;
		public TagInstance Model;
		public TagInstance CrateObject;
		public TagInstance CollisionDamage;
		public List<EarlyMoverProperty> EarlyMoverProperties;
		public TagInstance CreationEffect;
		public TagInstance MaterialEffects;
		public TagInstance MeleeImpact;
		public List<AiProperty> AiProperties;
		public List<Function> Functions;
		public short HudTextMessageIndex;
		public short Unknown2;
		public List<Attachment> Attachments;
		public List<Widget> Widgets;
		public List<ChangeColor> ChangeColors;
		public List<PredictedResource> PredictedResources;
		public List<MultiplayerObjectProperty> MultiplayerObjectProperties;
		public float DistanceMin;
		public float DistanceMax;
		public Angle ConeAngleMin;
		public Angle ConeAngleMax;

		public enum ObjectTypeValue : short
		{
			Biped,
			Vehicle,
			Weapon,
			Equipment,
			Terminal,
			Projectile,
			Scenery,
			Machine,
			Control,
			SoundScenery,
			Crate,
			Creature,
			Giant,
			EffectScenery,
		}

		public enum FlagsValue : ushort
		{
			None,
			DoesNotCastShadow,
			SearchCardinalDirectionLightmaps,
			Bit2 = 4,
			NotAPathfindingObstacle = 8,
			ExtensionOfParent = 16,
			DoesNotCauseCollisionDamage = 32,
			EarlyMover = 64,
			EarlyMoverLocalizedPhysics = 128,
			UseStaticMassiveLightmapSample = 256,
			ObjectScalesAttachments = 512,
			InheritsPlayerSAppearance = 1024,
			DeadBipedsCanTLocalize = 2048,
			AttachToClustersByDynamicSphere = 4096,
			EffectsCreatedByThisObjectDoNotSpawnObjectsInMultiplayer = 8192,
			Bit14 = 16384,
			Bit15 = 32768,
		}

		public enum LightmapShadowModeSizeValue : short
		{
			Default,
			Never,
			Always,
			Unknown,
		}

		public enum SweetenerSizeValue : sbyte
		{
			Small,
			Medium,
			Large,
		}

		public enum WaterDensityValue : sbyte
		{
			Default,
			Least,
			Some,
			Equal,
			More,
			MoreStill,
			LotsMore,
		}

		[TagStructure(Size = 0x28)]
		public class EarlyMoverProperty
		{
			public StringID Name;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
			public uint Unknown9;
		}

		[TagStructure(Size = 0x10)]
		public class AiProperty
		{
			public FlagsValue Flags;
			public StringID AiTypeName;
			public uint Unknown;
			public SizeValue Size;
			public LeapJumpSpeedValue LeapJumpSpeed;

			public enum FlagsValue : int
			{
				None,
				DestroyableCover,
				PathfindingIgnoreWhenDead,
				DynamicCover = 4,
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

			public enum SizeValue : short
			{
				Default,
				Tiny,
				Small,
				Medium,
				Large,
				Huge,
				Immobile,
			}

			public enum LeapJumpSpeedValue : short
			{
				None,
				Down,
				Step,
				Crouch,
				Stand,
				Storey,
				Tower,
				Infinite,
			}
		}

		[TagStructure(Size = 0x2C)]
		public class Function
		{
			public FlagsValue Flags;
			public StringID ImportName;
			public StringID ExportName;
			public StringID TurnOffWith;
			public float MinimumValue;
			public byte[] DefaultFunction;
			public StringID ScaleBy;

			public enum FlagsValue : int
			{
				None,
				Invert,
				MappingDoesNotControlsActive,
				AlwaysActive = 4,
				RandomTimeOffset = 8,
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

		[TagStructure(Size = 0x20)]
		public class Attachment
		{
			public TagInstance Attachment2;
			public StringID Marker;
			public ChangeColorValue ChangeColor;
			public short Unknown;
			public StringID PrimaryScale;
			public StringID SecondaryScale;

			public enum ChangeColorValue : short
			{
				None,
				Primary,
				Secondary,
				Tertiary,
				Quaternary,
			}
		}

		[TagStructure(Size = 0x10)]
		public class Widget
		{
			public TagInstance Type;
		}

		[TagStructure(Size = 0x18)]
		public class ChangeColor
		{
			public List<InitialPermutation> InitialPermutations;
			public List<Function> Functions;

			[TagStructure(Size = 0x20)]
			public class InitialPermutation
			{
				public uint Weight;
				public float ColorLowerBoundR;
				public float ColorLowerBoundG;
				public float ColorLowerBoundB;
				public float ColorUpperBoundR;
				public float ColorUpperBoundG;
				public float ColorUpperBoundB;
				public StringID VariantName;
			}

			[TagStructure(Size = 0x20)]
			public class Function
			{
				public ScaleFlagsValue ScaleFlags;
				public float ColorLowerBoundR;
				public float ColorLowerBoundG;
				public float ColorLowerBoundB;
				public float ColorUpperBoundR;
				public float ColorUpperBoundG;
				public float ColorUpperBoundB;
				public StringID DarkenBy;
				public StringID ScaleBy;

				public enum ScaleFlagsValue : int
				{
					None,
					BlendInHsv,
					MoreColors,
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
		}

		[TagStructure(Size = 0x8)]
		public class PredictedResource
		{
			public short Type;
			public short ResourceIndex;
			[TagField(Flags = TagFieldFlags.Short)] public TagInstance TagIndex;
		}

		[TagStructure(Size = 0xC4)]
		public class MultiplayerObjectProperty
		{
			public EngineFlagsValue EngineFlags;
			public ObjectTypeValue ObjectType;
			public TeleporterFlagsValue TeleporterFlags;
			public FlagsValue Flags;
			public ShapeValue Shape;
			public SpawnTimerModeValue SpawnTimerMode;
			public short SpawnTime;
			public short AbandonTime;
			public float RadiusWidth;
			public float Length;
			public float Top;
			public float Bottom;
			public float Unknown;
			public float Unknown2;
			public float Unknown3;
			public int Unknown4;
			public int Unknown5;
			public TagInstance ChildObject;
			public int Unknown6;
			public TagInstance ShapeShader;
			public TagInstance UnknownShader;
			public TagInstance Unknown7;
			public TagInstance Unknown8;
			public TagInstance Unknown9;
			public TagInstance Unknown10;
			public TagInstance Unknown11;
			public TagInstance Unknown12;

			public enum EngineFlagsValue : ushort
			{
				None,
				CaptureTheFlag,
				Slayer,
				Oddball = 4,
				KingOfTheHill = 8,
				Juggernaut = 16,
				Territories = 32,
				Assault = 64,
				Vip = 128,
				Infection = 256,
				Bit9 = 512,
			}

			public enum ObjectTypeValue : sbyte
			{
				Ordinary,
				Weapon,
				Grenade,
				Projectile,
				Powerup,
				Equipment,
				LightLandVehicle,
				HeavyLandVehicle,
				FlyingVehicle,
				Teleporter2way,
				TeleporterSender,
				TeleporterReceiver,
				PlayerSpawnLocation,
				PlayerRespawnZone,
				HoldSpawnObjective,
				CaptureSpawnObjective,
				HoldDestinationObjective,
				CaptureDestinationObjective,
				HillObjective,
				InfectionHavenObjective,
				TerritoryObjective,
				VipBoundaryObjective,
				VipDestinationObjective,
				JuggernautDestinationObjective,
			}

			public enum TeleporterFlagsValue : byte
			{
				None,
				DisallowsPlayers,
				AllowsLandVehicles,
				AllowsHeavyVehicles = 4,
				AllowsFlyingVehicles = 8,
				AllowsProjectiles = 16,
			}

			public enum FlagsValue : ushort
			{
				None,
				EditorOnly,
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

			public enum ShapeValue : sbyte
			{
				None,
				Sphere,
				Cylinder,
				Box,
			}

			public enum SpawnTimerModeValue : sbyte
			{
				OnDeath,
				OnDisturbance,
			}
		}
	}
}
