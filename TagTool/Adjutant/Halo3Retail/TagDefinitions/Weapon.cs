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
	[TagStructure(Class = "weap", Size = 0x500)]
	public class Weapon
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
		public FlagsValue2 Flags2;
		public short OldMessageIndex;
		public short SortOrder;
		public float OldMultiplayerOnGroundScale;
		public float OldCampaignOnGroundScale;
		public StringID PickupMessage;
		public StringID SwapMessage;
		public StringID PickupOrDualWieldMessage;
		public StringID SwapOrDualWieldMessage;
		public StringID PickedUpMessage;
		public StringID SwitchToMessage;
		public StringID SwitchToFromAiMessage;
		public StringID AllWeaponsEmptyMessage;
		public TagInstance CollisionSound;
		public List<PredictedBitmap> PredictedBitmaps;
		public TagInstance DetonationDamageEffect;
		public float DetonationDelayMin;
		public float DetonationDelayMax;
		public TagInstance DetonatingEffect;
		public TagInstance DetonationEffect;
		public float CampaignGroundScale;
		public float MultiplayerGroundScale;
		public float SmallHoldScale;
		public float SmallHolsterScale;
		public float MediumHoldScale;
		public float MediumHolsterScale;
		public float LargeHoldScale;
		public float LargeHolsterScale;
		public float HugeHoldScale;
		public float HugeHolsterScale;
		public float GroundedFrictionLength;
		public float GroundedFrictionUnknown;
		public FlagsValue3 Flags3;
		public MoreFlagsValue MoreFlags;
		public StringID Unknown3;
		public SecondaryTriggerModeValue SecondaryTriggerMode;
		public short MaximumAlternateShotsLoaded;
		public float TurnOnTime;
		public float ReadyTime;
		public TagInstance ReadyEffect;
		public TagInstance ReadyDamageEffect;
		public float HeatRecoveryThreshold;
		public float OverheatedThreshold;
		public float HeatDetonationThreshold;
		public float HeatDetonationFraction;
		public float HeatLossPerSecond;
		public float HeatIllumination;
		public float OverheatedHeatLossPerSecond;
		public TagInstance Overheated;
		public TagInstance OverheatedDamageEffect;
		public TagInstance Detonation;
		public TagInstance DetonationDamageEffect2;
		public TagInstance PlayerMeleeDamage;
		public TagInstance PlayerMeleeResponse;
		public Angle DamagePyramidAnglesY;
		public Angle DamagePyramidAnglesP;
		public float DamagePyramidDepth;
		public TagInstance _1stHitDamage;
		public TagInstance _1stHitResponse;
		public TagInstance _2ndHitDamage;
		public TagInstance _2ndHitResponse;
		public TagInstance _3rdHitDamage;
		public TagInstance _3rdHitResponse;
		public TagInstance LungeMeleeDamage;
		public TagInstance LungeMeleeResponse;
		public TagInstance GunGunClangDamage;
		public TagInstance GunGunClangResponse;
		public TagInstance GunSwordClangDamage;
		public TagInstance GunSwordClangResponse;
		public TagInstance ClashEffect;
		public MeleeDamageReportingTypeValue MeleeDamageReportingType;
		public sbyte Unknown4;
		public short MagnificationLevels;
		public float MagnificationRangeMin;
		public float MagnificationRangeMax;
		public Angle AutoaimAngle;
		public float AutoaimRangeLong;
		public float AutoaimRangeShort;
		public Angle MagnetismAngle;
		public float MagnetismRangeLong;
		public float MagnetismRangeShort;
		public Angle DeviationAngle;
		public uint Unknown5;
		public uint Unknown6;
		public uint Unknown7;
		public uint Unknown8;
		public uint Unknown9;
		public MovementPenalizedValue MovementPenalized;
		public short Unknown10;
		public float ForwardsMovementPenalty;
		public float SidewaysMovementPenalty;
		public float AiScariness;
		public float WeaponPowerOnTime;
		public float WeaponPowerOffTime;
		public TagInstance WeaponPowerOnEffect;
		public TagInstance WeaponPowerOffEffect;
		public float AgeHeatRecoveryPenalty;
		public float AgeRateOfFirePenalty;
		public float AgeMisfireStart;
		public float AgeMisfireChance;
		public TagInstance PickupSound;
		public TagInstance ZoomInSound;
		public TagInstance ZoomOutSound;
		public float ActiveCamoDing;
		public float ActiveCamoRegrowthRate;
		public StringID HandleNode;
		public StringID WeaponClass;
		public StringID WeaponName;
		public MultiplayerWeaponTypeValue MultiplayerWeaponType;
		public WeaponTypeValue WeaponType;
		public TrackingTypeValue TrackingType;
		public short Unknown11;
		public uint Unknown12;
		public uint Unknown13;
		public uint Unknown14;
		public uint Unknown15;
		public List<FirstPersonBlock> FirstPerson;
		public TagInstance HudInterface;
		public List<PredictedResource2> PredictedResources2;
		public List<Magazine> Magazines;
		public List<NewTrigger> NewTriggers;
		public List<Barrel> Barrels;
		public float Unknown16;
		public float Unknown17;
		public float MaximumMovementAcceleration;
		public float MaximumMovementVelocity;
		public float MaximumTurningAcceleration;
		public float MaximumTurningVelocity;
		public TagInstance DeployedVehicle;
		public TagInstance DeployedWeapon;
		public TagInstance AgeModel;
		public TagInstance AgeWeapon;
		public TagInstance AgedEffect;
		public float HammerAgePerUseMp;
		public float HammerAgePerUseSp;
		public float FirstPersonWeaponOffsetI;
		public float FirstPersonWeaponOffsetJ;
		public float FirstPersonWeaponOffsetK;
		public float FirstPersonScopeSizeI;
		public float FirstPersonScopeSizeJ;
		public float ThirdPersonPitchBoundsMin;
		public float ThirdPersonPitchBoundsMax;
		public float ZoomTransitionTime;
		public float MeleeWeaponDelay;
		public StringID WeaponHolsterMarker;

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

		public enum FlagsValue2 : int
		{
			None,
			AlwaysMaintainsZUp,
			DestroyedByExplosions,
			UnaffectedByGravity = 4,
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

		[TagStructure(Size = 0x10)]
		public class PredictedBitmap
		{
			public TagInstance Bitmap;
		}

		public enum FlagsValue3 : int
		{
			None,
			VerticalHeatDisplay,
			MutuallyExclusiveTriggers,
			AttacksAutomaticallyOnBump = 4,
			MustBeReadied = 8,
			DoesnTCountTowardsMaximum = 16,
			AimAssistsOnlyWhenZoomed = 32,
			PreventsGrenadeThrowing = 64,
			MustBePickedUp = 128,
			HoldsTriggersWhenDropped = 256,
			PreventsMeleeAttack = 512,
			DetonatesWhenDropped = 1024,
			CannotFireAtMaximumAge = 2048,
			SecondaryTriggerOverridesGrenades = 4096,
			DoesNotDepowerActiveCamoInMultiplayer = 8192,
			EnablesIntegratedNightVision = 16384,
			AisUseWeaponMeleeDamage = 32768,
			ForcesNoBinoculars = 65536,
			LoopFpFiringAnimation = 131072,
			PreventsSprinting = 262144,
			CannotFireWhileBoosting = 524288,
			PreventsDriving = 1048576,
			ThirdPersonCamera = 2097152,
			CanBeDualWielded = 4194304,
			CanOnlyBeDualWielded = 8388608,
			MeleeOnly = 16777216,
			CanTFireIfParentDead = 33554432,
			WeaponAgesWithEachKill = 67108864,
			WeaponUsesOldDualFireErrorCode = 134217728,
			PrimaryTriggerMeleeAttacks = 268435456,
			CannotBeUsedByPlayer = 536870912,
			Bit30 = 1073741824,
			Bit31 = -2147483648,
		}

		public enum MoreFlagsValue : int
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

		public enum SecondaryTriggerModeValue : short
		{
			Normal,
			SlavedToPrimary,
			InhibitsPrimary,
			LoadsAlternateAmmunition,
			LoadsMultiplePrimaryAmmunition,
		}

		public enum MeleeDamageReportingTypeValue : sbyte
		{
			Guardians,
			FallingDamage,
			Collision,
			Melee,
			Explosion,
			Magnum,
			PlasmaPistol,
			Needler,
			Mauler,
			Smg,
			PlasmaRifle,
			BattleRifle,
			Carbine,
			Shotgun,
			SniperRifle,
			BeamRifle,
			AssaultRifle,
			Spiker,
			FuelRodCannon,
			MissilePod,
			RocketLauncher,
			SpartanLaser,
			BruteShot,
			Flamethrower,
			SentinelGun,
			EnergySword,
			GravityHammer,
			FragGrenade,
			PlasmaGrenade,
			SpikeGrenade,
			FirebombGrenade,
			Flag,
			Bomb,
			BombExplosion,
			Ball,
			MachinegunTurret,
			PlasmaCannon,
			PlasmaMortar,
			PlasmaTurret,
			Banshee,
			Ghost,
			Mongoose,
			Scorpion,
			ScorpionGunner,
			Spectre,
			SpectreGunner,
			Warthog,
			WarthogGunner,
			WarthogGaussTurret,
			Wraith,
			WraithGunner,
			Tank,
			Chopper,
			Hornet,
			Mantis,
			Prowler,
			SentinelBeam,
			SentinelRpg,
			Teleporter,
			Tripmine,
			ElephantTurret,
		}

		public enum MovementPenalizedValue : short
		{
			Always,
			WhenZoomed,
			WhenZoomedOrReloading,
		}

		public enum MultiplayerWeaponTypeValue : short
		{
			None,
			CtfFlag,
			OddballBall,
			HeadhunterHead,
			JuggernautPowerup,
		}

		public enum WeaponTypeValue : short
		{
			Undefined,
			Shotgun,
			Needler,
			PlasmaPistol,
			PlasmaRifle,
			RocketLauncher,
			EnergySword,
			SpartanLaser,
		}

		public enum TrackingTypeValue : short
		{
			NoTracking,
			HumanTracking,
			PlasmaTracking,
		}

		[TagStructure(Size = 0x20)]
		public class FirstPersonBlock
		{
			public TagInstance FirstPersonModel;
			public TagInstance FirstPersonAnimations;
		}

		[TagStructure(Size = 0x8)]
		public class PredictedResource2
		{
			public short Type;
			public short ResourceIndex;
			[TagField(Flags = TagFieldFlags.Short)] public TagInstance TagIndex;
		}

		[TagStructure(Size = 0x80)]
		public class Magazine
		{
			public FlagsValue Flags;
			public short RoundsRecharged;
			public short RoundsTotalInitial;
			public short RoundsTotalMaximum;
			public short RoundsTotalLoadedMaximum;
			public short MaximumRoundsHeld;
			public short Unknown;
			public float ReloadTime;
			public short RoundsReloaded;
			public short Unknown2;
			public float ChamberTime;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
			public TagInstance ReloadingEffect;
			public TagInstance ReloadingDamageEffect;
			public TagInstance ChamberingEffect;
			public TagInstance ChamberingDamageEffect;
			public List<MagazineEquipmentBlock> MagazineEquipment;

			public enum FlagsValue : int
			{
				None,
				WastesRoundsWhenReloaded,
				EveryRoundMustBeChambered,
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

			[TagStructure(Size = 0x14)]
			public class MagazineEquipmentBlock
			{
				public short Rounds0ForMax;
				public short Unknown;
				public TagInstance Equipment;
			}
		}

		[TagStructure(Size = 0x90)]
		public class NewTrigger
		{
			public FlagsValue Flags;
			public ButtonUsedValue ButtonUsed;
			public BehaviorValue Behavior;
			public short PrimaryBarrel;
			public short SecondaryBarrel;
			public PredictionValue Prediction;
			public short Unknown;
			public float AutofireTime;
			public float AutofireThrow;
			public SecondaryActionValue SecondaryAction;
			public PrimaryActionValue PrimaryAction;
			public float ChargingTime;
			public float ChargedTime;
			public OverchargeActionValue OverchargeAction;
			public ChargeFlagsValue ChargeFlags;
			public float ChargedIllumination;
			public float SpewTime;
			public TagInstance ChargingEffect;
			public TagInstance ChargingDamageEffect;
			public TagInstance ChargingResponse;
			public float ChargingAgeDegeneration;
			public TagInstance DischargingEffect;
			public TagInstance DischargingDamageEffect;
			public float TargetTrackingDecayTime;
			public uint Unknown2;
			public float Unknown3;

			public enum FlagsValue : int
			{
				None,
				AutofireSingleActionOnly,
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

			public enum ButtonUsedValue : short
			{
				RightTrigger,
				LeftTrigger,
				MeleeAttack,
				AutomatedFire,
				RightBumper,
			}

			public enum BehaviorValue : short
			{
				Spew,
				Latch,
				LatchAutofire,
				Charge,
				LatchZoom,
				LatchRocketlauncher,
				SpewCharge,
			}

			public enum PredictionValue : short
			{
				None,
				Spew,
				Charge,
			}

			public enum SecondaryActionValue : short
			{
				Fire,
				Charge,
				Track,
				FireOther,
			}

			public enum PrimaryActionValue : short
			{
				Fire,
				Charge,
				Track,
				FireOther,
			}

			public enum OverchargeActionValue : short
			{
				None,
				Explode,
				Discharge,
			}

			public enum ChargeFlagsValue : ushort
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

		[TagStructure(Size = 0x134)]
		public class Barrel
		{
			public FlagsValue Flags;
			public float RoundsPerSecondMin;
			public float RoundsPerSecondMax;
			public float AccelerationTime;
			public float DecelerationTime;
			public float BarrelSpinScale;
			public float BlurredRateOfFire;
			public short ShotsPerFireMin;
			public short ShotsPerFireMax;
			public float FireRecoveryTime;
			public float SoftRecoveryFraction;
			public short Magazine;
			public short RoundsPerShot;
			public short MinimumRoundsLoaded;
			public short RoundsBetweenTracers;
			public StringID OptionalBarrelMarkerName;
			public PredictionTypeValue PredictionType;
			public FiringNoiseValue FiringNoise;
			public float AccelerationTime2;
			public float DecelerationTime2;
			public float DamageErrorMin;
			public float DamageErrorMax;
			public Angle BaseTurningSpeed;
			public Angle DynamicTurningSpeedMin;
			public Angle DynamicTurningSpeedMax;
			public float AccelerationTime3;
			public float DecelerationTime3;
			public float Unknown;
			public float Unknown2;
			public Angle MinimumError;
			public Angle ErrorAngleMin;
			public Angle ErrorAngleMax;
			public float DualWieldDamageScale;
			public DistributionFunctionValue DistributionFunction;
			public short ProjectilesPerShot;
			public Angle DistributionAngle;
			public Angle MinimumError2;
			public Angle ErrorAngleMin2;
			public Angle ErrorAngleMax2;
			public List<FirstPersonOffset> FirstPersonOffsets;
			public DamageReportingTypeValue DamageReportingType;
			public sbyte Unknown3;
			public short Unknown4;
			public TagInstance InitialProjectile;
			public TagInstance TrailingProjectile;
			public TagInstance DamageEffect;
			public TagInstance CrateProjectile;
			public float CrateProjectileSpeed;
			public float EjectionPortRecoveryTime;
			public float IlluminationRecoveryTime;
			public float HeatGeneratedPerRound;
			public float AgeGeneratedPerRoundMp;
			public float AgeGeneratedPerRoundSp;
			public float OverloadTime;
			public Angle AngleChangePerShotMin;
			public Angle AngleChangePerShotMax;
			public uint AngleChangeAccelerationTime;
			public uint AngleChangeDecelerationTime;
			public AngleChangeFunctionValue AngleChangeFunction;
			public short Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float FiringEffectDecelerationTime;
			public float Unknown8;
			public float RateOfFireAccelerationTime;
			public float RateOfFireDecelerationTime;
			public float Unknown9;
			public float Unknown10;
			public List<FiringEffect> FiringEffects;

			public enum FlagsValue : int
			{
				None,
				TracksFiredProjectile,
				RandomFiringEffects,
				CanFireWithPartialAmmo = 4,
				ProjectilesUseWeaponOrigin = 8,
				EjectsDuringChamber = 16,
				UseErrorWhenUnzoomed = 32,
				ProjectileVectorCannotBeAdjusted = 64,
				ProjectilesHaveIdenticalError = 128,
				ProjectilesFireParallel = 256,
				CantFireWhenOthersFiring = 512,
				CantFireWhenOthersRecovering = 1024,
				DonTClearFireBitAfterRecovering = 2048,
				StaggerFireAcrossMultipleMarkers = 4096,
				FiresLockedProjectiles = 8192,
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

			public enum PredictionTypeValue : short
			{
				None,
				Continuous,
				Instant,
			}

			public enum FiringNoiseValue : short
			{
				Silent,
				Medium,
				Loud,
				Shout,
				Quiet,
			}

			public enum DistributionFunctionValue : short
			{
				Point,
				HorizontalFan,
			}

			[TagStructure(Size = 0xC)]
			public class FirstPersonOffset
			{
				public float FirstPersonOffsetX;
				public float FirstPersonOffsetY;
				public float FirstPersonOffsetZ;
			}

			public enum DamageReportingTypeValue : sbyte
			{
				Guardians,
				FallingDamage,
				Collision,
				Melee,
				Explosion,
				Magnum,
				PlasmaPistol,
				Needler,
				Mauler,
				Smg,
				PlasmaRifle,
				BattleRifle,
				Carbine,
				Shotgun,
				SniperRifle,
				BeamRifle,
				AssaultRifle,
				Spiker,
				FuelRodCannon,
				MissilePod,
				RocketLauncher,
				SpartanLaser,
				BruteShot,
				Flamethrower,
				SentinelGun,
				EnergySword,
				GravityHammer,
				FragGrenade,
				PlasmaGrenade,
				SpikeGrenade,
				FirebombGrenade,
				Flag,
				Bomb,
				BombExplosion,
				Ball,
				MachinegunTurret,
				PlasmaCannon,
				PlasmaMortar,
				PlasmaTurret,
				Banshee,
				Ghost,
				Mongoose,
				Scorpion,
				ScorpionGunner,
				Spectre,
				SpectreGunner,
				Warthog,
				WarthogGunner,
				WarthogGaussTurret,
				Wraith,
				WraithGunner,
				Tank,
				Chopper,
				Hornet,
				Mantis,
				Prowler,
				SentinelBeam,
				SentinelRpg,
				Teleporter,
				Tripmine,
				ElephantTurret,
			}

			public enum AngleChangeFunctionValue : short
			{
				Linear,
				Early,
				VeryEarly,
				Late,
				VeryLate,
				Cosine,
				One,
				Zero,
			}

			[TagStructure(Size = 0xC4)]
			public class FiringEffect
			{
				public short ShotCountLowerBound;
				public short ShotCountUpperBound;
				public TagInstance FiringEffect2;
				public TagInstance MisfireEffect;
				public TagInstance EmptyEffect;
				public TagInstance UnknownEffect;
				public TagInstance FiringResponse;
				public TagInstance MisfireResponse;
				public TagInstance EmptyResponse;
				public TagInstance UnknownResponse;
				public TagInstance RiderFiringResponse;
				public TagInstance RiderMisfireResponse;
				public TagInstance RiderEmptyResponse;
				public TagInstance RiderUnknownResponse;
			}
		}
	}
}
