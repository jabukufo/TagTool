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
        /// <summary>
        /// Creature reference for swarm characters ONLY
        /// </summary>
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
        public List<FlockingProperty> FlockingProperties;
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
        public List<CombatformProperty> CombatformProperties;
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
            [TagField(Padding = true, Length = 2)]
            public byte[] Padding;
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
            None = 0,
            Swarm = 1 << 0,
            Flying = 1 << 1,
            DualWields = 1 << 2,
            UsesGravemind = 1 << 3,
            DoNotTradeWeapon = 1 << 5,
            DoNotStowWeapon = 1 << 6,
            HeroCharacter = 1 << 7,
            LeaderIndependentPositioning = 1 << 8,
            HasActiveCamo = 1 << 9,
            UseHeadMarkerForLooking = 1 << 10,
            SpaceCharacter = 1 << 11,
            DoNotDropEquipment = 1 << 12,
            DoNotAllowCrouch = 1 << 13,
            DoNotAllowMovingCrouch = 1 << 14,
            CriticalBetrayal = 1 << 15,
            DeathlessCriticalBetrayal = 1 << 16,
            /// <summary>
            /// Non-depleted ai-tracked damage sections prevent instant melee kills.
            /// </summary>
            ArmorPreventsAssassination = 1 << 17,
            /// <summary>
            /// The default is to drop only the currently equipped weapon.
            /// </summary>
            DropAllWeaponsOnDeath = 1 << 18,
            /// <summary>
            /// This will override 'drop all weapons'.
            /// </summary>
            DropNoWeaponsOnDeath = 1 << 19,
            /// <summary>
            /// Cannot be assassinated unless its shield has been depleted.
            /// </summary>
            ShieldPreventsAssassination = 1 << 20,
            /// <summary>
            /// This overrides all other character assassination modifications.
            /// </summary>
            CannotBeAssassinated = 1 << 21
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

            /// <summary>
            /// The rank of this character, helps determine who should be a squad leader. (0 is lowly, 32767 is highest)
            /// </summary>
            public short Rank;

            /// <summary>
            /// Where should my followers try and position themselves when I am their leader?
            /// </summary>
            public FollowerPositioningValue FollowerPositioning;

            [TagField(Padding = true, Length = 2)]
            public byte[] Padding;

            /// <summary>
            /// Don't let my combat range get outside this distance from my leader when in combat. (if 0 then defaults to 4wu)
            /// </summary>
            public float MaximumLeaderDistance;

            /// <summary>
            /// Never play dialogue if all players are outside of this range. (if 0 then defaults to 20wu)
            /// </summary>
            public float MaximumPlayerDialogueDistance;

            /// <summary>
            /// The inherent scariness of the character.
            /// </summary>
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
            public Bounds<float> StunTimeBounds;
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
            [TagField(Padding = true, Length = 4)]
            public byte[] Padding;

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

        [Flags]
        public enum MovementFlags : int
        {
            None = 0,
            DangerCrouchAllowMovement = 1 << 0,
            NoSideStep = 1 << 1,
            PreferToCombatNearFriends = 1 << 2,
            AllowBoostedJump = 1 << 3,
            Perch = 1 << 4,
            Climb = 1 << 5,
            PreferWallMovement = 1 << 6,
            HasFlyingMode = 1 << 7,
            DisallowCrouch = 1 << 8,
            DisallowAllMovement = 1 << 9,
            AlwaysUseSearchPoints = 1 << 10,
            KeepMoving = 1 << 11,
            CureIsolationJump = 1 << 12,
            GainElevation = 1 << 13,
            RepositionDistant = 1 << 14,
            OnlyUseAerialFiringPositions = 1 << 15,
            UseHighPriorityPathFinding = 1 << 16,
            LowerWeaponWhenNoAlertMovementOverride = 1 << 17,
            Phase = 1 << 18,
            NoOverrideWhenFiring = 1 << 19,
            NoStowDuringIdleActivities = 1 << 20,
            FlipAnyVehicle = 1 << 21,
            BoundAlongPath = 1 << 22
        }

        [Flags]
        public enum MovementHintFlags : int
        {
            None = 0,
            VaultStep = 1 << 0,
            VaultCrouch = 1 << 1,
            MountStep = 1 << 5,
            MountCrouch = 1 << 6,
            MountStand = 1 << 7,
            HoistCrouch = 1 << 11,
            HoistStand = 1 << 12
        }

        [TagStructure(Size = 0x2C)]
        public class MovementProperty
        {
            public MovementFlags Flags;
            public float PathfindingRadius;
            public float DestinationRadius;
            public float DiveGrenadeChance;
            public SizeValue ObstacleLeapMinimumSize;
            public SizeValue ObstacleLeapMaximumSize;
            public SizeValue ObstacleIgnoreSize;
            public SizeValue ObstaceSmashableSize;
            public JumpHeightValue JumpHeight;
            public MovementHintFlags HintFlags;
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;

            public enum SizeValue : short
            {
                None,
                Tiny,
                Small,
                Medium,
                Large,
                Huge,
                Immobile
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
                Infinite
            }
        }

        [TagStructure(Size = 0x18)]
        public class FlockingProperty
        {
            public float DecelerationDistance;
            public float NormalizedSpeed;
            public float BufferDistance;
            public Bounds<float> ThrottleThresholdBOunds;
            public float DecelerationStopTime;
        }

        [TagStructure(Size = 0x38)]
        public class SwarmProperty
        {
            public short ScatterKilledCount;

            [TagField(Padding = true, Length = 2)]
            public byte[] Padding;

            public float ScatterRadius;
            public float ScatterTime;
            public Bounds<float> HoundDistance;
            public Bounds<float> InfectionTime;
            public float PerlinOffsetScale;
            public Bounds<float> OffsetPeriod;
            public float PerlinIdleMovementThreshold;
            public float PerlinCombatMovementThreshold;
            public float StuckTime;
            public float StuckDistance;
        }

        [TagStructure(Size = 0x8)]
        public class ReadyProperty
        {
            public Bounds<float> ReadTimeBounds;
        }

        [Flags]
        public enum EngageFlags : int
        {
            None = 0,
            DefendThreatAxis = 1 << 0,
            FightConstantMovement = 1 << 1,
            FlightFightConstantMovement = 1 << 2,
            DisallowCombatCrouching = 1 << 3,
            DisallowCrouchShooting = 1 << 4,
            FightStable = 1 << 5,
            ThrowShouldLob = 1 << 6,
            AllowPositioningBeyondIdealRange = 1 << 7,
            CanSuppress = 1 << 8,
            PrefersBunker = 1 << 9,
            BurstInhibitsEvasion = 1 << 10
        }

        [TagStructure(Size = 0x38)]
        public class EngageProperty
        {
            public EngageFlags Flags;
            public uint Unknown;
            public float CrouchDangerThreshold;
            public float StandDangerThreshold;
            public float FightDangerMoveThreshold;
            public Bounds<short> FightDangerMoveThresholdCooldown;
            public TagInstance OverrideGrenadeProjectile;
            public uint Unknown4;
            public uint Unknown5;
            public uint Unknown6;
            public uint Unknown7;
        }

        [Flags]
        public enum ChargeFlags : int
        {
            None = 0,
            OffhandMeleeAllowed = 1 << 0,
            BerserkWheneverCharge = 1 << 1,
            DoNotUseBerserkMode = 1 << 2,
            DoNotStowWeaponDuringBerserk = 1 << 3,
            AllowDialogueWhileBerserking = 1 << 4,
            DoNotPlayBerserkAnimation = 1 << 5,
            DoNotShootDuringCharge = 1 << 6,
            AllowLeapWithRangedWeapons = 1 << 7,
            PermanentBerserkOnceInitiated = 1 << 8
        }

        [TagStructure(Size = 0x7C)]
        public class ChargeProperty
        {
            public ChargeFlags Flags;
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
            public List<DifficultyLimit> DifficultyLimits;

            [TagStructure(Size = 0x6)]
            public class DifficultyLimit
            {
                public short MaximumKamikazeCount;
                public short MaximumBerserkCount;
                public short MinimumBerserkCount;
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

        [Flags]
        public enum CoverFlags : int
        {
            None = 0,
            UsePhasing = 1 << 1
        }

        [TagStructure(Size = 0x54)]
        public class CoverProperty
        {
            public CoverFlags Flags;
            public Bounds<float> HideBehindCoverTime;
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
            public float VitalityFractionShieldEquipment;
            public float RecentDamageShieldEquipment;
            public float MinimumEnemyDistance;
        }

        [Flags]
        public enum RetreatFlags : int
        {
            None = 0,
            ZigZagWhenFleeing = 1 << 0
        }

        [TagStructure(Size = 0x58)]
        public class RetreatProperty
        {
            public RetreatFlags Flags;
            public float ShieldThreshold;
            public float ScaryTargetThreshold;
            public float DangerThreshold;
            public float ProximityThreshold;
            public Bounds<float> ForcedCowerTimeBounds;
            public Bounds<float> CowerTimeBounds;
            public float ProximityAmbushThreshold;
            public float AwarenessAmbushThreshold;
            public float LeaderDeadRetreatChance;
            public float PeerDeadRetreatChance;
            public float SecondPeerDeadRetreatChance;
            public float FleeTimeout;
            public Angle ZigZagAngle;
            public float ZigZagPeriod;
            public float RetreatGrenadeChance;
            public TagInstance BackupWeapon;
        }

        [Flags]
        public enum SearchFlags : int
        {
            None = 0,
            CrouchOnInvestigate = 1 << 0,
            WalkOnPursuit = 1 << 1,
            SearchForever = 1 << 2,
            SearchExclusively = 1 << 3,
            SearchPointsOnlyWhileWalking = 1 << 4
        }

        [TagStructure(Size = 0x20)]
        public class SearchProperty
        {
            public SearchFlags Flags;
            public Bounds<float> SearchTime;
            public float SearchDistance;
            public Bounds<float> UncoverDistanceBounds;
            public Bounds<float> VocalizationTime;
        }

        [Flags]
        public enum PreSearchFlags : int
        {
            None = 0,
            Flag1 = 1 << 0
        }

        [TagStructure(Size = 0x28)]
        public class PreSearchProperty
        {
            public PreSearchFlags Flags;
            public Bounds<float> MinimumPreSearchTime;
            public Bounds<float> MaximumPreSearchTime;
            public float MinimumCertaintyRadius;
            public uint Unknown;
            public Bounds<float> MinimumSuppressingTime;
            public short Unknown2;
            public short Unknown3;
        }

        [TagStructure(Size = 0x14)]
        public class IdleProperty
        {
            [TagField(Padding = true, Length = 4)]
            public byte[] Padding;
            public Bounds<float> IdlePoseDelayTime;
            public Bounds<float> WanderDelayTime;
        }

        [TagStructure(Size = 0xC)]
        public class VocalizationProperty
        {
            public float CharacterSkipFraction;
            public float LookCommentTime;
            public float LookLongCommentTime;
        }

        [Flags]
        public enum BoardingFlags : int
        {
            None = 0,
            AirborneBoarding = 1 << 0
        }

        [TagStructure(Size = 0x14)]
        public class BoardingProperty
        {
            public BoardingFlags Flags;
            public float MaximumDistance;
            public float AbortDistance;
            public float MaximumSpeed;
            public float BoardTime;
        }

        [TagStructure(Size = 0x8)]
        public class CombatformProperty
        {
            /// <summary>
            /// Distance at which the combatform will be forced into berserking.
            /// </summary>
            public float BerserkDistance;

            /// <summary>
            /// Chance of which the combatform will be forced into berserking this second.
            /// </summary>
            public float BerserkChance;
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
