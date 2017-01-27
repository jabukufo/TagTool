using System;
using System.Collections.Generic;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Tags.Definitions
{
    [TagStructure(Name = "character", Class = "char", Size = 0x1F8)]
    public class Character
    {
        public uint CharacterFlags;
        public TagInstance ParentCharacter;
        public TagInstance Unit;
        public TagInstance Creature;
        public TagInstance Style;
        public TagInstance MajorCharacter;
        public List<Variant> Variants;
        public List<UnitDialogueBlock> UnitDialogue;
        public List<GeneralProperty> GeneralProperties;
        public List<VitalityProperty> VitalityProperties;
        public List<PlacementProperty> PlacementProperties;
        public List<PerceptionProperty> PerceptionProperties;
        public List<LookProperty> LookProperties;
        public List<MovementProperty> MovementProperties;
        public List<UnknownBlock> Unknown;
        public List<SwarmProperty> SwarmProperties;
        public List<ReadyProperty> ReadyProperties;
        public List<EngageProperty> EngageProperties;
        public List<ChargeProperty> ChargeProperties;
        public List<EvasionProperty> EvasionProperties;
        public List<CoverProperty> CoverProperties;
        public List<RetreatProperty> RetreatProperties;
        public List<SearchProperty> SearchProperties;
        public List<PreSearchProperty> PreSearchProperties;
        public List<IdleProperty> IdleProperties;
        public List<VocalizationProperty> VocalizationProperties;
        public List<BoardingProperty> BoardingProperties;
        public List<UnknownBlock2> Unknown2;
        public uint Unknown3;
        public uint Unknown4;
        public uint Unknown5;
        public uint Unknown6;
        public uint Unknown7;
        public uint Unknown8;
        public List<EngineerProperty> EngineerProperties;
        public List<UnknownBlock3> Unknown9;
        public List<UnknownBlock4> Unknown10;
        public List<WeaponsProperty> WeaponsProperties;
        public List<FiringPatternProperty> FiringPatternProperties;
        public List<GrenadesProperty> GrenadesProperties;
        public List<VehicleProperty> VehicleProperties;
        public List<MorphProperty> MorphProperties;
        public List<EquipmentProperty> EquipmentProperties;
        public List<MetagameProperty> MetagameProperties;
        public List<ActAttachment> ActAttachments;

        [TagStructure(Size = 0x14)]
        public class Variant
        {
            public StringId VariantName;
            public short VariantIndex;
            [TagField(Count = 2)]
            public sbyte[] Padding;
            public List<DialogueVariation> DialogueVariations;

            [TagStructure(Size = 0x18)]
            public class DialogueVariation
            {
                public TagInstance Dialogue;
                public StringId Name;
                public float Weight;
            }
        }

        [TagStructure(Size = 0xC)]
        public class UnitDialogueBlock
        {
            public List<DialogueVariation> DialogueVariations;

            [TagStructure(Size = 0x18)]
            public class DialogueVariation
            {
                public TagInstance Dialogue;
                public StringId Name;
                public float Weight;
            }
        }

        [Flags]
        public enum GeneralPropertyFlags : int
        {
            None = 0
        }

        public enum ActorTypeValue : short
        {
            Elite,
            Jackal,
            Grunt,
            Hunter,
            Engineer,
            Assassin,
            Player,
            Marine,
            Crew,
            CombatForm,
            InfectionForm,
            CarrierForm,
            Monitor,
            Sentinel,
            None,
            MountedWeapon,
            Brute,
            Prophet,
            Bugger,
            Juggernaut,
            PureFormStealth,
            PureFormTank,
            PureFormRanged,
            Scarab,
            Guardian
        }

        public enum FollowerPositioningValue : short
        {
            InFrontOfMe,
            BehindMe,
            Tight
        }

        public enum GrenadeTypeValue : short
        {
            None,
            HumanGrenade,
            CovenantPlasma,
            BruteClaymore,
            Firebomb
        }

        public enum BehaviorTreeRootValue : short
        {
            Default,
            Flying
        }

        [TagStructure(Size = 0x1C)]
        public class GeneralProperty
        {
            public GeneralPropertyFlags Flags;
            public ActorTypeValue ActorType;
            public short Rank;
            public FollowerPositioningValue FollowerPositioning;
            [TagField(Count = 2)]
            public sbyte[] Padding;
            public float MaximumLeaderDistance;
            public float MaximumPlayerDialogueDistance;
            public float Scariness;
            public GrenadeTypeValue DefaultGrenadeType;
            public BehaviorTreeRootValue BehaviorTreeRoot;

        }

        [Flags]
        public enum VitalityFlags : int
        {
            None = 0,
            AutoResurrect = 1 << 0
        }

        [TagStructure(Size = 0x80)]
        public class VitalityProperty
        {
            public VitalityFlags Flags;
            public float NormalBodyVitality;
            public float NormalShieldVitality;
            public float LegendaryBodyVitality;
            public float LegendaryShieldVitality;
            public float BodyRechargeFraction;
            public float SoftPingShieldThreshold;
            public float SoftPingNoshieldThreshold;
            public float SoftPingCooldownTime;
            public float HardPingShieldThreshold;
            public float HardPingNoShieldThreshold;
            public float HardPingCooldownTime;
            public float CurrentDamageDecayDelay;
            public float CurrentDamageDecayTime;
            public float RecentDamageDecayDelay;
            public float RecentDamageDecayTime;
            public float BodyRechargeDelayTime;
            public float BodyRechargeTime;
            public float ShieldRechargeDelayTime;
            public float ShieldRechargeTime;
            public float StunThreshold;
            public float StunTimeBoundsMin;
            public float StunTimeBoundsMax;
            public float ExtendedShieldDamageThreshold;
            public float ExtendedBodyDamageThreshold;
            public float SuicideRadius;
            public float RuntimeBodyRechargeVelocity;
            public float RuntimeShieldRechargeVelocity;
            public TagInstance ResurrectWeapon;
        }

        [TagStructure(Size = 0x34)]
        public class PlacementProperty
        {
            [TagField(Count = 4)]
            public sbyte[] Padding;
            public float FewUpgradeChanceEasy;
            public float FewUpgradeChanceNormal;
            public float FewUpgradeChanceHeroic;
            public float FewUpgradeChanceLegendary;
            public float NormalUpgradeChanceEasy;
            public float NormalUpgradeChanceNormal;
            public float NormalUpgradeChanceHeroic;
            public float NormalUpgradeChanceLegendary;
            public float ManyUpgradeChanceEasy;
            public float ManyUpgradeChanceNormal;
            public float ManyUpgradeChanceHeroic;
            public float ManyUpgradeChanceLegendary;
        }

        public enum PerceptionMode : short
        {
            Idle,
            Alert,
            Combat,
            Search,
            Patrol,
            VehicleIdle,
            VehicleAlert,
            VehicleCombat
        }

        [Flags]
        public enum PerceptionFlags : ushort
        {
            None = 0,
            CharacterCanSeeInDarkness = 1 << 0,
            IgnoreTrackingProjectiles = 1 << 1,
            IgnoreMinorTrackingProjectiles = 1 << 2
        }

        [TagStructure(Size = 0x2C)]
        public class PerceptionProperty
        {
            public PerceptionMode Mode;
            public PerceptionFlags Flags;
            public float MaxVisionDistance;
            public Angle CentralVisionAngle;
            public Angle MaxVisionAngle;
            public Angle PeripheralVisionAngle;
            public float PeripheralDistance;
            public float HearingDistance;
            public float NoticeProjectileChance;
            public float NoticeVehicleChance;
            public float PerceptionTime;
            public float FirstAcknowledgeSurpriseDistance;
        }

        [TagStructure(Size = 0x50)]
        public class LookProperty
        {
            public RealEulerAngles2d MaximumAimingDeviation;
            public RealEulerAngles2d MaximumLookingDeviation;
            public RealEulerAngles2d RuntimeAimingDeviationCosines;
            public RealEulerAngles2d RuntimeLookingDeviationCosines;
            public Angle NoncombatLookDeltaLeft;
            public Angle NoncombatLookDeltaRight;
            public Angle CombatLookDeltaLeft;
            public Angle CombatLookDeltaRight;
            public Bounds<float> NoncombatIdleLooking;
            public Bounds<float> NoncombatIdleAiming;
            public Bounds<float> CombatIdleLooking;
            public Bounds<float> CombatIdleAiming;
        }

        [TagStructure(Size = 0x2C)]
        public class MovementProperty
        {
            public uint MovementFlags;
            public float PathfindingRadius;
            public float DestinationRadius;
            public float DiveGrenadeChance;
            public ObstaceLeapMinimumSizeValue ObstaceLeapMinimumSize;
            public ObstaceLeapMaximumSizeValue ObstaceLeapMaximumSize;
            public ObstaceIgnoreSizeValue ObstaceIgnoreSize;
            public ObstaceSmashableSizeValue ObstaceSmashableSize;
            public JumpHeightValue JumpHeight;
            public uint MovementHintFlags;
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;

            public enum ObstaceLeapMinimumSizeValue : short
            {
                None,
                Tiny,
                Small,
                Medium,
                Large,
                Huge,
                Immobile,
            }

            public enum ObstaceLeapMaximumSizeValue : short
            {
                None,
                Tiny,
                Small,
                Medium,
                Large,
                Huge,
                Immobile,
            }

            public enum ObstaceIgnoreSizeValue : short
            {
                None,
                Tiny,
                Small,
                Medium,
                Large,
                Huge,
                Immobile,
            }

            public enum ObstaceSmashableSizeValue : short
            {
                None,
                Tiny,
                Small,
                Medium,
                Large,
                Huge,
                Immobile,
            }

            public enum JumpHeightValue : int
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

        [TagStructure(Size = 0x18)]
        public class UnknownBlock
        {
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;
            public uint Unknown5;
            public uint Unknown6;
        }

        [TagStructure(Size = 0x38)]
        public class SwarmProperty
        {
            public short ScatterKilledCount;
            public short Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public float ScatterRadius;
            public float ScatterDistance;
            public float HoundMinDistance;
            public float HoundMaxDistance;
            public float PerlinOffsetScale;
            public float OffsetPeriodMin;
            public float OffsetPeriodMax;
            public float PerlinIdleMovementThreshold;
            public float PerlinCombatMovementThreshold;
            public uint Unknown4;
            public uint Unknown5;
        }

        [TagStructure(Size = 0x8)]
        public class ReadyProperty
        {
            public float ReadyTimeBoundsMin;
            public float ReadyTimeBoundsMax;
        }

        [TagStructure(Size = 0x38)]
        public class EngageProperty
        {
            public uint EngageFlags;
            public uint Unknown;
            public float CrouchDangerThreshold;
            public float StandDangerThreshold;
            public float FightDangerMoveThreshold;
            public uint Unknown2;
            public TagInstance Unknown3;
            public uint Unknown4;
            public uint Unknown5;
            public uint Unknown6;
            public uint Unknown7;
        }

        [TagStructure(Size = 0x7C)]
        public class ChargeProperty
        {
            public uint ChargeFlags;
            public float MeleeConsiderRange;
            public float MeleeChance;
            public float MeleeAttackRange;
            public float MeleeAbortRange;
            public float MeleeAttackTimeout;
            public float MeleeAttackDelayTimer;
            public float MeleeLeapRangeMin;
            public float MeleeLeapRangeMax;
            public float MeleeLeapChance;
            public float IdealLeapVelocity;
            public float MaxLeapVelocity;
            public float MeleeLeapBallistic;
            public float MeleeDelayTimer;
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;
            public uint Unknown5;
            public TagInstance BerserkWeapon;
            public uint Unknown6;
            public uint Unknown7;
            public uint Unknown8;
            public uint Unknown9;
            public uint Unknown10;
            public List<UnknownBlock> Unknown11;

            [TagStructure(Size = 0x6)]
            public class UnknownBlock
            {
                public short Unknown;
                public short Unknown2;
                public short Unknown3;
            }
        }

        [TagStructure(Size = 0x14)]
        public class EvasionProperty
        {
            public float EvasionDangerThreshold;
            public float EvasionDelayTimer;
            public float EvasionChance;
            public float EvasionProximityThreshold;
            public float DiveRetreatChance;
        }

        [TagStructure(Size = 0x54)]
        public class CoverProperty
        {
            public uint CoverFlags;
            public float HideBehindCoverTimeMin;
            public float HideBehindCoverTimeMax;
            public float CoverVitalityThreshold;
            public float CoverShieldFraction;
            public float CoverCheckDelay;
            public float CoverDangerThreshold;
            public float DangerUpperThreshold;
            public float CoverChanceMin;
            public float CoverChanceMax;
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public float ProximitySelfPreserve;
            public float DisallowCoverDistance;
            public float ProximityMeleeDistance;
            public float UnreachableEnemyDangerThreashold;
            public float ScaryTargetThreshold;
            public uint Unknown4;
            public uint Unknown5;
            public uint Unknown6;
        }

        [TagStructure(Size = 0x58)]
        public class RetreatProperty
        {
            public uint RetreatFlags;
            public float ShieldThreshold;
            public float ScaryTargetThreshold;
            public float DangerThreshold;
            public float ProximityThreshold;
            public float ForcedCowerTimeBoundsMin;
            public float ForcedCowerTimeBoundsMax;
            public float CowerTimeBoundsMin;
            public float CowerTimeBoundsMax;
            public float ProximityAmbushThreshold;
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;
            public uint Unknown5;
            public Angle ZigZagAngle;
            public float ZigZagPeriod;
            public float RetreatGrenadeChance;
            public TagInstance BackupWeapon;
        }

        [TagStructure(Size = 0x20)]
        public class SearchProperty
        {
            public uint SearchFlags;
            public float SearchTimeMin;
            public float SearchTimeMax;
            public uint Unknown;
            public float UncoverDistanceBoundsMin;
            public float UncoverDistanceBoundsMax;
            public uint Unknown2;
            public uint Unknown3;
        }

        [TagStructure(Size = 0x28)]
        public class PreSearchProperty
        {
            public uint PreSearchFlags;
            public float MinimumPresearchTimeMin;
            public float MinimumPresearchTimeMax;
            public float MaximumPresearchTimeMin;
            public float MaximumPresearchTimeMax;
            public float MinimumCertaintyRadius;
            public uint Unknown;
            public float MinimumSuppressingTimeMin;
            public float MinimumSuppressingTimeMax;
            public short Unknown2;
            public short Unknown3;
        }

        [TagStructure(Size = 0x14)]
        public class IdleProperty
        {
            public uint Unknown;
            public float IdlePoseDelayTimeMin;
            public float IdlePoseDelayTimeMax;
            public uint Unknown2;
            public uint Unknown3;
        }

        [TagStructure(Size = 0xC)]
        public class VocalizationProperty
        {
            public uint Unknown;
            public float LookCommentTime;
            public float LookLongCommentTime;
        }

        [TagStructure(Size = 0x14)]
        public class BoardingProperty
        {
            public uint Flags;
            public float MaxDistance;
            public float AbortDistance;
            public float MaxSpeed;
            public uint Unknown;
        }

        [TagStructure(Size = 0x8)]
        public class UnknownBlock2
        {
            public uint Unknown;
            public uint Unknown2;
        }

        [TagStructure(Size = 0x38)]
        public class EngineerProperty
        {
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;
            public uint Unknown5;
            public float ShieldAmount;
            public uint Unknown6;
            public uint Unknown7;
            public uint Unknown8;
            public uint Unknown9;
            public TagInstance Unknown10;
        }

        [TagStructure(Size = 0x14)]
        public class UnknownBlock3
        {
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;
            public uint Unknown5;
        }

        [TagStructure(Size = 0x18)]
        public class UnknownBlock4
        {
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;
            public uint Unknown5;
            public uint Unknown6;
        }

        [TagStructure(Size = 0xE0)]
        public class WeaponsProperty
        {
            public uint WeaponFlags;
            public TagInstance Weapon;
            public float MaximumFiringRange;
            public float MinimumFiringRange;
            public float NormalCombatRangeMin;
            public float NormalCombatRangeMax;
            public float BombardmentRange;
            public float MaxSpecialTargetDistance;
            public float TimidCombatRangeMin;
            public float TimidCombatRangeMax;
            public float AggressiveCombatRangeMin;
            public float AggressiveCombatRangeMax;
            public float SuperBallisticRange;
            public float BallisticFiringBoundsMin;
            public float BallisticFiringBoundsMax;
            public float BallisticFractionBoundsMin;
            public float BallisticFractionBoundsMax;
            public float FirstBurstDelayTimeMin;
            public float FirstBurstDelayTimeMax;
            public float SurpriseDelayTime;
            public float SurpriseFireWildlyTime;
            public float DeathFireWildlyChance;
            public float DeathFireWildlyTime;
            public float CustomStandGunOffsetI;
            public float CustomStandGunOffsetJ;
            public float CustomStandGunOffsetK;
            public float CustomCrouchGunOffsetI;
            public float CustomCrouchGunOffsetJ;
            public float CustomCrouchGunOffsetK;
            public SpecialFireModeValue SpecialFireMode;
            public SpecialFireSituationValue SpecialFireSituation;
            public float SpecialFireChance;
            public float SpecialFireDelay;
            public float SpecialDamageModifier;
            public Angle SpecialProjectileError;
            public float DropWeaponLoadedMin;
            public float DropWeaponLoadedMax;
            public short DropWeaponAmmoMin;
            public short DropWeaponAmmoMax;
            public float NormalAccuracyBoundsMin;
            public float NormalAccuracyBoundsMax;
            public float NormalAccuracyTime;
            public float HeroicAccuracyBoundsMin;
            public float HeroicAccuracyBoundsMax;
            public float HeroicAccuracyTime;
            public float LegendaryAccuracyBoundsMin;
            public float LegendaryAccuracyBoundsMax;
            public float LegendaryAccuracyTime;
            public List<FiringPattern> FiringPatterns;
            public TagInstance WeaponMeleeDamage;

            public enum SpecialFireModeValue : short
            {
                None,
                Overcharge,
                SecondaryTrigger,
            }

            public enum SpecialFireSituationValue : short
            {
                Never,
                EnemyVisible,
                EnemyOutOfSight,
                Strafing,
            }

            [TagStructure(Size = 0x40)]
            public class FiringPattern
            {
                public float RateOfFire;
                public float TargetTracking;
                public float TargetLeading;
                public float BurstOriginRadius;
                public Angle BurstOriginAngle;
                public float BurstReturnLengthMin;
                public float BurstReturnLengthMax;
                public Angle BurstReturnAngle;
                public float BurstDurationMin;
                public float BurstDurationMax;
                public float BurstSeparationMin;
                public float BurstSeparationMax;
                public float WeaponDamageModifier;
                public Angle ProjectileError;
                public Angle BurstAngularVelocity;
                public Angle MaximumErrorAngle;
            }
        }

        [TagStructure(Size = 0x1C)]
        public class FiringPatternProperty
        {
            public TagInstance Weapon;
            public List<FiringPattern> FiringPatterns;

            [TagStructure(Size = 0x40)]
            public class FiringPattern
            {
                public float RateOfFire;
                public float TargetTracking;
                public float TargetLeading;
                public float BurstOriginRadius;
                public Angle BurstOriginAngle;
                public float BurstReturnLengthMin;
                public float BurstReturnLengthMax;
                public Angle BurstReturnAngle;
                public float BurstDurationMin;
                public float BurstDurationMax;
                public float BurstSeparationMin;
                public float BurstSeparationMax;
                public float WeaponDamageModifier;
                public Angle ProjectileError;
                public Angle BurstAngularVelocity;
                public Angle MaximumErrorAngle;
            }
        }

        [TagStructure(Size = 0x3C)]
        public class GrenadesProperty
        {
            public int GrenadesFlags;
            public GrenadeTypeValue GrenadeType;
            public TrajectoryTypeValue TrajectoryType;
            public int MinimumEnemyCount;
            public float EnemyRadius;
            public float GrenadeIdealVelocity;
            public float GrenadeVelocity;
            public float GrenadeRangeMin;
            public float GrenadeRangeMax;
            public float CollateralDamageRadius;
            public float GrenadeChance;
            public float GrenadeThrowDelay;
            public float GrenadeUncoverChance;
            public float AntiVehicleGrenadeChance;
            public short DroppedGrenadeCountMin;
            public short DroppedGrenadeCountMax;
            public float DonTDropGrenadesChance;

            public enum GrenadeTypeValue : short
            {
                Frag,
                Plasma,
                Claymore,
                Firebomb,
            }

            public enum TrajectoryTypeValue : short
            {
                Toss,
                Lob,
                Bounce,
            }
        }

        [TagStructure(Size = 0xD0)]
        public class VehicleProperty
        {
            public TagInstance Unit;
            public TagInstance Style;
            public uint VehicleFlags;
            public float AiPathfindingRadius;
            public float AiDestinationRadius;
            public float AiDecelerationDistance;
            public float AiTurningRadius;
            public float AiInnerTurningRadius;
            public float AiIdealTurningRadius;
            public Angle AiBansheeSteeringMaximum;
            public float AiMaxSteeringAngle;
            public float AiMaxSteeringDelta;
            public float AiOversteeringScale;
            public Angle AiOversteeringBoundsMin;
            public Angle AiOversteeringBoundsMax;
            public float AiSideSlipDistance;
            public float AiAvoidanceDistance;
            public float AiMinimumUrgency;
            public Angle Unknown;
            public uint Unknown2;
            public float AiThrottleMaximum;
            public float AiGoalMinimumThrottleScale;
            public float AiTurnMinimumThrottleScale;
            public float AiDirectionMinimumThrottleScale;
            public float AiAccelerationScale;
            public float AiThrottleBlend;
            public float TheoreticalMaxSpeed;
            public float ErrorScale;
            public Angle AiAllowableAimDeviationAngle;
            public float AiChargeTightAngleDistance;
            public float AiChargeTightAngle;
            public float AiChargeRepeatTimeout;
            public float AiChargeLookAheadTime;
            public float AiConsiderDistance;
            public float AiChargeAbortDistance;
            public float VehicleRamTimeout;
            public float RamParalysisTime;
            public float AiCoverDamageThreshold;
            public float AiCoverMinimumDistance;
            public float AiCoverTime;
            public float AiCoverMinimumBoostDistance;
            public float TurtlingRecentDamageThreshold;
            public float TurtlingMinimumTime;
            public float TurtlingTimeout;
            public ObstacleIgnoreSizeValue ObstacleIgnoreSize;
            public short Unknown3;
            public short Unknown4;
            public short Unknown5;

            public enum ObstacleIgnoreSizeValue : short
            {
                None,
                Tiny,
                Small,
                Medium,
                Large,
                Huge,
                Immobile,
            }
        }

        [TagStructure(Size = 0xE4)]
        public class MorphProperty
        {
            public TagInstance MorphCharacter1;
            public TagInstance MorphCharacter2;
            public TagInstance MorphCharacter3;
            public TagInstance MorphMuffin;
            public TagInstance MorphWeapon1;
            public TagInstance MorphWeapon2;
            public TagInstance MorphWeapon3;
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;
            public uint Unknown5;
            public uint Unknown6;
            public uint Unknown7;
            public uint Unknown8;
            public TagInstance Character;
            public uint Unknown9;
            public StringId Unknown10;
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
        }

        [TagStructure(Size = 0x24)]
        public class EquipmentProperty
        {
            public TagInstance Equipment;
            public uint Unknown;
            public float UsageChance;
            public List<UsageCondition> UsageConditions;

            [TagStructure(Size = 0xC)]
            public class UsageCondition
            {
                public short Unknown;
                public short Unknown2;
                public uint Unknown3;
                public uint Unknown4;
            }
        }

        [TagStructure(Size = 0x8)]
        public class MetagameProperty
        {
            public byte Flags;
            public UnitValue Unit;
            public ClassificationValue Classification;
            public sbyte Unknown;
            public short Points;
            public short Unknown2;

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
                Engineer,
                EngineerRechargeStation,
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

        [TagStructure(Size = 0x1C)]
        public class ActAttachment
        {
            public StringId Name;
            public TagInstance ChildObject;
            public StringId ChildMarker;
            public StringId ParentMarker;
        }
    }
}
