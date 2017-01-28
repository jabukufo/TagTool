using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "ai_globals", Class = "aigl", Size = 0x10)]
    public class AiGlobals
    {
        public List<AiData> Data;

        [TagField(Padding = true, Length = 4)]
        public byte[] Unused;

        [TagStructure(Size = 0x144)]
        public class AiData
        {
            public float InfantryOnAiWeaponDamageScale;
            public float VehicleOnAiWeaponDamageScale;
            public float PlayerOnAiWeaponDamageScale;
            public float DangerBroadlyFacing;
            public float DangerShootingNear;
            public float DangerShootingAt;
            public float DangerExtremelyClose;
            public float DangerShieldDamage;
            public float DangerExtendedShieldDamage;
            public float DangerBodyDamage;
            public float DangerExtendedBodyDamage;
            public CachedTagInstance GlobalDialogue;
            public StringId DefaultMissionDialogueSoundEffect;
            public float JumpDown;
            public float JumpStep;
            public float JumpCrouch;
            public float JumpStand;
            public float JumpStorey;
            public float JumpTower;
            public float MaxJumpDownHeightDown;
            public float MaxJumpDownHeightStep;
            public float MaxJumpDownHeightCrouch;
            public float MaxJumpDownHeightStand;
            public float MaxJumpDownHeightStorey;
            public float MaxJumpDownHeightTower;
            public Bounds<float> HoistStep;
            public Bounds<float> HoistCrouch;
            public Bounds<float> HoistStand;
            public Bounds<float> VaultStep;
            public Bounds<float> VaultCrouch;
            public float SearchRangeInfantry;
            public float SearchRangeFlying;
            public float SearchRangeVehicle;
            public float SearchRangeGiant;
            public List<GravemindProperty> GravemindProperties;
            public float ScaryTargetThreshold;
            public float ScaryWeaponThreshold;
            public float PlayerScariness;
            public float BerserkingActorScariness;
            public float KamikazeingActorScariness;
            public float InvincibleActorScariness;
            public float MinimumDeathTime;
            public float ProjectileDistance;
            public float IdleClumpDistance;
            public float DangerousClumpDistance;
            public float ConverSearchDuration;
            public float TaskSearchDuration;
            public uint Unknown18;
            public List<Style> Styles;
            public List<Formation> Formations;
            public List<Template> SquadTemplates;
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

            [TagStructure(Size = 0xC)]
            public class GravemindProperty
            {
                public float MinimumRetreatTime;
                public float IdealRetreatTime;
                public float MaximumRetreatTime;
            }

            [TagStructure(Size = 0x10)]
            public class Style
            {
                public CachedTagInstance Style2;
            }

            [TagStructure(Size = 0x10)]
            public class Formation
            {
                public CachedTagInstance Formations;
            }

            [TagStructure(Size = 0x10)]
            public class Template
            {
                public CachedTagInstance SquadTemplate;
            }
        }
    }
}
