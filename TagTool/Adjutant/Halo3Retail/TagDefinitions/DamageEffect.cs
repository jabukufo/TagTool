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
	[TagStructure(Class = "jpt!", Size = 0xF0)]
	public class DamageEffect
	{
		public float RadiusMin;
		public float RadiusMax;
		public float CutoffScale;
		public FlagsValue Flags;
		public SideEffectValue SideEffect;
		public CategoryValue Category;
		public FlagsValue2 Flags2;
		public float AreaOfEffectCoreRadius;
		public float DamageLowerBound;
		public float DamageUpperBoundMin;
		public float DamageUpperBoundMax;
		public Angle DamageInnerConeAngle;
		public Angle DamageOuterConeAngle;
		public float ActiveCamoflageDamage;
		public float Stun;
		public float MaxStun;
		public float StunTime;
		public float InstantaneousAcceleration;
		public float RiderDirectDamageScale;
		public float RiderMaxTransferDamageScale;
		public float RiderMinTransferDamageScale;
		public StringID GeneralDamage;
		public StringID SpecificDamage;
		public StringID SpecialDamage;
		public float AiStunRadius;
		public float AiStunBoundsMin;
		public float AiStunBoundsMax;
		public float ShakeRadius;
		public float EmpRadius;
		public float Unknown;
		public float Unknown2;
		public List<PlayerRespons> PlayerResponses;
		public TagInstance DamageResponse;
		public float Duration;
		public FadeFunctionValue FadeFunction;
		public short Unknown3;
		public Angle Rotation;
		public float Pushback;
		public float JitterMin;
		public float JitterMax;
		public float Duration2;
		public FalloffFunctionValue FalloffFunction;
		public short Unknown4;
		public float RandomTranslation;
		public Angle RandomRotation;
		public WobbleFunctionValue WobbleFunction;
		public short Unknown5;
		public float WobbleFunctionPeriod;
		public float WobbleWeight;
		public TagInstance Sound;
		public float ForwardVelocity;
		public float ForwardRadius;
		public float ForwardExponent;
		public float OutwardVelocity;
		public float OutwardRadius;
		public float OutwardExponent;

		public enum FlagsValue : int
		{
			None,
			DonTScaleDamageByDistance,
			AreaDamagePlayersOnly,
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

		public enum SideEffectValue : short
		{
			None,
			Harmless,
			LethalToTheUnsuspecting,
			Emp,
		}

		public enum CategoryValue : short
		{
			None,
			Falling,
			Bullet,
			Grenade,
			HighExplosive,
			Sniper,
			Melee,
			Flame,
			MountedWeapon,
			Vehicle,
			Plasma,
			Needle,
			Shotgun,
		}

		public enum FlagsValue2 : int
		{
			None,
			DoesNotHurtOwner,
			CanCauseHeadshots,
			PingsResistantUnits = 4,
			DoesNotHurtFriends = 8,
			DoesNotPingUnits = 16,
			DetonatesExplosives = 32,
			OnlyHurtsShields = 64,
			CausesFlamingDeath = 128,
			DamageIndicatorsAlwaysPointDown = 256,
			SkipsShields = 512,
			OnlyHurtsOneInfectionForm = 1024,
			Bit11 = 2048,
			InfectionFormPop = 4096,
			IgnoreSeatScaleForDirectDamage = 8192,
			ForcesHardPing = 16384,
			DoesNotHurtPlayers = 32768,
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

		[TagStructure(Size = 0x70)]
		public class PlayerRespons
		{
			public ResponseTypeValue ResponseType;
			public short Unknown;
			public TypeValue Type;
			public PriorityValue Priority;
			public float Duration;
			public FadeFunctionValue FadeFunction;
			public short Unknown2;
			public float MaximumIntensity;
			public float ColorAlpha;
			public float ColorRed;
			public float ColorGreen;
			public float ColorBlue;
			public float LowFrequencyVibrationDuration;
			public byte[] LowFrequencyVibrationFunction;
			public float HighFrequencyVibrationDuration;
			public byte[] HighFrequencyVibrationFunction;
			public StringID EffectName;
			public float Duration2;
			public byte[] EffectScaleFunction;

			public enum ResponseTypeValue : short
			{
				Shielded,
				Unshielded,
				All,
			}

			public enum TypeValue : short
			{
				None,
				Lighten,
				Darken,
				Max,
				Min,
				Invert,
				Tint,
			}

			public enum PriorityValue : short
			{
				Low,
				Medium,
				High,
			}

			public enum FadeFunctionValue : short
			{
				Linear,
				Late,
				VeryLate,
				Early,
				VeryEarly,
				Cosine,
				Zero,
				One,
			}
		}

		public enum FadeFunctionValue : short
		{
			Linear,
			Late,
			VeryLate,
			Early,
			VeryEarly,
			Cosine,
			Zero,
			One,
		}

		public enum FalloffFunctionValue : short
		{
			Linear,
			Late,
			VeryLate,
			Early,
			VeryEarly,
			Cosine,
			Zero,
			One,
		}

		public enum WobbleFunctionValue : short
		{
			One,
			Zero,
			Cosine,
			CosineVariablePeriod,
			DiagonalWave,
			DiagonalWaveVariablePeriod,
			Slide,
			SlideVariablePeriod,
			Noise,
			Jitter,
			Wander,
			Spark,
		}
	}
}
