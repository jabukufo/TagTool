using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Serialization;
using TagTool.Cache;
using TagTool.Common;

namespace Adjutant.Library.Definitions.Halo3Retail.TagDefinitions
{
	[TagStructure(Class = "scnr", Size = 0x7B8)]
	public class Scenario
	{
		public MapTypeValue MapType;
		public FlagsValue Flags;
		public int CampaignId;
		public int MapId;
		public Angle LocalNorth;
		public float SandboxBudget;
		public List<StructureBsp> StructureBsps;
		public CachedTagInstance Unknown;
		public List<SkyReference> SkyReferences;
		public List<BspGroup> BspGroups;
		public List<ScenarioBspAudibilityBlock> ScenarioBspAudibility;
		public List<ScenarioZonesetGroup> ScenarioZonesetGroups;
		public List<BspAtla> BspAtlas;
		public uint Unknown2;
		public uint Unknown3;
		public uint Unknown4;
		public uint Unknown5;
		public uint Unknown6;
		public uint Unknown7;
		public uint Unknown8;
		public uint Unknown9;
		public uint Unknown10;
		public byte[] EditorScenarioData;
		public uint Unknown11;
		public uint Unknown12;
		public uint Unknown13;
		public List<ObjectName> ObjectNames;
		public List<SceneryBlock> Scenery;
		public List<SceneryPaletteBlock> SceneryPalette;
		public List<Biped> Bipeds;
		public List<BipedPaletteBlock> BipedPalette;
		public List<Vehicle> Vehicles;
		public List<VehiclePaletteBlock> VehiclePalette;
		public List<EquipmentBlock> Equipment;
		public List<EquipmentPaletteBlock> EquipmentPalette;
		public List<Weapon> Weapons;
		public List<WeaponPaletteBlock> WeaponPalette;
		public List<DeviceGroup> DeviceGroups;
		public List<Machine> Machines;
		public List<MachinePaletteBlock> MachinePalette;
		public List<Terminal> Terminals;
		public List<TerminalPaletteBlock> TerminalPalette;
		public List<Control> Controls;
		public List<ControlPaletteBlock> ControlPalette;
		public List<SoundSceneryBlock> SoundScenery;
		public List<SoundSceneryPaletteBlock> SoundSceneryPalette;
		public List<Giant> Giants;
		public List<GiantPaletteBlock> GiantPalette;
		public List<EffectSceneryBlock> EffectScenery;
		public List<EffectSceneryPaletteBlock> EffectSceneryPalette;
		public List<LightVolume> LightVolumes;
		public List<LightVolumesPaletteBlock> LightVolumesPalette;
		public List<SandboxVehicle> SandboxVehicles;
		public List<SandboxWeapon> SandboxWeapons;
		public List<SandboxEquipmentBlock> SandboxEquipment;
		public List<SandboxSceneryBlock> SandboxScenery;
		public List<SandboxTeleporter> SandboxTeleporters;
		public List<SandboxGoalObject> SandboxGoalObjects;
		public List<SandboxSpawningBlock> SandboxSpawning;
		public List<SoftCeiling> SoftCeilings;
		public List<PlayerStartingProfileBlock> PlayerStartingProfile;
		public List<PlayerStartingLocation> PlayerStartingLocations;
		public List<TriggerVolume> TriggerVolumes;
		public uint Unknown14;
		public uint Unknown15;
		public uint Unknown16;
		public List<ZonesetSwitchTriggerVolume> ZonesetSwitchTriggerVolumes;
		public List<MultiplayerConstantsOverrideBlock> MultiplayerConstantsOverride;
		public List<UnknownBlock> Unknown17;
		public List<UnknownBlock2> Unknown18;
		public List<UnknownBlock3> Unknown19;
		public List<UnknownBlock4> Unknown20;
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
		public uint Unknown55;
		public uint Unknown56;
		public List<Decal> Decals;
		public List<DecalPaletteBlock> DecalPalette;
		public uint Unknown57;
		public uint Unknown58;
		public uint Unknown59;
		public List<StylePaletteBlock> StylePalette;
		public List<SquadGroup> SquadGroups;
		public List<Squad> Squads;
		public List<Zone> Zones;
		public uint Unknown60;
		public uint Unknown61;
		public uint Unknown62;
		public List<CharacterPaletteBlock> CharacterPalette;
		public uint Unknown63;
		public uint Unknown64;
		public uint Unknown65;
		public List<AiPathfindingDatum> AiPathfindingData;
		public uint Unknown66;
		public uint Unknown67;
		public uint Unknown68;
		public byte[] ScriptStrings;
		public List<Script> Scripts;
		public List<Global> Globals;
		public List<ScriptReference> ScriptReferences;
		public uint Unknown69;
		public uint Unknown70;
		public uint Unknown71;
		public List<ScriptingDatum> ScriptingData;
		public List<CutsceneFlag> CutsceneFlags;
		public List<CutsceneCameraPoint> CutsceneCameraPoints;
		public List<CutsceneTitle> CutsceneTitles;
		public CachedTagInstance CustomObjectNameStrings;
		public CachedTagInstance ChapterTitleStrings;
		public List<ScenarioResource> ScenarioResources;
		public List<UnitSeatsMappingBlock> UnitSeatsMapping;
		public List<ScenarioKillTrigger> ScenarioKillTriggers;
		public List<ScenarioSafeTrigger> ScenarioSafeTriggers;
		public List<ScriptExpression> ScriptExpressions;
		public uint Unknown72;
		public uint Unknown73;
		public uint Unknown74;
		public List<AiTrigger> AiTriggers;
		public List<BackgroundSoundEnvironmentPaletteBlock> BackgroundSoundEnvironmentPalette;
		public uint Unknown75;
		public uint Unknown76;
		public uint Unknown77;
		public uint Unknown78;
		public uint Unknown79;
		public uint Unknown80;
		public List<UnknownBlock5> Unknown81;
		public List<FogBlock> Fog;
		public List<CameraEffect> CameraEffects;
		public uint Unknown82;
		public uint Unknown83;
		public uint Unknown84;
		public uint Unknown85;
		public uint Unknown86;
		public uint Unknown87;
		public uint Unknown88;
		public uint Unknown89;
		public uint Unknown90;
		public List<ScenarioClusterDatum> ScenarioClusterData;
		public uint Unknown91;
		public uint Unknown92;
		public uint Unknown93;
		public int ObjectSalts1;
		public int ObjectSalts2;
		public int ObjectSalts3;
		public int ObjectSalts4;
		public int ObjectSalts5;
		public int ObjectSalts6;
		public int ObjectSalts7;
		public int ObjectSalts8;
		public int ObjectSalts9;
		public int ObjectSalts10;
		public int ObjectSalts11;
		public int ObjectSalts12;
		public int ObjectSalts13;
		public int ObjectSalts14;
		public int ObjectSalts15;
		public int ObjectSalts16;
		public int ObjectSalts17;
		public int ObjectSalts18;
		public int ObjectSalts19;
		public int ObjectSalts20;
		public int ObjectSalts21;
		public int ObjectSalts22;
		public int ObjectSalts23;
		public int ObjectSalts24;
		public int ObjectSalts25;
		public int ObjectSalts26;
		public int ObjectSalts27;
		public int ObjectSalts28;
		public int ObjectSalts29;
		public int ObjectSalts30;
		public int ObjectSalts31;
		public int ObjectSalts32;
		public List<SpawnDatum> SpawnData;
		public CachedTagInstance SoundEffectsCollection;
		public List<Crate> Crates;
		public List<CratePaletteBlock> CratePalette;
		public List<FlockPaletteBlock> FlockPalette;
		public List<Flock> Flocks;
		public CachedTagInstance SubtitleStrings;
		public uint Unknown94;
		public uint Unknown95;
		public uint Unknown96;
		public List<CreaturePaletteBlock> CreaturePalette;
		public List<EditorFolder> EditorFolders;
		public CachedTagInstance TerritoryLocationNameStrings;
		public uint Unknown97;
		public uint Unknown98;
		public List<MissionDialogueBlock> MissionDialogue;
		public CachedTagInstance ObjectiveStrings;
		public List<Interpolator> Interpolators;
		public uint Unknown99;
		public uint Unknown100;
		public uint Unknown101;
		public uint Unknown102;
		public uint Unknown103;
		public uint Unknown104;
		public List<SimulationDefinitionTableBlock> SimulationDefinitionTable;
		public CachedTagInstance DefaultCameraFx;
		public CachedTagInstance DefaultScreenFx;
		public CachedTagInstance SkyParameters;
		public CachedTagInstance GlobalLighing;
		public CachedTagInstance Lightmap;
		public CachedTagInstance PerformanceThrottles;
		public List<UnknownBlock6> Unknown105;
		public List<AiObjective> AiObjectives;
		public List<DesignerZoneset> DesignerZonesets;
		public List<UnknownBlock7> Unknown106;
		public uint Unknown107;
		public uint Unknown108;
		public uint Unknown109;
		public List<Cinematic> Cinematics;
		public List<CinematicLightingBlock> CinematicLighting;
		public uint Unknown110;
		public uint Unknown111;
		public uint Unknown112;
		public List<ScenarioMetagameBlock> ScenarioMetagame;
		public List<UnknownBlock8> Unknown113;
		public List<UnknownBlock9> Unknown114;
		public List<CortanaEffect> CortanaEffects;
		public List<LightmapAirprobe> LightmapAirprobes;
		public uint Unknown115;
		public uint Unknown116;
		public uint Unknown117;

		public enum MapTypeValue : short
		{
			SinglePlayer,
			Multiplayer,
			MainMenu,
		}

		public enum FlagsValue : ushort
		{
			None,
			Bit0,
			Bit1,
			Bit2 = 4,
			Bit3 = 8,
			Bit4 = 16,
			CharactersUsePreviousMissionWeapons = 32,
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

		[TagStructure(Size = 0x6C)]
		public class StructureBsp
		{
			public CachedTagInstance StructureBsp2;
			public CachedTagInstance Design;
			public CachedTagInstance Lighting;
			public int Unknown;
			public float Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public short Unknown5;
			public short Unknown6;
			public short Unknown7;
			public short Unknown8;
			public CachedTagInstance Cubemap;
			public CachedTagInstance Wind;
			public int Unknown9;
		}

		[TagStructure(Size = 0x14)]
		public class SkyReference
		{
			public CachedTagInstance SkyObject;
			public short NameIndex;
			public ActiveBspsValue ActiveBsps;

			public enum ActiveBspsValue : ushort
			{
				None,
				Bsp0,
				Bsp1,
				Bsp2 = 4,
				Bsp3 = 8,
				Bsp4 = 16,
				Bsp5 = 32,
				Bsp6 = 64,
				Bsp7 = 128,
				Bsp8 = 256,
				Bsp9 = 512,
				Bsp10 = 1024,
				Bsp11 = 2048,
				Bsp12 = 4096,
				Bsp13 = 8192,
				Bsp14 = 16384,
				Bsp15 = 32768,
			}
		}

		[TagStructure(Size = 0x2C)]
		public class BspGroup
		{
			public IncludedBspsValue IncludedBsps;
			public int Unknown;
			public List<BspChecksum> BspChecksums;
			public List<Bsp> Bsps;
			public List<Bsp2> Bsps2;

			public enum IncludedBspsValue : int
			{
				None,
				Bsp0,
				Bsp1,
				Bsp2 = 4,
				Bsp3 = 8,
				Bsp4 = 16,
				Bsp5 = 32,
				Bsp6 = 64,
				Bsp7 = 128,
				Bsp8 = 256,
				Bsp9 = 512,
				Bsp10 = 1024,
				Bsp11 = 2048,
				Bsp12 = 4096,
				Bsp13 = 8192,
				Bsp14 = 16384,
				Bsp15 = 32768,
				Bsp16 = 65536,
				Bsp17 = 131072,
				Bsp18 = 262144,
				Bsp19 = 524288,
				Bsp20 = 1048576,
				Bsp21 = 2097152,
				Bsp22 = 4194304,
				Bsp23 = 8388608,
				Bsp24 = 16777216,
				Bsp25 = 33554432,
				Bsp26 = 67108864,
				Bsp27 = 134217728,
				Bsp28 = 268435456,
				Bsp29 = 536870912,
				Bsp30 = 1073741824,
				Bsp31 = -2147483648,
			}

			[TagStructure(Size = 0x4)]
			public class BspChecksum
			{
				public int StructureChecksum;
			}

			[TagStructure(Size = 0x54)]
			public class Bsp
			{
				public List<Cluster> Clusters;
				public List<Cluster2> Clusters2;
				public List<ClusterSky> ClusterSkies;
				public List<ClusterVisibleSky> ClusterVisibleSkies;
				public uint Unknown;
				public uint Unknown2;
				public uint Unknown3;
				public List<UnknownBlock> Unknown4;
				public List<Cluster3> Clusters3;

				[TagStructure(Size = 0xC)]
				public class Cluster
				{
					public List<Bsp> Bsps;

					[TagStructure(Size = 0xC)]
					public class Bsp
					{
						public List<UnknownBlock> Unknown;

						[TagStructure(Size = 0x4)]
						public class UnknownBlock
						{
							public AllowValue Allow;

							public enum AllowValue : int
							{
								None,
								Bit0,
								Bit1,
								Bit2 = 4,
								Bit3 = 8,
								Bit4 = 16,
								Effects = 32,
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
								FiringEffects = 65536,
								Bit17 = 131072,
								Bit18 = 262144,
								Bit19 = 524288,
								Bit20 = 1048576,
								Bit21 = 2097152,
								Bit22 = 4194304,
								Bit23 = 8388608,
								Decals = 16777216,
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

				[TagStructure(Size = 0xC)]
				public class Cluster2
				{
					public List<Bsp> Bsps;

					[TagStructure(Size = 0xC)]
					public class Bsp
					{
						public List<UnknownBlock> Unknown;

						[TagStructure(Size = 0x4)]
						public class UnknownBlock
						{
							public AllowValue Allow;

							public enum AllowValue : int
							{
								None,
								Bit0,
								Bit1,
								Bit2 = 4,
								Bit3 = 8,
								Bit4 = 16,
								Effects = 32,
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
								FiringEffects = 65536,
								Bit17 = 131072,
								Bit18 = 262144,
								Bit19 = 524288,
								Bit20 = 1048576,
								Bit21 = 2097152,
								Bit22 = 4194304,
								Bit23 = 8388608,
								Decals = 16777216,
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

				[TagStructure(Size = 0x1)]
				public class ClusterSky
				{
					public sbyte SkyIndex;
				}

				[TagStructure(Size = 0x1)]
				public class ClusterVisibleSky
				{
					public sbyte SkyIndex;
				}

				[TagStructure(Size = 0x4)]
				public class UnknownBlock
				{
					public uint Unknown;
				}

				[TagStructure(Size = 0xC)]
				public class Cluster3
				{
					public List<UnknownBlock> Unknown;

					[TagStructure(Size = 0x1)]
					public class UnknownBlock
					{
						public sbyte Unknown;
					}
				}
			}

			[TagStructure(Size = 0x18)]
			public class Bsp2
			{
				public List<UnknownBlock> Unknown;
				public List<UnknownBlock2> Unknown2;

				[TagStructure(Size = 0xC)]
				public class UnknownBlock
				{
					public short Unknown;
					public short Unknown2;
					public int Unknown3;
					public short Unknown4;
					public short Unknown5;
				}

				[TagStructure(Size = 0x2)]
				public class UnknownBlock2
				{
					public short Unknown;
				}
			}
		}

		[TagStructure(Size = 0x64)]
		public class ScenarioBspAudibilityBlock
		{
			public int DoorPortalCount;
			public int UniqueClusterCount;
			public float ClusterDistanceBoundsMin;
			public float ClusterDistanceBoundsMax;
			public List<EncodedDoorPa> EncodedDoorPas;
			public List<ClusterDoorPortalEncodedPa> ClusterDoorPortalEncodedPas;
			public List<AiDeafeningPa> AiDeafeningPas;
			public List<ClusterDistance> ClusterDistances;
			public List<Bsp> Bsps;
			public List<BspClusterListBlock> BspClusterList;
			public List<ClusterMappingBlock> ClusterMapping;

			[TagStructure(Size = 0x4)]
			public class EncodedDoorPa
			{
				public int Unknown;
			}

			[TagStructure(Size = 0x4)]
			public class ClusterDoorPortalEncodedPa
			{
				public int Unknown;
			}

			[TagStructure(Size = 0x4)]
			public class AiDeafeningPa
			{
				public int Unknown;
			}

			[TagStructure(Size = 0x1)]
			public class ClusterDistance
			{
				public sbyte Unknown;
			}

			[TagStructure(Size = 0x8)]
			public class Bsp
			{
				public int Start;
				public int Count;
			}

			[TagStructure(Size = 0x8)]
			public class BspClusterListBlock
			{
				public int StartIndex;
				public int ClusterCount;
			}

			[TagStructure(Size = 0x2)]
			public class ClusterMappingBlock
			{
				public short Index;
			}
		}

		[TagStructure(Size = 0x24)]
		public class ScenarioZonesetGroup
		{
			public StringId Name;
			public int BspGroupIndex;
			public int ImportLoadedBsps;
			public LoadedBspsValue LoadedBsps;
			public LoadedDesignerZonesetsValue LoadedDesignerZonesets;
			public UnloadedDesignerZonesetsValue UnloadedDesignerZonesets;
			public LoadedCinematicZonesetsValue LoadedCinematicZonesets;
			public int BspAtlasIndex;
			public int ScenarioBspAudibilityIndex;

			public enum LoadedBspsValue : int
			{
				None,
				Bsp0,
				Bsp1,
				Bsp2 = 4,
				Bsp3 = 8,
				Bsp4 = 16,
				Bsp5 = 32,
				Bsp6 = 64,
				Bsp7 = 128,
				Bsp8 = 256,
				Bsp9 = 512,
				Bsp10 = 1024,
				Bsp11 = 2048,
				Bsp12 = 4096,
				Bsp13 = 8192,
				Bsp14 = 16384,
				Bsp15 = 32768,
				Bsp16 = 65536,
				Bsp17 = 131072,
				Bsp18 = 262144,
				Bsp19 = 524288,
				Bsp20 = 1048576,
				Bsp21 = 2097152,
				Bsp22 = 4194304,
				Bsp23 = 8388608,
				Bsp24 = 16777216,
				Bsp25 = 33554432,
				Bsp26 = 67108864,
				Bsp27 = 134217728,
				Bsp28 = 268435456,
				Bsp29 = 536870912,
				Bsp30 = 1073741824,
				Bsp31 = -2147483648,
			}

			public enum LoadedDesignerZonesetsValue : int
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
				Set16 = 65536,
				Set17 = 131072,
				Set18 = 262144,
				Set19 = 524288,
				Set20 = 1048576,
				Set21 = 2097152,
				Set22 = 4194304,
				Set23 = 8388608,
				Set24 = 16777216,
				Set25 = 33554432,
				Set26 = 67108864,
				Set27 = 134217728,
				Set28 = 268435456,
				Set29 = 536870912,
				Set30 = 1073741824,
				Set31 = -2147483648,
			}

			public enum UnloadedDesignerZonesetsValue : int
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
				Set16 = 65536,
				Set17 = 131072,
				Set18 = 262144,
				Set19 = 524288,
				Set20 = 1048576,
				Set21 = 2097152,
				Set22 = 4194304,
				Set23 = 8388608,
				Set24 = 16777216,
				Set25 = 33554432,
				Set26 = 67108864,
				Set27 = 134217728,
				Set28 = 268435456,
				Set29 = 536870912,
				Set30 = 1073741824,
				Set31 = -2147483648,
			}

			public enum LoadedCinematicZonesetsValue : int
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
				Set16 = 65536,
				Set17 = 131072,
				Set18 = 262144,
				Set19 = 524288,
				Set20 = 1048576,
				Set21 = 2097152,
				Set22 = 4194304,
				Set23 = 8388608,
				Set24 = 16777216,
				Set25 = 33554432,
				Set26 = 67108864,
				Set27 = 134217728,
				Set28 = 268435456,
				Set29 = 536870912,
				Set30 = 1073741824,
				Set31 = -2147483648,
			}
		}

		[TagStructure(Size = 0xC)]
		public class BspAtla
		{
			public StringId Name;
			public BspValue Bsp;
			public ConnectedBspsValue ConnectedBsps;

			public enum BspValue : int
			{
				None,
				Bsp0,
				Bsp1,
				Bsp2 = 4,
				Bsp3 = 8,
				Bsp4 = 16,
				Bsp5 = 32,
				Bsp6 = 64,
				Bsp7 = 128,
				Bsp8 = 256,
				Bsp9 = 512,
				Bsp10 = 1024,
				Bsp11 = 2048,
				Bsp12 = 4096,
				Bsp13 = 8192,
				Bsp14 = 16384,
				Bsp15 = 32768,
				Bsp16 = 65536,
				Bsp17 = 131072,
				Bsp18 = 262144,
				Bsp19 = 524288,
				Bsp20 = 1048576,
				Bsp21 = 2097152,
				Bsp22 = 4194304,
				Bsp23 = 8388608,
				Bsp24 = 16777216,
				Bsp25 = 33554432,
				Bsp26 = 67108864,
				Bsp27 = 134217728,
				Bsp28 = 268435456,
				Bsp29 = 536870912,
				Bsp30 = 1073741824,
				Bsp31 = -2147483648,
			}

			public enum ConnectedBspsValue : int
			{
				None,
				Bsp0,
				Bsp1,
				Bsp2 = 4,
				Bsp3 = 8,
				Bsp4 = 16,
				Bsp5 = 32,
				Bsp6 = 64,
				Bsp7 = 128,
				Bsp8 = 256,
				Bsp9 = 512,
				Bsp10 = 1024,
				Bsp11 = 2048,
				Bsp12 = 4096,
				Bsp13 = 8192,
				Bsp14 = 16384,
				Bsp15 = 32768,
				Bsp16 = 65536,
				Bsp17 = 131072,
				Bsp18 = 262144,
				Bsp19 = 524288,
				Bsp20 = 1048576,
				Bsp21 = 2097152,
				Bsp22 = 4194304,
				Bsp23 = 8388608,
				Bsp24 = 16777216,
				Bsp25 = 33554432,
				Bsp26 = 67108864,
				Bsp27 = 134217728,
				Bsp28 = 268435456,
				Bsp29 = 536870912,
				Bsp30 = 1073741824,
				Bsp31 = -2147483648,
			}
		}

		[TagStructure(Size = 0x24)]
		public class ObjectName
		{
			[TagField(Length = 32)] public string Name;
			public TypeValue Type;
			public short PlacementIndex;

			public enum TypeValue : short
			{
				Null = -1,
				Biped = 0,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}
		}

		[TagStructure(Size = 0xB4)]
		public class SceneryBlock
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public StringId Variant;
			public ActiveChangeColorsValue ActiveChangeColors;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public sbyte Unknown8;
			public byte PrimaryColorA;
			public byte PrimaryColorR;
			public byte PrimaryColorG;
			public byte PrimaryColorB;
			public byte SecondaryColorA;
			public byte SecondaryColorR;
			public byte SecondaryColorG;
			public byte SecondaryColorB;
			public byte TertiaryColorA;
			public byte TertiaryColorR;
			public byte TertiaryColorG;
			public byte TertiaryColorB;
			public byte QuaternaryColorA;
			public byte QuaternaryColorR;
			public byte QuaternaryColorG;
			public byte QuaternaryColorB;
			public PathfindingPolicyValue PathfindingPolicy;
			public LightmappingPolicyValue LightmappingPolicy;
			public List<PathfindingReference> PathfindingReferences;
			public short Unknown9;
			public short Unknown10;
			public SymmetryValue Symmetry;
			public EngineFlagsValue EngineFlags;
			public TeamValue Team;
			public sbyte SpawnSequence;
			public sbyte RuntimeMinimum;
			public sbyte RuntimeMaximum;
			public MultiplayerFlagsValue MultiplayerFlags;
			public short SpawnTime;
			public short AbandonTime;
			public sbyte Unknown11;
			public ShapeValue Shape;
			public sbyte TeleporterChannel;
			public sbyte Unknown12;
			public short Unknown13;
			public short AttachedNameIndex;
			public uint Unknown14;
			public uint Unknown15;
			public float WidthRadius;
			public float Depth;
			public float Top;
			public float Bottom;
			public uint Unknown16;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum ActiveChangeColorsValue : byte
			{
				None,
				Primary,
				Secondary,
				Tertiary = 4,
				Quaternary = 8,
			}

			public enum PathfindingPolicyValue : short
			{
				TagDefault,
				Dynamic,
				CutOut,
				Standard,
				None,
			}

			public enum LightmappingPolicyValue : short
			{
				TagDefault,
				Dynamic,
				PerVertex,
			}

			[TagStructure(Size = 0x4)]
			public class PathfindingReference
			{
				public short BspIndex;
				public short PathfindingObjectIndex;
			}

			public enum SymmetryValue : int
			{
				Both,
				Symmetric,
				Asymmetric,
			}

			public enum EngineFlagsValue : ushort
			{
				None,
				CaptureTheFlag,
				Slayer,
				Oddball = 4,
				KingOfTheHill = 8,
				Juggernaut = 16,
				Territories = 32,
				Assault = 64,
				Vip = 128,
				Infection = 256,
				Bit9 = 512,
			}

			public enum TeamValue : short
			{
				Red,
				Blue,
				Green,
				Orange,
				Purple,
				Yellow,
				Brown,
				Pink,
				Neutral,
			}

			public enum MultiplayerFlagsValue : byte
			{
				None,
				IsUniqueObject,
				NotPlacedAtStart,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
			}

			public enum ShapeValue : sbyte
			{
				None,
				Sphere,
				Cylinder,
				Box,
			}
		}

		[TagStructure(Size = 0x30)]
		public class SceneryPaletteBlock
		{
			public CachedTagInstance Scenery;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x74)]
		public class Biped
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public StringId Variant;
			public ActiveChangeColorsValue ActiveChangeColors;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public sbyte Unknown8;
			public byte PrimaryColorA;
			public byte PrimaryColorR;
			public byte PrimaryColorG;
			public byte PrimaryColorB;
			public byte SecondaryColorA;
			public byte SecondaryColorR;
			public byte SecondaryColorG;
			public byte SecondaryColorB;
			public byte TertiaryColorA;
			public byte TertiaryColorR;
			public byte TertiaryColorG;
			public byte TertiaryColorB;
			public byte QuaternaryColorA;
			public byte QuaternaryColorR;
			public byte QuaternaryColorG;
			public byte QuaternaryColorB;
			public float BodyVitalityPercentage;
			public FlagsValue Flags;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum ActiveChangeColorsValue : byte
			{
				None,
				Primary,
				Secondary,
				Tertiary = 4,
				Quaternary = 8,
			}

			public enum FlagsValue : int
			{
				None,
				Dead,
				Closed,
				NotEnterableByPlayer = 4,
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

		[TagStructure(Size = 0x30)]
		public class BipedPaletteBlock
		{
			public CachedTagInstance Biped;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0xA8)]
		public class Vehicle
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public StringId Variant;
			public ActiveChangeColorsValue ActiveChangeColors;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public sbyte Unknown8;
			public byte PrimaryColorA;
			public byte PrimaryColorR;
			public byte PrimaryColorG;
			public byte PrimaryColorB;
			public byte SecondaryColorA;
			public byte SecondaryColorR;
			public byte SecondaryColorG;
			public byte SecondaryColorB;
			public byte TertiaryColorA;
			public byte TertiaryColorR;
			public byte TertiaryColorG;
			public byte TertiaryColorB;
			public byte QuaternaryColorA;
			public byte QuaternaryColorR;
			public byte QuaternaryColorG;
			public byte QuaternaryColorB;
			public float BodyVitalityPercentage;
			public FlagsValue Flags;
			public SymmetryValue Symmetry;
			public EngineFlagsValue EngineFlags;
			public TeamValue Team;
			public sbyte SpawnSequence;
			public sbyte RuntimeMinimum;
			public sbyte RuntimeMaximum;
			public MultiplayerFlagsValue MultiplayerFlags;
			public short SpawnTime;
			public short AbandonTime;
			public sbyte Unknown9;
			public ShapeValue Shape;
			public sbyte TeleporterChannel;
			public sbyte Unknown10;
			public short Unknown11;
			public short AttachedNameIndex;
			public uint Unknown12;
			public uint Unknown13;
			public float WidthRadius;
			public float Depth;
			public float Top;
			public float Bottom;
			public uint Unknown14;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum ActiveChangeColorsValue : byte
			{
				None,
				Primary,
				Secondary,
				Tertiary = 4,
				Quaternary = 8,
			}

			public enum FlagsValue : int
			{
				None,
				Dead,
				Closed,
				NotEnterableByPlayer = 4,
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

			public enum SymmetryValue : int
			{
				Both,
				Symmetric,
				Asymmetric,
			}

			public enum EngineFlagsValue : ushort
			{
				None,
				CaptureTheFlag,
				Slayer,
				Oddball = 4,
				KingOfTheHill = 8,
				Juggernaut = 16,
				Territories = 32,
				Assault = 64,
				Vip = 128,
				Infection = 256,
				Bit9 = 512,
			}

			public enum TeamValue : short
			{
				Red,
				Blue,
				Green,
				Orange,
				Purple,
				Yellow,
				Brown,
				Pink,
				Neutral,
			}

			public enum MultiplayerFlagsValue : byte
			{
				None,
				IsUniqueObject,
				NotPlacedAtStart,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
			}

			public enum ShapeValue : sbyte
			{
				None,
				Sphere,
				Cylinder,
				Box,
			}
		}

		[TagStructure(Size = 0x30)]
		public class VehiclePaletteBlock
		{
			public CachedTagInstance Vehicle;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x8C)]
		public class EquipmentBlock
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public EquipmentFlagsValue EquipmentFlags;
			public SymmetryValue Symmetry;
			public EngineFlagsValue EngineFlags;
			public TeamValue Team;
			public sbyte SpawnSequence;
			public sbyte RuntimeMinimum;
			public sbyte RuntimeMaximum;
			public MultiplayerFlagsValue MultiplayerFlags;
			public short SpawnTime;
			public short AbandonTime;
			public sbyte Unknown6;
			public ShapeValue Shape;
			public sbyte TeleporterChannel;
			public sbyte Unknown7;
			public short Unknown8;
			public short AttachedNameIndex;
			public uint Unknown9;
			public uint Unknown10;
			public float WidthRadius;
			public float Depth;
			public float Top;
			public float Bottom;
			public uint Unknown11;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum EquipmentFlagsValue : int
			{
				None,
				InitiallyAtRestDoesNotFall,
				Bit1,
				DoesAccelerateMovesDueToExplosions = 4,
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

			public enum SymmetryValue : int
			{
				Both,
				Symmetric,
				Asymmetric,
			}

			public enum EngineFlagsValue : ushort
			{
				None,
				CaptureTheFlag,
				Slayer,
				Oddball = 4,
				KingOfTheHill = 8,
				Juggernaut = 16,
				Territories = 32,
				Assault = 64,
				Vip = 128,
				Infection = 256,
				Bit9 = 512,
			}

			public enum TeamValue : short
			{
				Red,
				Blue,
				Green,
				Orange,
				Purple,
				Yellow,
				Brown,
				Pink,
				Neutral,
			}

			public enum MultiplayerFlagsValue : byte
			{
				None,
				IsUniqueObject,
				NotPlacedAtStart,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
			}

			public enum ShapeValue : sbyte
			{
				None,
				Sphere,
				Cylinder,
				Box,
			}
		}

		[TagStructure(Size = 0x30)]
		public class EquipmentPaletteBlock
		{
			public CachedTagInstance Equipment;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0xA8)]
		public class Weapon
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public StringId Variant;
			public ActiveChangeColorsValue ActiveChangeColors;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public sbyte Unknown8;
			public byte PrimaryColorA;
			public byte PrimaryColorR;
			public byte PrimaryColorG;
			public byte PrimaryColorB;
			public byte SecondaryColorA;
			public byte SecondaryColorR;
			public byte SecondaryColorG;
			public byte SecondaryColorB;
			public byte TertiaryColorA;
			public byte TertiaryColorR;
			public byte TertiaryColorG;
			public byte TertiaryColorB;
			public byte QuaternaryColorA;
			public byte QuaternaryColorR;
			public byte QuaternaryColorG;
			public byte QuaternaryColorB;
			public short RoundsLeft;
			public short RoundsLoaded;
			public WeaponFlagsValue WeaponFlags;
			public SymmetryValue Symmetry;
			public EngineFlagsValue EngineFlags;
			public TeamValue Team;
			public sbyte SpawnSequence;
			public sbyte RuntimeMinimum;
			public sbyte RuntimeMaximum;
			public MultiplayerFlagsValue MultiplayerFlags;
			public short SpawnTime;
			public short AbandonTime;
			public sbyte Unknown9;
			public ShapeValue Shape;
			public sbyte TeleporterChannel;
			public sbyte Unknown10;
			public short Unknown11;
			public short AttachedNameIndex;
			public uint Unknown12;
			public uint Unknown13;
			public float WidthRadius;
			public float Depth;
			public float Top;
			public float Bottom;
			public uint Unknown14;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum ActiveChangeColorsValue : byte
			{
				None,
				Primary,
				Secondary,
				Tertiary = 4,
				Quaternary = 8,
			}

			public enum WeaponFlagsValue : int
			{
				None,
				InitiallyAtRestDoesNotFall,
				Bit1,
				DoesAccelerateMovesDueToExplosions = 4,
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

			public enum SymmetryValue : int
			{
				Both,
				Symmetric,
				Asymmetric,
			}

			public enum EngineFlagsValue : ushort
			{
				None,
				CaptureTheFlag,
				Slayer,
				Oddball = 4,
				KingOfTheHill = 8,
				Juggernaut = 16,
				Territories = 32,
				Assault = 64,
				Vip = 128,
				Infection = 256,
				Bit9 = 512,
			}

			public enum TeamValue : short
			{
				Red,
				Blue,
				Green,
				Orange,
				Purple,
				Yellow,
				Brown,
				Pink,
				Neutral,
			}

			public enum MultiplayerFlagsValue : byte
			{
				None,
				IsUniqueObject,
				NotPlacedAtStart,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
			}

			public enum ShapeValue : sbyte
			{
				None,
				Sphere,
				Cylinder,
				Box,
			}
		}

		[TagStructure(Size = 0x30)]
		public class WeaponPaletteBlock
		{
			public CachedTagInstance Weapon;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x28)]
		public class DeviceGroup
		{
			[TagField(Length = 32)] public string Name;
			public float InitialValue;
			public FlagsValue Flags;

			public enum FlagsValue : int
			{
				None,
				OnlyUseOnce,
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

		[TagStructure(Size = 0x70)]
		public class Machine
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public short PowerGroup;
			public short PositionGroup;
			public DeviceFlagsValue DeviceFlags;
			public MachineFlagsValue MachineFlags;
			public List<PathfindingReference> PathfindingReferences;
			public PathfindingPolicyValue PathfindingPolicy;
			public short Unknown6;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum DeviceFlagsValue : int
			{
				None,
				InitiallyOpen,
				InitiallyClosed,
				CanOnlyChangeOnce = 4,
				PositionReversed = 8,
				UsableFromBothSides = 16,
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

			public enum MachineFlagsValue : int
			{
				None,
				DoesNotOperateAutomatically,
				OneSided,
				NeverAppearsLocked = 4,
				OpenedByMeleeAttack = 8,
				OneSidedForPlayer = 16,
				DoesNotCloseAutomatically = 32,
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
			public class PathfindingReference
			{
				public short BspIndex;
				public short PathfindingObjectIndex;
			}

			public enum PathfindingPolicyValue : short
			{
				TagDefault,
				CutOut,
				Sectors,
				Discs,
				None,
			}
		}

		[TagStructure(Size = 0x30)]
		public class MachinePaletteBlock
		{
			public CachedTagInstance Machine;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x60)]
		public class Terminal
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public short PowerGroup;
			public short PositionGroup;
			public DeviceFlagsValue DeviceFlags;
			public uint Unknown6;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum DeviceFlagsValue : int
			{
				None,
				InitiallyOpen,
				InitiallyClosed,
				CanOnlyChangeOnce = 4,
				PositionReversed = 8,
				UsableFromBothSides = 16,
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

		[TagStructure(Size = 0x30)]
		public class TerminalPaletteBlock
		{
			public CachedTagInstance Terminal;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x64)]
		public class Control
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public short PowerGroup;
			public short PositionGroup;
			public DeviceFlagsValue DeviceFlags;
			public ControlFlagsValue ControlFlags;
			public short Unknown6;
			public short Unknown7;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum DeviceFlagsValue : int
			{
				None,
				InitiallyOpen,
				InitiallyClosed,
				CanOnlyChangeOnce = 4,
				PositionReversed = 8,
				UsableFromBothSides = 16,
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

			public enum ControlFlagsValue : int
			{
				None,
				UsableFromBothSides,
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

		[TagStructure(Size = 0x30)]
		public class ControlPaletteBlock
		{
			public CachedTagInstance Control;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x70)]
		public class SoundSceneryBlock
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public int VolumeType;
			public float Height;
			public float OverrideDistanceMin;
			public float OverrideDistanceMax;
			public Angle OverrideConeAngleMin;
			public Angle OverrideConeAngleMax;
			public float OverrideOuterConeGain;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}
		}

		[TagStructure(Size = 0x30)]
		public class SoundSceneryPaletteBlock
		{
			public CachedTagInstance SoundScenery;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x84)]
		public class Giant
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public StringId Variant;
			public ActiveChangeColorsValue ActiveChangeColors;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public sbyte Unknown8;
			public byte PrimaryColorA;
			public byte PrimaryColorR;
			public byte PrimaryColorG;
			public byte PrimaryColorB;
			public byte SecondaryColorA;
			public byte SecondaryColorR;
			public byte SecondaryColorG;
			public byte SecondaryColorB;
			public byte TertiaryColorA;
			public byte TertiaryColorR;
			public byte TertiaryColorG;
			public byte TertiaryColorB;
			public byte QuaternaryColorA;
			public byte QuaternaryColorR;
			public byte QuaternaryColorG;
			public byte QuaternaryColorB;
			public float BodyVitalityPercentage;
			public FlagsValue Flags;
			public UnknownValue Unknown9;
			public short Unknown10;
			public List<PathfindingReference> PathfindingReferences;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum ActiveChangeColorsValue : byte
			{
				None,
				Primary,
				Secondary,
				Tertiary = 4,
				Quaternary = 8,
			}

			public enum FlagsValue : int
			{
				None,
				Dead,
				Closed,
				NotEnterableByPlayer = 4,
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

			public enum UnknownValue : short
			{
				_0,
				_1,
				_2,
				_3,
				_4,
			}

			[TagStructure(Size = 0x4)]
			public class PathfindingReference
			{
				public short BspIndex;
				public short PathfindingObjectIndex;
			}
		}

		[TagStructure(Size = 0x30)]
		public class GiantPaletteBlock
		{
			public CachedTagInstance Giant;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x54)]
		public class EffectSceneryBlock
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}
		}

		[TagStructure(Size = 0x30)]
		public class EffectSceneryPaletteBlock
		{
			public CachedTagInstance EffectScenery;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x8C)]
		public class LightVolume
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public short PowerGroup;
			public short PositionGroup;
			public DeviceFlagsValue DeviceFlags;
			public TypeValue2 Type2;
			public FlagsValue Flags;
			public LightmapTypeValue LightmapType;
			public LightmapFlagsValue LightmapFlags;
			public float LightmapHalfLife;
			public float LightmapLightScale;
			public float X;
			public float Y;
			public float Z;
			public float Width;
			public float HeightScale;
			public Angle FieldOfView;
			public float FalloffDistance;
			public float CutoffDistance;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum DeviceFlagsValue : int
			{
				None,
				InitiallyOpen,
				InitiallyClosed,
				CanOnlyChangeOnce = 4,
				PositionReversed = 8,
				UsableFromBothSides = 16,
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

			public enum TypeValue2 : short
			{
				Sphere,
				Projective,
			}

			public enum FlagsValue : ushort
			{
				None,
				CustomGeometry,
				Bit1,
				CinematicOnly = 4,
			}

			public enum LightmapTypeValue : short
			{
				UseLightTagSetting,
				DynamicOnly,
				DynamicWithLightmaps,
				LightmapsOnly,
			}

			public enum LightmapFlagsValue : ushort
			{
				None,
				Bit0,
			}
		}

		[TagStructure(Size = 0x30)]
		public class LightVolumesPaletteBlock
		{
			public CachedTagInstance LightVolume;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x30)]
		public class SandboxVehicle
		{
			public CachedTagInstance Object;
			public StringId Name;
			public int MaxAllowed;
			public float Cost;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x30)]
		public class SandboxWeapon
		{
			public CachedTagInstance Object;
			public StringId Name;
			public int MaxAllowed;
			public float Cost;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x30)]
		public class SandboxEquipmentBlock
		{
			public CachedTagInstance Object;
			public StringId Name;
			public int MaxAllowed;
			public float Cost;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x30)]
		public class SandboxSceneryBlock
		{
			public CachedTagInstance Object;
			public StringId Name;
			public int MaxAllowed;
			public float Cost;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x30)]
		public class SandboxTeleporter
		{
			public CachedTagInstance Object;
			public StringId Name;
			public int MaxAllowed;
			public float Cost;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x30)]
		public class SandboxGoalObject
		{
			public CachedTagInstance Object;
			public StringId Name;
			public int MaxAllowed;
			public float Cost;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x30)]
		public class SandboxSpawningBlock
		{
			public CachedTagInstance Object;
			public StringId Name;
			public int MaxAllowed;
			public float Cost;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0xC)]
		public class SoftCeiling
		{
			public short Type;
			public short Unknown;
			public StringId Name;
			public short Unknown2;
			public short Unknown3;
		}

		[TagStructure(Size = 0x54)]
		public class PlayerStartingProfileBlock
		{
			[TagField(Length = 32)] public string Name;
			public float StartingHealthDamage;
			public float StartingShieldDamage;
			public CachedTagInstance PrimaryWeapon;
			public short RoundsLoaded;
			public short RoundsTotal;
			public CachedTagInstance SecondaryWeapon;
			public short RoundsLoaded2;
			public short RoundsTotal2;
			public byte StartingFragGrenadeCount;
			public byte StartingPlasmaGrenadeCount;
			public byte StartingSpikeGrenadeCount;
			public byte StartingFirebombGrenadeCount;
		}

		[TagStructure(Size = 0x18)]
		public class PlayerStartingLocation
		{
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle FacingY;
			public Angle FacingP;
			public short Unknown;
			public CampaignPlayerTypeValue CampaignPlayerType;

			public enum CampaignPlayerTypeValue : short
			{
				Masterchief,
				Dervish,
				ChiefMultiplayer,
				EliteMultiplayer,
				EliteCoop,
				Monitor,
			}
		}

		[TagStructure(Size = 0x44)]
		public class TriggerVolume
		{
			public StringId Name;
			public short ObjectName;
			public short Unknown;
			public StringId NodeName;
			public float Unknown2;
			public float Unknown3;
			public float Unknown4;
			public float Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public float ExtentsX;
			public float ExtentsY;
			public float ExtentsZ;
			public uint Unknown8;
			public short KillVolume;
			public short EditorFolderIndex;
		}

		[TagStructure(Size = 0x8)]
		public class ZonesetSwitchTriggerVolume
		{
			public short Unknown;
			public short IncludedZonesetIndex;
			public short TriggerVolume;
			public short SoleZonesetIndex;
		}

		[TagStructure(Size = 0x14)]
		public class MultiplayerConstantsOverrideBlock
		{
			public float Unknown;
			public float Unknown2;
			public float Unknown3;
			public float Unknown4;
			public float Unknown5;
		}

		[TagStructure(Size = 0x14)]
		public class UnknownBlock
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x14)]
		public class UnknownBlock2
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x14)]
		public class UnknownBlock3
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x14)]
		public class UnknownBlock4
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x24)]
		public class Decal
		{
			public short PaletteIndex;
			public sbyte Yaw;
			public sbyte Pitch;
			public float I;
			public float J;
			public float K;
			public float W;
			public float X;
			public float Y;
			public float Z;
			public float Scale;
		}

		[TagStructure(Size = 0x10)]
		public class DecalPaletteBlock
		{
			public CachedTagInstance Decal;
		}

		[TagStructure(Size = 0x10)]
		public class StylePaletteBlock
		{
			public CachedTagInstance Style;
		}

		[TagStructure(Size = 0x28)]
		public class SquadGroup
		{
			[TagField(Length = 32)] public string Name;
			public short ParentIndex;
			public short ObjectiveIndex;
			public short Unknown;
			public short Unknown2;
		}

		[TagStructure(Size = 0x40)]
		public class Squad
		{
			[TagField(Length = 32)] public string Name;
			public FlagsValue Flags;
			public TeamValue Team;
			public short ParentSquadGroupIndex;
			public short ParentZone;
			public short TriggerIndex;
			public short ObjectiveIndex;
			public short ObjectiveRoleIndex;
			public List<BaseSquadBlock> BaseSquad;
			public short Unknown;
			public short Unknown2;

			public enum FlagsValue : int
			{
				None,
				Bit0,
				Blind,
				Deaf = 4,
				Braindead = 8,
				InitiallyPlaced = 16,
				UnitsNotEnterableByPlayer = 32,
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

			public enum TeamValue : short
			{
				Default,
				Player,
				Human,
				Covenant,
				Flood,
				Sentinel,
				Heretic,
				Prophet,
				Guilty,
				Unused9,
				Unused10,
				Unused11,
				Unused12,
				Unused13,
				Unused14,
				Unused15,
			}

			[TagStructure(Size = 0x60)]
			public class BaseSquadBlock
			{
				public short Unknown;
				public short Unknown2;
				public short Count;
				public short Unknown3;
				public short CharacterType;
				public short InitialPrimaryWeapon;
				public short InitialSecondaryWeapon;
				public GrenadeTypeValue GrenadeType;
				public short Equipment;
				public short Vehicle;
				public StringId VehicleVariant;
				[TagField(Length = 32)] public string CommandScriptName;
				public short CommandScriptIndex;
				public short Unknown4;
				public StringId InitialState;
				public short Unknown5;
				public short Unknown6;
				public short Unknown7;
				public short Unknown8;
				public List<MultiStateBlock> MultiState;
				public List<StartingLocation> StartingLocations;

				public enum GrenadeTypeValue : short
				{
					None,
					HumanFrag,
					CovenantPlasma,
					Spike,
					Firebomb,
				}

				[TagStructure(Size = 0x38)]
				public class MultiStateBlock
				{
					public short Unknown;
					public short Unknown2;
					public float Unknown3;
					public float Unknown4;
					public StringId State;
					public uint Unknown5;
					[TagField(Length = 32)] public string CommandScriptName;
					public short CommandScriptIndex;
					public short Unknown6;
				}

				[TagStructure(Size = 0x88)]
				public class StartingLocation
				{
					public short Unknown;
					public short Unknown2;
					public StringId Name;
					public float PositionX;
					public float PositionY;
					public float PositionZ;
					public short ReferenceFrame;
					public short Unknown3;
					public Angle FacingI;
					public Angle FacingJ;
					public Angle FacingK;
					public FlagsValue Flags;
					public short CharacterType;
					public short InitialPrimaryWeapon;
					public short InitialSecondaryWeapon;
					public short Unknown4;
					public short VehicleType;
					public SeatTypeValue SeatType;
					public GrenadeTypeValue GrenadeType;
					public short SwarmCount;
					public StringId ActorVariant;
					public StringId VehicleVariant;
					public float InitialMovementDistance;
					public short EmitterVehicle;
					public short EmitterGiant;
					public short EmitterBiped;
					public InitialMovementModeValue InitialMovementMode;
					[TagField(Length = 32)] public string CommandScriptName;
					public short CommandScriptIndex;
					public short Unknown5;
					public StringId InitialState;
					public short Unknown6;
					public short Unknown7;
					public short Unknown8;
					public short Unknown9;
					public List<MultiStateBlock> MultiState;

					public enum FlagsValue : int
					{
						None,
						Bit0,
						Bit1,
						AlwaysPlace = 4,
						InitiallyHidden = 8,
						KillVehicleIfNoDriver = 16,
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

					public enum SeatTypeValue : short
					{
						Default,
						SpawnInPassenger,
						SpawnInGunner,
						SpawnInDriver,
						SpawnOutOfVehicle,
						SpawnVehicleOnly = 6,
						SpawnInPassenger2,
					}

					public enum GrenadeTypeValue : short
					{
						None,
						HumanFrag,
						CovenantPlasma,
						Spike,
						Firebomb,
					}

					public enum InitialMovementModeValue : short
					{
						Default,
						Climbing,
						Flying,
					}

					[TagStructure(Size = 0x38)]
					public class MultiStateBlock
					{
						public short Unknown;
						public short Unknown2;
						public float Unknown3;
						public float Unknown4;
						public StringId State;
						public uint Unknown5;
						[TagField(Length = 32)] public string CommandScriptName;
						public short CommandScriptIndex;
						public short Unknown6;
					}
				}
			}
		}

		[TagStructure(Size = 0x40)]
		public class Zone
		{
			[TagField(Length = 32)] public string Name;
			public FlagsValue Flags;
			public short ManualBspIndex;
			public short Unknown;
			public List<FiringPosition> FiringPositions;
			public List<Area> Areas;

			public enum FlagsValue : int
			{
				None,
				UsesManualBspIndex,
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

			[TagStructure(Size = 0x28)]
			public class FiringPosition
			{
				public float PositionX;
				public float PositionY;
				public float PositionZ;
				public short ReferenceFrame;
				public short Unknown;
				public FlagsValue Flags;
				public short Unknown2;
				public short AreaIndex;
				public short ClusterIndex;
				public int Unknown3;
				public Angle NormalY;
				public Angle NormalP;
				public uint Unknown4;

				public enum FlagsValue : ushort
				{
					None,
					Open,
					Partial,
					Closed = 4,
					Mobile = 8,
					WallLean = 16,
					Perch = 32,
					GroundPoint = 64,
					DynamicCoverPoint = 128,
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

			[TagStructure(Size = 0x6C)]
			public class Area
			{
				[TagField(Length = 32)] public string Name;
				public AreaFlagsValue AreaFlags;
				public float PositionX;
				public float PositionY;
				public float PositionZ;
				public int Unknown;
				public float Unknown2;
				public short FiringPositionStartIndex;
				public short FiringPositionCount;
				public short Unknown3;
				public short Unknown4;
				public int Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;
				public uint Unknown9;
				public uint Unknown10;
				public uint Unknown11;
				public short ManualReferenceFrame;
				public short Unknown12;
				public List<FlightHint> FlightHints;

				public enum AreaFlagsValue : int
				{
					None,
					VehicleArea,
					Perch,
					ManualReferenceFrame = 4,
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

				[TagStructure(Size = 0x8)]
				public class FlightHint
				{
					public short FlightHintIndex;
					public short PoitIndex;
					public uint Unknown;
				}
			}
		}

		[TagStructure(Size = 0x10)]
		public class CharacterPaletteBlock
		{
			public CachedTagInstance Character;
		}

		[TagStructure(Size = 0x6C)]
		public class AiPathfindingDatum
		{
			public List<UnknownBlock> Unknown;
			public List<UnknownBlock2> Unknown2;
			public List<UnknownBlock3> Unknown3;
			public List<UnknownBlock4> Unknown4;
			public List<UnknownBlock5> Unknown5;
			public List<UnknownBlock6> Unknown6;
			public List<UnknownBlock7> Unknown7;
			public List<UnknownBlock8> Unknown8;
			public List<UnknownBlock9> Unknown9;

			[TagStructure(Size = 0x24)]
			public class UnknownBlock
			{
				public uint Unknown;
				public float Unknown2;
				public float Unknown3;
				public float Unknown4;
				public short Unknown5;
				public short Unknown6;
				public float Unknown7;
				public float Unknown8;
				public float Unknown9;
				public short Unknown10;
				public short Unknown11;
			}

			[TagStructure(Size = 0x48)]
			public class UnknownBlock2
			{
				public uint Unknown;
				public float Unknown2;
				public float Unknown3;
				public float Unknown4;
				public short Unknown5;
				public short Unknown6;
				public float Unknown7;
				public float Unknown8;
				public float Unknown9;
				public short Unknown10;
				public short Unknown11;
				public float Unknown12;
				public float Unknown13;
				public float Unknown14;
				public short Unknown15;
				public short Unknown16;
				public float Unknown17;
				public float Unknown18;
				public float Unknown19;
				public short Unknown20;
				public short Unknown21;
				public uint Unknown22;
			}

			[TagStructure(Size = 0x8)]
			public class UnknownBlock3
			{
				public short Unknown;
				public short Unknown2;
				public short Unknown3;
				public short Unknown4;
			}

			[TagStructure(Size = 0x8)]
			public class UnknownBlock4
			{
				public int Unknown;
				public uint Unknown2;
			}

			[TagStructure(Size = 0x10)]
			public class UnknownBlock5
			{
				public uint Unknown;
				public List<UnknownBlock> Unknown2;

				[TagStructure(Size = 0x1C)]
				public class UnknownBlock
				{
					public uint Unknown;
					public uint Unknown2;
					public uint Unknown3;
					public uint Unknown4;
					public uint Unknown5;
					public uint Unknown6;
					public uint Unknown7;
				}
			}

			[TagStructure(Size = 0xC)]
			public class UnknownBlock6
			{
				public List<UnknownBlock> Unknown;

				[TagStructure(Size = 0xC)]
				public class UnknownBlock
				{
					public float Unknown;
					public float Unknown2;
					public float Unknown3;
				}
			}

			[TagStructure(Size = 0x44)]
			public class UnknownBlock7
			{
				public StringId Unknown;
				public short Unknown2;
				public short Unknown3;
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
				public int Unknown18;
			}

			[TagStructure(Size = 0x8)]
			public class UnknownBlock8
			{
				public List<UnknownBlock> Unknown;

				[TagStructure(Size = 0xC)]
				public class UnknownBlock
				{
					public List<UnknownBlock2> Unknown;

					[TagStructure(Size = 0x18)]
					public class UnknownBlock2
					{
						public float Unknown;
						public float Unknown2;
						public float Unknown3;
						public short Unknown4;
						public short Unknown5;
						public Angle Unknown6;
						public Angle Unknown7;
					}
				}
			}

			[TagStructure(Size = 0x2)]
			public class UnknownBlock9
			{
				public short Unknown;
			}
		}

		[TagStructure(Size = 0x34)]
		public class Script
		{
			[TagField(Length = 32)] public string ScriptName;
			public ScriptTypeValue ScriptType;
			public ReturnTypeValue ReturnType;
			public ushort RootExpressionSalt;
			public ushort RootExpressionIndex;
			public List<Parameter> Parameters;

			public enum ScriptTypeValue : short
			{
				Startup,
				Dormant,
				Continuous,
				Static,
				CommandScript,
				Stub,
			}

			public enum ReturnTypeValue : short
			{
				Unparsed,
				SpecialForm,
				FunctionName,
				Passthrough,
				Void,
				Boolean,
				Real,
				Short,
				Long,
				String,
				Script,
				StringId,
				UnitSeatMapping,
				TriggerVolume,
				CutsceneFlag,
				CutsceneCameraPoint,
				CutsceneTitle,
				CutsceneRecording,
				DeviceGroup,
				Ai,
				AiCommandList,
				AiCommandScript,
				AiBehavior,
				AiOrders,
				AiLine,
				StartingProfile,
				Conversation,
				ZoneSet,
				DesignerZone,
				PointReference,
				Style,
				ObjectList,
				Folder,
				Sound,
				Effect,
				Damage,
				LoopingSound,
				AnimationGraph,
				DamageEffect,
				ObjectDefinition,
				Bitmap,
				Shader,
				RenderModel,
				StructureDefinition,
				LightmapDefinition,
				CinematicDefinition,
				CinematicSceneDefinition,
				BinkDefinition,
				AnyTag,
				AnyTagNotResolving,
				GameDifficulty,
				Team,
				MpTeam,
				Controller,
				ButtonPreset,
				JoystickPreset,
				PlayerColor,
				PlayerCharacterType,
				VoiceOutputSetting,
				VoiceMask,
				SubtitleSetting,
				ActorType,
				ModelState,
				Event,
				CharacterPhysics,
				Object,
				Unit,
				Vehicle,
				Weapon,
				Device,
				Scenery,
				EffectScenery,
				ObjectName,
				UnitName,
				VehicleName,
				WeaponName,
				DeviceName,
				SceneryName,
				EffectSceneryName,
				CinematicLightprobe,
				AnimationBudgetReference,
				LoopingSoundBudgetReference,
				SoundBudgetReference,
			}

			[TagStructure(Size = 0x24)]
			public class Parameter
			{
				[TagField(Length = 32)] public string Name;
				public TypeValue Type;
				public short Unknown;

				public enum TypeValue : short
				{
					Unparsed,
					SpecialForm,
					FunctionName,
					Passthrough,
					Void,
					Boolean,
					Real,
					Short,
					Long,
					String,
					Script,
					StringId,
					UnitSeatMapping,
					TriggerVolume,
					CutsceneFlag,
					CutsceneCameraPoint,
					CutsceneTitle,
					CutsceneRecording,
					DeviceGroup,
					Ai,
					AiCommandList,
					AiCommandScript,
					AiBehavior,
					AiOrders,
					AiLine,
					StartingProfile,
					Conversation,
					ZoneSet,
					DesignerZone,
					PointReference,
					Style,
					ObjectList,
					Folder,
					Sound,
					Effect,
					Damage,
					LoopingSound,
					AnimationGraph,
					DamageEffect,
					ObjectDefinition,
					Bitmap,
					Shader,
					RenderModel,
					StructureDefinition,
					LightmapDefinition,
					CinematicDefinition,
					CinematicSceneDefinition,
					BinkDefinition,
					AnyTag,
					AnyTagNotResolving,
					GameDifficulty,
					Team,
					MpTeam,
					Controller,
					ButtonPreset,
					JoystickPreset,
					PlayerColor,
					PlayerCharacterType,
					VoiceOutputSetting,
					VoiceMask,
					SubtitleSetting,
					ActorType,
					ModelState,
					Event,
					CharacterPhysics,
					Object,
					Unit,
					Vehicle,
					Weapon,
					Device,
					Scenery,
					EffectScenery,
					ObjectName,
					UnitName,
					VehicleName,
					WeaponName,
					DeviceName,
					SceneryName,
					EffectSceneryName,
					CinematicLightprobe,
					AnimationBudgetReference,
					LoopingSoundBudgetReference,
					SoundBudgetReference,
				}
			}
		}

		[TagStructure(Size = 0x28)]
		public class Global
		{
			[TagField(Length = 32)] public string Name;
			public TypeValue Type;
			public short Unknown;
			public ushort InitializationExpressionSalt;
			public ushort InitializationExpressionIndex;

			public enum TypeValue : short
			{
				Unparsed,
				SpecialForm,
				FunctionName,
				Passthrough,
				Void,
				Boolean,
				Real,
				Short,
				Long,
				String,
				Script,
				StringId,
				UnitSeatMapping,
				TriggerVolume,
				CutsceneFlag,
				CutsceneCameraPoint,
				CutsceneTitle,
				CutsceneRecording,
				DeviceGroup,
				Ai,
				AiCommandList,
				AiCommandScript,
				AiBehavior,
				AiOrders,
				AiLine,
				StartingProfile,
				Conversation,
				ZoneSet,
				DesignerZone,
				PointReference,
				Style,
				ObjectList,
				Folder,
				Sound,
				Effect,
				Damage,
				LoopingSound,
				AnimationGraph,
				DamageEffect,
				ObjectDefinition,
				Bitmap,
				Shader,
				RenderModel,
				StructureDefinition,
				LightmapDefinition,
				CinematicDefinition,
				CinematicSceneDefinition,
				BinkDefinition,
				AnyTag,
				AnyTagNotResolving,
				GameDifficulty,
				Team,
				MpTeam,
				Controller,
				ButtonPreset,
				JoystickPreset,
				PlayerColor,
				PlayerCharacterType,
				VoiceOutputSetting,
				VoiceMask,
				SubtitleSetting,
				ActorType,
				ModelState,
				Event,
				CharacterPhysics,
				Object,
				Unit,
				Vehicle,
				Weapon,
				Device,
				Scenery,
				EffectScenery,
				ObjectName,
				UnitName,
				VehicleName,
				WeaponName,
				DeviceName,
				SceneryName,
				EffectSceneryName,
				CinematicLightprobe,
				AnimationBudgetReference,
				LoopingSoundBudgetReference,
				SoundBudgetReference,
			}
		}

		[TagStructure(Size = 0x10)]
		public class ScriptReference
		{
			public CachedTagInstance Reference;
		}

		[TagStructure(Size = 0x84)]
		public class ScriptingDatum
		{
			public List<PointSet> PointSets;
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

			[TagStructure(Size = 0x34)]
			public class PointSet
			{
				[TagField(Length = 32)] public string Name;
				public List<Point> Points;
				public short BspIndex;
				public short ManualReferenceFrame;
				public FlagsValue Flags;

				[TagStructure(Size = 0x3C)]
				public class Point
				{
					[TagField(Length = 32)] public string Name;
					public float PositionX;
					public float PositionY;
					public float PositionZ;
					public short ReferenceFrame;
					public short Unknown;
					public int SurfaceIndex;
					public Angle FacingDirectionY;
					public Angle FacingDirectionP;
				}

				public enum FlagsValue : int
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

		[TagStructure(Size = 0x1C)]
		public class CutsceneFlag
		{
			public uint Unknown;
			public StringId Name;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle FacingY;
			public Angle FacingP;
		}

		[TagStructure(Size = 0x40)]
		public class CutsceneCameraPoint
		{
			public FlagsValue Flags;
			public TypeValue Type;
			[TagField(Length = 32)] public string Name;
			public int Unknown;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle OrientationY;
			public Angle OrientationP;
			public Angle OrientationR;

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
				Normal,
				IgnoreTargetOrientation,
				Dolly,
				IgnoreTargetUpdates,
			}
		}

		[TagStructure(Size = 0x28)]
		public class CutsceneTitle
		{
			public StringId Name;
			public short TextBoundsTop;
			public short TextBoundsLeft;
			public short TextBoundsBottom;
			public short TextBoundsRight;
			public HorizontalJustificationValue HorizontalJustification;
			public VerticalJustificationValue VerticalJustification;
			public short Font;
			public short Unknown;
			public byte TextColorA;
			public byte TextColorR;
			public byte TextColorG;
			public byte TextColorB;
			public byte ShadowColorA;
			public byte ShadowColorR;
			public byte ShadowColorG;
			public byte ShadowColorB;
			public float FadeInTime;
			public float Uptime;
			public float FadeOutTime;

			public enum HorizontalJustificationValue : short
			{
				Left,
				Right,
				Center,
			}

			public enum VerticalJustificationValue : short
			{
				Bottom,
				Top,
				Middle,
				Bottom2,
				Top2,
			}
		}

		[TagStructure(Size = 0x28)]
		public class ScenarioResource
		{
			public int Unknown;
			public List<ScriptSourceBlock> ScriptSource;
			public List<AiResource> AiResources;
			public List<Reference> References;

			[TagStructure(Size = 0x10)]
			public class ScriptSourceBlock
			{
				public CachedTagInstance HsSourceFile;
			}

			[TagStructure(Size = 0x10)]
			public class AiResource
			{
				public CachedTagInstance AiResource2;
			}

			[TagStructure(Size = 0x130)]
			public class Reference
			{
				public CachedTagInstance SceneryResource;
				public CachedTagInstance BipedsResource;
				public CachedTagInstance VehiclesResource;
				public CachedTagInstance EquipmentResource;
				public CachedTagInstance WeaponsResource;
				public CachedTagInstance SoundSceneryResource;
				public CachedTagInstance LightsResource;
				public CachedTagInstance DevicesResource;
				public CachedTagInstance EffectSceneryResource;
				public CachedTagInstance DecalsResource;
				public CachedTagInstance CinematicsResource;
				public CachedTagInstance TriggerVolumesResource;
				public CachedTagInstance ClusterDataResource;
				public CachedTagInstance CommentsResource;
				public CachedTagInstance CreatureResource;
				public CachedTagInstance StructureLightingResource;
				public CachedTagInstance DecoratorsResource;
				public CachedTagInstance SkyReferencesResource;
				public CachedTagInstance CubemapResource;
			}
		}

		[TagStructure(Size = 0xC)]
		public class UnitSeatsMappingBlock
		{
			[TagField(Flags = TagFieldFlags.Short)] public CachedTagInstance Unit;
			public SeatsValue Seats;
			public Seats2Value Seats2;

			public enum SeatsValue : int
			{
				None,
				Seat0,
				Seat1,
				Seat2 = 4,
				Seat3 = 8,
				Seat4 = 16,
				Seat5 = 32,
				Seat6 = 64,
				Seat7 = 128,
				Seat8 = 256,
				Seat9 = 512,
				Seat10 = 1024,
				Seat11 = 2048,
				Seat12 = 4096,
				Seat13 = 8192,
				Seat14 = 16384,
				Seat15 = 32768,
				Seat16 = 65536,
				Seat17 = 131072,
				Seat18 = 262144,
				Seat19 = 524288,
				Seat20 = 1048576,
				Seat21 = 2097152,
				Seat22 = 4194304,
				Seat23 = 8388608,
				Seat24 = 16777216,
				Seat25 = 33554432,
				Seat26 = 67108864,
				Seat27 = 134217728,
				Seat28 = 268435456,
				Seat29 = 536870912,
				Seat30 = 1073741824,
				Seat31 = -2147483648,
			}

			public enum Seats2Value : int
			{
				None,
				Seat32,
				Seat33,
				Seat34 = 4,
				Seat35 = 8,
				Seat36 = 16,
				Seat37 = 32,
				Seat38 = 64,
				Seat39 = 128,
				Seat40 = 256,
				Seat41 = 512,
				Seat42 = 1024,
				Seat43 = 2048,
				Seat44 = 4096,
				Seat45 = 8192,
				Seat46 = 16384,
				Seat47 = 32768,
				Seat48 = 65536,
				Seat49 = 131072,
				Seat50 = 262144,
				Seat51 = 524288,
				Seat52 = 1048576,
				Seat53 = 2097152,
				Seat54 = 4194304,
				Seat55 = 8388608,
				Seat56 = 16777216,
				Seat57 = 33554432,
				Seat58 = 67108864,
				Seat59 = 134217728,
				Seat60 = 268435456,
				Seat61 = 536870912,
				Seat62 = 1073741824,
				Seat63 = -2147483648,
			}
		}

		[TagStructure(Size = 0x2)]
		public class ScenarioKillTrigger
		{
			public short TriggerVolume;
		}

		[TagStructure(Size = 0x2)]
		public class ScenarioSafeTrigger
		{
			public short TriggerVolume;
		}

		[TagStructure(Size = 0x18)]
		public class ScriptExpression
		{
			public ushort Salt;
			public ushort Opcode;
			public ValueTypeValue ValueType;
			public short ExpressionType;
			public ushort NextExpressionSalt;
			public ushort NextExpressionIndex;
			public uint StringAddress;
			public sbyte Value03Msb;
			public sbyte Value02Byte;
			public sbyte Value01Byte;
			public sbyte Value00Lsb;
			public short LineNumber;
			public short Unknown;

			public enum ValueTypeValue : ushort
			{
				Invalid = 47802,
				Unparsed = 0,
				SpecialForm,
				FunctionName,
				Passthrough,
				Void,
				Boolean,
				Real,
				Short,
				Long,
				String,
				Script,
				StringId,
				UnitSeatMapping,
				TriggerVolume,
				CutsceneFlag,
				CutsceneCameraPoint,
				CutsceneTitle,
				CutsceneRecording,
				DeviceGroup,
				Ai,
				AiCommandList,
				AiCommandScript,
				AiBehavior,
				AiOrders,
				AiLine,
				StartingProfile,
				Conversation,
				ZoneSet,
				DesignerZone,
				PointReference,
				Style,
				ObjectList,
				Folder,
				Sound,
				Effect,
				Damage,
				LoopingSound,
				AnimationGraph,
				DamageEffect,
				ObjectDefinition,
				Bitmap,
				Shader,
				RenderModel,
				StructureDefinition,
				LightmapDefinition,
				CinematicDefinition,
				CinematicSceneDefinition,
				BinkDefinition,
				AnyTag,
				AnyTagNotResolving,
				GameDifficulty,
				Team,
				MpTeam,
				Controller,
				ButtonPreset,
				JoystickPreset,
				PlayerColor,
				PlayerCharacterType,
				VoiceOutputSetting,
				VoiceMask,
				SubtitleSetting,
				ActorType,
				ModelState,
				Event,
				CharacterPhysics,
				Object,
				Unit,
				Vehicle,
				Weapon,
				Device,
				Scenery,
				EffectScenery,
				ObjectName,
				UnitName,
				VehicleName,
				WeaponName,
				DeviceName,
				SceneryName,
				EffectSceneryName,
				CinematicLightprobe,
				AnimationBudgetReference,
				LoopingSoundBudgetReference,
				SoundBudgetReference,
			}
		}

		[TagStructure(Size = 0x34)]
		public class AiTrigger
		{
			[TagField(Length = 32)] public string Name;
			public TriggerFlagsValue TriggerFlags;
			public CombinationRuleValue CombinationRule;
			public short Unknown;
			public List<Condition> Conditions;

			public enum TriggerFlagsValue : int
			{
				None,
				LatchOnWhenTriggered,
			}

			public enum CombinationRuleValue : short
			{
				Or,
				And,
			}

			[TagStructure(Size = 0x38)]
			public class Condition
			{
				public RuleTypeValue RuleType;
				public short Squad;
				public short SquadGroup;
				public short A;
				public float X;
				public short TriggerVolume;
				public short Unknown;
				[TagField(Length = 32)] public string ExitConditionScript;
				public short ExitConditionScriptIndex;
				public short Unknown2;
				public FlagsValue Flags;

				public enum RuleTypeValue : short
				{
					AOrGreaterAlive,
					AOrFewerAlive,
					XOrGreaterStrength,
					XOrLessStrength,
					IfEnemySighted,
					AfterATicks,
					IfAlertedBySquadA,
					ScriptReferenceTrue,
					ScriptReferenceFalse,
					IfPlayerInTriggerVolume,
					IfAllPlayersInTriggerVolume,
					CombatStatusAOrMore,
					CombatStatusAOrLess,
					Arrived,
					InVehicle,
					SightedPlayer,
					AOrGreaterFighting,
					AOrFewerFighting,
					PlayerWithinXWorldUnits,
					PlayerShotMoreThanXSecondsAgo,
					GameSafeToSave,
				}

				public enum FlagsValue : int
				{
					None,
					Not,
				}
			}
		}

		[TagStructure(Size = 0x54)]
		public class BackgroundSoundEnvironmentPaletteBlock
		{
			public StringId Name;
			public CachedTagInstance SoundEnvironment;
			public float CutoffDistance;
			public float InterpolationSpeed;
			public CachedTagInstance BackgroundSound;
			public CachedTagInstance InsideClusterSound;
			public float CutoffDistance2;
			public ScaleFlagsValue ScaleFlags;
			public float InteriorScale;
			public float PortalScale;
			public float ExteriorScale;
			public float InterpolationSpeed2;

			public enum ScaleFlagsValue : int
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

		[TagStructure(Size = 0x78)]
		public class UnknownBlock5
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
		}

		[TagStructure(Size = 0x8)]
		public class FogBlock
		{
			public StringId Name;
			public short Unknown;
			public short Unknown2;
		}

		[TagStructure(Size = 0x30)]
		public class CameraEffect
		{
			public StringId Name;
			public CachedTagInstance Effect;
			public sbyte Unknown;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public sbyte Unknown4;
			public uint Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float Unknown8;
			public uint Unknown9;
			public uint Unknown10;
		}

		[TagStructure(Size = 0x68)]
		public class ScenarioClusterDatum
		{
			public CachedTagInstance Bsp;
			public List<BackgroundSoundEnvironment> BackgroundSoundEnvironments;
			public List<UnknownBlock> Unknown;
			public List<UnknownBlock2> Unknown2;
			public int BspChecksum;
			public List<ClusterCentroid> ClusterCentroids;
			public List<UnknownBlock3> Unknown3;
			public List<FogBlock> Fog;
			public List<CameraEffect> CameraEffects;

			[TagStructure(Size = 0x4)]
			public class BackgroundSoundEnvironment
			{
				public short BackgroundSoundEnvironmentIndex;
				public short Unknown;
			}

			[TagStructure(Size = 0x4)]
			public class UnknownBlock
			{
				public short Unknown;
				public short Unknown2;
			}

			[TagStructure(Size = 0x4)]
			public class UnknownBlock2
			{
				public short Unknown;
				public short Unknown2;
			}

			[TagStructure(Size = 0xC)]
			public class ClusterCentroid
			{
				public float CentroidX;
				public float CentroidY;
				public float CentroidZ;
			}

			[TagStructure(Size = 0x4)]
			public class UnknownBlock3
			{
				public short Unknown;
				public short Unknown2;
			}

			[TagStructure(Size = 0x4)]
			public class FogBlock
			{
				public short FogIndex;
				public short Unknown;
			}

			[TagStructure(Size = 0x4)]
			public class CameraEffect
			{
				public short CameraEffectIndex;
				public short Unknown;
			}
		}

		[TagStructure(Size = 0x6C)]
		public class SpawnDatum
		{
			public float DynamicSpawnLowerHeight;
			public float DynamicSpawnUpperHeight;
			public float GameObjectResetHeight;
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
			public List<DynamicSpawnOverload> DynamicSpawnOverloads;
			public List<StaticRespawnZone> StaticRespawnZones;
			public List<StaticInitialSpawnZone> StaticInitialSpawnZones;

			[TagStructure(Size = 0x10)]
			public class DynamicSpawnOverload
			{
				public short OverloadType;
				public short Unknown;
				public float InnerRadius;
				public float OuterRadius;
				public float Weight;
			}

			[TagStructure(Size = 0x30)]
			public class StaticRespawnZone
			{
				public StringId Name;
				public RelevantTeamsValue RelevantTeams;
				public RelevantGamesValue RelevantGames;
				public FlagsValue Flags;
				public float PositionX;
				public float PositionY;
				public float PositionZ;
				public float LowerHeight;
				public float UpperHeight;
				public float InnerRadius;
				public float OuterRadius;
				public float Weight;

				public enum RelevantTeamsValue : int
				{
					None,
					Red,
					Blue,
					Green = 4,
					Orange = 8,
					Purple = 16,
					Yellow = 32,
					Brown = 64,
					Pink = 128,
					Neutral = 256,
				}

				public enum RelevantGamesValue : int
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

				public enum FlagsValue : int
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

			[TagStructure(Size = 0x30)]
			public class StaticInitialSpawnZone
			{
				public StringId Name;
				public RelevantTeamsValue RelevantTeams;
				public RelevantGamesValue RelevantGames;
				public FlagsValue Flags;
				public float PositionX;
				public float PositionY;
				public float PositionZ;
				public float LowerHeight;
				public float UpperHeight;
				public float InnerRadius;
				public float OuterRadius;
				public float Weight;

				public enum RelevantTeamsValue : int
				{
					None,
					Red,
					Blue,
					Green = 4,
					Orange = 8,
					Purple = 16,
					Yellow = 32,
					Brown = 64,
					Pink = 128,
					Neutral = 256,
				}

				public enum RelevantGamesValue : int
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

				public enum FlagsValue : int
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

		[TagStructure(Size = 0xB0)]
		public class Crate
		{
			public short PaletteIndex;
			public short NameIndex;
			public PlacementFlagsValue PlacementFlags;
			public float PositionX;
			public float PositionY;
			public float PositionZ;
			public Angle RotationI;
			public Angle RotationJ;
			public Angle RotationK;
			public float Scale;
			public List<NodePositioningBlock> NodePositioning;
			public short Unknown;
			public OldManualBspFlagsNowZonesetsValue OldManualBspFlagsNowZonesets;
			public StringId UniqueName;
			public ushort UniqueIdSalt;
			public ushort UniqueIdIndex;
			public short OriginBspIndex;
			public TypeValue Type;
			public SourceValue Source;
			public BspPolicyValue BspPolicy;
			public sbyte Unknown2;
			public short EditorFolderIndex;
			public short Unknown3;
			public short ParentNameIndex;
			public StringId ChildName;
			public StringId Unknown4;
			public AllowedZonesetsValue AllowedZonesets;
			public short Unknown5;
			public StringId Variant;
			public ActiveChangeColorsValue ActiveChangeColors;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public sbyte Unknown8;
			public byte PrimaryColorA;
			public byte PrimaryColorR;
			public byte PrimaryColorG;
			public byte PrimaryColorB;
			public byte SecondaryColorA;
			public byte SecondaryColorR;
			public byte SecondaryColorG;
			public byte SecondaryColorB;
			public byte TertiaryColorA;
			public byte TertiaryColorR;
			public byte TertiaryColorG;
			public byte TertiaryColorB;
			public byte QuaternaryColorA;
			public byte QuaternaryColorR;
			public byte QuaternaryColorG;
			public byte QuaternaryColorB;
			public uint Unknown9;
			public List<UnknownBlock> Unknown10;
			public SymmetryValue Symmetry;
			public EngineFlagsValue EngineFlags;
			public TeamValue Team;
			public sbyte SpawnSequence;
			public sbyte RuntimeMinimum;
			public sbyte RuntimeMaximum;
			public MultiplayerFlagsValue MultiplayerFlags;
			public short SpawnTime;
			public short AbandonTime;
			public sbyte Unknown11;
			public ShapeValue Shape;
			public sbyte TeleporterChannel;
			public sbyte Unknown12;
			public short Unknown13;
			public short AttachedNameIndex;
			public uint Unknown14;
			public uint Unknown15;
			public float WidthRadius;
			public float Depth;
			public float Top;
			public float Bottom;
			public uint Unknown16;

			public enum PlacementFlagsValue : int
			{
				None,
				NotAutomatically,
				NotOnEasy,
				NotOnNormal = 4,
				NotOnHard = 8,
				LockTypeToEnvObject = 16,
				LockTransformToEnvObject = 32,
				NeverPlaced = 64,
				LockNameToEnvObject = 128,
				CreateAtRest = 256,
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

			[TagStructure(Size = 0x1C)]
			public class NodePositioningBlock
			{
				public short NodeCount;
				public short Unknown;
				public List<NodeFlag> NodeFlags;
				public List<Orientation> Orientations;
				public List<NodeFlagsReadableBlock> NodeFlagsReadable;
				public List<OrientationsReadableBlock> OrientationsReadable;

				[TagStructure(Size = 0x1)]
				public class NodeFlag
				{
					public FlagsValue Flags;

					public enum FlagsValue : byte
					{
						None,
						Node081624324048566472808896,
						Node191725334149576573818997,
						Node2101826344250586674829098 = 4,
						Node3111927354351596775839199 = 8,
						Node41220283644526068768492100 = 16,
						Node51321293745536169778593101 = 32,
						Node61422303846546270788694102 = 64,
						Node71523313947556371798795103 = 128,
					}
				}

				[TagStructure(Size = 0x2)]
				public class Orientation
				{
					public short RotationXYZW;
				}

				[TagStructure(Size = 0x4)]
				public class NodeFlagsReadableBlock
				{
					public FlagsValue Flags;
					public FlagsValue2 Flags2;
					public FlagsValue3 Flags3;
					public FlagsValue4 Flags4;

					public enum FlagsValue : byte
					{
						None,
						Node0326496128160192224,
						Node1336597129161193225,
						Node2346698130162194226 = 4,
						Node3356799131163195227 = 8,
						Node43668100132164196228 = 16,
						Node53769101133165197229 = 32,
						Node63870102134166198230 = 64,
						Node73971103135167199231 = 128,
					}

					public enum FlagsValue2 : byte
					{
						None,
						Node84072104136168200232,
						Node94173105137169201233,
						Node104274106138170202234 = 4,
						Node114375107139171203235 = 8,
						Node124476108140172204236 = 16,
						Node134577109141173205237 = 32,
						Node144678110142174206238 = 64,
						Node154779111143175207239 = 128,
					}

					public enum FlagsValue3 : byte
					{
						None,
						Node164880112144176208240,
						Node174981113145177209241,
						Node185082114146178210242 = 4,
						Node195183115147179211243 = 8,
						Node205284116148180212244 = 16,
						Node215385117149181213245 = 32,
						Node225486118150182214246 = 64,
						Node235587119151183215247 = 128,
					}

					public enum FlagsValue4 : byte
					{
						None,
						Node245688120152184216248,
						Node255789121153185217249,
						Node265890122154186218250 = 4,
						Node275991123155187219251 = 8,
						Node286092124156188220252 = 16,
						Node296193125157189221253 = 32,
						Node306294126158190222254 = 64,
						Node316395127159191223255 = 128,
					}
				}

				[TagStructure(Size = 0x8)]
				public class OrientationsReadableBlock
				{
					public short RotationX;
					public short RotationY;
					public short RotationZ;
					public short RotationW;
				}
			}

			public enum OldManualBspFlagsNowZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum TypeValue : sbyte
			{
				Biped,
				Vehicle,
				Weapon,
				Equipment,
				Terminal,
				Projectile,
				Scenery,
				Machine,
				Control,
				SoundScenery,
				Crate,
				Creature,
				Giant,
				EffectScenery,
			}

			public enum SourceValue : sbyte
			{
				Structure,
				Editor,
				Dynamic,
				Legacy,
			}

			public enum BspPolicyValue : sbyte
			{
				Default,
				AlwaysPlaced,
				ManualBspIndex,
			}

			public enum AllowedZonesetsValue : ushort
			{
				None,
				Set0,
				Set1,
				Set2 = 4,
				Set3 = 8,
				Set4 = 16,
				Set5 = 32,
				Set6 = 64,
				Set7 = 128,
				Set8 = 256,
				Set9 = 512,
				Set10 = 1024,
				Set11 = 2048,
				Set12 = 4096,
				Set13 = 8192,
				Set14 = 16384,
				Set15 = 32768,
			}

			public enum ActiveChangeColorsValue : byte
			{
				None,
				Primary,
				Secondary,
				Tertiary = 4,
				Quaternary = 8,
			}

			[TagStructure(Size = 0x4)]
			public class UnknownBlock
			{
				public uint Unknown;
			}

			public enum SymmetryValue : int
			{
				Both,
				Symmetric,
				Asymmetric,
			}

			public enum EngineFlagsValue : ushort
			{
				None,
				CaptureTheFlag,
				Slayer,
				Oddball = 4,
				KingOfTheHill = 8,
				Juggernaut = 16,
				Territories = 32,
				Assault = 64,
				Vip = 128,
				Infection = 256,
				Bit9 = 512,
			}

			public enum TeamValue : short
			{
				Red,
				Blue,
				Green,
				Orange,
				Purple,
				Yellow,
				Brown,
				Pink,
				Neutral,
			}

			public enum MultiplayerFlagsValue : byte
			{
				None,
				IsUniqueObject,
				NotPlacedAtStart,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
			}

			public enum ShapeValue : sbyte
			{
				None,
				Sphere,
				Cylinder,
				Box,
			}
		}

		[TagStructure(Size = 0x30)]
		public class CratePaletteBlock
		{
			public CachedTagInstance Crate;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x10)]
		public class FlockPaletteBlock
		{
			public CachedTagInstance Flock;
		}

		[TagStructure(Size = 0x48)]
		public class Flock
		{
			public StringId Name;
			public short FlockPaletteIndex;
			public short BspIndex;
			public short BoundingTriggerVolume;
			public FlagsValue Flags;
			public float EcologyMargin;
			public List<Source> Sources;
			public List<Sink> Sinks;
			public float ProductionFrequencyMin;
			public float ProductionFrequencyMax;
			public float ScaleMin;
			public float ScaleMax;
			public float Unknown;
			public uint Unknown2;
			public short CreaturePaletteIndex;
			public short BoidCountMin;
			public short BoidCountMax;
			public short Unknown3;

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

			[TagStructure(Size = 0x24)]
			public class Source
			{
				public int Unknown;
				public float PositionX;
				public float PositionY;
				public float PositionZ;
				public Angle StartingY;
				public Angle StartingP;
				public float Radius;
				public float Weight;
				public sbyte Unknown2;
				public sbyte Unknown3;
				public sbyte Unknown4;
				public sbyte Unknown5;
			}

			[TagStructure(Size = 0x10)]
			public class Sink
			{
				public float PositionX;
				public float PositionY;
				public float PositionZ;
				public float Radius;
			}
		}

		[TagStructure(Size = 0x30)]
		public class CreaturePaletteBlock
		{
			public CachedTagInstance Creature;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public uint Unknown8;
		}

		[TagStructure(Size = 0x104)]
		public class EditorFolder
		{
			public int ParentFolder;
			[TagField(Length = 256)] public string Name;
		}

		[TagStructure(Size = 0x10)]
		public class MissionDialogueBlock
		{
			public CachedTagInstance MissionDialogue;
		}

		[TagStructure(Size = 0x24)]
		public class Interpolator
		{
			public StringId Name;
			public StringId AcceleratorName;
			public StringId MultiplierName;
			public byte[] Function;
			public short Unknown;
			public short Unknown2;
		}

		[TagStructure(Size = 0x4)]
		public class SimulationDefinitionTableBlock
		{
			[TagField(Flags = TagFieldFlags.Short)] public CachedTagInstance Tag;
		}

		[TagStructure(Size = 0x10)]
		public class UnknownBlock6
		{
			public short Unknown;
			public short Unknown2;
			public short Unknown3;
			public short Unknown4;
			public short Unknown5;
			public short Unknown6;
			public short Unknown7;
			public short Unknown8;
		}

		[TagStructure(Size = 0x14)]
		public class AiObjective
		{
			public StringId Name;
			public short Zone;
			public short Unknown;
			public List<Role> Roles;

			[TagStructure(Size = 0xCC)]
			public class Role
			{
				public short Unknown;
				public short Unknown2;
				public short Unknown3;
				public short Unknown4;
				public short Unknown5;
				public short Unknown6;
				public uint Unknown7;
				[TagField(Length = 32)] public string CommandScriptName1;
				[TagField(Length = 32)] public string CommandScriptName2;
				[TagField(Length = 32)] public string CommandScriptName3;
				public short CommandScriptIndex1;
				public short CommandScriptIndex2;
				public short CommandScriptIndex3;
				public short Unknown8;
				public short Unknown9;
				public short Unknown10;
				public List<Unknown84Block> Unknown84;
				public StringId Task;
				public short HierarchyLevelFrom100;
				public short PreviousRole;
				public short NextRole;
				public short ParentRole;
				public List<Condition> Conditions;
				public short ScriptIndex;
				public short Unknown11;
				public short Unknown12;
				public FilterValue Filter;
				public short Min;
				public short Max;
				public short Bodies;
				public short Unknown13;
				public uint Unknown14;
				public List<UnknownBlock> Unknown15;
				public List<PointGeometryBlock> PointGeometry;

				[TagStructure(Size = 0x8)]
				public class Unknown84Block
				{
					public uint Unknown;
					public uint Unknown2;
				}

				[TagStructure(Size = 0x124)]
				public class Condition
				{
					[TagField(Length = 32)] public string Name;
					[TagField(Length = 256)] public string Condition2;
					public short Unknown;
					public short Unknown2;
				}

				public enum FilterValue : short
				{
					None,
					Leader,
					Arbiter = 3,
					Player,
					Infantry = 7,
					Flood = 16,
					Sentinel,
					Jackal = 21,
					Grunt,
					Marine = 24,
					FloodCombat,
					FloodCarrier,
					Brute = 28,
					Drone = 30,
					FloodPureform,
					Warthog = 34,
					Wraith = 39,
					Phantom,
					BruteChopper = 44,
				}

				[TagStructure(Size = 0xA)]
				public class UnknownBlock
				{
					public short Unknown;
					public short Unknown2;
					public short Unknown3;
					public short Unknown4;
					public short Unknown5;
				}

				[TagStructure(Size = 0x20)]
				public class PointGeometryBlock
				{
					public float Point0X;
					public float Point0Y;
					public float Point0Z;
					public short ReferenceFrame;
					public short Unknown;
					public float Point1X;
					public float Point1Y;
					public float Point1Z;
					public short ReferenceFrame2;
					public short Unknown2;
				}
			}
		}

		[TagStructure(Size = 0xBC)]
		public class DesignerZoneset
		{
			public StringId Name;
			public uint Unknown;
			public List<Biped> Bipeds;
			public List<Vehicle> Vehicles;
			public List<Weapon> Weapons;
			public List<EquipmentBlock> Equipment;
			public List<SceneryBlock> Scenery;
			public List<Machine> Machines;
			public List<Terminal> Terminals;
			public List<Control> Controls;
			public List<UnknownBlock> Unknown2;
			public List<Crate> Crates;
			public List<Creature> Creatures;
			public List<Giant> Giants;
			public List<UnknownBlock2> Unknown3;
			public List<Character> Characters;
			public uint Unknown4;
			public uint Unknown5;
			public uint Unknown6;

			[TagStructure(Size = 0x2)]
			public class Biped
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class Vehicle
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class Weapon
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class EquipmentBlock
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class SceneryBlock
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class Machine
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class Terminal
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class Control
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class UnknownBlock
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class Crate
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class Creature
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class Giant
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class UnknownBlock2
			{
				public short PaletteIndex;
			}

			[TagStructure(Size = 0x2)]
			public class Character
			{
				public short PaletteIndex;
			}
		}

		[TagStructure(Size = 0x4)]
		public class UnknownBlock7
		{
			public short Unknown;
			public short Unknown2;
		}

		[TagStructure(Size = 0x10)]
		public class Cinematic
		{
			public CachedTagInstance Cinematic2;
		}

		[TagStructure(Size = 0x14)]
		public class CinematicLightingBlock
		{
			public StringId Name;
			public CachedTagInstance CinematicLight;
		}

		[TagStructure(Size = 0x10)]
		public class ScenarioMetagameBlock
		{
			public List<TimeMultiplier> TimeMultipliers;
			public float ParScore;

			[TagStructure(Size = 0x8)]
			public class TimeMultiplier
			{
				public float Time;
				public float Multiplier;
			}
		}

		[TagStructure(Size = 0x8)]
		public class UnknownBlock8
		{
			public uint Unknown;
			public uint Unknown2;
		}

		[TagStructure(Size = 0x10)]
		public class UnknownBlock9
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public short Unknown4;
			public short Unknown5;
		}

		[TagStructure(Size = 0x10)]
		public class CortanaEffect
		{
			public CachedTagInstance Unknown;
		}

		[TagStructure(Size = 0x14)]
		public class LightmapAirprobe
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public StringId Unknown4;
			public UnknownValue Unknown5;
			public short Unknown6;

			public enum UnknownValue : ushort
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
		}
	}
}
