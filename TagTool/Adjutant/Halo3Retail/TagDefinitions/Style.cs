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
	[TagStructure(Class = "styl", Size = 0x5C)]
	public class Style
	{
		[TagField(Length = 32)] public string Name;
		public CombatStatusDecayOptionsValue CombatStatusDecayOptions;
		public short Unknown;
		public StyleControlValue StyleControl;
		public Behaviors1Value Behaviors1;
		public Behaviors2Value Behaviors2;
		public Behaviors3Value Behaviors3;
		public Behaviors4Value Behaviors4;
		public Behaviors5Value Behaviors5;
		public Behaviors6Value Behaviors6;
		public Behaviors7Value Behaviors7;
		public List<SpecialMovementBlock> SpecialMovement;
		public List<BehaviorListBlock> BehaviorList;

		public enum CombatStatusDecayOptionsValue : short
		{
			LatchAtIdle,
			LatchAtAlert,
			LatchAtCombat,
		}

		public enum StyleControlValue : int
		{
			None,
			NewBehaviorsDefaultToOn,
		}

		public enum Behaviors1Value : int
		{
			None,
			General,
			Root,
			Null = 4,
			NullDiscrete = 8,
			Obey = 16,
			Guard = 32,
			FollowBehavior = 64,
			Ready = 128,
			SmashObstacle = 256,
			DestroyObstacle = 512,
			Perch = 1024,
			CoverFriend = 2048,
			BlindPanic = 4096,
			Combat = 8192,
			Broken = 16384,
			BrokenBehavior = 32768,
			HuddleImpulse = 65536,
			HuddleBehavior = 131072,
			KamikazeBehavior = 262144,
			BrokenKamikazeImpulse = 524288,
			BrokenBerserkImpulse = 1048576,
			BrokenFleeImpulse = 2097152,
			BrokenScatterImpulse = 4194304,
			Engage = 8388608,
			Equipment = 16777216,
			Engage2 = 33554432,
			Fight = 67108864,
			MeleeCharge = 134217728,
			MeleeLeapingCharge = 268435456,
			Surprise = 536870912,
			GrenadeImpulse = 1073741824,
			AntiVehicleGrenade = -2147483648,
		}

		public enum Behaviors2Value : int
		{
			None,
			Stalk,
			Flank,
			BerserkWanderImpulse = 4,
			StalkerCamoControl = 8,
			LeaderAbandonedBerserk = 16,
			UnassailableGrenadeImpulse = 32,
			Perimeter = 64,
			PerimeterTimeoutMorph = 128,
			PerimeterInfectionSpew = 256,
			Berserk = 512,
			ShieldDepletedBerserk = 1024,
			LastManBerserk = 2048,
			StuckWithGrenadeBerserk = 4096,
			Presearch = 8192,
			Presearch2 = 16384,
			PresearchUncover = 32768,
			DestroyCover = 65536,
			SuppressingFire = 131072,
			GrenadeUncover = 262144,
			LeapOnCover = 524288,
			Leader = 1048576,
			SearchSync = 2097152,
			EngageSync = 4194304,
			Search = 8388608,
			Search2 = 16777216,
			Uncover = 33554432,
			Investigate = 67108864,
			PursuitSync = 134217728,
			Pursuit = 268435456,
			RefreshTarget = 536870912,
			SenseTarget = 1073741824,
			Postsearch = -2147483648,
		}

		public enum Behaviors3Value : int
		{
			None,
			CovermeInvestigate,
			SelfDefense,
			SelfPreservation = 4,
			Cover = 8,
			CoverPeek = 16,
			Avoid = 32,
			EvasionImpulse = 64,
			DiveImpulse = 128,
			DangerCoverImpulse = 256,
			DangerCrouchImpulse = 512,
			ProximityMelee = 1024,
			ProximitySelfPreservation = 2048,
			UnreachableEnemyCover = 4096,
			UnassailableEnemyCover = 8192,
			ScaryTargetCover = 16384,
			GroupEmerge = 32768,
			ShieldDepletedCover = 65536,
			Retreat = 131072,
			Retreat2 = 262144,
			RetreatGrenade = 524288,
			Flee = 1048576,
			Cower = 2097152,
			LowShieldRetreat = 4194304,
			ScaryTargetRetreat = 8388608,
			LeaderDeadRetreat = 16777216,
			PeerDeadRetreat = 33554432,
			DangerRetreat = 67108864,
			ProximityRetreat = 134217728,
			ChargeWhenCornered = 268435456,
			SurpriseRetreat = 536870912,
			OverheatedWeaponRetreat = 1073741824,
			Ambush = -2147483648,
		}

		public enum Behaviors4Value : int
		{
			None,
			Ambush,
			CoordinatedAmbush,
			ProximityAmbush = 4,
			VulnerableEnemyAmbush = 8,
			NowhereToRunAmbush = 16,
			Vehicle = 32,
			EnterVehicle = 64,
			EnterFriendlyVehicle = 128,
			VehicleEnterImpulse = 256,
			VehicleEntryEngageImpulse = 512,
			VehicleBoard = 1024,
			VehicleFight = 2048,
			VehicleFightBoost = 4096,
			VehicleCharge = 8192,
			VehicleRamBehavior = 16384,
			VehicleCover = 32768,
			DamageVehicleCover = 65536,
			ExposedRearCoverImpulse = 131072,
			PlayerEndageredCoverImpulse = 262144,
			VehicleAvoid = 524288,
			VehiclePickup = 1048576,
			VehiclePlayerPickup = 2097152,
			VehicleExitImpulse = 4194304,
			DangerVehicleExitImpulse = 8388608,
			VehicleFlipImpulse = 16777216,
			VehicleFlip = 33554432,
			VehicleTurtle = 67108864,
			VehicleEngagePatrolImpulse = 134217728,
			VehicleEngageWanderImpulse = 268435456,
			Postcombat = 536870912,
			Postcombat2 = 1073741824,
			PostPostcombat = -2147483648,
		}

		public enum Behaviors5Value : int
		{
			None,
			CheckFriend,
			ShootCorpse,
			PostcombatApproach = 4,
			Alert = 8,
			Alert2 = 16,
			Idle = 32,
			Idle2 = 64,
			WanderBehavior = 128,
			FlightWander = 256,
			Patrol = 512,
			FallSleep = 1024,
			Buggers = 2048,
			BuggerGroundUncover = 4096,
			Swarms = 8192,
			SwarmRoot = 16384,
			SwarmAttack = 32768,
			SupportAttack = 65536,
			Infect = 131072,
			Scatter = 262144,
			Combatforms = 524288,
			CombatFormBerserkControl = 1048576,
			EjectParasite = 2097152,
			Sentinels = 4194304,
			EnforcerWeaponControl = 8388608,
			Grapple = 16777216,
			Guardians = 33554432,
			GuardianSurge = 67108864,
			GuardianProximitySurge = 134217728,
			GuardianDangerSurge = 268435456,
			GuardianIsolationSurge = 536870912,
			Pureforms = 1073741824,
			GroupMorphImpulse = -2147483648,
		}

		public enum Behaviors6Value : int
		{
			None,
			ArrivalMorphImpulse,
			PureformDefaultImpulse,
			SearchMorph = 4,
			StealthActiveCamoControl = 8,
			StealthDamageMorph = 16,
			StealthStalk = 32,
			StealthStalkThwarted = 64,
			StealthStalkGroup = 128,
			StealthChargeRecover = 256,
			RangedProximityMorph = 512,
			TankDistanceDamageMorph = 1024,
			TankThrottleControl = 2048,
			StealthMorph = 4096,
			TankMorph = 8192,
			RangedMorph = 16384,
			RangedTurtle = 32768,
			RangedUncover = 65536,
			Scarab = 131072,
			ScarabRoot = 262144,
			ScarabCureIsolation = 524288,
			ScarabCombat = 1048576,
			ScarabFight = 2097152,
			ScarabTargetLock = 4194304,
			ScarabSearch = 8388608,
			ScarabSearchPause = 16777216,
			Atoms = 33554432,
			GoTo = 67108864,
			Activities = 134217728,
			Activity = 268435456,
			Posture = 536870912,
			ActivityDefault = 1073741824,
			Special = -2147483648,
		}

		public enum Behaviors7Value : int
		{
			None,
			Formation,
			GruntScaredByElite,
			Stunned = 4,
			CureIsolation = 8,
			DeployTurret = 16,
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

		[TagStructure(Size = 0x4)]
		public class SpecialMovementBlock
		{
			public SpecialMovement1Value SpecialMovement1;

			public enum SpecialMovement1Value : int
			{
				None,
				Jump,
				Climb,
				Vault = 4,
				Mount = 8,
				Hoist = 16,
				WallJump = 32,
				NA = 64,
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
		public class BehaviorListBlock
		{
			[TagField(Length = 32)] public string BehaviorName;
		}
	}
}
