using System.Collections.Generic;
using TagTool.Common;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "projectile", Class = "proj", Size = 0x1AC, MaxVersion = CacheVersion.HaloOnline449175)]
    [TagStructure(Name = "projectile", Class = "proj", Size = 0x1B4, MinVersion = CacheVersion.HaloOnline498295)]
    public class Projectile : GameObject
    {
        public uint Flags2;
        public DetonationTimerStartsValue DetonationTimerStarts;
        public ImpactNoiseValue ImpactNoise;
        public float CollisionRadius;
        public float ArmingTime;
        public float DangerRadius;
        public float TimerMin;
        public float TimerMax;
        public float MinimumVelocity;
        public float MaximumRange;
        public float DetonationChargeTime;
        [MinVersion(CacheVersion.HaloOnline498295)] public uint Unknown17;
        [MinVersion(CacheVersion.HaloOnline498295)] public uint Unknown18;
        public DetonationNoiseValue DetonationNoise;
        public short SuperDetonationProjectileCount;
        public float SuperDetonationDelay;
        public CachedTagInstance DetonationStarted;
        public CachedTagInstance AirborneDetonationEffect;
        public CachedTagInstance GroundDetonationEffect;
        public CachedTagInstance DetonationDamage;
        public CachedTagInstance AttachedDetonationDamage;
        public CachedTagInstance SuperDetonation;
        public CachedTagInstance SuperDetonationDamage;
        public CachedTagInstance DetonationSound;
        public DamageReportingTypeValue DamageReportingType;
        public sbyte Unknown6;
        public sbyte Unknown7;
        public sbyte Unknown8;
        public CachedTagInstance AttachedSuperDetonationDamage;
        public float MaterialEffectRadius;
        public CachedTagInstance FlybySound;
        public CachedTagInstance FlybyResponse;
        public CachedTagInstance ImpactEffect;
        public CachedTagInstance ImpactDamage;
        public float BoardingDetonationTime;
        public CachedTagInstance BoardingDetonationDamage;
        public CachedTagInstance BoardingAttachedDetonationDamage;
        public float AirGravityScale;
        public float AirDamageRangeMin;
        public float AirDamageRangeMax;
        public float WaterGravityScale;
        public float WaterDamageScaleMin;
        public float WaterDamageScaleMax;
        public float InitialVelocity;
        public float FinalVelocity;
        public uint Unknown9;
        public uint Unknown10;
        public Angle GuidedAngularVelocityLower;
        public Angle GuidedAngularVelocityUpper;
        public Angle Unknown11;
        public float AccelerationRangeMin;
        public float AccelerationRangeMax;
        public uint Unknown12;
        public uint Unknown13;
        public float TargetedLeadingFraction;
        public uint Unknown14;
        public uint Unknown15;
        public List<MaterialRespons> MaterialResponses;
        public List<ImpactProperty> ImpactProperties;
        public List<UnknownBlock> Unknown16;
        public List<ShotgunProperty> ShotgunProperties;

        public enum DetonationTimerStartsValue : short
        {
            Immediately,
            AfterFirstBounce,
            WhenAtRest,
            AfterFirstBounceOffAnySurface,
        }

        public enum ImpactNoiseValue : short
        {
            Silent,
            Medium,
            Loud,
            Shout,
            Quiet,
        }

        public enum DetonationNoiseValue : short
        {
            Silent,
            Medium,
            Loud,
            Shout,
            Quiet,
        }

        public enum DamageReportingTypeValue : sbyte
        {
            GuardiansUnknown,
            Guardians,
            FallingDamage,
            GenericCollision,
            ArmorLockCrush,
            GenericMelee,
            GenericExplosion,
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
            ShadeTurret,
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
            Dmr,
        }

        [TagStructure(Size = 0x40)]
        public class MaterialRespons
        {
            public ushort Flags;
            public ResponseValue Response;
            public StringId MaterialName;
            public short GlobalMaterialIndex;
            public short Unknown;
            public ResponseValue2 Response2;
            public ushort Flags2;
            public float ChanceFraction;
            public Angle BetweenAngleMin;
            public Angle BetweenAngleMax;
            public float AndVelocityMin;
            public float AndVelocityMax;
            public ScaleEffectsByValue ScaleEffectsBy;
            public short Unknown2;
            public Angle AngularNoise;
            public float VelocityNoise;
            public float InitialFriction;
            public float MaximumDistance;
            public float ParallelFriction;
            public float PerpendicularFriction;

            public enum ResponseValue : short
            {
                ImpactDetonate,
                Fizzle,
                Overpenetrate,
                Attach,
                Bounce,
                BounceDud,
                FizzleRicochet,
            }

            public enum ResponseValue2 : short
            {
                ImpactDetonate,
                Fizzle,
                Overpenetrate,
                Attach,
                Bounce,
                BounceDud,
                FizzleRicochet,
            }

            public enum ScaleEffectsByValue : short
            {
                Damage,
                Angle,
            }
        }

        [TagStructure(Size = 0x30)]
        public class ImpactProperty
        {
            public Angle Unknown;
            public Angle Unknown2;
            public Angle Unknown3;
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

        [TagStructure(Size = 0x4)]
        public class UnknownBlock
        {
            public uint Unknown;
        }

        [TagStructure(Size = 0xC)]
        public class ShotgunProperty
        {
            public short Amount;
            public short Distance;
            public float Accuracy;
            public Angle SpreadConeAngle;
        }
    }
}
