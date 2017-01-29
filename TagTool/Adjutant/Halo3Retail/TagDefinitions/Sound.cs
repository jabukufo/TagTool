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
	[TagStructure(Class = "snd!", Size = 0x20)]
	public class Sound
	{
		public FlagsValue Flags;
		public SoundClassValue SoundClass;
		public sbyte Unknown;
		public short UghPlatformCodecIndex;
		public short UghPitchRangeIndex;
		public short UghLanguageBIndex;
		public short Unknown2;
		public short UghPlaybackParameterIndex;
		public short UghScaleIndex;
		public sbyte UghPromotionIndex;
		public sbyte UghCustomPlaybackIndex;
		public short UghExtraInfoIndex;
		public int Unknown3;
		public ushort ZoneAssetSalt;
		public ushort ZoneAssetIndex;
		public int UselessPadding;

		public enum FlagsValue : ushort
		{
			None,
			FitToAdpcmBlocksize,
			SplitLongSoundIntoPermutations,
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

		public enum SoundClassValue : sbyte
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
	}
}
