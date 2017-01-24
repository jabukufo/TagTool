using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache.HaloOnline;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Tags
{
    class CleanCacheCommand : Command
    {
        public GameCacheContext Info { get; }

        private HashSet<int> AudioResourceIndices { get; } = new HashSet<int>();
        private HashSet<int> TexturesResourceIndices { get; } = new HashSet<int>();
        private HashSet<int> TexturesBResourceIndices { get; } = new HashSet<int>();
        private HashSet<int> VideoResourceIndices { get; } = new HashSet<int>();

        private HashSet<int> ResourcesResourceIndices { get; } = new HashSet<int>
        {
            0x169, 0x16A, 0x16B, 0x170, 0x171,
            0x2AF, 0x2B0, 0x38E, 0x540, 0x541,
            0x542, 0x543, 0x544, 0x546, 0x549,
            0x54D, 0x54F, 0x550, 0x55B, 0x56A,
            0x580, 0x587, 0x6B9, 0x6ED, 0x6EE
        };

        public CleanCacheCommand(GameCacheContext info)
            : base(CommandFlags.None,
                  "clean-cache",
                  "Nulls and removes unused tags and resources from cache.",
                  "clean-cache",
                  "Nulls and removes unused tags and resources from cache.")
        {
            Info = info;
        }

        private void LoadTagDependencies(int index, ref HashSet<int> tags)
        {
            var queue = new List<int> { index };

            while (queue.Count != 0)
            {
                var nextQueue = new List<int>();

                foreach (var entry in queue)
                {
                    if (!tags.Contains(entry))
                    {
                        if (Info.Cache.Tags[entry] == null)
                            continue;

                        tags.Add(entry);

                        foreach (var dependency in Info.Cache.Tags[entry].Dependencies)
                            if (!nextQueue.Contains(dependency))
                                nextQueue.Add(dependency);
                    }
                }

                queue = nextQueue;
            }
        }

        private void AddResource(ResourceReference resourceReference)
        {
            var index = resourceReference.Index;

            switch (resourceReference.GetLocation())
            {
                case ResourceLocation.Audio:
                    AudioResourceIndices.Add(index);
                    break;

                case ResourceLocation.Resources:
                    ResourcesResourceIndices.Add(index);
                    break;

                case ResourceLocation.Textures:
                    TexturesResourceIndices.Add(index);
                    break;

                case ResourceLocation.TexturesB:
                    TexturesBResourceIndices.Add(index);
                    break;

                case ResourceLocation.Video:
                    VideoResourceIndices.Add(index);
                    break;

                default:
                    break;
            }
        }

        private void CleanGlobals(Stream stream)
        {
            var matgTag = Info.Cache.Tags.FindFirstInGroup("matg");
            var matgContext = new TagSerializationContext(stream, Info, matgTag);
            var matgDefinition = Info.Deserializer.Deserialize<Globals>(matgContext);

            var playerControl = matgDefinition.PlayerControl[0];

            playerControl.MagnetismFriction = 0.6f;
            playerControl.MagnetismAdhesion = 0.6f;
            playerControl.InconsequentialTargetScale = 0.35f;

            playerControl.SecondsToStart = 4;
            playerControl.SecondsToFullSpeed = 0.8f;
            playerControl.DecayRate = 2;
            playerControl.FullSpeedMultiplier = 1.0f;
            playerControl.PeggedMagnitude = 0.9f;
            playerControl.PeggedAngularThreshold = 10;
            playerControl.Unknown = 1083179008;
            playerControl.Unknown2 = 1051931443;

            var playerInformation = matgDefinition.PlayerInformation[0];

            playerInformation.RunForward = 2.25f;
            playerInformation.RunBackward = 2;
            playerInformation.RunSideways = 2;

            Info.Serializer.Serialize(matgContext, matgDefinition);
        }

        private void CleanMultiplayerGlobals(Stream stream)
        {
            var mulgTag = Info.Cache.Tags.FindFirstInGroup("mulg");
            var mulgContext = new TagSerializationContext(stream, Info, mulgTag);
            var mulgDefinition = Info.Deserializer.Deserialize<MultiplayerGlobals>(mulgContext);

            #region Universal GameVariantWeapons
            mulgDefinition.Universal[0].GameVariantWeapons = new List<MultiplayerGlobals.UniversalBlock.GameVariantWeapon>
            {
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("battle_rifle"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x157C]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("assault_rifle"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x151E]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("plasma_pistol"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x14F7]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("spike_rifle"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x1500]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("smg"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x157D]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("carbine"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x14FE]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("energy_sword"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x159E]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("magnum"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x157E]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("needler"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x14F8]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("plasma_rifle"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x1525]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("rocket_launcher"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x15B3]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("shotgun"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x1A45]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("sniper_rifle"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x15B1]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("brute_shot"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x14FF]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("unarmed"),
                    RandomChance = 0,
                    Weapon = Info.Cache.Tags[0x157F]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("beam_rifle"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x1509]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("spartan_laser"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x15B2]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("none"),
                    RandomChance = 0,
                    Weapon = null
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("gravity_hammer"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x150C]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("excavator"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x1504]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("flamethrower"),
                    RandomChance = 0,
                    Weapon = Info.Cache.Tags[0x1A55]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantWeapon
                {
                    Name = Info.StringIDs.GetStringID("missile_pod"),
                    RandomChance = 0.1f,
                    Weapon = Info.Cache.Tags[0x1A54]
                }
            };
            #endregion

            #region Runtime Weapons
            mulgDefinition.Runtime[0].MultiplayerConstants[0].Weapons = new List<MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon>
            {
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // battle_rifle
                    Weapon2 = Info.Cache.Tags[0x157C],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // carbine
                    Weapon2 = Info.Cache.Tags[0x14FE],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // sniper_rifle
                    Weapon2 = Info.Cache.Tags[0x15B1],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // beam_rifle
                    Weapon2 = Info.Cache.Tags[0x1509],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // spartan_laster
                    Weapon2 = Info.Cache.Tags[0x15B2],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // rocket_launcher
                    Weapon2 = Info.Cache.Tags[0x15B3],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // chaingun_turret
                    Weapon2 = Info.Cache.Tags[0x15B4],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // machinegun_turret
                    Weapon2 = Info.Cache.Tags[0x15B5],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // machinegun_turret_integrated
                    Weapon2 = Info.Cache.Tags[0x15B6],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // plasma_cannon
                    Weapon2 = Info.Cache.Tags[0x150E],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // plasma_cannon_integrated
                    Weapon2 = Info.Cache.Tags[0x15B7],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // needler
                    Weapon2 = Info.Cache.Tags[0x14F8],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // flak_cannon
                    Weapon2 = Info.Cache.Tags[0x14F9],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // gauss_turret
                    Weapon2 = Info.Cache.Tags[0x15B8],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // anti_infantry
                    Weapon2 = Info.Cache.Tags[0x15B9],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Weapon
                {
                    // behemoth_chaingun_turret
                    Weapon2 = Info.Cache.Tags[0x15BA],
                    Unknown1 = 5.0f,
                    Unknown2 = 15.0f,
                    Unknown3 = 5.0f,
                    Unknown4 = -10.0f
                }
            };
            #endregion

            #region Universal GameVariantVehicles
            mulgDefinition.Universal[0].GameVariantVehicles = new List<MultiplayerGlobals.UniversalBlock.GameVariantVehicle>
            {
                new MultiplayerGlobals.UniversalBlock.GameVariantVehicle
                {
                    Name = Info.StringIDs.GetStringID("warthog"),
                    Vehicle = Info.Cache.Tags[0x151F]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantVehicle
                {
                    Name = Info.StringIDs.GetStringID("ghost"),
                    Vehicle = Info.Cache.Tags[0x1517]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantVehicle
                {
                    Name = Info.StringIDs.GetStringID("scorpion"),
                    Vehicle = Info.Cache.Tags[0x1520]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantVehicle
                {
                    Name = Info.StringIDs.GetStringID("wraith"),
                    Vehicle = Info.Cache.Tags[0x1519]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantVehicle
                {
                    Name = Info.StringIDs.GetStringID("banshee"),
                    Vehicle = Info.Cache.Tags[0x151A]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantVehicle
                {
                    Name = Info.StringIDs.GetStringID("mongoose"),
                    Vehicle = Info.Cache.Tags[0x1596]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantVehicle
                {
                    Name = Info.StringIDs.GetStringID("chopper"),
                    Vehicle = Info.Cache.Tags[0x1518]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantVehicle
                {
                    Name = Info.StringIDs.GetStringID("mauler"),
                    Vehicle = Info.Cache.Tags[0x547E]
                },
                new MultiplayerGlobals.UniversalBlock.GameVariantVehicle
                {
                    Name = Info.StringIDs.GetStringID("hornet"),
                    Vehicle = Info.Cache.Tags[0x1598]
                }
            };
            #endregion

            #region Universal VehicleSets
            mulgDefinition.Universal[0].VehicleSets = new List<MultiplayerGlobals.UniversalBlock.VehicleSet>
            {
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("default"),
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>()
                },
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("no_vehicles"),
                    #region Substitutions
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>
                    {
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("warthog"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("ghost"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("scorpion"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("wraith"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("mongoose"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("banshee"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("chopper"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("mauler"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("hornet"),
                            SubstitutedVehicle = StringID.Null
                        }
                    }
                    #endregion
                },
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("mongooses_only"),
                    #region Substitutions
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>
                    {
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("warthog"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("ghost"),
                            SubstitutedVehicle = Info.StringIDs.GetStringID("mongoose")
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("scorpion"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("wraith"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("banshee"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("chopper"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("mauler"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("hornet"),
                            SubstitutedVehicle = StringID.Null
                        }
                    }
                    #endregion
                },
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("light_ground_only"),
                    #region Substitutions
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>
                    {
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("scorpion"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("wraith"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("banshee"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("hornet"),
                            SubstitutedVehicle = StringID.Null
                        }
                    }
                    #endregion
                },
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("tanks_only"),
                    #region Substitutions
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>
                    {
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("warthog"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("ghost"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("mongoose"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("banshee"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("chopper"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("mauler"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("hornet"),
                            SubstitutedVehicle = StringID.Null
                        }
                    }
                    #endregion
                },
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("aircraft_only"),
                    #region Substitutions
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>
                    {
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("warthog"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("ghost"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("scorpion"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("wraith"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("mongoose"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("chopper"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("mauler"),
                            SubstitutedVehicle = StringID.Null
                        }
                    }
                    #endregion
                },
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("no_light_ground"),
                    #region Substitutions
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>
                    {
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("warthog"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("ghost"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("mongoose"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("chopper"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("mauler"),
                            SubstitutedVehicle = StringID.Null
                        }
                    }
                    #endregion
                },
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("no_tanks"),
                    #region Substitutions
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>
                    {
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("scorpion"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("wraith"),
                            SubstitutedVehicle = StringID.Null
                        }
                    }
                    #endregion
                },
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("no_aircraft"),
                    #region Substitutions
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>
                    {
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("banshee"),
                            SubstitutedVehicle = StringID.Null
                        },
                        new MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution
                        {
                            OriginalVehicle = Info.StringIDs.GetStringID("hornet"),
                            SubstitutedVehicle = StringID.Null
                        }
                    }
                    #endregion
                },
                new MultiplayerGlobals.UniversalBlock.VehicleSet
                {
                    Name = Info.StringIDs.GetStringID("all_vehicles"),
                    Substitutions = new List<MultiplayerGlobals.UniversalBlock.VehicleSet.Substitution>()
                }
            };
            #endregion

            #region Runtime Vehicles
            mulgDefinition.Runtime[0].MultiplayerConstants[0].Vehicles = new List<MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Vehicle>
            {
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Vehicle
                {
                    Vehicle2 = Info.Cache.Tags[0x1517],
                    Unknown1 = 2.0f,
                    Unknown2 = 1.5f,
                    Unknown3 = 0.5f,
                    Unknown4 = -1000.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Vehicle
                {
                    Vehicle2 = Info.Cache.Tags[0x151F],
                    Unknown1 = 2.0f,
                    Unknown2 = 1.5f,
                    Unknown3 = 0.5f,
                    Unknown4 = -1000.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Vehicle
                {
                    Vehicle2 = Info.Cache.Tags[0x151A],
                    Unknown1 = 2.0f,
                    Unknown2 = 1.5f,
                    Unknown3 = 0.5f,
                    Unknown4 = -1000.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Vehicle
                {
                    Vehicle2 = Info.Cache.Tags[0x1596],
                    Unknown1 = 1.5f,
                    Unknown2 = 1.5f,
                    Unknown3 = 0.5f,
                    Unknown4 = -1000.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Vehicle
                {
                    Vehicle2 = Info.Cache.Tags[0x1518],
                    Unknown1 = 3.0f,
                    Unknown2 = 1.5f,
                    Unknown3 = 0.25f,
                    Unknown4 = -1000.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Vehicle
                {
                    Vehicle2 = Info.Cache.Tags[0x1598],
                    Unknown1 = 2.0f,
                    Unknown2 = 1.5f,
                    Unknown3 = 0.5f,
                    Unknown4 = -1000.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Vehicle
                {
                    Vehicle2 = Info.Cache.Tags[0x1520],
                    Unknown1 = 3.0f,
                    Unknown2 = 1.5f,
                    Unknown3 = 0.5f,
                    Unknown4 = -1000.0f
                },
                new MultiplayerGlobals.RuntimeBlock.MultiplayerConstant.Vehicle
                {
                    Vehicle2 = Info.Cache.Tags[0x1519],
                    Unknown1 = 3.0f,
                    Unknown2 = 1.5f,
                    Unknown3 = 0.5f,
                    Unknown4 = -1000.0f
                },
            };
            #endregion

            Info.Serializer.Serialize(mulgContext, mulgDefinition);
        }

        private void NullTags(Stream stream, ref HashSet<int> retainedTags)
        {
            for (var i = 0; i < Info.Cache.Tags.Count; i++)
            {
                var tag = Info.Cache.Tags[i];

                if (tag == null)
                    continue;

                if (retainedTags.Contains(i))
                {
                    Console.Write($"Cleaning {Info.TagNames[tag.Index]}.{Info.StringIDs.GetString(tag.Group.Name)}...");

                    var context = new TagSerializationContext(stream, Info, tag);

                    if (tag.IsInGroup("bink"))
                    {
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing video resource...");
                        AddResource(((Bink)tagDefinition).Resource);
                    }
                    else if (tag.IsInGroup("bitm"))
                    {
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing bitmap resources...");

                        foreach (var resource in ((Bitmap)tagDefinition).Resources)
                        {
                            AddResource(resource.Resource);
                        }
                    }
                    else if (tag.IsInGroup("jmad"))
                    {
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing animation resources...");

                        foreach (var resourceGroup in ((ModelAnimationGraph)tagDefinition).ResourceGroups)
                        {
                            AddResource(resourceGroup.Resource);
                        }
                    }
                    else if (tag.IsInGroup("Lbsp"))
                    {
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing geometry resource...");
                        AddResource(((ScenarioLightmapBspData)tagDefinition).Geometry.Resource);
                    }
                    else if (tag.IsInGroup("mode"))
                    {
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing geometry resource...");
                        AddResource(((RenderModel)tagDefinition).Geometry.Resource);
                    }
                    else if (tag.IsInGroup("sbsp"))
                    {
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));

                        try
                        {
                            Console.WriteLine($"preparing small geometry resource...");
                            AddResource(((ScenarioStructureBsp)tagDefinition).Geometry.Resource);
                        }
                        catch { }

                        try
                        {
                            Console.Write($"preparing large geometry resource...");
                            AddResource(((ScenarioStructureBsp)tagDefinition).Geometry2.Resource);
                        }
                        catch { }

                        try
                        {
                            Console.Write($"preparing collision resource...");
                            AddResource(((ScenarioStructureBsp)tagDefinition).CollisionBspResource);
                        }
                        catch { }

                        try
                        {
                            Console.Write($"preparing unknown resource...");
                            AddResource(((ScenarioStructureBsp)tagDefinition).Resource4);
                        }
                        catch { }
                    }
                    else if (tag.IsInGroup("snd!"))
                    {
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing sound resource...");
                        AddResource(((Sound)tagDefinition).Resource);
                    }
                }
                else
                {
                    Console.Write($"Nulling {Info.TagNames[tag.Index]}.{Info.StringIDs.GetString(tag.Group.Name)}...");

                    Info.Cache.Tags[tag.Index] = null;
                    Info.Cache.SetTagDataRaw(stream, tag, new byte[] { });
                }

                Console.WriteLine("done.");
            }
        }

        private void NullResources()
        {
            //
            // Audio Resources
            //

            Console.WriteLine("Deserializing audio.dat");
            var resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "audio.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!AudioResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling audio resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.CacheFile.Directory}/audio.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "audio.dat")));

            //
            // Main Resources
            //

            Console.WriteLine("Deserializing resources.dat");
            resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "resources.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!ResourcesResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling resources resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.CacheFile.Directory}/resources.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "resources.dat")));

            //
            // Textures Resources
            //

            Console.WriteLine("Deserializing textures.dat");
            resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "textures.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!TexturesResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling textures resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.CacheFile.Directory}/textures.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "textures.dat")));

            //
            // TexturesB Resources
            //

            Console.WriteLine("Deserializing textures_b.dat");
            resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "textures_b.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!TexturesBResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling textures_b resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.CacheFile.Directory}/textures_b.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "textures_b.dat")));

            //
            // Video Resources
            //

            Console.WriteLine("Deserializing video.dat");
            resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "video.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!VideoResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling video resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.CacheFile.Directory}/video.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.CacheFile.DirectoryName, "video.dat")));
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;
            
            using (var srcStream = Info.OpenCacheReadWrite())
            using (var destStream = File.Create(Info.CacheFile.FullName + ".tmp"))
            using (var writer = new BinaryWriter(destStream))
            {
                CleanGlobals(srcStream);
                CleanMultiplayerGlobals(srcStream);

                var retainedTags = new HashSet<int>();
                LoadTagDependencies(0, ref retainedTags);
                LoadTagDependencies(0x27C3, ref retainedTags);

                NullTags(srcStream, ref retainedTags);
                NullResources();
            }

            return true;
        }

        public class ResourceFile
        {
            public byte[] Padding0 { get; set; } // Padding at beginning of file
            public uint TableOffset { get; set; } // Offset of where the offsets-table begins.
            public int ResourceCount { get; set; } // Amount of resources in the file.
            public byte[] Padding1 { get; set; } // Padding following the resource count.
            public long TimeStamp { get; set; } // Uh, a timestamp?
            public byte[] Padding2 { get; set; } // Padding following the timestamp.
            public List<Resource> Resources { get; set; } = new List<Resource> { }; // List of all the resources in their file (with their index, offset, size, and data).

            public ResourceFile(FileInfo file)
            {
                using (var stream = file.OpenRead())
                using (var reader = new BinaryReader(stream))
                {
                    // Read the resource file header.
                    Padding0 = reader.ReadBytes(0x4);
                    TableOffset = reader.ReadUInt32();
                    ResourceCount = reader.ReadInt32();
                    Padding1 = reader.ReadBytes(0x4);
                    TimeStamp = reader.ReadInt64();
                    Padding2 = reader.ReadBytes(0x8);

                    // Add all resources except the last one to the resources List... (it will get added right after this for-loop.)
                    reader.BaseStream.Position = TableOffset;
                    for (int i = 0; (Resources != null ? Resources.Count : 0) < ResourceCount - 1; i++)
                    {
                        Resource resource = new Resource();
                        resource.Index = i;
                        resource.StartOffset = reader.ReadUInt32();

                        // Used to find our place in the offset's table again after calculating the resource size and data.
                        long returnPosition = reader.BaseStream.Position;

                        // Add the next resource Offset and use it's start offset for the resource's
                        // EndOffset if it's non-nulled (uint.MaxValue for offset). In that case use the next one. If there isn't a next one,
                        // use the TableOffset instead.
                        resource.EndOffset = reader.ReadUInt32();
                        resource.NextIndex = i + 1;
                        while (resource.EndOffset == uint.MaxValue)
                        {
                            try
                            {
                                resource.EndOffset = reader.ReadUInt32();
                                resource.NextIndex = resource.NextIndex + 1;
                            }
                            catch { resource.EndOffset = TableOffset; }
                        }

                        // Don't try to read data for null resources.
                        if (resource.StartOffset == uint.MaxValue)
                        {
                            Resources.Add(resource);
                            reader.BaseStream.Position = returnPosition;
                            continue;
                        }
                        // Read the resource data.
                        resource.Size = resource.EndOffset - resource.StartOffset;
                        reader.BaseStream.Position = resource.StartOffset;
                        resource.Data = reader.ReadBytes((int)resource.Size);
                        // Add the resource to the list and return the stream position.
                        Resources.Add(resource);
                        reader.BaseStream.Position = returnPosition;
                    }

                    // Add the last resource in the file to the resources List.
                    Resource lastResource = new Resource();
                    lastResource.Index = ResourceCount - 1;
                    lastResource.StartOffset = reader.ReadUInt32();
                    // Don't try to read data for a null resource. Just add the resource to the list then return, since we are done here now.
                    if (lastResource.StartOffset == uint.MaxValue)
                    {
                        Resources.Add(lastResource);
                        return;
                    }

                    // Read the resource data.
                    lastResource.Size = TableOffset - lastResource.StartOffset;
                    reader.BaseStream.Position = lastResource.StartOffset;
                    lastResource.Data = reader.ReadBytes((int)lastResource.Size);
                    // Add the resource to the list.
                    Resources.Add(lastResource);
                }
            }

            public void Serialize(FileInfo file)
            {
                for (var i = Resources.Count - 1; i >= 0; i--)
                {
                    if (Resources[i].StartOffset != uint.MaxValue)
                        break;

                    Resources.RemoveAt(i);
                }

                using (var stream = file.Create())
                using (var writer = new BinaryWriter(stream))
                {
                    // Write the header
                    writer.Write(Padding0);
                    writer.Write(TableOffset);
                    writer.Write(Resources.Count);
                    writer.Write(Padding1);
                    writer.Write(TimeStamp);
                    writer.Write(Padding2);

                    // Write the resources data (if it has any) and add it's offset to the list.
                    List<uint> offsets = new List<uint> { };
                    foreach (Resource resource in Resources)
                    {
                        if (resource.Data != null)
                            writer.Write(resource.Data);

                        offsets.Add(resource.StartOffset);
                    }

                    // Write each offset.
                    foreach (uint offset in offsets)
                        writer.Write(offset);
                }
            }

            public void NullResource(int index)
            {
                if (index == -1)
                    return;

                uint size = Resources[index].Size;
                Resources[index].Size = 0; // Set the size to 0.
                Resources[index].StartOffset = uint.MaxValue; // The offset gets left in the table as 0xFFFFFFFF
                Resources[index].EndOffset = uint.MaxValue;
                Resources[index].Data = null; // Null the resource data.
                TableOffset -= size; // Remove it's size from the table-offset.

                // Fix up the offset for each resource which follows the nulled resource. Skip previously nulled resources, as their offset
                // should remain at 0xFFFFFFFF
                int nextIndex = index;
                while (Resources[nextIndex].NextIndex != 0)
                {
                    nextIndex = Resources[nextIndex].NextIndex;

                    if (Resources[nextIndex].StartOffset != uint.MaxValue)
                        Resources[nextIndex].StartOffset -= size;
                }
            }

            public class Resource
            {
                public int Index { get; set; } = 0; // Index of the resource's offset in the offsets-table.
                public int NextIndex { get; set; } = 0; // Index of the next resource...
                public uint StartOffset { get; set; } = 0; // Offset of where the resource's data begins.
                public uint EndOffset { get; set; } = 0; // Offset of where the resource's data ends.
                public uint Size { get; set; } = 0; // Size of the resource data.
                public byte[] Data { get; set; } = null; // Raw resource data.
            }
        }
    }
}
 