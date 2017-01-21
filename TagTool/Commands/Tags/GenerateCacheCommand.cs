using System.Collections.Generic;
using System.IO;
using System.Linq;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Tags.Definitions;
using System;

namespace TagTool.Commands.Tags
{
    class GenerateCacheCommand : Command
    {
        private GameCacheContext Info { get; }

        public GenerateCacheCommand(GameCacheContext info)
            : base(CommandFlags.Inherit,
                  "generatecache",
                  "Generates an empty set of cache files.",
                  "generatecache <output directory>",
                  "Generates an empty set of cache files.")
        {
            Info = info;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1)
                return false;

            var destDir = new DirectoryInfo(args[0]);
            if (!destDir.Exists)
            {
                Console.Write("Destination directory does not exist. Create it? [y/n] ");
                var answer = Console.ReadLine().ToLower();

                if (answer.Length == 0 || !(answer.StartsWith("y") || answer.StartsWith("n")))
                    return false;

                if (answer.StartsWith("y"))
                    destDir.Create();
                else
                    return false;
            }

            var globalTags = new HashSet<int>();
            LoadTagDependencies(0, ref globalTags);
            LoadTagDependencies(0x16, ref globalTags);
            LoadTagDependencies(0x27D7, ref globalTags);

            for (var i = 0; i < Info.Cache.Tags.Count; i++)
            {
                var tag = Info.Cache.Tags[i];

                if (tag == null)
                    continue;

                if (globalTags.Contains(i))
                    continue;

                Console.Write($"Nulling {Info.TagNames[tag.Index]}.{Info.StringIDs.GetString(tag.Group.Name)}...");

                using (var stream = Info.OpenCacheReadWrite())
                using (var writer = new BinaryWriter(stream))
                {
                    Info.Cache.SetTagDataRaw(stream, tag, new byte[] { });
                    Info.Cache.Tags[tag.Index] = null;
                    Info.Cache.UpdateTagOffsets(writer);
                }

                Console.WriteLine("done.");
            }

            var lastTag = -1;

            using (var cacheStream = Info.OpenCacheRead())
                foreach (var tag in Info.Cache.Tags)
                {
                    if (tag == null)
                        continue;

                    lastTag = tag.Index;
                }

            Console.WriteLine($"Last non-null tag: 0x{lastTag:X4}");

            Console.WriteLine($"Generating cache files in \"{destDir.FullName}\"...");

            var destTagsFile = new FileInfo(Path.Combine(destDir.FullName, "tags.dat"));

            Console.Write($"Generating {destTagsFile.FullName}...");
            using (var tagCacheStream = destTagsFile.Create())
            using (var writer = new BinaryWriter(tagCacheStream))
            {
                writer.Write((int)0); // padding
                writer.Write((int)0); // tag list offset
                writer.Write((int)0); // tag count
                writer.Write((int)0); // padding
                writer.Write((long)130713360239499012); // timestamp
                writer.Write((long)0); // padding
                writer.Write((long)0); // padding
            }
            Console.WriteLine("done.");

            var destStringIDsFile = new FileInfo(Path.Combine(destDir.FullName, "string_ids.dat"));

            Console.Write($"Generating {destStringIDsFile.FullName}...");
            Info.StringIDsFile.CopyTo(destStringIDsFile.FullName);

            var resourceCachePaths = new string[]
            {
                Path.Combine(destDir.FullName, "audio.dat"),
                Path.Combine(destDir.FullName, "resources.dat"),
                Path.Combine(destDir.FullName, "textures.dat"),
                Path.Combine(destDir.FullName, "textures_b.dat"),
                Path.Combine(destDir.FullName, "video.dat")
            };

            foreach (var resourceCachePath in resourceCachePaths)
            {
                Console.Write($"Generating {resourceCachePath}...");
                using (var resourceCacheStream = File.Create(resourceCachePath))
                using (var writer = new BinaryWriter(resourceCacheStream))
                {
                    writer.Write((int)0); // padding
                    writer.Write((int)0x1C); // table offset
                    writer.Write((int)1); // resource count
                    writer.Write((int)0); // padding
                    writer.Write((long)130713360241169179); //timestamp
                    writer.Write((long)0); // padding
                    writer.Write((int)0); // null resource padding
                    writer.Write((int)-1); // null resource offset
                }
                Console.WriteLine("done.");
            }

            var destResourcesFile = new FileInfo(Path.Combine(destDir.FullName, "resources.dat"));
            if (!destResourcesFile.Exists)
            {
                Console.WriteLine($"Destination resource cache file does not exist: {destResourcesFile.FullName}");
                return false;
            }

            var destTexturesFile = new FileInfo(Path.Combine(destDir.FullName, "textures.dat"));
            if (!destTexturesFile.Exists)
            {
                Console.WriteLine($"Destination texture cache file does not exist: {destTexturesFile.FullName}");
                return false;
            }

            var destTexturesBFile = new FileInfo(Path.Combine(destDir.FullName, "textures_b.dat"));
            if (!destTexturesBFile.Exists)
            {
                Console.WriteLine($"Destination texture cache file does not exist: {destTexturesBFile.FullName}");
                return false;
            }

            var destAudioFile = new FileInfo(Path.Combine(destDir.FullName, "audio.dat"));
            if (!destAudioFile.Exists)
            {
                Console.WriteLine($"Destination audio cache file does not exist: {destAudioFile.FullName}");
                return false;
            }
            
            TagCache destTagCache;
            using (var stream = destTagsFile.OpenRead())
                destTagCache = new TagCache(stream);

            CacheVersion guessedVersion;
            var destVersion = CacheVersionDetection.Detect(destTagCache, out guessedVersion);
            if (destVersion == CacheVersion.Unknown)
            {
                Console.WriteLine($"Unrecognized target version! (guessed {CacheVersionDetection.GetVersionString(guessedVersion)})");
                return true;
            }

            Console.WriteLine($"Destination cache version: {CacheVersionDetection.GetVersionString(destVersion)}");

            StringIdCache destStringIdCache;
            using (var stream = destStringIDsFile.OpenRead())
                destStringIdCache = new StringIdCache(stream, StringIdResolverFactory.Create(destVersion));

            var destResources = new ResourceDataManager();
            destResources.LoadCachesFromDirectory(destDir.FullName);

            var srcResources = new ResourceDataManager();
            srcResources.LoadCachesFromDirectory(Info.CacheFile.DirectoryName);

            var destSerializer = new TagSerializer(destVersion);
            var destDeserializer = new TagDeserializer(destVersion);

            var destInfo = new GameCacheContext
            {
                Cache = destTagCache,
                CacheFile = destTagsFile,
                StringIDs = destStringIdCache,
                StringIDsFile = destStringIDsFile,
                Version = destVersion,
                Serializer = destSerializer,
                Deserializer = destDeserializer
            };
            
            using (var srcStream = Info.OpenCacheRead())
            using (var destStream = destInfo.OpenCacheReadWrite())
            using (var destWriter = new BinaryWriter(destStream))
            {
                for (var i = 0; i < (lastTag + 1); i++)
                {
                    var oldTag = Info.Cache.Tags[i];

                    if (oldTag == null || !globalTags.Contains(i))
                    {
                        destInfo.Cache.AllocateTag(TagGroup.Null);
                        destInfo.Cache.Tags[i] = null;
                        continue;
                    }

                    var tagName = Info.TagNames[oldTag.Index];
                    var groupName = Info.StringIDs.GetString(oldTag.Group.Name);

                    Console.WriteLine($"Copying {tagName}.{groupName}...");

                    var newTag = destInfo.Cache.AllocateTag(oldTag.Group);

                    var srcContext = new TagSerializationContext(srcStream, Info.Cache, Info.StringIDs, oldTag);
                    var destContext = new TagSerializationContext(destStream, destInfo.Cache, Info.StringIDs, newTag);

                    var tagDefinition = Info.Deserializer.Deserialize(srcContext, TagStructureTypes.FindByGroupTag(oldTag.Group.Tag));
                    
                    if (oldTag.IsInGroup("bink"))
                    {
                        var bink = (Bink)tagDefinition;

                        if (bink.Resource.Index != -1)
                        {
                            Console.Write($"> Copying {groupName} resource...");

                            destResources.AddRaw(
                                bink.Resource,
                                bink.Resource.GetLocation(),
                                srcResources.ExtractRaw(bink.Resource));

                            Console.WriteLine("done.");
                        }
                    }
                    else if (oldTag.IsInGroup("bitm"))
                    {
                        var bitmap = ((Bitmap)tagDefinition);

                        for (var j = 0; j < bitmap.Resources.Count; j++)
                        {
                            var resource = bitmap.Resources[j];

                            if (resource.Resource.Index != -1)
                            {
                                Console.Write($"> Copying {groupName} resource {j}...");

                                destResources.AddRaw(
                                    resource.Resource,
                                    resource.Resource.GetLocation(),
                                    srcResources.ExtractRaw(resource.Resource));

                                Console.WriteLine("done.");
                            }
                        }
                    }
                    else if (oldTag.IsInGroup("jmad"))
                    {
                        var modelAnimationGraph = ((ModelAnimationGraph)tagDefinition);

                        for (var j = 0; j < modelAnimationGraph.ResourceGroups.Count; j++)
                        {
                            var resourceGroup = modelAnimationGraph.ResourceGroups[j];

                            if (resourceGroup.Resource.Index != -1)
                            {
                                Console.Write($"> Copying {groupName} resource group {j}...");

                                destResources.AddRaw(
                                    resourceGroup.Resource,
                                    resourceGroup.Resource.GetLocation(),
                                    srcResources.ExtractRaw(resourceGroup.Resource));

                                Console.WriteLine("done.");
                            }
                        }
                    }
                    else if (oldTag.IsInGroup("Lbsp"))
                    {
                        var scenarioLightmapBspData = (ScenarioLightmapBspData)tagDefinition;

                        if (scenarioLightmapBspData.Geometry.Resource.Index != -1)
                        {
                            Console.Write($"> Copying {groupName} geometry resource...");

                            destResources.AddRaw(
                                scenarioLightmapBspData.Geometry.Resource,
                                scenarioLightmapBspData.Geometry.Resource.GetLocation(),
                                srcResources.ExtractRaw(scenarioLightmapBspData.Geometry.Resource));

                            Console.WriteLine("done.");
                        }
                    }
                    else if (oldTag.IsInGroup("mode"))
                    {
                        var renderModel = (RenderModel)tagDefinition;

                        if (renderModel.Geometry.Resource.Index != -1)
                        {
                            Console.Write($"> Copying {groupName} geometry resource...");

                            destResources.AddRaw(
                                renderModel.Geometry.Resource,
                                renderModel.Geometry.Resource.GetLocation(),
                                srcResources.ExtractRaw(renderModel.Geometry.Resource));

                            Console.WriteLine("done.");
                        }
                    }
                    else if (oldTag.IsInGroup("sbsp"))
                    {
                        var scenarioStructureBsp = (ScenarioStructureBsp)tagDefinition;

                        if (scenarioStructureBsp.Geometry.Resource.Index != -1)
                        {
                            Console.Write($"> Copying {groupName} geometry resource...");

                            destResources.AddRaw(
                                scenarioStructureBsp.Geometry.Resource,
                                scenarioStructureBsp.Geometry.Resource.GetLocation(),
                                srcResources.ExtractRaw(scenarioStructureBsp.Geometry.Resource));

                            Console.WriteLine("done.");
                        }

                        if (scenarioStructureBsp.Geometry2.Resource.Index != -1)
                        {
                            Console.Write($"> Copying {groupName} geometry resource...");

                            destResources.AddRaw(
                                scenarioStructureBsp.Geometry2.Resource,
                                scenarioStructureBsp.Geometry2.Resource.GetLocation(),
                                srcResources.ExtractRaw(scenarioStructureBsp.Geometry2.Resource));

                            Console.WriteLine("done.");
                        }

                        if (scenarioStructureBsp.CollisionBspResource.Index != -1)
                        {
                            Console.Write($"> Copying {groupName} collision resource...");

                            destResources.AddRaw(
                                scenarioStructureBsp.CollisionBspResource,
                                scenarioStructureBsp.CollisionBspResource.GetLocation(),
                                srcResources.ExtractRaw(scenarioStructureBsp.CollisionBspResource));

                            Console.WriteLine("done.");
                        }

                        if (scenarioStructureBsp.Resource4.Index != -1)
                        {
                            Console.Write($"> Copying {groupName} unknown resource...");

                            destResources.AddRaw(
                                scenarioStructureBsp.Resource4,
                                scenarioStructureBsp.Resource4.GetLocation(),
                                srcResources.ExtractRaw(scenarioStructureBsp.Resource4));

                            Console.WriteLine("done.");
                        }
                    }
                    else if (oldTag.IsInGroup("snd!"))
                    {
                        var sound = (Sound)tagDefinition;

                        if (sound.Resource.Index != -1)
                        {
                            Console.Write($"> Copying {groupName} resource...");

                            destResources.AddRaw(
                                sound.Resource,
                                sound.Resource.GetLocation(),
                                srcResources.ExtractRaw(sound.Resource));

                            Console.WriteLine("done.");
                        }
                    }

                    Info.Serializer.Serialize(destContext, tagDefinition);
                }

                destInfo.Cache.UpdateTagOffsets(destWriter);
            }
            
            Console.WriteLine($"Done generating cache files in \"{destDir.FullName}\".");

            return true;
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
    }
}
