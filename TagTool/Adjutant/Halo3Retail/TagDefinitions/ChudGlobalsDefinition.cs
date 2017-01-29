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
	[TagStructure(Class = "chgd", Size = 0xF0)]
	public class ChudGlobalsDefinition
	{
		public List<HudGlobal> HudGlobals;
		public List<HudShader> HudShaders;
		public List<UnknownBlock> Unknown;
		public List<UnknownBlock2> Unknown2;
		public List<PlayerTrainingDatum> PlayerTrainingData;
		public TagInstance StartMenuEmblems;
		public TagInstance CampaignMedals;
		public TagInstance CampaignMedalHudAnimation;
		public float CampaignMedalScale;
		public float CampaignMedalSpacing;
		public float CampaignMedalOffsetX;
		public float CampaignMedalOffsetY;
		public float MetagameScoreboardTopY;
		public float MetagameScoreboardSpacing;
		public TagInstance UnitDamageGrid;
		public float MicroTextureTileAmount;
		public float MediumSensorBlipScale;
		public float SmallSensorBlipScale;
		public float LargeSensorBlipScale;
		public float SensorBlipGlowAmount;
		public float SensorBlipGlowRadius;
		public float SensorBlipGlowOpacity;
		public TagInstance MotionSensorBlip;
		public TagInstance BirthdayPartyEffect;
		public TagInstance CampaignFloodMask;
		public TagInstance CampaignFloodMaskTile;

		[TagStructure(Size = 0x208)]
		public class HudGlobal
		{
			public BipedValue Biped;
			public byte _0Alpha;
			public byte _0HudDisabledR;
			public byte _0HudDisabledG;
			public byte _0HudDisabledB;
			public byte _1Alpha;
			public byte _1HudPrimaryR;
			public byte _1HudPrimaryG;
			public byte _1HudPrimaryB;
			public byte _2Alpha;
			public byte _2HudForegroundR;
			public byte _2HudForegroundG;
			public byte _2HudForegroundB;
			public byte _3Alpha;
			public byte _3HudWarningR;
			public byte _3HudWarningG;
			public byte _3HudWarningB;
			public byte _4Alpha;
			public byte _4NeutralReticuleR;
			public byte _4NeutralReticuleG;
			public byte _4NeutralReticuleB;
			public byte _5Alpha;
			public byte _5HostileReticuleR;
			public byte _5HostileReticuleG;
			public byte _5HostileReticuleB;
			public byte _6Alpha;
			public byte _6FriendlyReticuleR;
			public byte _6FriendlyReticuleG;
			public byte _6FriendlyReticuleB;
			public byte _7Alpha;
			public byte _7R;
			public byte _7G;
			public byte _7B;
			public byte _8Alpha;
			public byte _8NeutralBlipR;
			public byte _8NeutralBlipG;
			public byte _8NeutralBlipB;
			public byte _9Alpha;
			public byte _9HostileBlipR;
			public byte _9HostileBlipG;
			public byte _9HostileBlipB;
			public byte _10Alpha;
			public byte _10FriendlyPlayerBlipR;
			public byte _10FriendlyPlayerBlipG;
			public byte _10FriendlyPlayerBlipB;
			public byte _11Alpha;
			public byte _11FriendlyAiBlipR;
			public byte _11FriendlyAiBlipG;
			public byte _11FriendlyAiBlipB;
			public byte _12Alpha;
			public byte _12R;
			public byte _12G;
			public byte _12B;
			public byte _13Alpha;
			public byte _13WaypointBlipR;
			public byte _13WaypointBlipG;
			public byte _13WaypointBlipB;
			public byte _14Alpha;
			public byte _14DistantWaypointBlipR;
			public byte _14DistantWaypointBlipG;
			public byte _14DistantWaypointBlipB;
			public byte _15Alpha;
			public byte _15WaypointR;
			public byte _15WaypointG;
			public byte _15WaypointB;
			public byte _16Alpha;
			public byte _16R;
			public byte _16G;
			public byte _16B;
			public byte _17Alpha;
			public byte _17R;
			public byte _17G;
			public byte _17B;
			public byte _18Alpha;
			public byte _18R;
			public byte _18G;
			public byte _18B;
			public byte _19Alpha;
			public byte _19R;
			public byte _19G;
			public byte _19B;
			public byte _20Alpha;
			public byte _20R;
			public byte _20G;
			public byte _20B;
			public byte _21Alpha;
			public byte _21R;
			public byte _21G;
			public byte _21B;
			public byte _22Alpha;
			public byte _22TextFadeInR;
			public byte _22TextFadeInG;
			public byte _22TextFadeInB;
			public byte _23Alpha;
			public byte _23R;
			public byte _23G;
			public byte _23B;
			public byte _24Alpha;
			public byte _24R;
			public byte _24G;
			public byte _24B;
			public byte _25Alpha;
			public byte _25R;
			public byte _25G;
			public byte _25B;
			public byte _26Alpha;
			public byte _26R;
			public byte _26G;
			public byte _26B;
			public byte _27Alpha;
			public byte _27R;
			public byte _27G;
			public byte _27B;
			public List<HudAttribute> HudAttributes;
			public List<HudSound> HudSounds;
			public TagInstance Unknown;
			public TagInstance FragGrenadeSwapSound;
			public TagInstance PlasmaGrenadeSwapSound;
			public TagInstance SpikeGrenadeSwapSound;
			public TagInstance FirebombGrenadeSwapSound;
			public TagInstance DamageMicrotexture;
			public TagInstance DamageNoise;
			public TagInstance DirectionalArrow;
			public TagInstance Waypoints;
			public TagInstance ScoreboardHud;
			public TagInstance MetagameScoreboardHud;
			public TagInstance TheaterHud;
			public TagInstance ForgeHud;
			public TagInstance HudStrings;
			public TagInstance Medals;
			public List<MultiplayerMedal> MultiplayerMedals;
			public TagInstance MedalHudAnimation;
			public TagInstance CortanaChannel;
			public TagInstance Unknown2;
			public TagInstance Unknown3;
			public TagInstance JammerResponse;
			public TagInstance JammerShieldHit;
			public float GrenadeScematicsSpacing;
			public float EquipmentScematicOffsetY;
			public float DualEquipmentScematicOffsetY;
			public float Unknown4;
			public float Unknown5;
			public float ScoreboardLeaderOffsetY;
			public uint Unknown6;
			public float WaypointScale;

			public enum BipedValue : int
			{
				Spartan,
				Elite,
				Monitor,
			}

			[TagStructure(Size = 0x60)]
			public class HudAttribute
			{
				public ResolutionFlagsValue ResolutionFlags;
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
				public float NotificationOffsetY;
				public float StateLeftRightOffsetY;
				public float StateCenterOffsetY;
				public float Unknown;
				public float Unknown2;
				public float Unknown3;
				public float StateScale;
				public float NotificationScale;
				public float NotificationLineSpacing;
				public short Unknown4;
				public short Unknown5;

				public enum ResolutionFlagsValue : int
				{
					None,
					WideFull,
					WideHalf,
					Bit2 = 4,
					StandardFull = 8,
					WideQuarter = 16,
					StandardHalf = 32,
					Bit6 = 64,
					StandardQuarter = 128,
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

			[TagStructure(Size = 0x28)]
			public class HudSound
			{
				public TagInstance SpartanSound;
				public LatchedToValue LatchedTo;
				public float Scale;
				public TagInstance EliteSound;

				public enum LatchedToValue : int
				{
					None,
					ShieldRecharging,
					ShieldDamaged,
					ShieldLow = 4,
					ShieldEmpty = 8,
					HealthLow = 16,
					HealthEmpty = 32,
					HealthMinorDamage = 64,
					HealthMajorDamage = 128,
					RocketLocking = 256,
					RocketLocked = 512,
					MissileLocking = 1024,
					MissileLocked = 2048,
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

			[TagStructure(Size = 0x4)]
			public class MultiplayerMedal
			{
				public StringID Medal;
			}
		}

		[TagStructure(Size = 0x20)]
		public class HudShader
		{
			public TagInstance VertexShader;
			public TagInstance PixelShader;
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
				public TagInstance Sound;
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
				public TagInstance Sound2;
			}
		}

		[TagStructure(Size = 0x14)]
		public class PlayerTrainingDatum
		{
			public StringID DisplayString;
			public short MaxDisplayTime;
			public short DisplayCount;
			public short DisappearDelay;
			public short RedisplayDelay;
			public float DisplayDelay;
			public FlagsValue Flags;
			public short Unknown;

			public enum FlagsValue : ushort
			{
				None,
				NotInMultiplayer,
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
	}
}
