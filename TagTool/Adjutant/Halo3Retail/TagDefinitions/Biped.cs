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
	[TagStructure(Class = "bipd", Size = 0x4E0)]
	public class Biped
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
		public Angle MovingTurningSpeed;
		public FlagsValue3 Flags3;
		public Angle StationaryTurningThreshold;
		public float JumpVelocity;
		public float MaximumSoftLandingTime;
		public float MaximumHardLandingTime;
		public float MinimumSoftLandingVelocity;
		public float MinimumHardLandingVelocity;
		public float MaximumHardLandingVelocity;
		public float DeathHardLandingVelocity;
		public float StunDuration;
		public float StandingCameraHeight;
		public float CrouchingCameraHeight;
		public float CrouchTransitionTime;
		public Angle CameraInterpolationStart;
		public Angle CameraInterpolationEnd;
		public float CameraForwardMovementScale;
		public float CameraSideMovementScale;
		public float CameraVerticalMovementScale;
		public float CameraExclusionDistance;
		public float AutoaimWidth;
		public LockOnFlagsValue LockOnFlags;
		public float LockOnDistance;
		public short PhysicsControlNodeIndex;
		public short Unknown9;
		public float Unknown10;
		public float Unknown11;
		public short PelvisNodeIndex;
		public short HeadNodeIndex;
		public float HeadshotAccelerationScale;
		public TagInstance AreaDamageEffect;
		public FlagsValue4 Flags4;
		public float HeightStanding;
		public float HeightCrouching;
		public float Radius;
		public float Mass;
		public StringID LivingMaterialName;
		public StringID DeadMaterialName;
		public short LivingGlobalMaterialIndex;
		public short DeadGlobalMaterialIndex;
		public List<DeadSphereShape> DeadSphereShapes;
		public List<PillShape> PillShapes;
		public List<SphereShape> SphereShapes;
		public Angle MaximumSlopeAngle;
		public Angle DownhillFalloffAngle;
		public Angle DownhillCutoffAngle;
		public Angle UphillFalloffAngle;
		public Angle UphillCutoffAngle;
		public float DownhillVelocityScale;
		public float UphillVelocityScale;
		public float Unknown12;
		public float Unknown13;
		public float Unknown14;
		public float Unknown15;
		public float Unknown16;
		public float Unknown17;
		public float Unknown18;
		public float FallingVelocityScale;
		public float Unknown19;
		public Angle BankAngle;
		public float BankApplyTime;
		public float BankDecayTime;
		public float PitchRatio;
		public float MaximumVelocity;
		public float MaximumSidestepVelocity;
		public float Acceleration;
		public float Deceleration;
		public Angle AngularVelocityMaximum;
		public Angle AngularAccelerationMaximum;
		public float CrouchVelocityModifier;
		public uint Unknown20;
		public List<ContactPoint> ContactPoints;
		public TagInstance ReanimationCharacter;
		public TagInstance TransformationMuffin;
		public TagInstance DeathSpawnCharacter;
		public short DeathSpawnCount;
		public short Unknown21;
		public uint Unknown22;
		public float Unknown23;
		public float Unknown24;
		public float Unknown25;
		public float Unknown26;
		public Angle Unknown27;
		public Angle Unknown28;
		public uint Unknown29;
		public uint Unknown30;
		public float Unknown31;
		public float Unknown32;
		public float Unknown33;
		public float Unknown34;
		public float Unknown35;
		public float Unknown36;
		public float Unknown37;
		public float Unknown38;
		public Angle Unknown39;
		public Angle Unknown40;
		public float Unknown41;
		public float Unknown42;
		public float Unknown43;
		public float Unknown44;
		public float Unknown45;

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
			TurnsWithoutAnimating,
			PassesThroughOtherBipeds,
			ImmuneToFallingDamage = 4,
			RotateWhileAirborne = 8,
			UseLimpBodyPhysics = 16,
			Bit5 = 32,
			RandomSpeedIncrease = 64,
			Bit7 = 128,
			SpawnDeathChildrenOnDestroy = 256,
			StunnedByEmpDamage = 512,
			DeadPhysicsWhenStunned = 1024,
			AlwaysRagdollWhenDead = 2048,
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

		public enum LockOnFlagsValue : int
		{
			None,
			LockedByHumanTargeting,
			LockedByPlasmaTargeting,
			AlwaysLockedByHumanTargeting = 4,
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

		public enum FlagsValue4 : int
		{
			None,
			CenteredAtOrigin,
			ShapeSpherical,
			UsePlayerPhysics = 4,
			ClimbAnySurface = 8,
			Flying = 16,
			NotPhysical = 32,
			DeadCharacterCollisionGroup = 64,
			Bit7 = 128,
			NeverRests = 256,
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

		[TagStructure(Size = 0x70)]
		public class DeadSphereShape
		{
			public StringID Name;
			public sbyte MaterialIndex;
			public sbyte Unknown;
			public short GlobalMaterialIndex;
			public float RelativeMassScale;
			public float Friction;
			public float Restitution;
			public float Volume;
			public float Mass;
			public short OverallShapeIndex;
			public sbyte PhantomIndex;
			public sbyte InteractionUnknown;
			public int Unknown2;
			public short Size;
			public short Count;
			public int Offset;
			public int Unknown3;
			public float Radius;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public int Unknown7;
			public short Size2;
			public short Count2;
			public int Offset2;
			public int Unknown8;
			public float Radius2;
			public uint Unknown9;
			public uint Unknown10;
			public uint Unknown11;
			public float TranslationI;
			public float TranslationJ;
			public float TranslationK;
			public float TranslationRadius;
		}

		[TagStructure(Size = 0x60)]
		public class PillShape
		{
			public StringID Name;
			public sbyte MaterialIndex;
			public sbyte Unknown;
			public short GlobalMaterialIndex;
			public float RelativeMassScale;
			public float Friction;
			public float Restitution;
			public float Volume;
			public float Mass;
			public short OverallShapeIndex;
			public sbyte PhantomIndex;
			public sbyte InteractionUnknown;
			public int Unknown2;
			public short Size;
			public short Count;
			public int Offset;
			public int Unknown3;
			public float Radius;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public float BottomI;
			public float BottomJ;
			public float BottomK;
			public float BottomRadius;
			public float TopI;
			public float TopJ;
			public float TopK;
			public float TopRadius;
		}

		[TagStructure(Size = 0x70)]
		public class SphereShape
		{
			public StringID Name;
			public sbyte MaterialIndex;
			public sbyte Unknown;
			public short GlobalMaterialIndex;
			public float RelativeMassScale;
			public float Friction;
			public float Restitution;
			public float Volume;
			public float Mass;
			public short OverallShapeIndex;
			public sbyte PhantomIndex;
			public sbyte InteractionUnknown;
			public int Unknown2;
			public short Size;
			public short Count;
			public int Offset;
			public int Unknown3;
			public float Radius;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public int Unknown7;
			public short Size2;
			public short Count2;
			public int Offset2;
			public int Unknown8;
			public float Radius2;
			public uint Unknown9;
			public uint Unknown10;
			public uint Unknown11;
			public float TranslationI;
			public float TranslationJ;
			public float TranslationK;
			public float TranslationRadius;
		}

		[TagStructure(Size = 0x4)]
		public class ContactPoint
		{
			public StringID MarkerName;
		}
	}
}
