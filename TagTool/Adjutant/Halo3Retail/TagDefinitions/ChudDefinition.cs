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
	[TagStructure(Class = "chdt", Size = 0x18)]
	public class ChudDefinition
	{
		public List<HudWidget> HudWidgets;
		public int LowClipCutoff;
		public int LowAmmoCutoff;
		public int AgeCutoff;

		[TagStructure(Size = 0x50)]
		public class HudWidget
		{
			public StringID Name;
			public SpecialHudTypeValue SpecialHudType;
			public byte Unknown;
			public byte Unknown2;
			public List<StateDatum> StateData;
			public List<PlacementDatum> PlacementData;
			public List<AnimationDatum> AnimationData;
			public List<RenderDatum> RenderData;
			public List<BitmapWidget> BitmapWidgets;
			public List<TextWidget> TextWidgets;

			public enum SpecialHudTypeValue : short
			{
				Unspecial,
				Ammo,
				CrosshairAndScope,
				UnitShieldMeter,
				Grenades,
				Gametype,
				MotionSensor,
				SpikeGrenade,
				FirebombGrenade,
			}

			[TagStructure(Size = 0x28)]
			public class StateDatum
			{
				public _1EngineValue _1Engine;
				public _2Value _2;
				public _3Value _3;
				public _4ResolutionValue _4Resolution;
				public _5ScoreboardValue _5Scoreboard;
				public _6Value _6;
				public _7EditorValue _7Editor;
				public _8Value _8;
				public _9Value _9;
				public _10Value _10;
				public _11Value _11;
				public _12Value _12;
				public _13Value _13;
				public _14Value _14;
				public _15Value _15;
				public _16Value _16;
				public _17Value _17;
				public _18AmmoValue _18Ammo;
				public _19Value _19;
				public short Unknown;

				public enum _1EngineValue : ushort
				{
					None,
					Bit0,
					Bit1,
					Bit2 = 4,
					Bit3 = 8,
					CaptureTheFlag = 16,
					Slayer = 32,
					Oddball = 64,
					KingOfTheHill = 128,
					Juggernaut = 256,
					Territories = 512,
					Assault = 1024,
					Vip = 2048,
					Infection = 4096,
					Bit13 = 8192,
					Editor = 16384,
					Theater = 32768,
				}

				public enum _2Value : ushort
				{
					None,
					Biped1,
					Biped2,
					Biped3 = 4,
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

				public enum _3Value : ushort
				{
					None,
					Offense,
					Defense,
					FreeForAll = 4,
					Bit3 = 8,
					Bit4 = 16,
					Bit5 = 32,
					TalkingDisabled = 64,
					TapToTalk = 128,
					TalkingEnabled = 256,
					NotTalking = 512,
					Talking = 1024,
					Bit11 = 2048,
					Bit12 = 4096,
					Bit13 = 8192,
					Bit14 = 16384,
					Bit15 = 32768,
				}

				public enum _4ResolutionValue : ushort
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

				public enum _5ScoreboardValue : ushort
				{
					None,
					HasFriends,
					HasEnemies,
					HasVariantName = 4,
					SomeoneIsTalking = 8,
					IsArming = 16,
					TimeEnabled = 32,
					FriendsHaveX = 64,
					EnemiesHaveX = 128,
					FriendsAreX = 256,
					EnemiesAreX = 512,
					XIsDown = 1024,
					SummaryEnabled = 2048,
					Netdebug = 4096,
					Bit13 = 8192,
					Bit14 = 16384,
					Bit15 = 32768,
				}

				public enum _6Value : ushort
				{
					None,
					TextureCamEnabled,
					Autoaim,
					Bit2 = 4,
					Bit3 = 8,
					TrainingPrompt = 16,
					ObjectivePrompt = 32,
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

				public enum _7EditorValue : ushort
				{
					None,
					EditorInactive,
					EditorActive,
					EditorHolding = 4,
					EditorNotAllowed = 8,
					IsEditorBiped = 16,
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

				public enum _8Value : ushort
				{
					None,
					MotionTracker10m,
					MotionTracker25m,
					MotionTracker75m = 4,
					MotionTracker150m = 8,
					Bit4 = 16,
					Bit5 = 32,
					MetagamePlayer2Exists = 64,
					Bit7 = 128,
					MetagamePlayer3Exists = 256,
					Bit9 = 512,
					MetagamePlayer4Exists = 1024,
					Bit11 = 2048,
					MetagameScoreAdded = 4096,
					Bit13 = 8192,
					MetagameScoreRemoved = 16384,
					Bit15 = 32768,
				}

				public enum _9Value : ushort
				{
					None,
					PickupGrenades,
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

				public enum _10Value : ushort
				{
					None,
					BinocularsEnabled,
					UnitIsZoomedLevel1,
					UnitIsZoomedLevel2 = 4,
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

				public enum _11Value : ushort
				{
					None,
					PrimaryWeapon,
					SecondaryWeapon,
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

				public enum _12Value : ushort
				{
					None,
					MotionTrackerEnabled,
					Bit1,
					SelectedFragGrenades = 4,
					SelectedPlasmaGrenades = 8,
					SelectedSpikeGrenades = 16,
					SelectedFireGrenades = 32,
					Bit6 = 64,
					Bit7 = 128,
					Bit8 = 256,
					Bit9 = 512,
					Bit10 = 1024,
					Bit11 = 2048,
					Has1xOvershield = 4096,
					Has2xOvershield = 8192,
					Has3xOvershield = 16384,
					HasShields = 32768,
				}

				public enum _13Value : ushort
				{
					None,
					Bit0,
					PickupAmmo,
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

				public enum _14Value : ushort
				{
					None,
					PrimaryWeapon,
					SecondaryWeapon,
					Backpack = 4,
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

				public enum _15Value : ushort
				{
					None,
					NotAutoaim,
					AutoaimFriendly,
					AutoaimEnemy = 4,
					AutoaimHeadshot = 8,
					Bit4 = 16,
					Bit5 = 32,
					Bit6 = 64,
					PlasmaLockedOn = 128,
					Bit8 = 256,
					Bit9 = 512,
					Bit10 = 1024,
					Bit11 = 2048,
					Bit12 = 4096,
					Bit13 = 8192,
					Bit14 = 16384,
					Bit15 = 32768,
				}

				public enum _16Value : ushort
				{
					None,
					Bit0,
					MissileLocked,
					MissileLocking = 4,
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

				public enum _17Value : ushort
				{
					None,
					Bit0,
					Bit1,
					HasFragGrenades = 4,
					HasPlasmaGrenades = 8,
					HasSpikeGrenades = 16,
					HasFireGrenades = 32,
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

				public enum _18AmmoValue : ushort
				{
					None,
					ClipWarning,
					AmmoWarning,
					Bit2 = 4,
					Bit3 = 8,
					LowBattery1 = 16,
					LowBattery2 = 32,
					Overheated = 64,
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

				public enum _19Value : ushort
				{
					None,
					BinocularsEnabled,
					UnitIsZoomedLevel1,
					UnitIsZoomedLevel2 = 4,
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

			[TagStructure(Size = 0x1C)]
			public class PlacementDatum
			{
				public AnchorValue Anchor;
				public short Unknown;
				public float MirrorOffsetX;
				public float MirrorOffsetY;
				public float OffsetX;
				public float OffsetY;
				public float ScaleX;
				public float ScaleY;

				public enum AnchorValue : short
				{
					TopLeft,
					TopRight,
					BottomRight,
					BottomLeft,
					Center,
					TopEdge,
					GrenadeA,
					GrenadeB,
					GrenadeC,
					GrenadeD,
					ScoreboardFriendly,
					ScoreboardEnemy,
					HealthAndShield,
					BottomEdge,
					Unknown,
					Equipment,
					Unknown2,
					Depreciated,
					Depreciated2,
					Depreciated3,
					Depreciated4,
					Depreciated5,
					Unknown3,
					Gametype,
					Unknown4,
					StateRight,
					StateLeft,
					StateCenter,
					Unknown5,
					GametypeFriendly,
					GametypeEnemy,
					MetagameTop,
					MetagamePlayer1,
					MetagamePlayer2,
					MetagamePlayer3,
					MetagamePlayer4,
					Theater,
				}
			}

			[TagStructure(Size = 0x78)]
			public class AnimationDatum
			{
				public Animation1FlagsValue Animation1Flags;
				public Animation1FunctionValue Animation1Function;
				public TagInstance Animation1;
				public Animation2FlagsValue Animation2Flags;
				public Animation2FunctionValue Animation2Function;
				public TagInstance Animation2;
				public Animation3FlagsValue Animation3Flags;
				public Animation3FunctionValue Animation3Function;
				public TagInstance Animation3;
				public Animation4FlagsValue Animation4Flags;
				public Animation4FunctionValue Animation4Function;
				public TagInstance Animation4;
				public Animation5FlagsValue Animation5Flags;
				public Animation5FunctionValue Animation5Function;
				public TagInstance Animation5;
				public Animation6FlagsValue Animation6Flags;
				public Animation6FunctionValue Animation6Function;
				public TagInstance Animation6;

				public enum Animation1FlagsValue : ushort
				{
					None,
					ReverseFrames,
				}

				public enum Animation1FunctionValue : short
				{
					Default,
					UseInput,
					UseRangeInput,
					Zero,
				}

				public enum Animation2FlagsValue : ushort
				{
					None,
					ReverseFrames,
				}

				public enum Animation2FunctionValue : short
				{
					Default,
					UseInput,
					UseRangeInput,
					Zero,
				}

				public enum Animation3FlagsValue : ushort
				{
					None,
					ReverseFrames,
				}

				public enum Animation3FunctionValue : short
				{
					Default,
					UseInput,
					UseRangeInput,
					Zero,
				}

				public enum Animation4FlagsValue : ushort
				{
					None,
					ReverseFrames,
				}

				public enum Animation4FunctionValue : short
				{
					Default,
					UseInput,
					UseRangeInput,
					Zero,
				}

				public enum Animation5FlagsValue : ushort
				{
					None,
					ReverseFrames,
				}

				public enum Animation5FunctionValue : short
				{
					Default,
					UseInput,
					UseRangeInput,
					Zero,
				}

				public enum Animation6FlagsValue : ushort
				{
					None,
					ReverseFrames,
				}

				public enum Animation6FunctionValue : short
				{
					Default,
					UseInput,
					UseRangeInput,
					Zero,
				}
			}

			[TagStructure(Size = 0x40)]
			public class RenderDatum
			{
				public ShaderIndexValue ShaderIndex;
				public short Unknown;
				public InputValue Input;
				public RangeInputValue RangeInput;
				public byte LocalColorAlphaA;
				public byte LocalColorAR;
				public byte LocalColorAG;
				public byte LocalColorAB;
				public byte LocalColorAlphaB;
				public byte LocalColorBR;
				public byte LocalColorBG;
				public byte LocalColorBB;
				public byte LocalColorAlphaC;
				public byte LocalColorCR;
				public byte LocalColorCG;
				public byte LocalColorCB;
				public byte LocalColorAlphaD;
				public byte LocalColorDR;
				public byte LocalColorDG;
				public byte LocalColorDB;
				public float LocalScalarA;
				public float LocalScalarB;
				public float LocalScalarC;
				public float LocalScalarD;
				public OutputColorAValue OutputColorA;
				public OutputColorBValue OutputColorB;
				public OutputColorCValue OutputColorC;
				public OutputColorDValue OutputColorD;
				public OutputColorEValue OutputColorE;
				public OutputColorFValue OutputColorF;
				public OutputScalarAValue OutputScalarA;
				public OutputScalarBValue OutputScalarB;
				public OutputScalarCValue OutputScalarC;
				public OutputScalarDValue OutputScalarD;
				public OutputScalarEValue OutputScalarE;
				public OutputScalarFValue OutputScalarF;

				public enum ShaderIndexValue : short
				{
					Simple,
					Meter,
					TextSimple,
					MeterShield,
					MeterGradient,
					Crosshair,
					DirectionalDamage,
					Solid,
					Sensor,
					MeterSingleColor,
					Navpoint,
					Medal,
					TextureCam,
					CortanaScreen,
					CortanaCamera,
					CortanaOffscreen,
					CortanaScreenFinal,
					MeterChapter,
					MeterDoubleGradient,
					MeterRadialGradient,
					Turbulence,
					Emblem,
					CortanaComposite,
					DirectionalDamageApply,
					ReallySimple,
				}

				public enum InputValue : short
				{
					Zero,
					One,
					Time,
					Fade,
					UnitShieldCurrent,
					UnitShield,
					ClipAmmoFraction,
					TotalAmmoFraction,
					HeatFraction,
					BatteryFraction,
					Pickup,
					UnitAutoaimed,
					Grenade,
					GrenadeFraction,
					ChargeFraction,
					FriendlyScore,
					EnemyScore,
					ScoreToWin,
					ArmingFraction,
					Unknown,
					Unit1xOvershieldCurrent,
					Unit1xOvershield,
					Unit2xOvershieldCurrent,
					Unit2xOvershield,
					Unit3xOvershieldCurrent,
					Unit3xOvershield,
					AimYaw,
					AimPitch,
					TargetDistance,
					TargetElevation,
					EditorBudget,
					EditorBudgetCost,
					FilmTotalTime,
					FilmCurrentTime,
					Unknown2,
					FilmTimelineFraction1,
					FilmTimelineFraction2,
					Unknown3,
					Unknown4,
					MetagameTime,
					MetagameScoreTransient,
					MetagameScorePlayer1,
					MetagameScorePlayer2,
					MetagameScorePlayer3,
					MetagameScorePlayer4,
					MetagameModifier,
					Unknown5,
					SensorRange,
					NetdebugLatency,
					NetdebugLatencyQuality,
					NetdebugHostQuality,
					NetdebugLocalQuality,
					MetagameScoreNegative,
				}

				public enum RangeInputValue : short
				{
					Zero,
					One,
					Time,
					Fade,
					UnitShieldCurrent,
					UnitShield,
					ClipAmmoFraction,
					TotalAmmoFraction,
					HeatFraction,
					BatteryFraction,
					Pickup,
					UnitAutoaimed,
					Grenade,
					GrenadeFraction,
					ChargeFraction,
					FriendlyScore,
					EnemyScore,
					ScoreToWin,
					ArmingFraction,
					Unknown,
					Unit1xOvershieldCurrent,
					Unit1xOvershield,
					Unit2xOvershieldCurrent,
					Unit2xOvershield,
					Unit3xOvershieldCurrent,
					Unit3xOvershield,
					AimYaw,
					AimPitch,
					TargetDistance,
					TargetElevation,
					EditorBudget,
					EditorBudgetCost,
					FilmTotalTime,
					FilmCurrentTime,
					Unknown2,
					FilmTimelineFraction1,
					FilmTimelineFraction2,
					Unknown3,
					Unknown4,
					MetagameTime,
					MetagameScoreTransient,
					MetagameScorePlayer1,
					MetagameScorePlayer2,
					MetagameScorePlayer3,
					MetagameScorePlayer4,
					MetagameModifier,
					Unknown5,
					SensorRange,
					NetdebugLatency,
					NetdebugLatencyQuality,
					NetdebugHostQuality,
					NetdebugLocalQuality,
					MetagameScoreNegative,
				}

				public enum OutputColorAValue : short
				{
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown4,
					Unknown5,
					ScoreboardFriendly,
					ScoreboardEnemy,
					ArmingTeam,
					MetagamePlayer1,
					MetagamePlayer2,
					MetagamePlayer3,
					MetagamePlayer4,
					Unknown13,
					GlobalDynamic0,
					GlobalDynamic1,
					GlobalDynamic2,
					GlobalDynamic3,
					GlobalDynamic4,
					GlobalDynamic5,
					GlobalDynamic6,
					GlobalDynamic7,
					GlobalDynamic8,
					GlobalDynamic9,
					GlobalDynamic10,
					GlobalDynamic11,
					GlobalDynamic12,
					GlobalDynamic13,
					GlobalDynamic14,
					GlobalDynamic15,
					GlobalDynamic16,
					GlobalDynamic17,
					GlobalDynamic18,
					GlobalDynamic19,
					GlobalDynamic20,
					GlobalDynamic21,
					GlobalDynamic22,
					GlobalDynamic23,
					GlobalDynamic24,
					GlobalDynamic25,
					GlobalDynamic26,
					GlobalDynamic27,
				}

				public enum OutputColorBValue : short
				{
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown4,
					Unknown5,
					ScoreboardFriendly,
					ScoreboardEnemy,
					ArmingTeam,
					MetagamePlayer1,
					MetagamePlayer2,
					MetagamePlayer3,
					MetagamePlayer4,
					Unknown13,
					GlobalDynamic0,
					GlobalDynamic1,
					GlobalDynamic2,
					GlobalDynamic3,
					GlobalDynamic4,
					GlobalDynamic5,
					GlobalDynamic6,
					GlobalDynamic7,
					GlobalDynamic8,
					GlobalDynamic9,
					GlobalDynamic10,
					GlobalDynamic11,
					GlobalDynamic12,
					GlobalDynamic13,
					GlobalDynamic14,
					GlobalDynamic15,
					GlobalDynamic16,
					GlobalDynamic17,
					GlobalDynamic18,
					GlobalDynamic19,
					GlobalDynamic20,
					GlobalDynamic21,
					GlobalDynamic22,
					GlobalDynamic23,
					GlobalDynamic24,
					GlobalDynamic25,
					GlobalDynamic26,
					GlobalDynamic27,
				}

				public enum OutputColorCValue : short
				{
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown4,
					Unknown5,
					ScoreboardFriendly,
					ScoreboardEnemy,
					ArmingTeam,
					MetagamePlayer1,
					MetagamePlayer2,
					MetagamePlayer3,
					MetagamePlayer4,
					Unknown13,
					GlobalDynamic0,
					GlobalDynamic1,
					GlobalDynamic2,
					GlobalDynamic3,
					GlobalDynamic4,
					GlobalDynamic5,
					GlobalDynamic6,
					GlobalDynamic7,
					GlobalDynamic8,
					GlobalDynamic9,
					GlobalDynamic10,
					GlobalDynamic11,
					GlobalDynamic12,
					GlobalDynamic13,
					GlobalDynamic14,
					GlobalDynamic15,
					GlobalDynamic16,
					GlobalDynamic17,
					GlobalDynamic18,
					GlobalDynamic19,
					GlobalDynamic20,
					GlobalDynamic21,
					GlobalDynamic22,
					GlobalDynamic23,
					GlobalDynamic24,
					GlobalDynamic25,
					GlobalDynamic26,
					GlobalDynamic27,
				}

				public enum OutputColorDValue : short
				{
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown4,
					Unknown5,
					ScoreboardFriendly,
					ScoreboardEnemy,
					ArmingTeam,
					MetagamePlayer1,
					MetagamePlayer2,
					MetagamePlayer3,
					MetagamePlayer4,
					Unknown13,
					GlobalDynamic0,
					GlobalDynamic1,
					GlobalDynamic2,
					GlobalDynamic3,
					GlobalDynamic4,
					GlobalDynamic5,
					GlobalDynamic6,
					GlobalDynamic7,
					GlobalDynamic8,
					GlobalDynamic9,
					GlobalDynamic10,
					GlobalDynamic11,
					GlobalDynamic12,
					GlobalDynamic13,
					GlobalDynamic14,
					GlobalDynamic15,
					GlobalDynamic16,
					GlobalDynamic17,
					GlobalDynamic18,
					GlobalDynamic19,
					GlobalDynamic20,
					GlobalDynamic21,
					GlobalDynamic22,
					GlobalDynamic23,
					GlobalDynamic24,
					GlobalDynamic25,
					GlobalDynamic26,
					GlobalDynamic27,
				}

				public enum OutputColorEValue : short
				{
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown4,
					Unknown5,
					ScoreboardFriendly,
					ScoreboardEnemy,
					ArmingTeam,
					MetagamePlayer1,
					MetagamePlayer2,
					MetagamePlayer3,
					MetagamePlayer4,
					Unknown13,
					GlobalDynamic0,
					GlobalDynamic1,
					GlobalDynamic2,
					GlobalDynamic3,
					GlobalDynamic4,
					GlobalDynamic5,
					GlobalDynamic6,
					GlobalDynamic7,
					GlobalDynamic8,
					GlobalDynamic9,
					GlobalDynamic10,
					GlobalDynamic11,
					GlobalDynamic12,
					GlobalDynamic13,
					GlobalDynamic14,
					GlobalDynamic15,
					GlobalDynamic16,
					GlobalDynamic17,
					GlobalDynamic18,
					GlobalDynamic19,
					GlobalDynamic20,
					GlobalDynamic21,
					GlobalDynamic22,
					GlobalDynamic23,
					GlobalDynamic24,
					GlobalDynamic25,
					GlobalDynamic26,
					GlobalDynamic27,
				}

				public enum OutputColorFValue : short
				{
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown4,
					Unknown5,
					ScoreboardFriendly,
					ScoreboardEnemy,
					ArmingTeam,
					MetagamePlayer1,
					MetagamePlayer2,
					MetagamePlayer3,
					MetagamePlayer4,
					Unknown13,
					GlobalDynamic0,
					GlobalDynamic1,
					GlobalDynamic2,
					GlobalDynamic3,
					GlobalDynamic4,
					GlobalDynamic5,
					GlobalDynamic6,
					GlobalDynamic7,
					GlobalDynamic8,
					GlobalDynamic9,
					GlobalDynamic10,
					GlobalDynamic11,
					GlobalDynamic12,
					GlobalDynamic13,
					GlobalDynamic14,
					GlobalDynamic15,
					GlobalDynamic16,
					GlobalDynamic17,
					GlobalDynamic18,
					GlobalDynamic19,
					GlobalDynamic20,
					GlobalDynamic21,
					GlobalDynamic22,
					GlobalDynamic23,
					GlobalDynamic24,
					GlobalDynamic25,
					GlobalDynamic26,
					GlobalDynamic27,
				}

				public enum OutputScalarAValue : short
				{
					Input,
					RangeInput,
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown6,
					Unknown7,
				}

				public enum OutputScalarBValue : short
				{
					Input,
					RangeInput,
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown6,
					Unknown7,
				}

				public enum OutputScalarCValue : short
				{
					Input,
					RangeInput,
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown6,
					Unknown7,
				}

				public enum OutputScalarDValue : short
				{
					Input,
					RangeInput,
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown6,
					Unknown7,
				}

				public enum OutputScalarEValue : short
				{
					Input,
					RangeInput,
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown6,
					Unknown7,
				}

				public enum OutputScalarFValue : short
				{
					Input,
					RangeInput,
					LocalA,
					LocalB,
					LocalC,
					LocalD,
					Unknown6,
					Unknown7,
				}
			}

			[TagStructure(Size = 0x54)]
			public class BitmapWidget
			{
				public StringID Name;
				public SpecialHudTypeValue SpecialHudType;
				public byte Unknown;
				public byte Unknown2;
				public List<StateDatum> StateData;
				public List<PlacementDatum> PlacementData;
				public List<AnimationDatum> AnimationData;
				public List<RenderDatum> RenderData;
				public int WidgetIndex;
				public FlagsValue Flags;
				public short Unknown3;
				public TagInstance Bitmap;
				public byte BitmapSpriteIndex;
				public byte Unknown4;
				public byte Unknown5;
				public byte Unknown6;

				public enum SpecialHudTypeValue : short
				{
					Unspecial,
					Ammo,
					CrosshairAndScope,
					UnitShieldMeter,
					Grenades,
					Gametype,
					MotionSensor,
					SpikeGrenade,
					FirebombGrenade,
				}

				[TagStructure(Size = 0x28)]
				public class StateDatum
				{
					public _1EngineValue _1Engine;
					public _2Value _2;
					public _3Value _3;
					public _4ResolutionValue _4Resolution;
					public _5ScoreboardValue _5Scoreboard;
					public _6Value _6;
					public _7EditorValue _7Editor;
					public _8Value _8;
					public _9Value _9;
					public _10Value _10;
					public _11Value _11;
					public _12Value _12;
					public _13Value _13;
					public _14Value _14;
					public _15Value _15;
					public _16Value _16;
					public _17Value _17;
					public _18AmmoValue _18Ammo;
					public _19Value _19;
					public short Unknown;

					public enum _1EngineValue : ushort
					{
						None,
						Bit0,
						Bit1,
						Bit2 = 4,
						Bit3 = 8,
						CaptureTheFlag = 16,
						Slayer = 32,
						Oddball = 64,
						KingOfTheHill = 128,
						Juggernaut = 256,
						Territories = 512,
						Assault = 1024,
						Vip = 2048,
						Infection = 4096,
						Bit13 = 8192,
						Editor = 16384,
						Theater = 32768,
					}

					public enum _2Value : ushort
					{
						None,
						Biped1,
						Biped2,
						Biped3 = 4,
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

					public enum _3Value : ushort
					{
						None,
						Offense,
						Defense,
						FreeForAll = 4,
						Bit3 = 8,
						Bit4 = 16,
						Bit5 = 32,
						TalkingDisabled = 64,
						TapToTalk = 128,
						TalkingEnabled = 256,
						NotTalking = 512,
						Talking = 1024,
						Bit11 = 2048,
						Bit12 = 4096,
						Bit13 = 8192,
						Bit14 = 16384,
						Bit15 = 32768,
					}

					public enum _4ResolutionValue : ushort
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

					public enum _5ScoreboardValue : ushort
					{
						None,
						HasFriends,
						HasEnemies,
						HasVariantName = 4,
						SomeoneIsTalking = 8,
						IsArming = 16,
						TimeEnabled = 32,
						FriendsHaveX = 64,
						EnemiesHaveX = 128,
						FriendsAreX = 256,
						EnemiesAreX = 512,
						XIsDown = 1024,
						SummaryEnabled = 2048,
						Netdebug = 4096,
						Bit13 = 8192,
						Bit14 = 16384,
						Bit15 = 32768,
					}

					public enum _6Value : ushort
					{
						None,
						TextureCamEnabled,
						Autoaim,
						Bit2 = 4,
						Bit3 = 8,
						TrainingPrompt = 16,
						ObjectivePrompt = 32,
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

					public enum _7EditorValue : ushort
					{
						None,
						EditorInactive,
						EditorActive,
						EditorHolding = 4,
						EditorNotAllowed = 8,
						IsEditorBiped = 16,
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

					public enum _8Value : ushort
					{
						None,
						MotionTracker10m,
						MotionTracker25m,
						MotionTracker75m = 4,
						MotionTracker150m = 8,
						Bit4 = 16,
						Bit5 = 32,
						MetagamePlayer2Exists = 64,
						Bit7 = 128,
						MetagamePlayer3Exists = 256,
						Bit9 = 512,
						MetagamePlayer4Exists = 1024,
						Bit11 = 2048,
						MetagameScoreAdded = 4096,
						Bit13 = 8192,
						MetagameScoreRemoved = 16384,
						Bit15 = 32768,
					}

					public enum _9Value : ushort
					{
						None,
						PickupGrenades,
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

					public enum _10Value : ushort
					{
						None,
						BinocularsEnabled,
						UnitIsZoomedLevel1,
						UnitIsZoomedLevel2 = 4,
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

					public enum _11Value : ushort
					{
						None,
						PrimaryWeapon,
						SecondaryWeapon,
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

					public enum _12Value : ushort
					{
						None,
						MotionTrackerEnabled,
						Bit1,
						SelectedFragGrenades = 4,
						SelectedPlasmaGrenades = 8,
						SelectedSpikeGrenades = 16,
						SelectedFireGrenades = 32,
						Bit6 = 64,
						Bit7 = 128,
						Bit8 = 256,
						Bit9 = 512,
						Bit10 = 1024,
						Bit11 = 2048,
						Has1xOvershield = 4096,
						Has2xOvershield = 8192,
						Has3xOvershield = 16384,
						HasShields = 32768,
					}

					public enum _13Value : ushort
					{
						None,
						Bit0,
						PickupAmmo,
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

					public enum _14Value : ushort
					{
						None,
						PrimaryWeapon,
						SecondaryWeapon,
						Backpack = 4,
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

					public enum _15Value : ushort
					{
						None,
						NotAutoaim,
						AutoaimFriendly,
						AutoaimEnemy = 4,
						AutoaimHeadshot = 8,
						Bit4 = 16,
						Bit5 = 32,
						Bit6 = 64,
						PlasmaLockedOn = 128,
						Bit8 = 256,
						Bit9 = 512,
						Bit10 = 1024,
						Bit11 = 2048,
						Bit12 = 4096,
						Bit13 = 8192,
						Bit14 = 16384,
						Bit15 = 32768,
					}

					public enum _16Value : ushort
					{
						None,
						Bit0,
						MissileLocked,
						MissileLocking = 4,
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

					public enum _17Value : ushort
					{
						None,
						Bit0,
						Bit1,
						HasFragGrenades = 4,
						HasPlasmaGrenades = 8,
						HasSpikeGrenades = 16,
						HasFireGrenades = 32,
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

					public enum _18AmmoValue : ushort
					{
						None,
						ClipWarning,
						AmmoWarning,
						Bit2 = 4,
						Bit3 = 8,
						LowBattery1 = 16,
						LowBattery2 = 32,
						Overheated = 64,
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

					public enum _19Value : ushort
					{
						None,
						BinocularsEnabled,
						UnitIsZoomedLevel1,
						UnitIsZoomedLevel2 = 4,
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

				[TagStructure(Size = 0x1C)]
				public class PlacementDatum
				{
					public AnchorValue Anchor;
					public short Unknown;
					public float MirrorOffsetX;
					public float MirrorOffsetY;
					public float OffsetX;
					public float OffsetY;
					public float ScaleX;
					public float ScaleY;

					public enum AnchorValue : short
					{
						TopLeft,
						TopRight,
						BottomRight,
						BottomLeft,
						Center,
						TopEdge,
						GrenadeA,
						GrenadeB,
						GrenadeC,
						GrenadeD,
						ScoreboardFriendly,
						ScoreboardEnemy,
						HealthAndShield,
						BottomEdge,
						Unknown,
						Equipment,
						Unknown2,
						Depreciated,
						Depreciated2,
						Depreciated3,
						Depreciated4,
						Depreciated5,
						Unknown3,
						Gametype,
						Unknown4,
						StateRight,
						StateLeft,
						StateCenter,
						Unknown5,
						GametypeFriendly,
						GametypeEnemy,
						MetagameTop,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Theater,
					}
				}

				[TagStructure(Size = 0x78)]
				public class AnimationDatum
				{
					public Animation1FlagsValue Animation1Flags;
					public Animation1FunctionValue Animation1Function;
					public TagInstance Animation1;
					public Animation2FlagsValue Animation2Flags;
					public Animation2FunctionValue Animation2Function;
					public TagInstance Animation2;
					public Animation3FlagsValue Animation3Flags;
					public Animation3FunctionValue Animation3Function;
					public TagInstance Animation3;
					public Animation4FlagsValue Animation4Flags;
					public Animation4FunctionValue Animation4Function;
					public TagInstance Animation4;
					public Animation5FlagsValue Animation5Flags;
					public Animation5FunctionValue Animation5Function;
					public TagInstance Animation5;
					public Animation6FlagsValue Animation6Flags;
					public Animation6FunctionValue Animation6Function;
					public TagInstance Animation6;

					public enum Animation1FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation1FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation2FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation2FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation3FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation3FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation4FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation4FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation5FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation5FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation6FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation6FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}
				}

				[TagStructure(Size = 0x40)]
				public class RenderDatum
				{
					public ShaderIndexValue ShaderIndex;
					public short Unknown;
					public InputValue Input;
					public RangeInputValue RangeInput;
					public byte LocalColorAlphaA;
					public byte LocalColorAR;
					public byte LocalColorAG;
					public byte LocalColorAB;
					public byte LocalColorAlphaB;
					public byte LocalColorBR;
					public byte LocalColorBG;
					public byte LocalColorBB;
					public byte LocalColorAlphaC;
					public byte LocalColorCR;
					public byte LocalColorCG;
					public byte LocalColorCB;
					public byte LocalColorAlphaD;
					public byte LocalColorDR;
					public byte LocalColorDG;
					public byte LocalColorDB;
					public float LocalScalarA;
					public float LocalScalarB;
					public float LocalScalarC;
					public float LocalScalarD;
					public OutputColorAValue OutputColorA;
					public OutputColorBValue OutputColorB;
					public OutputColorCValue OutputColorC;
					public OutputColorDValue OutputColorD;
					public OutputColorEValue OutputColorE;
					public OutputColorFValue OutputColorF;
					public OutputScalarAValue OutputScalarA;
					public OutputScalarBValue OutputScalarB;
					public OutputScalarCValue OutputScalarC;
					public OutputScalarDValue OutputScalarD;
					public OutputScalarEValue OutputScalarE;
					public OutputScalarFValue OutputScalarF;

					public enum ShaderIndexValue : short
					{
						Simple,
						Meter,
						TextSimple,
						MeterShield,
						MeterGradient,
						Crosshair,
						DirectionalDamage,
						Solid,
						Sensor,
						MeterSingleColor,
						Navpoint,
						Medal,
						TextureCam,
						CortanaScreen,
						CortanaCamera,
						CortanaOffscreen,
						CortanaScreenFinal,
						MeterChapter,
						MeterDoubleGradient,
						MeterRadialGradient,
						Turbulence,
						Emblem,
						CortanaComposite,
						DirectionalDamageApply,
						ReallySimple,
					}

					public enum InputValue : short
					{
						Zero,
						One,
						Time,
						Fade,
						UnitShieldCurrent,
						UnitShield,
						ClipAmmoFraction,
						TotalAmmoFraction,
						HeatFraction,
						BatteryFraction,
						Pickup,
						UnitAutoaimed,
						Grenade,
						GrenadeFraction,
						ChargeFraction,
						FriendlyScore,
						EnemyScore,
						ScoreToWin,
						ArmingFraction,
						Unknown,
						Unit1xOvershieldCurrent,
						Unit1xOvershield,
						Unit2xOvershieldCurrent,
						Unit2xOvershield,
						Unit3xOvershieldCurrent,
						Unit3xOvershield,
						AimYaw,
						AimPitch,
						TargetDistance,
						TargetElevation,
						EditorBudget,
						EditorBudgetCost,
						FilmTotalTime,
						FilmCurrentTime,
						Unknown2,
						FilmTimelineFraction1,
						FilmTimelineFraction2,
						Unknown3,
						Unknown4,
						MetagameTime,
						MetagameScoreTransient,
						MetagameScorePlayer1,
						MetagameScorePlayer2,
						MetagameScorePlayer3,
						MetagameScorePlayer4,
						MetagameModifier,
						Unknown5,
						SensorRange,
						NetdebugLatency,
						NetdebugLatencyQuality,
						NetdebugHostQuality,
						NetdebugLocalQuality,
						MetagameScoreNegative,
					}

					public enum RangeInputValue : short
					{
						Zero,
						One,
						Time,
						Fade,
						UnitShieldCurrent,
						UnitShield,
						ClipAmmoFraction,
						TotalAmmoFraction,
						HeatFraction,
						BatteryFraction,
						Pickup,
						UnitAutoaimed,
						Grenade,
						GrenadeFraction,
						ChargeFraction,
						FriendlyScore,
						EnemyScore,
						ScoreToWin,
						ArmingFraction,
						Unknown,
						Unit1xOvershieldCurrent,
						Unit1xOvershield,
						Unit2xOvershieldCurrent,
						Unit2xOvershield,
						Unit3xOvershieldCurrent,
						Unit3xOvershield,
						AimYaw,
						AimPitch,
						TargetDistance,
						TargetElevation,
						EditorBudget,
						EditorBudgetCost,
						FilmTotalTime,
						FilmCurrentTime,
						Unknown2,
						FilmTimelineFraction1,
						FilmTimelineFraction2,
						Unknown3,
						Unknown4,
						MetagameTime,
						MetagameScoreTransient,
						MetagameScorePlayer1,
						MetagameScorePlayer2,
						MetagameScorePlayer3,
						MetagameScorePlayer4,
						MetagameModifier,
						Unknown5,
						SensorRange,
						NetdebugLatency,
						NetdebugLatencyQuality,
						NetdebugHostQuality,
						NetdebugLocalQuality,
						MetagameScoreNegative,
					}

					public enum OutputColorAValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorBValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorCValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorDValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorEValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorFValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputScalarAValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarBValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarCValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarDValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarEValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarFValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}
				}

				public enum FlagsValue : ushort
				{
					None,
					MirrorHorizontally,
					MirrorVertically,
					StretchEdges = 4,
					EnableTextureCam = 8,
					Looping = 16,
					Bit5 = 32,
					Player1Emblem = 64,
					Player2Emblem = 128,
					Player3Emblem = 256,
					Player4Emblem = 512,
					Bit10 = 1024,
					Bit11 = 2048,
					Bit12 = 4096,
					Bit13 = 8192,
					Bit14 = 16384,
					Bit15 = 32768,
				}
			}

			[TagStructure(Size = 0x44)]
			public class TextWidget
			{
				public StringID Name;
				public SpecialHudTypeValue SpecialHudType;
				public byte Unknown;
				public byte Unknown2;
				public List<StateDatum> StateData;
				public List<PlacementDatum> PlacementData;
				public List<AnimationDatum> AnimationData;
				public List<RenderDatum> RenderData;
				public int WidgetIndex;
				public FlagsValue Flags;
				public FontValue Font;
				public StringID String;

				public enum SpecialHudTypeValue : short
				{
					Unspecial,
					Ammo,
					CrosshairAndScope,
					UnitShieldMeter,
					Grenades,
					Gametype,
					MotionSensor,
					SpikeGrenade,
					FirebombGrenade,
				}

				[TagStructure(Size = 0x28)]
				public class StateDatum
				{
					public _1EngineValue _1Engine;
					public _2Value _2;
					public _3Value _3;
					public _4ResolutionValue _4Resolution;
					public _5ScoreboardValue _5Scoreboard;
					public _6Value _6;
					public _7EditorValue _7Editor;
					public _8Value _8;
					public _9Value _9;
					public _10Value _10;
					public _11Value _11;
					public _12Value _12;
					public _13Value _13;
					public _14Value _14;
					public _15Value _15;
					public _16Value _16;
					public _17Value _17;
					public _18AmmoValue _18Ammo;
					public _19Value _19;
					public short Unknown;

					public enum _1EngineValue : ushort
					{
						None,
						Bit0,
						Bit1,
						Bit2 = 4,
						Bit3 = 8,
						CaptureTheFlag = 16,
						Slayer = 32,
						Oddball = 64,
						KingOfTheHill = 128,
						Juggernaut = 256,
						Territories = 512,
						Assault = 1024,
						Vip = 2048,
						Infection = 4096,
						Bit13 = 8192,
						Editor = 16384,
						Theater = 32768,
					}

					public enum _2Value : ushort
					{
						None,
						Biped1,
						Biped2,
						Biped3 = 4,
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

					public enum _3Value : ushort
					{
						None,
						Offense,
						Defense,
						FreeForAll = 4,
						Bit3 = 8,
						Bit4 = 16,
						Bit5 = 32,
						TalkingDisabled = 64,
						TapToTalk = 128,
						TalkingEnabled = 256,
						NotTalking = 512,
						Talking = 1024,
						Bit11 = 2048,
						Bit12 = 4096,
						Bit13 = 8192,
						Bit14 = 16384,
						Bit15 = 32768,
					}

					public enum _4ResolutionValue : ushort
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

					public enum _5ScoreboardValue : ushort
					{
						None,
						HasFriends,
						HasEnemies,
						HasVariantName = 4,
						SomeoneIsTalking = 8,
						IsArming = 16,
						TimeEnabled = 32,
						FriendsHaveX = 64,
						EnemiesHaveX = 128,
						FriendsAreX = 256,
						EnemiesAreX = 512,
						XIsDown = 1024,
						SummaryEnabled = 2048,
						Netdebug = 4096,
						Bit13 = 8192,
						Bit14 = 16384,
						Bit15 = 32768,
					}

					public enum _6Value : ushort
					{
						None,
						TextureCamEnabled,
						Autoaim,
						Bit2 = 4,
						Bit3 = 8,
						TrainingPrompt = 16,
						ObjectivePrompt = 32,
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

					public enum _7EditorValue : ushort
					{
						None,
						EditorInactive,
						EditorActive,
						EditorHolding = 4,
						EditorNotAllowed = 8,
						IsEditorBiped = 16,
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

					public enum _8Value : ushort
					{
						None,
						MotionTracker10m,
						MotionTracker25m,
						MotionTracker75m = 4,
						MotionTracker150m = 8,
						Bit4 = 16,
						Bit5 = 32,
						MetagamePlayer2Exists = 64,
						Bit7 = 128,
						MetagamePlayer3Exists = 256,
						Bit9 = 512,
						MetagamePlayer4Exists = 1024,
						Bit11 = 2048,
						MetagameScoreAdded = 4096,
						Bit13 = 8192,
						MetagameScoreRemoved = 16384,
						Bit15 = 32768,
					}

					public enum _9Value : ushort
					{
						None,
						PickupGrenades,
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

					public enum _10Value : ushort
					{
						None,
						BinocularsEnabled,
						UnitIsZoomedLevel1,
						UnitIsZoomedLevel2 = 4,
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

					public enum _11Value : ushort
					{
						None,
						PrimaryWeapon,
						SecondaryWeapon,
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

					public enum _12Value : ushort
					{
						None,
						MotionTrackerEnabled,
						Bit1,
						SelectedFragGrenades = 4,
						SelectedPlasmaGrenades = 8,
						SelectedSpikeGrenades = 16,
						SelectedFireGrenades = 32,
						Bit6 = 64,
						Bit7 = 128,
						Bit8 = 256,
						Bit9 = 512,
						Bit10 = 1024,
						Bit11 = 2048,
						Has1xOvershield = 4096,
						Has2xOvershield = 8192,
						Has3xOvershield = 16384,
						HasShields = 32768,
					}

					public enum _13Value : ushort
					{
						None,
						Bit0,
						PickupAmmo,
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

					public enum _14Value : ushort
					{
						None,
						PrimaryWeapon,
						SecondaryWeapon,
						Backpack = 4,
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

					public enum _15Value : ushort
					{
						None,
						NotAutoaim,
						AutoaimFriendly,
						AutoaimEnemy = 4,
						AutoaimHeadshot = 8,
						Bit4 = 16,
						Bit5 = 32,
						Bit6 = 64,
						PlasmaLockedOn = 128,
						Bit8 = 256,
						Bit9 = 512,
						Bit10 = 1024,
						Bit11 = 2048,
						Bit12 = 4096,
						Bit13 = 8192,
						Bit14 = 16384,
						Bit15 = 32768,
					}

					public enum _16Value : ushort
					{
						None,
						Bit0,
						MissileLocked,
						MissileLocking = 4,
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

					public enum _17Value : ushort
					{
						None,
						Bit0,
						Bit1,
						HasFragGrenades = 4,
						HasPlasmaGrenades = 8,
						HasSpikeGrenades = 16,
						HasFireGrenades = 32,
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

					public enum _18AmmoValue : ushort
					{
						None,
						ClipWarning,
						AmmoWarning,
						Bit2 = 4,
						Bit3 = 8,
						LowBattery1 = 16,
						LowBattery2 = 32,
						Overheated = 64,
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

					public enum _19Value : ushort
					{
						None,
						BinocularsEnabled,
						UnitIsZoomedLevel1,
						UnitIsZoomedLevel2 = 4,
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

				[TagStructure(Size = 0x1C)]
				public class PlacementDatum
				{
					public AnchorValue Anchor;
					public short Unknown;
					public float MirrorOffsetX;
					public float MirrorOffsetY;
					public float OffsetX;
					public float OffsetY;
					public float ScaleX;
					public float ScaleY;

					public enum AnchorValue : short
					{
						TopLeft,
						TopRight,
						BottomRight,
						BottomLeft,
						Center,
						TopEdge,
						GrenadeA,
						GrenadeB,
						GrenadeC,
						GrenadeD,
						ScoreboardFriendly,
						ScoreboardEnemy,
						HealthAndShield,
						BottomEdge,
						Unknown,
						Equipment,
						Unknown2,
						Depreciated,
						Depreciated2,
						Depreciated3,
						Depreciated4,
						Depreciated5,
						Unknown3,
						Gametype,
						Unknown4,
						StateRight,
						StateLeft,
						StateCenter,
						Unknown5,
						GametypeFriendly,
						GametypeEnemy,
						MetagameTop,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Theater,
					}
				}

				[TagStructure(Size = 0x78)]
				public class AnimationDatum
				{
					public Animation1FlagsValue Animation1Flags;
					public Animation1FunctionValue Animation1Function;
					public TagInstance Animation1;
					public Animation2FlagsValue Animation2Flags;
					public Animation2FunctionValue Animation2Function;
					public TagInstance Animation2;
					public Animation3FlagsValue Animation3Flags;
					public Animation3FunctionValue Animation3Function;
					public TagInstance Animation3;
					public Animation4FlagsValue Animation4Flags;
					public Animation4FunctionValue Animation4Function;
					public TagInstance Animation4;
					public Animation5FlagsValue Animation5Flags;
					public Animation5FunctionValue Animation5Function;
					public TagInstance Animation5;
					public Animation6FlagsValue Animation6Flags;
					public Animation6FunctionValue Animation6Function;
					public TagInstance Animation6;

					public enum Animation1FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation1FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation2FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation2FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation3FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation3FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation4FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation4FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation5FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation5FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}

					public enum Animation6FlagsValue : ushort
					{
						None,
						ReverseFrames,
					}

					public enum Animation6FunctionValue : short
					{
						Default,
						UseInput,
						UseRangeInput,
						Zero,
					}
				}

				[TagStructure(Size = 0x40)]
				public class RenderDatum
				{
					public ShaderIndexValue ShaderIndex;
					public short Unknown;
					public InputValue Input;
					public RangeInputValue RangeInput;
					public byte LocalColorAlphaA;
					public byte LocalColorAR;
					public byte LocalColorAG;
					public byte LocalColorAB;
					public byte LocalColorAlphaB;
					public byte LocalColorBR;
					public byte LocalColorBG;
					public byte LocalColorBB;
					public byte LocalColorAlphaC;
					public byte LocalColorCR;
					public byte LocalColorCG;
					public byte LocalColorCB;
					public byte LocalColorAlphaD;
					public byte LocalColorDR;
					public byte LocalColorDG;
					public byte LocalColorDB;
					public float LocalScalarA;
					public float LocalScalarB;
					public float LocalScalarC;
					public float LocalScalarD;
					public OutputColorAValue OutputColorA;
					public OutputColorBValue OutputColorB;
					public OutputColorCValue OutputColorC;
					public OutputColorDValue OutputColorD;
					public OutputColorEValue OutputColorE;
					public OutputColorFValue OutputColorF;
					public OutputScalarAValue OutputScalarA;
					public OutputScalarBValue OutputScalarB;
					public OutputScalarCValue OutputScalarC;
					public OutputScalarDValue OutputScalarD;
					public OutputScalarEValue OutputScalarE;
					public OutputScalarFValue OutputScalarF;

					public enum ShaderIndexValue : short
					{
						Simple,
						Meter,
						TextSimple,
						MeterShield,
						MeterGradient,
						Crosshair,
						DirectionalDamage,
						Solid,
						Sensor,
						MeterSingleColor,
						Navpoint,
						Medal,
						TextureCam,
						CortanaScreen,
						CortanaCamera,
						CortanaOffscreen,
						CortanaScreenFinal,
						MeterChapter,
						MeterDoubleGradient,
						MeterRadialGradient,
						Turbulence,
						Emblem,
						CortanaComposite,
						DirectionalDamageApply,
						ReallySimple,
					}

					public enum InputValue : short
					{
						Zero,
						One,
						Time,
						Fade,
						UnitShieldCurrent,
						UnitShield,
						ClipAmmoFraction,
						TotalAmmoFraction,
						HeatFraction,
						BatteryFraction,
						Pickup,
						UnitAutoaimed,
						Grenade,
						GrenadeFraction,
						ChargeFraction,
						FriendlyScore,
						EnemyScore,
						ScoreToWin,
						ArmingFraction,
						Unknown,
						Unit1xOvershieldCurrent,
						Unit1xOvershield,
						Unit2xOvershieldCurrent,
						Unit2xOvershield,
						Unit3xOvershieldCurrent,
						Unit3xOvershield,
						AimYaw,
						AimPitch,
						TargetDistance,
						TargetElevation,
						EditorBudget,
						EditorBudgetCost,
						FilmTotalTime,
						FilmCurrentTime,
						Unknown2,
						FilmTimelineFraction1,
						FilmTimelineFraction2,
						Unknown3,
						Unknown4,
						MetagameTime,
						MetagameScoreTransient,
						MetagameScorePlayer1,
						MetagameScorePlayer2,
						MetagameScorePlayer3,
						MetagameScorePlayer4,
						MetagameModifier,
						Unknown5,
						SensorRange,
						NetdebugLatency,
						NetdebugLatencyQuality,
						NetdebugHostQuality,
						NetdebugLocalQuality,
						MetagameScoreNegative,
					}

					public enum RangeInputValue : short
					{
						Zero,
						One,
						Time,
						Fade,
						UnitShieldCurrent,
						UnitShield,
						ClipAmmoFraction,
						TotalAmmoFraction,
						HeatFraction,
						BatteryFraction,
						Pickup,
						UnitAutoaimed,
						Grenade,
						GrenadeFraction,
						ChargeFraction,
						FriendlyScore,
						EnemyScore,
						ScoreToWin,
						ArmingFraction,
						Unknown,
						Unit1xOvershieldCurrent,
						Unit1xOvershield,
						Unit2xOvershieldCurrent,
						Unit2xOvershield,
						Unit3xOvershieldCurrent,
						Unit3xOvershield,
						AimYaw,
						AimPitch,
						TargetDistance,
						TargetElevation,
						EditorBudget,
						EditorBudgetCost,
						FilmTotalTime,
						FilmCurrentTime,
						Unknown2,
						FilmTimelineFraction1,
						FilmTimelineFraction2,
						Unknown3,
						Unknown4,
						MetagameTime,
						MetagameScoreTransient,
						MetagameScorePlayer1,
						MetagameScorePlayer2,
						MetagameScorePlayer3,
						MetagameScorePlayer4,
						MetagameModifier,
						Unknown5,
						SensorRange,
						NetdebugLatency,
						NetdebugLatencyQuality,
						NetdebugHostQuality,
						NetdebugLocalQuality,
						MetagameScoreNegative,
					}

					public enum OutputColorAValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorBValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorCValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorDValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorEValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputColorFValue : short
					{
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown4,
						Unknown5,
						ScoreboardFriendly,
						ScoreboardEnemy,
						ArmingTeam,
						MetagamePlayer1,
						MetagamePlayer2,
						MetagamePlayer3,
						MetagamePlayer4,
						Unknown13,
						GlobalDynamic0,
						GlobalDynamic1,
						GlobalDynamic2,
						GlobalDynamic3,
						GlobalDynamic4,
						GlobalDynamic5,
						GlobalDynamic6,
						GlobalDynamic7,
						GlobalDynamic8,
						GlobalDynamic9,
						GlobalDynamic10,
						GlobalDynamic11,
						GlobalDynamic12,
						GlobalDynamic13,
						GlobalDynamic14,
						GlobalDynamic15,
						GlobalDynamic16,
						GlobalDynamic17,
						GlobalDynamic18,
						GlobalDynamic19,
						GlobalDynamic20,
						GlobalDynamic21,
						GlobalDynamic22,
						GlobalDynamic23,
						GlobalDynamic24,
						GlobalDynamic25,
						GlobalDynamic26,
						GlobalDynamic27,
					}

					public enum OutputScalarAValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarBValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarCValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarDValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarEValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}

					public enum OutputScalarFValue : short
					{
						Input,
						RangeInput,
						LocalA,
						LocalB,
						LocalC,
						LocalD,
						Unknown6,
						Unknown7,
					}
				}

				public enum FlagsValue : ushort
				{
					None,
					StringIsANumber,
					Force2Digit,
					Force3Digit = 4,
					Prefix = 8,
					MSuffix = 16,
					HundredthsDecimal = 32,
					ThousandthsDecimal = 64,
					HundredThousandthsDecimal = 128,
					OnlyANumber = 256,
					XSuffix = 512,
					InBrackets = 1024,
					TimeFormatSMs = 2048,
					TimeFormatHMS = 4096,
					MoneyFormat = 8192,
					Prefix2 = 16384,
					Bit15 = 32768,
				}

				public enum FontValue : short
				{
					Conduit18,
					Fixedsys9,
					Fixedsys9_2,
					Conduit16,
					Conduit32,
					Conduit32_2,
					Conduit23,
					Larabie10,
					Conduit18_2,
					Conduit16_2,
					Pragmata14,
				}
			}
		}
	}
}
