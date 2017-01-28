using System.Collections.Generic;
using TagTool.Common;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "chud_globals_definition", Class = "chgd", Size = 0x2C0)]
    public class ChudGlobalsDefinition
    {
        public List<HudGlobal> HudGlobals;
        public List<HudShader> HudShaders;
        public List<UnknownBlock> Unknown;
        public List<UnknownBlock2> Unknown2;
        public List<PlayerTrainingDatum> PlayerTrainingData;
        public CachedTagInstance StartMenuEmblems;
        public CachedTagInstance CampaignMedals;
        public CachedTagInstance CampaignMedalHudAnimation;
        public short Unknown3;
        public short Unknown4;
        public float CampaignMedalScale;
        public float CampaignMedalSpacing;
        public float CampaignMedalOffsetX;
        public float CampaignMedalOffsetY;
        public float MetagameScoreboardTopY;
        public float MetagameScoreboardSpacing;
        public CachedTagInstance UnitDamageGrid;
        public float MicroTextureTileAmount;
        public float MediumSensorBlipScale;
        public float SmallSensorBlipScale;
        public float LargeSensorBlipScale;
        public float SensorBlipGlowAmount;
        public float SensorBlipGlowRadius;
        public float SensorBlipGlowOpacity;
        public CachedTagInstance MotionSensorBlip;
        public CachedTagInstance BirthdayPartyEffect;
        public CachedTagInstance CampaignFloodMask;
        public CachedTagInstance CampaignFloodMaskTile;
        public uint Unknown5;
        public uint Unknown6;
        public uint Unknown7;
        public uint Unknown8;
        public uint Unknown9;
        public uint Unknown10;
        public uint Unknown11;
        public uint Unknown12;
        public uint Unknown13;
        public uint Unknownundefined;
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
        public byte[] Unknown27;
        public uint Unknown28;
        public uint Unknown29;
        public uint Unknown30;
        public uint Unknown31;
        public uint Unknown32;
        public uint Unknown33;
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
        public byte[] Unknown44;
        public uint Unknown45;
        public uint Unknown46;
        public uint Unknown47;
        public CachedTagInstance Unknown48;
        public uint Unknown49;
        public byte[] Unknown50;
        public byte[] Unknown51;
        public byte[] Unknown52;
        public byte[] Unknown53;
        public byte[] Unknown54;
        public uint Unknown55;
        public byte[] Unknown56;
        public byte[] Unknown57;
        public byte[] Unknown58;
        public byte[] Unknown59;
        public byte[] Unknown60;
        public CachedTagInstance Unknown61;
        public uint Unknown62;
        public uint Unknown63;
        public uint Unknown64;

        [TagStructure(Size = 0x4)]
        public class RgbaColor
        {
            public byte R;
            public byte G;
            public byte B;
            public byte A;
        }

        [TagStructure(Size = 0x2B0)]
        public class HudGlobal
        {
            public BipedValue Biped;
            [TagField(Count = 37)] public RgbaColor[] Colors;
            public List<HudAttribute> HudAttributes;
            public List<HudSound> HudSounds;
            public CachedTagInstance Unknown;
            public CachedTagInstance FragGrenadeSwapSound;
            public CachedTagInstance PlasmaGrenadeSwapSound;
            public CachedTagInstance SpikeGrenadeSwapSound;
            public CachedTagInstance FirebombGrenadeSwapSound;
            public CachedTagInstance DamageMicrotexture;
            public CachedTagInstance DamageNoise;
            public CachedTagInstance DirectionalArrow;
            public CachedTagInstance Unknown2;
            public CachedTagInstance Unknown3;
            public uint Unknown4;
            public uint Unknown5;
            public uint Unknown6;
            public uint Unknown7;
            public uint Unknown8;
            public uint Unknown9;
            public CachedTagInstance Waypoints;
            public CachedTagInstance Unknown10;
            public CachedTagInstance ScoreboardHud;
            public CachedTagInstance MetagameScoreboardHud;
            public CachedTagInstance SurvivalHud;
            public CachedTagInstance MetagameScoreboardHud2;
            public CachedTagInstance TheaterHud;
            public CachedTagInstance ForgeHud;
            public CachedTagInstance HudStrings;
            public CachedTagInstance Medals;
            public List<MultiplayerMedal> MultiplayerMedals;
            public CachedTagInstance MedalHudAnimation;
            public CachedTagInstance MedalHudAnimation2;
            public CachedTagInstance CortanaChannel;
            public CachedTagInstance Unknown11;
            public CachedTagInstance Unknown12;
            public CachedTagInstance Unknown13;
            public CachedTagInstance Unknown14;
            public uint Unknown15;
            public uint Unknown16;
            public float GrenadeScematicsSpacing;
            public float EquipmentScematicOffsetY;
            public float DualEquipmentScematicOffsetY;
            public uint Unknown17;
            public uint Unknown18;
            public float ScoreboardLeaderOffsetY;
            public uint Unknown19;
            public float WaypointScale;
            public uint Unknown20;

            public enum BipedValue : int
            {
                Spartan,
                Elite,
                Monitor,
            }

            [TagStructure(Size = 0xE8)]
            public class HudAttribute
            {
                public uint ResolutionFlags;
                public Angle WarpAngle;
                public float WarpAmount;
                public float WarpDirection;
                public uint ResolutionWidth;
                public uint ResolutionHeight;
                public float MotionSensorOffsetX;
                public float MotionSensorOffsetY;
                public float MotionSensorRadius;
                public float MotionSensorScale;
                public float HorizontalScale;
                public float VerticalScale;
                public float HorizontalStretch;
                public float VerticalStretch;
                public CachedTagInstance Unknown;
                public CachedTagInstance Unknown2;
                public CachedTagInstance FirstPersonDamageBorder;
                public CachedTagInstance ThirdPersonDamageBorder;
                public uint Unknown3;
                public uint Unknown4;
                public uint Unknown5;
                public uint Unknown6;
                public uint Unknown7;
                public uint Unknown8;
                public uint Unknown9;
                public float StateCenterOffsetY;
                public uint Unknown10;
                public uint Unknown11;
                public uint Unknown12;
                public uint Unknown13;
                public uint Unknown14;
                public uint Unknown15;
                public uint Unknown16;
                public uint Unknown17;
                public float NotificationScale;
                public float NotificationLineSpacing;
                public uint Unknown18;
                public uint Unknown19;
                public float NotificationOffsetY;
                public uint Unknown20;
                public uint Unknown21;
                public uint Unknown22;
                public uint Unknown23;
                public uint Unknown24;
                public uint Unknown25;
                public uint Unknown26;
            }

            [TagStructure(Size = 0x14, MaxVersion = CacheVersion.HaloOnline449175)]
            [TagStructure(Size = 0x18, MinVersion = CacheVersion.HaloOnline498295)]
            public class HudSound
            {
                public uint LatchedTo;
                [MinVersion(CacheVersion.HaloOnline498295)] public uint LatchedTo2;
                public float Scale;
                public List<UnknownBlock> Unknown;

                [TagStructure(Size = 0x14)]
                public class UnknownBlock
                {
                    public BipedValue Biped;
                    public CachedTagInstance Sound;

                    public enum BipedValue : int
                    {
                        Spartan,
                        Elite,
                        Monitor,
                    }
                }
            }

            [TagStructure(Size = 0x4)]
            public class MultiplayerMedal
            {
                public StringId Medal;
            }
        }

        [TagStructure(Size = 0x20)]
        public class HudShader
        {
            public CachedTagInstance VertexShader;
            public CachedTagInstance PixelShader;
        }

        [TagStructure(Size = 0x40)]
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
        }

        [TagStructure(Size = 0x10)]
        public class UnknownBlock2
        {
            public uint Unknown;
            public List<UnknownBlock> Unknown2;

            [TagStructure(Size = 0xE4)]
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
                public CachedTagInstance Sound;
                public uint Unknown26;
                public uint Unknown27;
                public uint Unknown28;
                public uint Unknown29;
                public uint Unknown30;
                public uint Unknown31;
                public uint Unknown32;
                public uint Unknown33;
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
                public CachedTagInstance Sound2;
            }
        }

        [TagStructure(Size = 0x14)]
        public class PlayerTrainingDatum
        {
            public StringId DisplayString;
            public short MaxDisplayTime;
            public short DisplayCount;
            public short DisappearDelay;
            public short RedisplayDelay;
            public float DisplayDelay;
            public ushort Flags;
            public short Unknown;
        }
    }
}
