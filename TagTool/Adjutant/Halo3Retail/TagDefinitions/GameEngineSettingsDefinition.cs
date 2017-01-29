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
	[TagStructure(Class = "wezr", Size = 0x88)]
	public class GameEngineSettingsDefinition
	{
		public uint Unknown;
		public List<TraitProfile> TraitProfiles;
		public List<SlayerVariant> SlayerVariants;
		public List<OddballVariant> OddballVariants;
		public List<CaptureTheFlagVariant> CaptureTheFlagVariants;
		public List<AssaultVariant> AssaultVariants;
		public List<InfectionVariant> InfectionVariants;
		public List<KingOfTheHillVariant> KingOfTheHillVariants;
		public List<TerritoriesVariant> TerritoriesVariants;
		public List<JuggernautVariant> JuggernautVariants;
		public List<VipVariant> VipVariants;
		public List<SandboxEditorVariant> SandboxEditorVariants;

		[TagStructure(Size = 0x40)]
		public class TraitProfile
		{
			public StringID Name;
			public List<ShieldsAndHealthBlock> ShieldsAndHealth;
			public List<WeaponsAndDamageBlock> WeaponsAndDamage;
			public List<MovementBlock> Movement;
			public List<AppearanceBlock> Appearance;
			public List<Sensor> Sensors;

			[TagStructure(Size = 0x8)]
			public class ShieldsAndHealthBlock
			{
				public DamageResistanceValue DamageResistance;
				public ShieldMultiplierValue ShieldMultiplier;
				public ShieldRechargeRateValue ShieldRechargeRate;
				public HeadshotImmunityValue HeadshotImmunity;
				public ShieldVampirismValue ShieldVampirism;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum DamageResistanceValue : sbyte
				{
					Unchanged,
					_10,
					_50,
					_90,
					_100,
					_110,
					_150,
					_200,
					_300,
					_500,
					_1000,
					_2000,
					Invulnerable,
				}

				public enum ShieldMultiplierValue : sbyte
				{
					Unchanged,
					NoShields,
					NormalShields,
					_2xOvershields,
					_3xOvershields,
					_4xOvershields,
				}

				public enum ShieldRechargeRateValue : sbyte
				{
					Unchanged,
					_25,
					_10,
					_5,
					_0,
					_50,
					_90,
					_100,
					_110,
					_200,
				}

				public enum HeadshotImmunityValue : sbyte
				{
					Unchanged,
					Enabled,
					Disabled,
				}

				public enum ShieldVampirismValue : sbyte
				{
					Unchanged,
					Disabled,
					_10,
					_25,
					_50,
					_100,
				}
			}

			[TagStructure(Size = 0x10)]
			public class WeaponsAndDamageBlock
			{
				public DamageModifierValue DamageModifier;
				public GrenadeRegenerationValue GrenadeRegeneration;
				public WeaponPickupValue WeaponPickup;
				public InfiniteAmmoValue InfiniteAmmo;
				public StringID PrimaryWeapon;
				public StringID SecondaryWeapon;
				public GrenadeCountValue GrenadeCount;
				public sbyte Unknown;
				public sbyte Unknown2;

				public enum DamageModifierValue : sbyte
				{
					Unchanged,
					_0,
					_25,
					_50,
					_75,
					_90,
					_100,
					_110,
					_125,
					_150,
					_200,
					_300,
					InstantKill,
				}

				public enum GrenadeRegenerationValue : sbyte
				{
					Unchanged,
					Enabled,
					Disabled,
				}

				public enum WeaponPickupValue : sbyte
				{
					Unchanged,
					Enabled,
					Disabled,
				}

				public enum InfiniteAmmoValue : sbyte
				{
					Unchanged,
					Disabled,
					Enabled,
				}

				public enum GrenadeCountValue : short
				{
					Unchanged,
					MapDefault,
					None,
				}
			}

			[TagStructure(Size = 0x4)]
			public class MovementBlock
			{
				public PlayerSpeedValue PlayerSpeed;
				public PlayerGravityValue PlayerGravity;
				public VehicleUseValue VehicleUse;
				public sbyte Unknown;

				public enum PlayerSpeedValue : sbyte
				{
					Unchanged,
					_25,
					_50,
					_75,
					_90,
					_100,
					_110,
					_125,
					_150,
					_200,
					_300,
				}

				public enum PlayerGravityValue : sbyte
				{
					Unchanged,
					_50,
					_75,
					_100,
					_150,
					_200,
				}

				public enum VehicleUseValue : sbyte
				{
					Unchanged,
					None,
					PassengerOnly,
					FullUse,
				}
			}

			[TagStructure(Size = 0x4)]
			public class AppearanceBlock
			{
				public ActiveCamoValue ActiveCamo;
				public WaypointValue Waypoint;
				public AuraValue Aura;
				public ForcedColorValue ForcedColor;

				public enum ActiveCamoValue : sbyte
				{
					Unchanged,
					Disabled,
					BadCamo,
					PoorCamo,
					GoodCamo,
				}

				public enum WaypointValue : sbyte
				{
					Unchanged,
					None,
					VisibleToAllies,
					VisibleToEveryone,
				}

				public enum AuraValue : sbyte
				{
					Unchanged,
					Disabled,
					Team,
					Black,
					White,
				}

				public enum ForcedColorValue : sbyte
				{
					Unchanged,
					Off,
					Red,
					Blue,
					Green,
					Orange,
					Purple,
					Gold,
					Brown,
					Pink,
					White,
					Black,
					Zombie,
					PinkUnused,
				}
			}

			[TagStructure(Size = 0x8)]
			public class Sensor
			{
				public MotionTrackerModeValue MotionTrackerMode;
				public MotionTrackerRangeValue MotionTrackerRange;

				public enum MotionTrackerModeValue : int
				{
					Unchanged,
					Disabled,
					AllyMovement,
					PlayerMovement,
					PlayerLocations,
				}

				public enum MotionTrackerRangeValue : int
				{
					Unchanged,
					_10m,
					_15m,
					_25m,
					_50m,
					_75m,
					_100m,
					_150m,
				}
			}
		}

		[TagStructure(Size = 0x50)]
		public class SlayerVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public TeamScoringValue TeamScoring;
			public short PointsToWin;
			public sbyte KillPoints;
			public sbyte AssistPoints;
			public sbyte DeathPoints;
			public sbyte SuicidePoints;
			public sbyte BetrayalPoints;
			public sbyte LeaderKillBonus;
			public sbyte EliminationBonus;
			public sbyte AssassinationBonus;
			public sbyte HeadshotBonus;
			public sbyte BeatdownBonus;
			public sbyte StickyBonus;
			public sbyte SplatterBonus;
			public sbyte SpreeBonus;
			public sbyte Unknown;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public StringID LeaderTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum TeamScoringValue : short
			{
				SumOfTeam,
				MinimumScore,
				MaximumScore,
				Default,
			}
		}

		[TagStructure(Size = 0x50)]
		public class OddballVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public FlagsValue Flags;
			public TeamScoringValue TeamScoring;
			public short PointsToWin;
			public sbyte CarryingPoints;
			public sbyte KillPoints;
			public sbyte BallKillPoints;
			public sbyte BallCarrierKillPoints;
			public sbyte BallCount;
			public sbyte Unknown;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public short InitialBallDelay;
			public short BallRespawnDelay;
			public StringID BallCarrierTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum FlagsValue : int
			{
				None,
				AutopickupEnabled,
				BallEffectEnabled,
			}

			public enum TeamScoringValue : short
			{
				SumOfTeam,
				MinimumScore,
				MaximumScore,
				Default,
			}
		}

		[TagStructure(Size = 0x50)]
		public class CaptureTheFlagVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public FlagsValue Flags;
			public HomeFlagWaypointValue HomeFlagWaypoint;
			public GameModeValue GameMode;
			public RespawnOnCaptureValue RespawnOnCapture;
			public short FlagReturnTime;
			public short SuddenDeathTime;
			public short ScoreToWin;
			public short FlagResetTime;
			public sbyte Unknown;
			public sbyte Unknown2;
			public StringID FlagCarrierTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum FlagsValue : int
			{
				None,
				FlagAtHomeToScore,
			}

			public enum HomeFlagWaypointValue : short
			{
				Unknown1,
				Unknown2,
				Unknown3,
				NotInSingle,
			}

			public enum GameModeValue : short
			{
				Multiple,
				Single,
				Neutral,
			}

			public enum RespawnOnCaptureValue : short
			{
				Disabled,
				OnAllyCapture,
				OnEnemyCapture,
				OnAnyCapture,
			}
		}

		[TagStructure(Size = 0x58)]
		public class AssaultVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public FlagsValue Flags;
			public RespawnOnCaptureValue RespawnOnCapture;
			public GameModeValue GameMode;
			public EnemyBombWaypointValue EnemyBombWaypoint;
			public short SuddenDeathTime;
			public short DetonationsToWin;
			public short BombResetTime;
			public short BombArmingTime;
			public short BombDisarmingTime;
			public short BombFuseTime;
			public short Unknown;
			public StringID BombCarrierTraitProfile;
			public StringID UnknownTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum FlagsValue : int
			{
				None,
				ResetOnDisarm,
			}

			public enum RespawnOnCaptureValue : short
			{
				Disabled,
				OnAllyCapture,
				OnEnemyCapture,
				OnAnyCapture,
			}

			public enum GameModeValue : short
			{
				Multiple,
				Single,
				Neutral,
			}

			public enum EnemyBombWaypointValue : short
			{
				Unknown1,
				Unknown2,
				Unknown3,
				NotInSingle,
			}
		}

		[TagStructure(Size = 0x5C)]
		public class InfectionVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public FlagsValue Flags;
			public SafeHavensValue SafeHavens;
			public NextZombieValue NextZombie;
			public short InitialZombieCount;
			public short SafeHavenMovementTime;
			public sbyte ZombieKillPoints;
			public sbyte InfectionPoints;
			public sbyte SafeHavenArrivalPoints;
			public sbyte SuicidePoints;
			public sbyte BetrayalPoints;
			public sbyte LastManStandingBonus;
			public sbyte Unknown;
			public sbyte Unknown2;
			public StringID ZombieTraitProfile;
			public StringID AlphaZombieTraitProfile;
			public StringID OnHavenTraitProfile;
			public StringID LastHumanTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum FlagsValue : int
			{
				None,
				RespawnOnHavenMove,
			}

			public enum SafeHavensValue : short
			{
				None,
				Random,
				Sequence,
			}

			public enum NextZombieValue : short
			{
				MostPoints,
				FirstInfected,
				Unchanged,
				Random,
			}
		}

		[TagStructure(Size = 0x4C)]
		public class KingOfTheHillVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public FlagsValue Flags;
			public short ScoreToWin;
			public TeamScoringValue TeamScoring;
			public HillMovementValue HillMovement;
			public HillMovementOrderValue HillMovementOrder;
			public sbyte OnHillPoints;
			public sbyte UncontestedControlPoints;
			public sbyte OffHillPoints;
			public sbyte KillPoints;
			public StringID OnHillTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum FlagsValue : int
			{
				None,
				OpaqueHill,
			}

			public enum TeamScoringValue : short
			{
				Sum,
				Minimum,
				Maximum,
				Default,
			}

			public enum HillMovementValue : short
			{
				NoMovement,
				After10Seconds,
				After15Seconds,
				After30Seconds,
				After1Minute,
				After2Minutes,
				After3Minutes,
				After4Minutes,
				After5Minutes,
			}

			public enum HillMovementOrderValue : short
			{
				Random,
				Sequence,
			}
		}

		[TagStructure(Size = 0x4C)]
		public class TerritoriesVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public FlagsValue Flags;
			public RespawnOnCaptureValue RespawnOnCapture;
			public short TerritoryCaptureTime;
			public short SuddenDeathTime;
			public short Unknown;
			public StringID DefenderTraitProfile;
			public StringID AttackerTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum FlagsValue : int
			{
				None,
				OneSided,
				LockAfterFirstCapture,
			}

			public enum RespawnOnCaptureValue : short
			{
				Disabled,
				OnAllyCapture,
				OnEnemyCapture,
				OnAnyCapture,
			}
		}

		[TagStructure(Size = 0x54)]
		public class JuggernautVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public FlagsValue Flags;
			public FirstJuggernautValue FirstJuggernaut;
			public NextJuggernautValue NextJuggernaut;
			public GoalZoneMovementValue GoalZoneMovement;
			public GoalZoneOrderValue GoalZoneOrder;
			public short ScoreToWin;
			public sbyte KillPoints;
			public sbyte TakedownPoints;
			public sbyte KillAsJuggernautPoints;
			public sbyte GoalArrivalPoints;
			public sbyte SuicidePoints;
			public sbyte BetrayalPoints;
			public sbyte NextJuggernautDelay;
			public sbyte Unknown;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public StringID JuggernautTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum FlagsValue : int
			{
				None,
				AlliedAgainstJuggernaut,
				RespawnOnLoneJuggernaut,
				GoalZonesEnabled = 4,
			}

			public enum FirstJuggernautValue : short
			{
				Random,
				FirstKill,
				FirstDeath,
			}

			public enum NextJuggernautValue : short
			{
				Killer,
				Killed,
				Unchanged,
				Random,
			}

			public enum GoalZoneMovementValue : short
			{
				NoMovement,
				After10Seconds,
				After15Seconds,
				After30Seconds,
				After1Minute,
				After2Minutes,
				After3Minutes,
				After4Minutes,
				After5Minutes,
				OnArrival,
				OnNewJuggernaut,
			}

			public enum GoalZoneOrderValue : short
			{
				Random,
				Sequence,
			}
		}

		[TagStructure(Size = 0x5C)]
		public class VipVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public FlagsValue Flags;
			public short ScoreToWin;
			public NextVipValue NextVip;
			public GoalZoneMovementValue GoalZoneMovement;
			public GoalZoneMovementOrderValue GoalZoneMovementOrder;
			public sbyte KillPoints;
			public sbyte VipTakedownPoints;
			public sbyte KillAsVipPoints;
			public sbyte VipDeathPoints;
			public sbyte GoalArrivalPoints;
			public sbyte SuicidePoints;
			public sbyte VipBetrayalPoints;
			public sbyte BetrayalPoints;
			public sbyte VipProximityTraitRadius;
			public sbyte Unknown;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public StringID VipTeamTraitProfile;
			public StringID VipProximityTraitProfile;
			public StringID VipTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum FlagsValue : int
			{
				None,
				SingleVip,
				GoalZonesEnabled,
				EndRoundOnVipDeath = 4,
			}

			public enum NextVipValue : short
			{
				Random,
				Unknown,
				NextDeath,
				Unchanged,
			}

			public enum GoalZoneMovementValue : short
			{
				NoMovement,
				After10Seconds,
				After15Seconds,
				After30Seconds,
				After1Minute,
				After2Minutes,
				After3Minutes,
				After4Minutes,
				After5Minutes,
				OnArrival,
				OnNewVip,
			}

			public enum GoalZoneMovementOrderValue : short
			{
				Random,
				Sequence,
			}
		}

		[TagStructure(Size = 0x44)]
		public class SandboxEditorVariant
		{
			public StringID Name;
			public StringID Description;
			public List<GeneralSetting> GeneralSettings;
			public List<RespawnSetting> RespawnSettings;
			public List<SocialSetting> SocialSettings;
			public List<MapOverride> MapOverrides;
			public FlagsValue Flags;
			public EditModeValue EditMode;
			public short EditorRespawnTime;
			public StringID EditorTraitProfile;

			[TagStructure(Size = 0x8)]
			public class GeneralSetting
			{
				public FlagsValue Flags;
				public sbyte TimeLimit;
				public sbyte NumberOfRounds;
				public sbyte EarlyVictoryWinCount;
				public RoundResetsValue RoundResets;

				public enum FlagsValue : int
				{
					None,
					TeamsEnabled,
				}

				public enum RoundResetsValue : sbyte
				{
					Nothing,
					PlayersOnly,
					Everything,
				}
			}

			[TagStructure(Size = 0x10)]
			public class RespawnSetting
			{
				public FlagsValue Flags;
				public sbyte LivesPerRound;
				public sbyte SharedTeamLives;
				public byte RespawnTime;
				public byte SuicidePenalty;
				public byte BetrayalPenalty;
				public byte RespawnTimeGrowth;
				public StringID RespawnTraitProfile;
				public sbyte RespawnTraitDuration;
				public sbyte Unknown;
				public sbyte Unknown2;
				public sbyte Unknown3;

				public enum FlagsValue : ushort
				{
					None,
					InheritRespawnTime,
					RespawnWithTeam,
					RespawnAtLocation = 4,
					RespawnOnKills = 8,
				}
			}

			[TagStructure(Size = 0x4)]
			public class SocialSetting
			{
				public FlagsValue Flags;

				public enum FlagsValue : int
				{
					None,
					ObserversEnabled,
					TeamChangingEnabled,
					BalancedTeamChanging = 4,
					FriendlyFireEnabled = 8,
					BetrayalBootingEnabled = 16,
					EnemyVoiceEnabled = 32,
					OpenChannelVoiceEnabled = 64,
					DeadPlayerVoiceEnabled = 128,
				}
			}

			[TagStructure(Size = 0x20)]
			public class MapOverride
			{
				public FlagsValue Flags;
				public StringID BasePlayerTraitProfile;
				public StringID WeaponSet;
				public StringID VehicleSet;
				public StringID OvershieldTraitProfile;
				public StringID ActiveCamoTraitProfile;
				public StringID CustomPowerupTraitProfile;
				public sbyte OvershieldTraitDuration;
				public sbyte ActiveCamoTraitDuration;
				public sbyte CustomPowerupTraitDuration;
				public sbyte Unknown;

				public enum FlagsValue : int
				{
					None,
					GrenadesOnMap,
					IndestructableVehicles,
				}
			}

			public enum FlagsValue : int
			{
				None,
				OpenChannelVoiceEnabled,
			}

			public enum EditModeValue : short
			{
				Everyone,
				LeaderOnly,
			}
		}
	}
}
