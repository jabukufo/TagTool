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
	[TagStructure(Class = "mulg", Size = 0x18)]
	public class MultiplayerGlobals
	{
		public List<UniversalBlock> Universal;
		public List<RuntimeBlock> Runtime;

		[TagStructure(Size = 0xB4)]
		public class UniversalBlock
		{
			public TagInstance RandomPlayerNameStrings;
			public TagInstance TeamNameStrings;
			public List<TeamColor> TeamColors;
			public List<ArmorCustomizationBlock> ArmorCustomization;
			public TagInstance MultiplayerStrings;
			public TagInstance SandboxUiStrings;
			public TagInstance SandboxUiProperties;
			public List<GameVariantWeapon> GameVariantWeapons;
			public List<GameVariantVehicle> GameVariantVehicles;
			public List<GameVariantEquipmentBlock> GameVariantEquipment;
			public List<WeaponSet> WeaponSets;
			public List<VehicleSet> VehicleSets;
			public TagInstance EngineSettings;

			[TagStructure(Size = 0xC)]
			public class TeamColor
			{
				public float ColorR;
				public float ColorG;
				public float ColorB;
			}

			[TagStructure(Size = 0x10)]
			public class ArmorCustomizationBlock
			{
				public StringID CharacterName;
				public List<Region> Regions;

				[TagStructure(Size = 0x10)]
				public class Region
				{
					public StringID Name;
					public List<Permuation> Permuations;

					[TagStructure(Size = 0x1C)]
					public class Permuation
					{
						public StringID Name;
						public StringID Description;
						public FlagsValue Flags;
						public short Unknown;
						public StringID AchievementRequirement;
						public List<VariantBlock> Variant;

						public enum FlagsValue : ushort
						{
							None,
							HasRequirement,
							HasSpecialRequirement,
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

						[TagStructure(Size = 0x8)]
						public class VariantBlock
						{
							public StringID Region;
							public StringID Permutation;
						}
					}
				}
			}

			[TagStructure(Size = 0x18)]
			public class GameVariantWeapon
			{
				public StringID Name;
				public float RandomChance;
				public TagInstance Weapon;
			}

			[TagStructure(Size = 0x14)]
			public class GameVariantVehicle
			{
				public StringID Name;
				public TagInstance Vehicle;
			}

			[TagStructure(Size = 0x14)]
			public class GameVariantEquipmentBlock
			{
				public StringID Name;
				public TagInstance Grenade;
			}

			[TagStructure(Size = 0x10)]
			public class WeaponSet
			{
				public StringID Name;
				public List<Substitution> Substitutions;

				[TagStructure(Size = 0x8)]
				public class Substitution
				{
					public StringID OriginalWeapon;
					public StringID SubstitutedWeapon;
				}
			}

			[TagStructure(Size = 0x10)]
			public class VehicleSet
			{
				public StringID Name;
				public List<Substitution> Substitutions;

				[TagStructure(Size = 0x8)]
				public class Substitution
				{
					public StringID OriginalVehicle;
					public StringID SubstitutedVehicle;
				}
			}
		}

		[TagStructure(Size = 0x20C)]
		public class RuntimeBlock
		{
			public TagInstance SandboxEditorUnit;
			public TagInstance SandboxEditorObject;
			public TagInstance Flag;
			public TagInstance Ball;
			public TagInstance Bomb;
			public TagInstance VipZone;
			public TagInstance InGameStrings;
			public List<Sound> Sounds;
			public List<LoopingSound> LoopingSounds;
			public List<GeneralEvent> GeneralEvents;
			public List<FlavorEvent> FlavorEvents;
			public List<SlayerEvent> SlayerEvents;
			public List<CtfEvent> CtfEvents;
			public List<OddballEvent> OddballEvents;
			public List<KingOfTheHillEvent> KingOfTheHillEvents;
			public List<VipEvent> VipEvents;
			public List<JuggernautEvent> JuggernautEvents;
			public List<TerritoriesEvent> TerritoriesEvents;
			public List<AssaultEvent> AssaultEvents;
			public List<InfectionEvent> InfectionEvents;
			public int DefaultFragGrenadeCount;
			public int DefaultPlasmaGrenadeCount;
			public List<MultiplayerConstant> MultiplayerConstants;
			public List<StateRespons> StateResponses;
			public TagInstance ScoreboardEmblemBitmap;
			public TagInstance ScoreboardDeadEmblemBitmap;
			public TagInstance DefaultShapeShader;
			public TagInstance Unknown;
			public TagInstance CtfIntroUi;
			public TagInstance SlayerIntroUi;
			public TagInstance OddballIntroUi;
			public TagInstance KingOfTheHillIntroUi;
			public TagInstance SandboxIntroUi;
			public TagInstance VipIntroUi;
			public TagInstance JuggernautIntroUi;
			public TagInstance TerritoriesIntroUi;
			public TagInstance AssaultIntroUi;
			public TagInstance InfectionIntroUi;

			[TagStructure(Size = 0x10)]
			public class Sound
			{
				public TagInstance Sound2;
			}

			[TagStructure(Size = 0x10)]
			public class LoopingSound
			{
				public TagInstance LoopingSound2;
			}

			[TagStructure(Size = 0x104)]
			public class GeneralEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					Kill,
					Suicide,
					Betrayal,
					Victory,
					TeamVictory,
					Unused1,
					Unused2,
					_1MinToWin,
					Team1MinToWin,
					_30SecsToWin,
					Team30SecsToWin,
					PlayerQuit,
					PlayerJoined,
					KilledByUnknown,
					_30MinutesLeft,
					_15MinutesLeft,
					_5MinutesLeft,
					_1MinuteLeft,
					TimeExpired,
					GameOver,
					RespawnTick,
					LastRespawnTick,
					TeleporterUsed,
					TeleporterBlocked,
					PlayerChangedTeam,
					PlayerRejoined,
					GainedLead,
					GainedTeamLead,
					LostLead,
					LostTeamLead,
					TiedLeader,
					TiedTeamLeader,
					RoundOver,
					_30SecondsLeft,
					_10SecondsLeft,
					KillFalling,
					KillCollision,
					KillMelee,
					SuddenDeath,
					PlayerBootedPlayer,
					KillFlagCarrier,
					KillBombCarrier,
					KillStickyGrenade,
					KillSniper,
					KillStandardMelee,
					BoardedVehicle,
					StartTeamNotice,
					Telefrag,
					_10SecsToWin,
					Team10SecsToWin,
					KillBulltrue,
					KillPostMortem,
					Highjack,
					Skyjack,
					KillLaser,
					KillFire,
					Wheelman,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class FlavorEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					Extermination,
					Perfection,
					DoubleKill,
					TripleKill,
					Overkill,
					Killtacular,
					Killtrocity,
					Killimanjaro,
					Killtastrophe,
					Killpocalypse,
					Killionaire,
					KillingSpree,
					KillingFrenzy,
					RunningRiot,
					Rampage,
					Untouchable,
					Invincible,
					SniperSpree,
					Sharpshooter,
					ShotgunSpree,
					OpenSeason,
					SplatterSpree,
					VehicularManslaughter,
					SwordSpree,
					SliceNDice,
					JuggernautSpree,
					Unstoppable,
					InfectionSpree,
					MmmmBrains,
					ZombieKillingSpree,
					HellSJanitor,
					IsQuisnamProteroDamno,
					HailToTheKing,
					Bulltrue,
					Splatter,
					Highjack,
					Skyjack,
					DeathFromTheGrave,
					Killjoy,
					LaserKill,
					StickyKill,
					SniperKill,
					Assassin,
					BeatDown,
					Incineration,
					Wheelman,
					BombPlanted,
					KilledBombCarrier,
					KilledVip,
					KilledJuggernaut,
					OddballKill,
					FlagScore,
					KilledFlagCarrier,
					FlagKill,
					LastManStanding,
					SandboxNotEnoughRoom,
					SandboxTooManyOnMap,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class SlayerEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					GameStart,
					NewTarget,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class CtfEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					GameStart,
					FlagTaken,
					FlagTaken2,
					FlagDropped,
					FlagReturnedByPlayer,
					FlagReturnedByTimeout,
					FlagCaptured,
					FlagNewDefensiveTeam,
					FlagReturnFailure,
					SideSwitchTick,
					SideSwitchFinalTick,
					SideSwitch30Seconds,
					SideSwitch10Seconds,
					FlagContested,
					FlagCaptureFailure,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class OddballEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					GameStart,
					BallSpawned,
					BallPickedUp,
					BallDropped,
					BallReset,
					BallTick,
					_10PointsRemaining,
					_25PointsRemaining,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class KingOfTheHillEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					GameStart,
					HillControlled,
					HillContested,
					HillTick,
					HillMove,
					HillControlledTeam,
					HillContestedTeam,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class VipEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					GameStart,
					NewVip,
					KilledVip,
					VipDeath,
					VipNotice,
					ArrivedAtDestination,
					DestinationMove,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class JuggernautEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					GameStart,
					NewJuggernaut,
					DestinationMove,
					JuggernautKilled,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class TerritoriesEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					GameStart,
					TerritoryControlGained,
					TerritoryContestLost,
					AllTerritoriesControlled,
					NewDefensiveTeam,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class AssaultEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					GameStart,
					BombTaken,
					BombDropped,
					BombReturnedByPlayer,
					BombReturnedByTimeout,
					BombCaptured,
					BombNewDefensiveTeam,
					BombReturnFailure,
					SideSwitchTick,
					SideSwitchFinalTick,
					SideSwitch30Seconds,
					SideSwitch10Seconds,
					BombReturnedByDefusing,
					BombPlacedOnEnemyPost,
					BombArmingStarted,
					BombArmingCompleted,
					BombContested,
					BombReturnedNeutral,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x104)]
			public class InfectionEvent
			{
				public FlagsValue Flags;
				public TypeValue Type;
				public EventValue Event;
				public AudienceValue Audience;
				public short Unknown;
				public short Unknown2;
				public TeamValue Team;
				public short Unknown3;
				public StringID DisplayString;
				public StringID DisplayMedal;
				public RequiredFieldValue RequiredField;
				public ExcludedAudienceValue ExcludedAudience;
				public RequiredField2Value RequiredField2;
				public ExcludedAudience2Value ExcludedAudience2;
				public StringID PrimaryString;
				public int PrimaryStringDuration;
				public StringID PluralDisplayString;
				public float SoundDelayAnnouncerOnly;
				public SoundFlagsValue SoundFlags;
				public short Unknown4;
				public TagInstance EnglishSound;
				public TagInstance JapaneseSound;
				public TagInstance GermanSound;
				public TagInstance FrenchSound;
				public TagInstance SpanishSound;
				public TagInstance LatinAmericanSpanishSound;
				public TagInstance ItalianSound;
				public TagInstance KoreanSound;
				public TagInstance ChineseTraditionalSound;
				public TagInstance ChineseSimplifiedSound;
				public TagInstance PortugueseSound;
				public TagInstance PolishSound;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;

				public enum FlagsValue : ushort
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

				public enum TypeValue : short
				{
					General,
					Flavor,
					Slayer,
					CaptureTheFlag,
					Oddball,
					Unused,
					KingOfTheHill,
					Vip,
					Juggernaut,
					Territories,
					Assault,
					Infection,
				}

				public enum EventValue : short
				{
					GameStart,
					Infected,
					NewZombie,
					NewAlphaZombie,
					LastManStanding,
				}

				public enum AudienceValue : short
				{
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
					All,
				}

				public enum TeamValue : short
				{
					NonePlayerOnly,
					Cause,
					Effect,
					All,
				}

				public enum RequiredFieldValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudienceValue : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum RequiredField2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum ExcludedAudience2Value : short
				{
					None,
					CausePlayer,
					CauseTeam,
					EffectPlayer,
					EffectTeam,
				}

				public enum SoundFlagsValue : ushort
				{
					None,
					AnnouncerSound,
				}
			}

			[TagStructure(Size = 0x21C)]
			public class MultiplayerConstant
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
				public float Unknown20;
				public float Unknown21;
				public float Unknown22;
				public float Unknown23;
				public float Unknown24;
				public float Unknown25;
				public float Unknown26;
				public List<Weapon> Weapons;
				public List<Vehicle> Vehicles;
				public List<Projectile> Projectiles;
				public List<EquipmentBlock> Equipment;
				public float Unknown27;
				public float Unknown28;
				public float Unknown29;
				public float Unknown30;
				public float Unknown31;
				public float Unknown32;
				public float Unknown33;
				public float Unknown34;
				public float Unknown35;
				public float Unknown36;
				public float Unknown37;
				public float Unknown38;
				public float Unknown39;
				public float Unknown40;
				public float Unknown41;
				public float Unknown42;
				public float Unknown43;
				public float Unknown44;
				public float Unknown45;
				public float Unknown46;
				public float Unknown47;
				public float Unknown48;
				public float Unknown49;
				public float Unknown50;
				public float Unknown51;
				public float Unknown52;
				public float Unknown53;
				public float Unknown54;
				public float Unknown55;
				public float Unknown56;
				public float Unknown57;
				public float Unknown58;
				public float Unknown59;
				public float Unknown60;
				public float Unknown61;
				public float Unknown62;
				public float Unknown63;
				public float Unknown64;
				public float Unknown65;
				public float Unknown66;
				public float MaximumRandomSpawnBias;
				public float TeleporterRechargeTime;
				public float GrenadeDangerWeight;
				public float GrenadeDangerInnerRadius;
				public float GrenadeDangerOuterRadius;
				public float GrenadeDangerLeadTime;
				public float VehicleDangerMinimumSpeed;
				public float VehicleDangerWeight;
				public float VehicleDangerRadius;
				public float VehicleDangerLeadTime;
				public float VehicleNearbyPlayerDistance;
				public TagInstance HillShader;
				public float Unknown67;
				public float Unknown68;
				public float Unknown69;
				public float Unknown70;
				public TagInstance BombExplodeEffect;
				public TagInstance Unknown71;
				public TagInstance BombExplodeDamageEffect;
				public TagInstance BombDefuseEffect;
				public TagInstance CursorImpactEffect;
				public StringID BombDefusalString;
				public StringID BlockedTeleporterString;
				public StringID Unknown72;
				public StringID SpawnAllowedDefaultRespawnString;
				public StringID SpawnAtPlayerLookingAtSelfString;
				public StringID SpawnAtPlayerLookingAtTargetString;
				public StringID SpawnAtPlayerLookingAtPotentialTargetString;
				public StringID SpawnAtTerritoryAllowedLookingAtTargetString;
				public StringID SpawnAtTerritoryAllowedLookingAtPotentialTargetString;
				public StringID PlayerOutOfLivesString;
				public StringID InvalidSpawnTargetString;
				public StringID TargettedPlayerEnemiesNearbyString;
				public StringID TargettedPlayerUnfriendlyTeamString;
				public StringID TargettedPlayerIsDeadString;
				public StringID TargettedPlayerInCombatString;
				public StringID TargettedPlayerTooFarFromOwnedFlagString;
				public StringID NoAvailableNetpointsString;
				public StringID NetpointContestedString;

				[TagStructure(Size = 0x20)]
				public class Weapon
				{
					public TagInstance Weapon2;
					public float Unknown;
					public float Unknown2;
					public float Unknown3;
					public float Unknown4;
				}

				[TagStructure(Size = 0x20)]
				public class Vehicle
				{
					public TagInstance Vehicle2;
					public float Unknown;
					public float Unknown2;
					public float Unknown3;
					public float Unknown4;
				}

				[TagStructure(Size = 0x1C)]
				public class Projectile
				{
					public TagInstance Projectile2;
					public float Unknown;
					public float Unknown2;
					public float Unknown3;
				}

				[TagStructure(Size = 0x14)]
				public class EquipmentBlock
				{
					public TagInstance Equipment;
					public float Unknown;
				}
			}

			[TagStructure(Size = 0x24)]
			public class StateRespons
			{
				public FlagsValue Flags;
				public short Unknown;
				public StateValue State;
				public short Unknown2;
				public StringID FreeForAllMessage;
				public StringID TeamMessage;
				public TagInstance Unknown3;
				public uint Unknown4;

				public enum FlagsValue : ushort
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

				public enum StateValue : short
				{
					WaitingForSpaceToClear,
					Observing,
					RespawningSoon,
					SittingOut,
					OutOfLives,
					PlayingWinning,
					PlayingTied,
					PlayingLosing,
					GameOverWon,
					GameOverTied,
					GameOverLost,
					GameOverTied2,
					YouHaveFlag,
					EnemyHasFlag,
					FlagNotHome,
					CarryingOddball,
					YouAreJuggernaut,
					YouControlHill,
					SwitchingSidesSoon,
					PlayerRecentlyStarted,
					YouHaveBomb,
					FlagContested,
					BombContested,
					LimitedLivesMultiple,
					LimitedLivesSingle,
					LimitedLivesFinal,
					PlayingWinningUnlimited,
					PlayingTiedUnlimited,
					PlayingLosingUnlimited,
				}
			}
		}
	}
}
