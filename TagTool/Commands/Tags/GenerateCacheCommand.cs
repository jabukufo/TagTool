using System.Collections.Generic;
using System.IO;
using System.Linq;
using TagTool.Serialization;
using TagTool.Tags;
using static System.Console;
using static System.IO.Path;
using static TagTool.Cache.CacheVersionDetection;
using static TagTool.Cache.CacheVersion;
using static TagTool.Cache.HaloOnline.StringIdResolverFactory;
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
                Write("Destination directory does not exist. Create it? [y/n] ");
                var answer = ReadLine().ToLower();

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
            LoadTagDependencies(0x2E8A, ref globalTags);

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

            WriteLine($"Generating cache files in \"{destDir.FullName}\"...");

            var destTagsFile = new FileInfo(Combine(destDir.FullName, "tags.dat"));

            Write($"Generating {destTagsFile.FullName}...");
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
            WriteLine("done.");

            var destStringIDsFile = new FileInfo(Combine(destDir.FullName, "string_ids.dat"));

            Write($"Generating {destStringIDsFile.FullName}...");
            Info.StringIDsFile.CopyTo(destStringIDsFile.FullName);

            var resourceCachePaths = new string[]
            {
                Combine(destDir.FullName, "audio.dat"),
                Combine(destDir.FullName, "resources.dat"),
                Combine(destDir.FullName, "textures.dat"),
                Combine(destDir.FullName, "textures_b.dat"),
                Combine(destDir.FullName, "video.dat")
            };

            foreach (var resourceCachePath in resourceCachePaths)
            {
                Write($"Generating {resourceCachePath}...");
                using (var resourceCacheStream = File.Create(resourceCachePath))
                using (var writer = new BinaryWriter(resourceCacheStream))
                {
                    writer.Write((int)0); // padding
                    writer.Write((int)0); // table offset
                    writer.Write((int)0); // resource count
                    writer.Write((int)0); // padding
                    writer.Write((long)130713360239499012); // timestamp
                    writer.Write((long)0); // padding
                }
                WriteLine("done.");
            }

            var destResourcesFile = new FileInfo(Combine(destDir.FullName, "resources.dat"));
            if (!destResourcesFile.Exists)
            {
                WriteLine($"Destination resource cache file does not exist: {destResourcesFile.FullName}");
                return false;
            }

            var destTexturesFile = new FileInfo(Combine(destDir.FullName, "textures.dat"));
            if (!destTexturesFile.Exists)
            {
                WriteLine($"Destination texture cache file does not exist: {destTexturesFile.FullName}");
                return false;
            }

            var destTexturesBFile = new FileInfo(Combine(destDir.FullName, "textures_b.dat"));
            if (!destTexturesBFile.Exists)
            {
                WriteLine($"Destination texture cache file does not exist: {destTexturesBFile.FullName}");
                return false;
            }

            var destAudioFile = new FileInfo(Combine(destDir.FullName, "audio.dat"));
            if (!destAudioFile.Exists)
            {
                WriteLine($"Destination audio cache file does not exist: {destAudioFile.FullName}");
                return false;
            }
            
            TagCache destTagCache;
            using (var stream = destTagsFile.OpenRead())
                destTagCache = new TagCache(stream);

            CacheVersion guessedVersion;
            var destVersion = Detect(destTagCache, out guessedVersion);
            if (destVersion == Unknown)
            {
                WriteLine($"Unrecognized target version! (guessed {GetVersionString(guessedVersion)})");
                return true;
            }

            WriteLine($"Destination cache version: {GetVersionString(destVersion)}");

            StringIdCache destStringIdCache;
            using (var stream = destStringIDsFile.OpenRead())
                destStringIdCache = new StringIdCache(stream, Create(destVersion));

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

                    var newTag = destInfo.Cache.AllocateTag(oldTag.Group);

                    var srcContext = new TagSerializationContext(srcStream, Info.Cache, Info.StringIDs, oldTag);
                    var destContext = new TagSerializationContext(destStream, destInfo.Cache, Info.StringIDs, newTag);

                    var tagDefinition = Info.Deserializer.Deserialize(srcContext, TagStructureTypes.FindByGroupTag(oldTag.Group.Tag));
                    
                    if (oldTag.IsInGroup("bink"))
                    {
                        var bink = (Bink)tagDefinition;

                        if (bink.Resource.Index != -1)
                            destResources.AddRaw(bink.Resource, bink.Resource.GetLocation(), srcResources.ExtractRaw(bink.Resource));
                    }
                    else if (oldTag.IsInGroup("bitm"))
                    {
                        foreach (var resource in ((Bitmap)tagDefinition).Resources)
                        {
                            if (resource.Resource.Index != -1)
                                destResources.AddRaw(resource.Resource, resource.Resource.GetLocation(), srcResources.ExtractRaw(resource.Resource));
                        }
                    }
                    else if (oldTag.IsInGroup("jmad"))
                    {
                        foreach (var resourceGroup in ((ModelAnimationGraph)tagDefinition).ResourceGroups)
                        {
                            if (resourceGroup.Resource.Index != -1)
                                destResources.AddRaw(resourceGroup.Resource, resourceGroup.Resource.GetLocation(), srcResources.ExtractRaw(resourceGroup.Resource));
                        }
                    }
                    else if (oldTag.IsInGroup("Lbsp"))
                    {
                        var geometry = ((ScenarioLightmapBspData)tagDefinition).Geometry;

                        if (geometry.Resource.Index != -1)
                            destResources.AddRaw(geometry.Resource, geometry.Resource.GetLocation(), srcResources.ExtractRaw(geometry.Resource));
                    }
                    else if (oldTag.IsInGroup("mode"))
                    {
                        var geometry = ((RenderModel)tagDefinition).Geometry;

                        if (geometry.Resource.Index != -1)
                            destResources.AddRaw(geometry.Resource, geometry.Resource.GetLocation(), srcResources.ExtractRaw(geometry.Resource));
                    }
                    else if (oldTag.IsInGroup("sbsp"))
                    {
                        var bsp = (ScenarioStructureBsp)tagDefinition;

                        if (bsp.Geometry.Resource.Index != -1)
                            destResources.AddRaw(bsp.Geometry.Resource, bsp.Geometry.Resource.GetLocation(), srcResources.ExtractRaw(bsp.Geometry.Resource));

                        if (bsp.Geometry2.Resource.Index != -1)
                            destResources.AddRaw(bsp.Geometry2.Resource, bsp.Geometry2.Resource.GetLocation(), srcResources.ExtractRaw(bsp.Geometry2.Resource));

                        if (bsp.CollisionBSPResource.Index != -1)
                            destResources.AddRaw(bsp.CollisionBSPResource, bsp.CollisionBSPResource.GetLocation(), srcResources.ExtractRaw(bsp.CollisionBSPResource));

                        if (bsp.Resource4.Index != -1)
                            destResources.AddRaw(bsp.Resource4, bsp.Resource4.GetLocation(), srcResources.ExtractRaw(bsp.Resource4));
                    }
                    else if (oldTag.IsInGroup("snd!"))
                    {
                        var sound = (Sound)tagDefinition;

                        if (sound.Resource.Index != -1)
                            destResources.AddRaw(sound.Resource, sound.Resource.GetLocation(), srcResources.ExtractRaw(sound.Resource));
                    }

                    Info.Serializer.Serialize(destContext, tagDefinition);
                }

                destInfo.Cache.UpdateTagOffsets(destWriter);
            }
            
            WriteLine($"Done generating cache files in \"{destDir.FullName}\".");

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
