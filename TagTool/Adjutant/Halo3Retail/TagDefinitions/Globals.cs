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
	[TagStructure(Class = "matg", Size = 0x600)]
	public class Globals
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
		public LanguageValue Language;
		public List<HavokCleanupResource> HavokCleanupResources;
		public List<SoundGlobal> SoundGlobals;
		public List<AiGlobal> AiGlobals;
		public List<DamageTableBlock> DamageTable;
		public uint Unknown44;
		public uint Unknown45;
		public uint Unknown46;
		public List<Sound> Sounds;
		public List<CameraBlock> Camera;
		public List<PlayerControlBlock> PlayerControl;
		public List<DifficultyBlock> Difficulty;
		public List<Grenade> Grenades;
		public uint Unknown47;
		public uint Unknown48;
		public uint Unknown49;
		public List<InterfaceTag> InterfaceTags;
		public uint Unknown50;
		public uint Unknown51;
		public uint Unknown52;
		public uint Unknown53;
		public uint Unknown54;
		public uint Unknown55;
		public List<PlayerInformationBlock> PlayerInformation;
		public List<PlayerRepresentationBlock> PlayerRepresentation;
		public List<FallingDamageBlock> FallingDamage;
		public List<Material> Materials;
		public List<PlayerColor> PlayerColors;
		public TagInstance MultiplayerGlobals;
		public List<CinematicAnchor> CinematicAnchors;
		public List<MetagameGlobal> MetagameGlobals;
		public uint Unknown56;
		public uint Unknown57;
		public uint StringCount;
		public uint LocaleTableSize;
		public uint LocaleIndexTableOffset;
		public uint LocaleDataIndexOffset;
		[TagField(Count = 20)] public byte[] IndexTableHash;
		[TagField(Count = 20)] public byte[] StringDataHash;
		public uint Unknown58;
		public uint Unknown59;
		public uint Unknown60;
		public uint StringCount2;
		public uint LocaleTableSize2;
		public uint LocaleIndexTableOffset2;
		public uint LocaleDataIndexOffset2;
		[TagField(Count = 20)] public byte[] IndexTableHash2;
		[TagField(Count = 20)] public byte[] StringDataHash2;
		public uint Unknown61;
		public uint Unknown62;
		public uint Unknown63;
		public uint StringCount3;
		public uint LocaleTableSize3;
		public uint LocaleIndexTableOffset3;
		public uint LocaleDataIndexOffset3;
		[TagField(Count = 20)] public byte[] IndexTableHash3;
		[TagField(Count = 20)] public byte[] StringDataHash3;
		public uint Unknown64;
		public uint Unknown65;
		public uint Unknown66;
		public uint StringCount4;
		public uint LocaleTableSize4;
		public uint LocaleIndexTableOffset4;
		public uint LocaleDataIndexOffset4;
		[TagField(Count = 20)] public byte[] IndexTableHash4;
		[TagField(Count = 20)] public byte[] StringDataHash4;
		public uint Unknown67;
		public uint Unknown68;
		public uint Unknown69;
		public uint StringCount5;
		public uint LocaleTableSize5;
		public uint LocaleIndexTableOffset5;
		public uint LocaleDataIndexOffset5;
		[TagField(Count = 20)] public byte[] IndexTableHash5;
		[TagField(Count = 20)] public byte[] StringDataHash5;
		public uint Unknown70;
		public uint Unknown71;
		public uint Unknown72;
		public uint StringCount6;
		public uint LocaleTableSize6;
		public uint LocaleIndexTableOffset6;
		public uint LocaleDataIndexOffset6;
		[TagField(Count = 20)] public byte[] IndexTableHash6;
		[TagField(Count = 20)] public byte[] StringDataHash6;
		public uint Unknown73;
		public uint Unknown74;
		public uint Unknown75;
		public uint StringCount7;
		public uint LocaleTableSize7;
		public uint LocaleIndexTableOffset7;
		public uint LocaleDataIndexOffset7;
		[TagField(Count = 20)] public byte[] IndexTableHash7;
		[TagField(Count = 20)] public byte[] StringDataHash7;
		public uint Unknown76;
		public uint Unknown77;
		public uint Unknown78;
		public uint StringCount8;
		public uint LocaleTableSize8;
		public uint LocaleIndexTableOffset8;
		public uint LocaleDataIndexOffset8;
		[TagField(Count = 20)] public byte[] IndexTableHash8;
		[TagField(Count = 20)] public byte[] StringDataHash8;
		public uint Unknown79;
		public uint Unknown80;
		public uint Unknown81;
		public uint StringCount9;
		public uint LocaleTableSize9;
		public uint LocaleIndexTableOffset9;
		public uint LocaleDataIndexOffset9;
		[TagField(Count = 20)] public byte[] IndexTableHash9;
		[TagField(Count = 20)] public byte[] StringDataHash9;
		public uint Unknown82;
		public uint Unknown83;
		public uint Unknown84;
		public uint StringCount10;
		public uint LocaleTableSize10;
		public uint LocaleIndexTableOffset10;
		public uint LocaleDataIndexOffset10;
		[TagField(Count = 20)] public byte[] IndexTableHash10;
		[TagField(Count = 20)] public byte[] StringDataHash10;
		public uint Unknown85;
		public uint Unknown86;
		public uint Unknown87;
		public uint StringCount11;
		public uint LocaleTableSize11;
		public uint LocaleIndexTableOffset11;
		public uint LocaleDataIndexOffset11;
		[TagField(Count = 20)] public byte[] IndexTableHash11;
		[TagField(Count = 20)] public byte[] StringDataHash11;
		public uint Unknown88;
		public uint Unknown89;
		public uint Unknown90;
		public uint StringCount12;
		public uint LocaleTableSize12;
		public uint LocaleIndexTableOffset12;
		public uint LocaleDataIndexOffset12;
		[TagField(Count = 20)] public byte[] IndexTableHash12;
		[TagField(Count = 20)] public byte[] StringDataHash12;
		public uint Unknown91;
		public TagInstance RasterizerGlobals;
		public TagInstance DefaultCameraEffect;
		public TagInstance DefaultWind;
		public TagInstance DefaultDamageEffect;
		public TagInstance DefaultCollisionDamage;
		public StringID UnknownMaterial;
		public short UnknownGlobalMaterialIndex;
		public short Unknown92;
		public TagInstance EffectGlobals;
		public uint Unknown93;
		public uint Unknown94;
		public uint Unknown95;
		public uint Unknown96;
		public uint Unknown97;
		public uint Unknown98;
		public uint Unknown99;
		public uint Unknown100;
		public uint Unknown101;
		public uint Unknown102;
		public uint Unknown103;
		public uint Unknown104;
		public uint Unknown105;
		public uint Unknown106;
		public uint Unknown107;
		public uint Unknown108;
		public uint Unknown109;
		public uint Unknown110;
		public uint Unknown111;
		public uint Unknown112;
		public uint Unknown113;
		public uint Unknown114;
		public uint Unknown115;
		public uint Unknown116;
		public uint Unknown117;
		public uint Unknown118;
		public uint Unknown119;
		public uint Unknown120;
		public uint Unknown121;
		public uint Unknown122;
		public uint Unknown123;
		public uint Unknown124;
		public uint Unknown125;
		public uint Unknown126;
		public uint Unknown127;
		public uint Unknown128;
		public uint Unknown129;
		public uint Unknown130;
		public uint Unknown131;
		public uint Unknown132;
		public uint Unknown133;
		public uint Unknown134;
		public uint Unknown135;

		public enum LanguageValue : int
		{
			English,
			Japanese,
			German,
			French,
			Spanish,
			LatinAmericanSpanish,
			Italian,
			Korean,
			ChineseTraditional,
			ChineseSimplified,
			Portuguese,
			Polish,
		}

		[TagStructure(Size = 0x10)]
		public class HavokCleanupResource
		{
			public TagInstance ObjectCleanupEffect;
		}

		[TagStructure(Size = 0x50)]
		public class SoundGlobal
		{
			public TagInstance SoundClasses;
			public TagInstance SoundEffects;
			public TagInstance SoundMix;
			public TagInstance SoundCombatDialogueConstants;
			public TagInstance SoundGlobalPropagation;
		}

		[TagStructure(Size = 0x1B0)]
		public class AiGlobal
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public float DangerBroadlyFacing;
			public uint Unknown4;
			public float DangerShootingNear;
			public uint Unknown5;
			public float DangerShootingAt;
			public uint Unknown6;
			public float DangerExtremelyClose;
			public uint Unknown7;
			public float DangerShieldDamage;
			public float DangerExtendedShieldDamage;
			public float DangerBodyDamage;
			public float DangerExtendedBodyDamage;
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
			public TagInstance GlobalDialogue;
			public StringID DefaultMissionDialogueSoundEffect;
			public uint Unknown20;
			public uint Unknown21;
			public uint Unknown22;
			public uint Unknown23;
			public uint Unknown24;
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
			public float HoistStepMin;
			public float HoistStepMax;
			public float HoistCrouchMin;
			public float HoistCrouchMax;
			public float HoistStandMin;
			public float HoistStandMax;
			public uint Unknown25;
			public uint Unknown26;
			public uint Unknown27;
			public uint Unknown28;
			public uint Unknown29;
			public uint Unknown30;
			public float VaultStepMin;
			public float VaultStepMax;
			public float VaultCrouchMin;
			public float VaultCrouchMax;
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
			public List<GravemindProperty> GravemindProperties;
			public uint Unknown43;
			public uint Unknown44;
			public uint Unknown45;
			public uint Unknown46;
			public uint Unknown47;
			public uint Unknown48;
			public uint Unknown49;
			public uint Unknown50;
			public uint Unknown51;
			public uint Unknown52;
			public uint Unknown53;
			public uint Unknown54;
			public float ScaryTargetThreshold;
			public float ScaryWeaponThreshold;
			public uint Unknown55;
			public uint Unknown56;
			public uint Unknown57;
			public uint Unknown58;
			public uint Unknown59;
			public uint Unknown60;
			public uint Unknown61;
			public uint Unknown62;
			public uint Unknown63;
			public uint Unknown64;
			public uint Unknown65;
			public List<Style> Styles;

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
				public TagInstance Style2;
			}
		}

		[TagStructure(Size = 0xC)]
		public class DamageTableBlock
		{
			public List<DamageGroup> DamageGroups;

			[TagStructure(Size = 0x10)]
			public class DamageGroup
			{
				public StringID Name;
				public List<ArmorModifier> ArmorModifiers;

				[TagStructure(Size = 0x8)]
				public class ArmorModifier
				{
					public StringID Name;
					public float DamageMultiplier;
				}
			}
		}

		[TagStructure(Size = 0x10)]
		public class Sound
		{
			public TagInstance SoundObsolete;
		}

		[TagStructure(Size = 0xA0)]
		public class CameraBlock
		{
			public TagInstance DefaultUnitCameraTrack;
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
			public short Unknown25;
			public short Unknown26;
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
		}

		[TagStructure(Size = 0x88)]
		public class PlayerControlBlock
		{
			public float MagnetismFriction;
			public float MagnetismAdhesion;
			public float InconsequentialTargetScale;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public float CrosshairLocationX;
			public float CrosshairLocationY;
			public float SecondsToStart;
			public float SecondsToFullSpeed;
			public float DecayRate;
			public float FullSpeedMultiplier;
			public float PeggedMagnitude;
			public float PeggedAngularThreshold;
			public uint Unknown4;
			public uint Unknown5;
			public float LookDefaultPitchRate;
			public float LookDefaultYawRate;
			public float LookPegThreshold;
			public float LookYawAccelerationTime;
			public float LookYawAccelerationScale;
			public float LookPitchAccelerationTime;
			public float LookPitchAccelerationScale;
			public float LookAutolevelingScale;
			public uint Unknown6;
			public uint Unknown7;
			public float GravityScale;
			public int MinimumAutolevelingTicks;
			public Angle MinimumAngleForVehicleFlipping;
			public List<LookFunctionBlock> LookFunction;
			public float MinimumActionHoldTime;
			public uint Unknown8;

			[TagStructure(Size = 0x4)]
			public class LookFunctionBlock
			{
				public float Scale;
			}
		}

		[TagStructure(Size = 0x284)]
		public class DifficultyBlock
		{
			public float EasyEnemyDamage;
			public float NormalEnemyDamage;
			public float HardEnemyDamage;
			public float ImpossibleEnemyDamage;
			public float EasyEnemyVitality;
			public float NormalEnemyVitality;
			public float HardEnemyVitality;
			public float ImpossibleEnemyVitality;
			public float EasyEnemyShield;
			public float NormalEnemyShield;
			public float HardEnemyShield;
			public float ImpossibleEnemyShield;
			public float EasyEnemyRecharge;
			public float NormalEnemyRecharge;
			public float HardEnemyRecharge;
			public float ImpossibleEnemyRecharge;
			public float EasyFriendDamage;
			public float NormalFriendDamage;
			public float HardFriendDamage;
			public float ImpossibleFriendDamage;
			public float EasyFriendVitality;
			public float NormalFriendVitality;
			public float HardFriendVitality;
			public float ImpossibleFriendVitality;
			public float EasyFriendShield;
			public float NormalFriendShield;
			public float HardFriendShield;
			public float ImpossibleFriendShield;
			public float EasyFriendRecharge;
			public float NormalFriendRecharge;
			public float HardFriendRecharge;
			public float ImpossibleFriendRecharge;
			public float EasyInfectionForms;
			public float NormalInfectionForms;
			public float HardInfectionForms;
			public float ImpossibleInfectionForms;
			public float EasyUnknown;
			public float NormalUnknown;
			public float HardUnknown;
			public float ImpossibleUnknown;
			public float EasyRateOfFire;
			public float NormalRateOfFire;
			public float HardRateOfFire;
			public float ImpossibleRateOfFire;
			public float EasyProjectileError;
			public float NormalProjectileError;
			public float HardProjectileError;
			public float ImpossibleProjectileError;
			public float EasyBurstError;
			public float NormalBurstError;
			public float HardBurstError;
			public float ImpossibleBurstError;
			public float EasyTargetDelay;
			public float NormalTargetDelay;
			public float HardTargetDelay;
			public float ImpossibleTargetDelay;
			public float EasyBurstSeparation;
			public float NormalBurstSeparation;
			public float HardBurstSeparation;
			public float ImpossibleBurstSeparation;
			public float EasyTargetTracking;
			public float NormalTargetTracking;
			public float HardTargetTracking;
			public float ImpossibleTargetTracking;
			public float EasyTargetLeading;
			public float NormalTargetLeading;
			public float HardTargetLeading;
			public float ImpossibleTargetLeading;
			public float EasyOverchargeChance;
			public float NormalOverchargeChance;
			public float HardOverchargeChance;
			public float ImpossibleOverchargeChance;
			public float EasySpecialFireDelay;
			public float NormalSpecialFireDelay;
			public float HardSpecialFireDelay;
			public float ImpossibleSpecialFireDelay;
			public float EasyGuidanceVsPlayer;
			public float NormalGuidanceVsPlayer;
			public float HardGuidanceVsPlayer;
			public float ImpossibleGuidanceVsPlayer;
			public float EasyMeleeDelayBase;
			public float NormalMeleeDelayBase;
			public float HardMeleeDelayBase;
			public float ImpossibleMeleeDelayBase;
			public float EasyMeleeDelayScale;
			public float NormalMeleeDelayScale;
			public float HardMeleeDelayScale;
			public float ImpossibleMeleeDelayScale;
			public float EasyUnknown2;
			public float NormalUnknown2;
			public float HardUnknown2;
			public float ImpossibleUnknown2;
			public float EasyGrenadeChanceScale;
			public float NormalGrenadeChanceScale;
			public float HardGrenadeChanceScale;
			public float ImpossibleGrenadeChanceScale;
			public float EasyGrenadeTimerScale;
			public float NormalGrenadeTimerScale;
			public float HardGrenadeTimerScale;
			public float ImpossibleGrenadeTimerScale;
			public float EasyUnknown3;
			public float NormalUnknown3;
			public float HardUnknown3;
			public float ImpossibleUnknown3;
			public float EasyUnknown4;
			public float NormalUnknown4;
			public float HardUnknown4;
			public float ImpossibleUnknown4;
			public float EasyUnknown5;
			public float NormalUnknown5;
			public float HardUnknown5;
			public float ImpossibleUnknown5;
			public float EasyMajorUpgradeNormal;
			public float NormalMajorUpgradeNormal;
			public float HardMajorUpgradeNormal;
			public float ImpossibleMajorUpgradeNormal;
			public float EasyMajorUpgradeFew;
			public float NormalMajorUpgradeFew;
			public float HardMajorUpgradeFew;
			public float ImpossibleMajorUpgradeFew;
			public float EasyMajorUpgradeMany;
			public float NormalMajorUpgradeMany;
			public float HardMajorUpgradeMany;
			public float ImpossibleMajorUpgradeMany;
			public float EasyPlayerVehicleRamChance;
			public float NormalPlayerVehicleRamChance;
			public float HardPlayerVehicleRamChance;
			public float ImpossiblePlayerVehicleRamChance;
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
			public uint Unknown26;
			public uint Unknown27;
			public uint Unknown28;
			public uint Unknown29;
			public uint Unknown30;
			public uint Unknown31;
			public uint Unknown32;
			public uint Unknown33;
		}

		[TagStructure(Size = 0x44)]
		public class Grenade
		{
			public short MaximumCount;
			public short Unknown;
			public TagInstance ThrowingEffect;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public TagInstance Equipment;
			public TagInstance Projectile;
		}

		[TagStructure(Size = 0x120)]
		public class InterfaceTag
		{
			public TagInstance Spinner;
			public TagInstance Obsolete;
			public TagInstance ScreenColorTable;
			public TagInstance HudColorTable;
			public TagInstance EditorColorTable;
			public TagInstance DialogColorTable;
			public TagInstance MotionSensorSweepBitmap;
			public TagInstance MotionSensorSweepBitmapMask;
			public TagInstance MultiplayerHudBitmap;
			public TagInstance HudDigitsDefinition;
			public TagInstance MotionSensorBlipBitmap;
			public TagInstance InterfaceGooMap1;
			public TagInstance InterfaceGooMap2;
			public TagInstance InterfaceGooMap3;
			public TagInstance MainMenuUiGlobals;
			public TagInstance SinglePlayerUiGlobals;
			public TagInstance MultiplayerUiGlobals;
			public TagInstance HudGlobals;
		}

		[TagStructure(Size = 0xC0)]
		public class PlayerInformationBlock
		{
			public float WalkingSpeed;
			public float RunForward;
			public float RunBackward;
			public float RunSideways;
			public float RunAcceleration;
			public float SneakForward;
			public float SneakBackward;
			public float SneakSideways;
			public float SneakAcceleration;
			public float AirborneAcceleration;
			public float GrenadeOriginX;
			public float GrenadeOriginY;
			public float GrenadeOriginZ;
			public float StunMovementPenalty;
			public float StunTurningPenalty;
			public float StunJumpingPenalty;
			public float MinimumStunTime;
			public float MaximumStunTime;
			public float FirstPersonIdleTimeMin;
			public float FirstPersonIdleTimeMax;
			public float FirstPersonSkipFraction;
			public TagInstance Unknown;
			public TagInstance Unknown2;
			public TagInstance CoopRespawnEffect;
			public int BinocularsZoomCount;
			public float BinocularZoomRangeMin;
			public float BinocularZoomRangeMax;
			public TagInstance FlashlightOn;
			public TagInstance FlashlightOff;
			public TagInstance DefaultDamageResponse;
		}

		[TagStructure(Size = 0x54)]
		public class PlayerRepresentationBlock
		{
			public TagInstance FirstPersonHands;
			public TagInstance FirstPersonBody;
			public TagInstance ThirdPersonUnit;
			public StringID ThirdPersonVariant;
			public TagInstance BinocularsZoomInSound;
			public TagInstance BinocularsZoomOutSound;
		}

		[TagStructure(Size = 0x78)]
		public class FallingDamageBlock
		{
			public float HarmfulFallingDistanceMin;
			public float HarmfulFallingDistanceMax;
			public TagInstance FallingDamage;
			public TagInstance Unknown;
			public TagInstance SoftLanding;
			public TagInstance HardLanding;
			public TagInstance ScriptDamage;
			public float MaximumFallingDistance;
			public TagInstance DistanceDamage;
			public float Unknown2;
			public float Unknown3;
			public float Unknown4;
		}

		[TagStructure(Size = 0x170)]
		public class Material
		{
			public StringID Name;
			public StringID ParentName;
			public short ParentIndex;
			public FlagsValue Flags;
			public StringID GeneralArmor;
			public StringID SpecificArmor;
			public uint Unknown;
			public float Friction;
			public float Restitution;
			public float Density;
			public List<WaterDragProperty> WaterDragProperties;
			public TagInstance BreakableSurface;
			public TagInstance SoundSweetenerSmall;
			public TagInstance SoundSweetenerMedium;
			public TagInstance SoundSweetenerLarge;
			public TagInstance SoundSweetenerRolling;
			public TagInstance SoundSweetenerGrinding;
			public TagInstance SoundSweetenerMeleeSmall;
			public TagInstance SoundSweetenerMeleeMedium;
			public TagInstance SoundSweetenerMeleeLarge;
			public TagInstance EffectSweetenerSmall;
			public TagInstance EffectSweetenerMedium;
			public TagInstance EffectSweetenerLarge;
			public TagInstance EffectSweetenerRolling;
			public TagInstance EffectSweetenerGrinding;
			public TagInstance EffectSweetenerMelee;
			public TagInstance WaterRippleSmall;
			public TagInstance WaterRippleMedium;
			public TagInstance WaterRippleLarge;
			public SweetenerInheritanceFlagsValue SweetenerInheritanceFlags;
			public TagInstance MaterialEffects;
			public List<WaterInteractionBlock> WaterInteraction;

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

			[TagStructure(Size = 0x28)]
			public class WaterDragProperty
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
				public uint Unknown10;
			}

			public enum SweetenerInheritanceFlagsValue : int
			{
				None,
				SoundSmall,
				SoundMedium,
				SoundLarge = 4,
				SoundRolling = 8,
				SoundGrinding = 16,
				SoundMeleeSmall = 32,
				SoundMeleeMedium = 64,
				SoundMeleeLarge = 128,
				EffectSmall = 256,
				EffectMedium = 512,
				EffectLarge = 1024,
				EffectRolling = 2048,
				EffectGrinding = 4096,
				EffectMelee = 8192,
				WaterRippleSmall = 16384,
				WaterRippleMedium = 32768,
				WaterRippleLarge = 65536,
			}

			[TagStructure(Size = 0xC)]
			public class WaterInteractionBlock
			{
				public StringID SurfaceName;
				public StringID SubmergedName;
				public short SurfaceIndex;
				public short SubmergedIndex;
			}
		}

		[TagStructure(Size = 0xC)]
		public class PlayerColor
		{
			public float ColorR;
			public float ColorG;
			public float ColorB;
		}

		[TagStructure(Size = 0x14)]
		public class CinematicAnchor
		{
			public TagInstance CinematicAnchor2;
			public uint Unknown;
		}

		[TagStructure(Size = 0x48)]
		public class MetagameGlobal
		{
			public List<Medal> Medals;
			public List<DifficultyBlock> Difficulty;
			public List<PrimarySkull> PrimarySkulls;
			public List<SecondarySkull> SecondarySkulls;
			public int Unknown;
			public int DeathPenalty;
			public int BetrayalPenalty;
			public int Unknown2;
			public float MultikillWindow;
			public float EmpWindow;

			[TagStructure(Size = 0x4)]
			public class Medal
			{
				public float Multiplier;
			}

			[TagStructure(Size = 0x4)]
			public class DifficultyBlock
			{
				public float Multiplier;
			}

			[TagStructure(Size = 0x4)]
			public class PrimarySkull
			{
				public float Multiplier;
			}

			[TagStructure(Size = 0x4)]
			public class SecondarySkull
			{
				public float Multiplier;
			}
		}
	}
}
