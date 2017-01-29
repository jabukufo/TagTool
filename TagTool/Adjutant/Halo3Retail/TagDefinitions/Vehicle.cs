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
	[TagStructure(Class = "vehi", Size = 0x44C)]
	public class Vehicle
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
		public DefaultTeamValue DefaultTeam;
		public ConstantSoundVolumeValue ConstantSoundVolume;
		public List<MetagameProperty> MetagameProperties;
		public TagInstance IntegratedLightToggle;
		public Angle CameraFieldOfView;
		public float CameraStiffness;
		public short Unknown3;
		public short Unknown4;
		public StringID CameraMarkerName;
		public StringID CameraSubmergedMarkerName;
		public Angle PitchAutoLevel;
		public Angle PitchRangeMin;
		public Angle PitchRangeMax;
		public List<CameraTrack> CameraTracks;
		public Angle Unknown5;
		public Angle Unknown6;
		public Angle Unknown7;
		public List<UnknownBlock> Unknown8;
		public float AccelerationRangeI;
		public float AccelerationRangeJ;
		public float AccelerationRangeK;
		public float AccelerationActionScale;
		public float AccelerationAttachScale;
		public float SoftPingThreshold;
		public float SoftPingInterruptTime;
		public float HardPingThreshold;
		public float HardPingInterruptTime;
		public float FeignDeathThreshold;
		public float FeignDeathTime;
		public float DistanceOfEvadeAnimation;
		public float DistanceOfDiveAnimation;
		public float StunnedMovementThreshold;
		public float FeignDeathChance;
		public float FeignRepeatChance;
		public TagInstance SpawnedTurretCharacter;
		public short SpawnedActorCountMin;
		public short SpawnedActorCountMax;
		public float SpawnedVelocity;
		public Angle AimingVelocityMaximum;
		public Angle AimingAccelerationMaximum;
		public float CasualAimingModifier;
		public Angle LookingVelocityMaximum;
		public Angle LookingAccelerationMaximum;
		public StringID RightHandNode;
		public StringID LeftHandNode;
		public StringID PreferredGunNode;
		public TagInstance MeleeDamage;
		public TagInstance BoardingMeleeDamage;
		public TagInstance BoardingMeleeResponse;
		public TagInstance EjectionMeleeDamage;
		public TagInstance EjectionMeleeResponse;
		public TagInstance LandingMeleeDamage;
		public TagInstance FlurryMeleeDamage;
		public TagInstance ObstacleSmashDamage;
		public MotionSensorBlipSizeValue MotionSensorBlipSize;
		public ItemScaleValue ItemScale;
		public List<Posture> Postures;
		public List<HudInterface> HudInterfaces;
		public List<DialogueVariant> DialogueVariants;
		public float GrenadeVelocity;
		public GrenadeTypeValue GrenadeType;
		public short GrenadeCount;
		public List<PoweredSeat> PoweredSeats;
		public List<Weapon> Weapons;
		public List<Seat> Seats;
		public float EmpRadius;
		public TagInstance EmpEffect;
		public TagInstance BoostCollisionDamage;
		public float BoostPeakPower;
		public float BoostRisePower;
		public float BoostPeakTime;
		public float BoostFallPower;
		public float BoostDeadTime;
		public float LipsyncAttackWeight;
		public float LipsyncDecayWeight;
		public TagInstance DetachDamage;
		public TagInstance DetachedWeapon;
		public FlagsValue3 Flags3;
		public List<TankEngineMotionProperty> TankEngineMotionProperties;
		public List<EngineMotionProperty> EngineMotionProperties;
		public List<DropshipMotionProperty> DropshipMotionProperties;
		public List<AntigravityMotionProperty> AntigravityMotionProperties;
		public List<JetEngineMotionProperty> JetEngineMotionProperties;
		public List<TurretProperty> TurretProperties;
		public uint Unknown9;
		public uint Unknown10;
		public uint Unknown11;
		public List<HelicopterMotionProperty> HelicopterMotionProperties;
		public List<AntigravityEngineMotionProperty> AntigravityEngineMotionProperties;
		public List<AutoturretEquipmentBlock> AutoturretEquipment;
		public FlagsValue4 Flags4;
		public float GroundFriction;
		public float GroundDepth;
		public float GroundDampFactor;
		public float GroundMovingFriction;
		public float GroundMaximumSlope0;
		public float GroundMaximumSlope1LessThanSlope0;
		public float Unknown12;
		public float AntiGravityBankLift;
		public float SteeringBankReactionScale;
		public float GravityScale;
		public float Radius;
		public float Unknown13;
		public float Unknown14;
		public float Unknown15;
		public List<AntiGravityPoint> AntiGravityPoints;
		public List<FrictionPoint> FrictionPoints;
		public List<PhantomShape> PhantomShapes;
		public PlayerTrainingVehicleTypeValue PlayerTrainingVehicleType;
		public VehicleSizeValue VehicleSize;
		public sbyte Unknown16;
		public sbyte Unknown17;
		public float MinimumFlippingAngularVelocity;
		public float MaximumFlippingAngularVelocity;
		public uint Unknown18;
		public uint Unknown19;
		public float SeatEntranceAccelerationScale;
		public float SeatExitAccelerationScale;
		public float FlipTime;
		public StringID FlipOverMessage;
		public TagInstance SuspensionSound;
		public TagInstance RunningEffect;
		public TagInstance UnknownResponse;
		public TagInstance UnknownResponse2;

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
			CircularAiming,
			DestroyedAfterDying,
			HalfSpeedInterpolation = 4,
			FiresFromCamera = 8,
			EntranceInsideBoundingSphere = 16,
			DoesnTShowReadiedWeapon = 32,
			CausesPassengerDialogue = 64,
			ResistsPings = 128,
			MeleeAttackIsFatal = 256,
			DonTRefaceDuringPings = 512,
			HasNoAiming = 1024,
			SimpleCreature = 2048,
			ImpactMeleeAttachesToUnit = 4096,
			ImpactMeleeDiesOnShield = 8192,
			CannotOpenDoorsAutomatically = 16384,
			MeleeAttackersCannotAttach = 32768,
			NotInstantlyKilledByMelee = 65536,
			ShieldSapping = 131072,
			RunsAroundFlaming = 262144,
			Inconsequential = 524288,
			SpecialCinematicUnit = 1048576,
			IgnoredByAutoaiming = 2097152,
			ShieldsFryInfectionForms = 4194304,
			CanDualWield = 8388608,
			Bit24 = 16777216,
			ActsAsGunnerForParent = 33554432,
			ControlledByParentGunner = 67108864,
			ParentSPrimaryWeapon = 134217728,
			UnitHasBoost = 268435456,
			Bit29 = 536870912,
			Bit30 = 1073741824,
			Bit31 = -2147483648,
		}

		public enum DefaultTeamValue : short
		{
			Default,
			Player,
			Human,
			Covenant,
			Flood,
			Sentinel,
			Heretic,
			Prophet,
			Guilty,
			Unused9,
			Unused10,
			Unused11,
			Unused12,
			Unused13,
			Unused14,
			Unused15,
		}

		public enum ConstantSoundVolumeValue : short
		{
			Silent,
			Medium,
			Loud,
			Shout,
			Quiet,
		}

		[TagStructure(Size = 0x8)]
		public class MetagameProperty
		{
			public FlagsValue Flags;
			public UnitValue Unit;
			public ClassificationValue Classification;
			public sbyte Unknown;
			public short Points;
			public short Unknown2;

			public enum FlagsValue : byte
			{
				None,
				MustHaveActiveSeats,
			}

			public enum UnitValue : sbyte
			{
				Brute,
				Grunt,
				Jackal,
				Marine,
				Bugger,
				Hunter,
				FloodInfection,
				FloodCarrier,
				FloodCombat,
				FloodPureform,
				Sentinel,
				Elite,
				Turret,
				Mongoose,
				Warthog,
				Scorpion,
				Hornet,
				Pelican,
				Shade,
				Watchtower,
				Ghost,
				Chopper,
				Mauler,
				Wraith,
				Banshee,
				Phantom,
				Scarab,
				Guntower,
			}

			public enum ClassificationValue : sbyte
			{
				Infantry,
				Leader,
				Hero,
				Specialist,
				LightVehicle,
				HeavyVehicle,
				GiantVehicle,
				StandardVehicle,
			}
		}

		[TagStructure(Size = 0x10)]
		public class CameraTrack
		{
			public TagInstance Track;
		}

		[TagStructure(Size = 0x4C)]
		public class UnknownBlock
		{
			public float Unknown;
			public float Unknown2;
			public float Unknown3;
			public float Unknown4;
			public float Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float Unknown8;
			public float Unknown9;
			public float Unknown10;
			public float Unknown11;
			public float Unknown12;
			public float Unknown13;
			public float Unknown14;
			public float Unknown15;
			public float Unknown16;
			public float Unknown17;
			public float Unknown18;
			public float Unknown19;
		}

		public enum MotionSensorBlipSizeValue : short
		{
			Medium,
			Small,
			Large,
		}

		public enum ItemScaleValue : short
		{
			Small,
			Medium,
			Large,
			Huge,
		}

		[TagStructure(Size = 0x10)]
		public class Posture
		{
			public StringID Name;
			public float PillOffsetI;
			public float PillOffsetJ;
			public float PillOffsetK;
		}

		[TagStructure(Size = 0x10)]
		public class HudInterface
		{
			public TagInstance UnitHudInterface;
		}

		[TagStructure(Size = 0x14)]
		public class DialogueVariant
		{
			public short VariantNumber;
			public short Unknown;
			public TagInstance Dialogue;
		}

		public enum GrenadeTypeValue : short
		{
			HumanFragmentation,
			CovenantPlasma,
			BruteSpike,
			Firebomb,
		}

		[TagStructure(Size = 0x8)]
		public class PoweredSeat
		{
			public float DriverPowerupTime;
			public float DriverPowerdownTime;
		}

		[TagStructure(Size = 0x10)]
		public class Weapon
		{
			public TagInstance Weapon2;
		}

		[TagStructure(Size = 0xE4)]
		public class Seat
		{
			public FlagsValue Flags;
			public StringID SeatAnimation;
			public StringID SeatMarkerName;
			public StringID EntryMarkerSName;
			public StringID BoardingGrenadeMarker;
			public StringID BoardingGrenadeString;
			public StringID BoardingMeleeString;
			public StringID DetachWeaponString;
			public float PingScale;
			public float TurnoverTime;
			public float AccelerationRangeI;
			public float AccelerationRangeJ;
			public float AccelerationRangeK;
			public float AccelerationActionScale;
			public float AccelerationAttachScale;
			public float AiScariness;
			public AiSeatTypeValue AiSeatType;
			public short BoardingSeat;
			public float ListenerInterpolationFactor;
			public float YawRateBoundsMin;
			public float YawRateBoundsMax;
			public float PitchRateBoundsMin;
			public float PitchRateBoundsMax;
			public float Unknown;
			public float MinimumSpeedReference;
			public float MaximumSpeedReference;
			public float SpeedExponent;
			public short Unknown2;
			public short Unknown3;
			public StringID CameraMarkerName;
			public StringID CameraSubmergedMarkerName;
			public Angle PitchAutoLevel;
			public Angle PitchRangeMin;
			public Angle PitchRangeMax;
			public List<CameraTrack> CameraTracks;
			public Angle Unknown4;
			public Angle Unknown5;
			public Angle Unknown6;
			public List<UnknownBlock> Unknown7;
			public List<UnitHudInterfaceBlock> UnitHudInterface;
			public StringID EnterSeatString;
			public Angle YawRangeMin;
			public Angle YawRangeMax;
			public TagInstance BuiltInGunner;
			public float EntryRadius;
			public Angle EntryMarkerConeAngle;
			public Angle EntryMarkerFacingAngle;
			public float MaximumRelativeVelocity;
			public StringID InvisibleSeatRegion;
			public int RuntimeInvisibleSeatRegionIndex;

			public enum FlagsValue : int
			{
				None,
				Invisible,
				Locked,
				Driver = 4,
				Gunner = 8,
				ThirdPersonCamera = 16,
				AllowsWeapons = 32,
				ThirdPersonOnEnter = 64,
				FirstPersonCameraSlavedToGun = 128,
				AllowVehicleCommunicationAnimations = 256,
				NotValidWithoutDriver = 512,
				AllowAiNoncombatants = 1024,
				BoardingSeat = 2048,
				AiFiringDisabledByMaxAcceleration = 4096,
				BoardingEntersSeat = 8192,
				BoardingNeedAnyPassenger = 16384,
				ControlsOpenAndClose = 32768,
				InvalidForPlayer = 65536,
				InvalidForNonPlayer = 131072,
				GunnerPlayerOnly = 262144,
				InvisibleUnderMajorDamage = 524288,
				Bit20 = 1048576,
				Bit21 = 2097152,
				DetachableWeapon = 4194304,
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

			public enum AiSeatTypeValue : short
			{
				None,
				Passenger,
				Gunner,
				SmallCargo,
				LargeCargo,
				Driver,
			}

			[TagStructure(Size = 0x10)]
			public class CameraTrack
			{
				public TagInstance Track;
			}

			[TagStructure(Size = 0x4C)]
			public class UnknownBlock
			{
				public float Unknown;
				public float Unknown2;
				public float Unknown3;
				public float Unknown4;
				public float Unknown5;
				public float Unknown6;
				public float Unknown7;
				public float Unknown8;
				public float Unknown9;
				public float Unknown10;
				public float Unknown11;
				public float Unknown12;
				public float Unknown13;
				public float Unknown14;
				public float Unknown15;
				public float Unknown16;
				public float Unknown17;
				public float Unknown18;
				public float Unknown19;
			}

			[TagStructure(Size = 0x10)]
			public class UnitHudInterfaceBlock
			{
				public TagInstance UnitHudInterface;
			}
		}

		public enum FlagsValue3 : int
		{
			None,
			NoFrictionWithDriver,
			CanTriggerAutomaticOpeningDoors,
			AutoaimWhenTeamless = 4,
			AiWeaponCannotRotate = 8,
			AiDoesNotRequireDriver = 16,
			AiDriverEnable = 32,
			AiDriverFlying = 64,
			AiDriverCanSidestep = 128,
			AiDriverHovering = 256,
			NoncombatVehicle = 512,
			VehicleIsChild = 1024,
			BouncesAtDeathBarriers = 2048,
			Hydraulics = 4096,
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

		[TagStructure(Size = 0x58)]
		public class TankEngineMotionProperty
		{
			public Angle SteeringOverdampenCuspAngle;
			public float SteeringOverdamenExponent;
			public float Unknown;
			public float SpeedLeft;
			public float SpeedRight;
			public float TurningSpeedLeft;
			public float TurningSpeedRight;
			public float SpeedLeft2;
			public float SpeedRight2;
			public float TurningSpeedLeft2;
			public float TurningSpeedRight2;
			public float EngineMomentum;
			public float EngineMaximumAngularVelocity;
			public List<Gear> Gears;
			public TagInstance ChangeGearSound;
			public float Unknown2;
			public float Unknown3;

			[TagStructure(Size = 0x44)]
			public class Gear
			{
				public float MinTorque;
				public float MaxTorque;
				public float PeakTorqueScale;
				public float PastPeakTorqueExponent;
				public float TorqueAtMaxAngularVelovity;
				public float TorqueAt2xMaxAngularVelocity;
				public float MinTorque2;
				public float MaxTorque2;
				public float PeakTorqueScale2;
				public float PastPeakTorqueExponent2;
				public float TorqueAtMaxAngularVelovity2;
				public float TorqueAt2xMaxAngularVelocity2;
				public float MinTimeToUpshift;
				public float EngineUpshiftScale;
				public float GearRatio;
				public float MinTimeToDownshift;
				public float EngineDownshiftScale;
			}
		}

		[TagStructure(Size = 0x40)]
		public class EngineMotionProperty
		{
			public Angle SteeringOverdampenCuspAngle;
			public float SteeringOverdamenExponent;
			public Angle MaximumLeftTurn;
			public Angle MaximumRightTurnNegative;
			public Angle TurnRate;
			public float EngineMomentum;
			public float EngineMaximumAngularVelocity;
			public List<Gear> Gears;
			public TagInstance ChangeGearSound;
			public float Unknown;
			public float Unknown2;

			[TagStructure(Size = 0x44)]
			public class Gear
			{
				public float MinTorque;
				public float MaxTorque;
				public float PeakTorqueScale;
				public float PastPeakTorqueExponent;
				public float TorqueAtMaxAngularVelovity;
				public float TorqueAt2xMaxAngularVelocity;
				public float MinTorque2;
				public float MaxTorque2;
				public float PeakTorqueScale2;
				public float PastPeakTorqueExponent2;
				public float TorqueAtMaxAngularVelovity2;
				public float TorqueAt2xMaxAngularVelocity2;
				public float MinTimeToUpshift;
				public float EngineUpshiftScale;
				public float GearRatio;
				public float MinTimeToDownshift;
				public float EngineDownshiftScale;
			}
		}

		[TagStructure(Size = 0x4C)]
		public class DropshipMotionProperty
		{
			public float ForwardAcceleration;
			public float BackwardAcceleration;
			public float Unknown;
			public float Unknown2;
			public float LeftStrafeAcceleration;
			public float RightStrafeAcceleration;
			public float Unknown3;
			public float Unknown4;
			public float LiftAcceleration;
			public float DropAcceleration;
			public float Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float Unknown8;
			public float Unknown9;
			public float Unknown10;
			public Angle Unknown11;
			public float Unknown12;
			public Angle Unknown13;
		}

		[TagStructure(Size = 0x70)]
		public class AntigravityMotionProperty
		{
			public Angle SteeringOverdampenCuspAngle;
			public float SteeringOverdamenExponent;
			public float MaximumForwardSpeed;
			public float MaximumReverseSpeed;
			public float SpeedAcceleration;
			public float SpeedDeceleration;
			public float MaximumLeftSlide;
			public float MaximumRightSlide;
			public float SlideAcceleration;
			public float SlideDeceleration;
			public sbyte Unknown;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public sbyte Unknown4;
			public float Traction;
			public uint Unknown5;
			public float TurningRate;
			public StringID Unknown6;
			public float Unknown7;
			public float Unknown8;
			public float Unknown9;
			public float Unknown10;
			public StringID Unknown11;
			public float Unknown12;
			public float Unknown13;
			public float Unknown14;
			public float Unknown15;
			public float Unknown16;
			public float Unknown17;
			public float Unknown18;
			public Angle Unknown19;
		}

		[TagStructure(Size = 0x64)]
		public class JetEngineMotionProperty
		{
			public Angle SteeringOverdampenCuspAngle;
			public float SteeringOverdamenExponent;
			public Angle MaximumLeftTurn;
			public Angle MaximumRightTurnNegative;
			public Angle TurnRate;
			public float FlyingSpeed;
			public float Acceleration;
			public float SpeedAcceleration;
			public float SpeedDeceleration;
			public float PitchLeftSpeed;
			public float PitchRightSpeed;
			public float PitchRate;
			public float UnpitchRate;
			public float FlightStability;
			public uint Unknown;
			public float NoseAngle;
			public float Unknown2;
			public float Unknown3;
			public float Unknown4;
			public float FallingSpeed;
			public float FallingSpeed2;
			public float Unknown5;
			public float Unknown6;
			public float IdleRise;
			public float IdleForward;
		}

		[TagStructure(Size = 0x4)]
		public class TurretProperty
		{
			public uint Unknown;
		}

		[TagStructure(Size = 0x74)]
		public class HelicopterMotionProperty
		{
			public Angle MaximumLeftTurn;
			public Angle MaximumRightTurnNegative;
			public Angle Unknown;
			public StringID ThrustFrontLeft;
			public StringID ThrustFrontRight;
			public StringID Thrust;
			public Angle Unknown2;
			public Angle Unknown3;
			public Angle Unknown4;
			public Angle Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float Unknown8;
			public float Unknown9;
			public float Unknown10;
			public float Unknown11;
			public float Unknown12;
			public float Unknown13;
			public float Unknown14;
			public float Unknown15;
			public float Unknown16;
			public float Unknown17;
			public float Unknown18;
			public float Unknown19;
			public float Unknown20;
			public Angle Unknown21;
			public Angle Unknown22;
			public float Unknown23;
			public float Unknown24;
		}

		[TagStructure(Size = 0x70)]
		public class AntigravityEngineMotionProperty
		{
			public Angle SteeringOverdampenCuspAngle;
			public float SteeringOverdamenExponent;
			public Angle MaximumLeftTurn;
			public Angle MaximumRightTurnNegative;
			public Angle TurnRate;
			public float EngineMomentum;
			public float EngineMaximumAngularVelocity;
			public List<Gear> Gears;
			public TagInstance ChangeGearSound;
			public float Unknown;
			public StringID Unknown2;
			public float Unknown3;
			public float Unknown4;
			public float Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float Unknown8;
			public Angle Unknown9;
			public float Unknown10;
			public float Unknown11;
			public float Unknown12;
			public float Unknown13;
			public float Unknown14;

			[TagStructure(Size = 0x44)]
			public class Gear
			{
				public float MinTorque;
				public float MaxTorque;
				public float PeakTorqueScale;
				public float PastPeakTorqueExponent;
				public float TorqueAtMaxAngularVelovity;
				public float TorqueAt2xMaxAngularVelocity;
				public float MinTorque2;
				public float MaxTorque2;
				public float PeakTorqueScale2;
				public float PastPeakTorqueExponent2;
				public float TorqueAtMaxAngularVelovity2;
				public float TorqueAt2xMaxAngularVelocity2;
				public float MinTimeToUpshift;
				public float EngineUpshiftScale;
				public float GearRatio;
				public float MinTimeToDownshift;
				public float EngineDownshiftScale;
			}
		}

		[TagStructure(Size = 0x30)]
		public class AutoturretEquipmentBlock
		{
			public Angle Unknown;
			public float Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public float Unknown6;
			public uint Unknown7;
			public uint Unknown8;
			public uint Unknown9;
			public float Unknown10;
			public float Unknown11;
			public float Unknown12;
		}

		public enum FlagsValue4 : int
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

		[TagStructure(Size = 0x4C)]
		public class AntiGravityPoint
		{
			public StringID MarkerName;
			public FlagsValue Flags;
			public float AntigravStrength;
			public float AntigravOffset;
			public float AntigravHeight;
			public float AntigravDumpFactor;
			public float AntigravNormalK1;
			public float AntigravNormalK0;
			public float Radius;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public short Unknown4;
			public short DamageSourceRegionIndex;
			public StringID DamageSourceRegionName;
			public float DefaultStateError;
			public float MinorDamageError;
			public float MediumDamageError;
			public float MajorDamageError;
			public float DestroyedStateError;

			public enum FlagsValue : int
			{
				None,
				GetsDamageFromRegion,
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

		[TagStructure(Size = 0x4C)]
		public class FrictionPoint
		{
			public StringID MarkerName;
			public FlagsValue Flags;
			public float FractionOfTotalMass;
			public float Radius;
			public float DamagedRadius;
			public FrictionTypeValue FrictionType;
			public short Unknown;
			public float MovingFrictionVelocityDiff;
			public float EBrakeMovingFriction;
			public float EBrakeFriction;
			public float EBrakeMovingFrictionVelocityDiff;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public StringID CollisionMaterialName;
			public short CollisionGlobalMaterialIndex;
			public ModelStateDestroyedValue ModelStateDestroyed;
			public StringID RegionName;
			public int RegionIndex;

			public enum FlagsValue : int
			{
				None,
				GetsDamageFromRegion,
				Powered,
				FrontTurning = 4,
				RearTurning = 8,
				AttachedToEBrake = 16,
				CanBeDestroyed = 32,
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

			public enum FrictionTypeValue : short
			{
				Point,
				Forward,
			}

			public enum ModelStateDestroyedValue : short
			{
				Default,
				MinorDamage,
				MediumDamage,
				MajorDamage,
				Destroyed,
			}
		}

		[TagStructure(Size = 0x330)]
		public class PhantomShape
		{
			public int Unknown;
			public short Size;
			public short Count;
			public int OverallShapeIndex;
			public int Offset;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public int Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
			public uint Unknown9;
			public float Unknown10;
			public float Unknown11;
			public float Unknown12;
			public float Unknown13;
			public float Unknown14;
			public float Unknown15;
			public float Unknown16;
			public uint Unknown17;
			public int MultisphereCount;
			public FlagsValue Flags;
			public float X0;
			public float X1;
			public float Y0;
			public float Y1;
			public float Z0;
			public float Z1;
			public int Unknown18;
			public short Size2;
			public short Count2;
			public int OverallShapeIndex2;
			public int Offset2;
			public int NumberOfSpheres;
			public uint Unknown19;
			public uint Unknown20;
			public uint Unknown21;
			public uint Sphere0X;
			public uint Sphere0Y;
			public uint Sphere0Z;
			public uint Sphere0Radius;
			public uint Sphere1X;
			public uint Sphere1Y;
			public uint Sphere1Z;
			public uint Sphere1Radius;
			public uint Sphere2X;
			public uint Sphere2Y;
			public uint Sphere2Z;
			public uint Sphere2Radius;
			public uint Sphere3X;
			public uint Sphere3Y;
			public uint Sphere3Z;
			public uint Sphere3Radius;
			public uint Sphere4X;
			public uint Sphere4Y;
			public uint Sphere4Z;
			public uint Sphere4Radius;
			public uint Sphere5X;
			public uint Sphere5Y;
			public uint Sphere5Z;
			public uint Sphere5Radius;
			public uint Sphere6X;
			public uint Sphere6Y;
			public uint Sphere6Z;
			public uint Sphere6Radius;
			public uint Sphere7X;
			public uint Sphere7Y;
			public uint Sphere7Z;
			public uint Sphere7Radius;
			public int Unknown22;
			public short Size3;
			public short Count3;
			public int OverallShapeIndex3;
			public int Offset3;
			public int NumberOfSpheres2;
			public uint Unknown23;
			public uint Unknown24;
			public uint Unknown25;
			public uint Sphere0X2;
			public uint Sphere0Y2;
			public uint Sphere0Z2;
			public uint Sphere0Radius2;
			public uint Sphere1X2;
			public uint Sphere1Y2;
			public uint Sphere1Z2;
			public uint Sphere1Radius2;
			public uint Sphere2X2;
			public uint Sphere2Y2;
			public uint Sphere2Z2;
			public uint Sphere2Radius2;
			public uint Sphere3X2;
			public uint Sphere3Y2;
			public uint Sphere3Z2;
			public uint Sphere3Radius2;
			public uint Sphere4X2;
			public uint Sphere4Y2;
			public uint Sphere4Z2;
			public uint Sphere4Radius2;
			public uint Sphere5X2;
			public uint Sphere5Y2;
			public uint Sphere5Z2;
			public uint Sphere5Radius2;
			public uint Sphere6X2;
			public uint Sphere6Y2;
			public uint Sphere6Z2;
			public uint Sphere6Radius2;
			public uint Sphere7X2;
			public uint Sphere7Y2;
			public uint Sphere7Z2;
			public uint Sphere7Radius2;
			public int Unknown26;
			public short Size4;
			public short Count4;
			public int OverallShapeIndex4;
			public int Offset4;
			public int NumberOfSpheres3;
			public uint Unknown27;
			public uint Unknown28;
			public uint Unknown29;
			public uint Sphere0X3;
			public uint Sphere0Y3;
			public uint Sphere0Z3;
			public uint Sphere0Radius3;
			public uint Sphere1X3;
			public uint Sphere1Y3;
			public uint Sphere1Z3;
			public uint Sphere1Radius3;
			public uint Sphere2X3;
			public uint Sphere2Y3;
			public uint Sphere2Z3;
			public uint Sphere2Radius3;
			public uint Sphere3X3;
			public uint Sphere3Y3;
			public uint Sphere3Z3;
			public uint Sphere3Radius3;
			public uint Sphere4X3;
			public uint Sphere4Y3;
			public uint Sphere4Z3;
			public uint Sphere4Radius3;
			public uint Sphere5X3;
			public uint Sphere5Y3;
			public uint Sphere5Z3;
			public uint Sphere5Radius3;
			public uint Sphere6X3;
			public uint Sphere6Y3;
			public uint Sphere6Z3;
			public uint Sphere6Radius3;
			public uint Sphere7X3;
			public uint Sphere7Y3;
			public uint Sphere7Z3;
			public uint Sphere7Radius3;
			public int Unknown30;
			public short Size5;
			public short Count5;
			public int OverallShapeIndex5;
			public int Offset5;
			public int NumberOfSpheres4;
			public uint Unknown31;
			public uint Unknown32;
			public uint Unknown33;
			public uint Sphere0X4;
			public uint Sphere0Y4;
			public uint Sphere0Z4;
			public uint Sphere0Radius4;
			public uint Sphere1X4;
			public uint Sphere1Y4;
			public uint Sphere1Z4;
			public uint Sphere1Radius4;
			public uint Sphere2X4;
			public uint Sphere2Y4;
			public uint Sphere2Z4;
			public uint Sphere2Radius4;
			public uint Sphere3X4;
			public uint Sphere3Y4;
			public uint Sphere3Z4;
			public uint Sphere3Radius4;
			public uint Sphere4X4;
			public uint Sphere4Y4;
			public uint Sphere4Z4;
			public uint Sphere4Radius4;
			public uint Sphere5X4;
			public uint Sphere5Y4;
			public uint Sphere5Z4;
			public uint Sphere5Radius4;
			public uint Sphere6X4;
			public uint Sphere6Y4;
			public uint Sphere6Z4;
			public uint Sphere6Radius4;
			public uint Sphere7X4;
			public uint Sphere7Y4;
			public uint Sphere7Z4;
			public uint Sphere7Radius4;
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

			public enum FlagsValue : int
			{
				None,
				HasAabbPhantom,
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

		public enum PlayerTrainingVehicleTypeValue : sbyte
		{
			None,
			Warthog,
			WarthogTurret,
			Ghost,
			Banshee,
			Tank,
			Wraith,
		}

		public enum VehicleSizeValue : sbyte
		{
			Small,
			Large,
		}
	}
}
