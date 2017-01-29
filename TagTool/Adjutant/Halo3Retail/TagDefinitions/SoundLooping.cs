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
	[TagStructure(Class = "lsnd", Size = 0x40)]
	public class SoundLooping
	{
		public FlagsValue Flags;
		public float MartySMusicTime;
		public float Unknown;
		public float Unknown2;
		public float Unknown3;
		public TagInstance Unused;
		public SoundClassValue SoundClass;
		public short Unknown4;
		public List<Track> Tracks;
		public List<DetailSound> DetailSounds;

		public enum FlagsValue : int
		{
			None,
			DeafeningToAis,
			NotALoop,
			StopsMusic = 4,
			AlwaysSpatialize = 8,
			SynchronizePlayback = 16,
			SynchronizeTracks = 32,
			FakeSpatializationWithDistance = 64,
			CombineAll3dPlayback = 128,
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

		public enum SoundClassValue : short
		{
			ProjectileImpact,
			ProjectileDetonation,
			ProjectileFlyby,
			ProjectileDetonationLod,
			WeaponFire,
			WeaponReady,
			WeaponReload,
			WeaponEmpty,
			WeaponCharge,
			WeaponOverheat,
			WeaponIdle,
			WeaponMelee,
			WeaponAnimation,
			ObjectImpacts,
			ParticleImpacts,
			WeaponFireLod,
			Unused1Impacts,
			Unused2Impacts,
			UnitFootsteps,
			UnitDialog,
			UnitAnimation,
			UnitUnused,
			VehicleCollision,
			VehicleEngine,
			VehicleAnimation,
			VehicleEngineLod,
			DeviceDoor,
			DeviceUnused0,
			DeviceMachinery,
			DeviceStationary,
			DeviceUnused1,
			DeviceUnused2,
			Music,
			AmbientNature,
			AmbientMachinery,
			AmbientStationary,
			HugeAss,
			ObjectLooping,
			CinematicMusic,
			UnknownUnused0,
			UnknownUnused1,
			AmbientFlock,
			NoPad,
			NoPadStationary,
			MissionUnused0,
			CortanaMission,
			CortanaGravemindChannel,
			MissionDialog,
			CinematicDialog,
			ScriptedCinematicFoley,
			GameEvent,
			Ui,
			Test,
			MultilingualTest,
		}

		[TagStructure(Size = 0x90)]
		public class Track
		{
			public StringID Name;
			public FlagsValue Flags;
			public float Gain;
			public float FadeInDuration;
			public float FadeOutDuration;
			public TagInstance In;
			public TagInstance Loop;
			public TagInstance Out;
			public TagInstance AlternateLoop;
			public TagInstance AlternateOut;
			public OutputEffectValue OutputEffect;
			public short Unknown;
			public TagInstance AlternateTransitionIn;
			public TagInstance AlternateTransitionOut;
			public float AlternateCrossfadeDuration;
			public float AlternateFadeOutDuration;

			public enum FlagsValue : int
			{
				None,
				FadeInAtStart,
				FadeOutAtStop,
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

			public enum OutputEffectValue : short
			{
				None,
				OutputFrontSpeakers,
				OutputRearSpeakers,
				OutputCenterSpeakers,
			}
		}

		[TagStructure(Size = 0x3C)]
		public class DetailSound
		{
			public StringID Name;
			public TagInstance Sound;
			public float RandomPeriodBoundsMin;
			public float RandomPeriodBoundsMax;
			public float Unknown;
			public FlagsValue Flags;
			public Angle YawBoundsMin;
			public Angle YawBoundsMax;
			public Angle PitchBoundsMin;
			public Angle PitchBoundsMax;
			public float DistanceBoundsMin;
			public float DistanceBoundsMax;

			public enum FlagsValue : int
			{
				None,
				DonTPlayWithAlternate,
				DonTPlayWithoutAlternate,
				StartImmediatelyWithLoop = 4,
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
	}
}
