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
            }
            WriteLine("done.");

            var destStringIDsFile = new FileInfo(Combine(destDir.FullName, "string_ids.dat"));

            Write($"Generating {destStringIDsFile.FullName}...");
            using (var stringIDCacheStream = destStringIDsFile.Create())
            using (var writer = new BinaryWriter(stringIDCacheStream))
            {
                writer.Write((int)0); // string count
                writer.Write((int)0); // data size
            }
            WriteLine("done.");

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
                }
                WriteLine("done.");
            }

            var dependencies = new HashSet<int>();
            LoadTagDependencies(0, ref dependencies);
            LoadTagDependencies(0x16, ref dependencies);
            LoadTagDependencies(0x27D7, ref dependencies);
            
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
                var lastTagIndex = dependencies.Max();

                for (var i = 0; i < (lastTagIndex + 1); i++)
                {
                    var oldTag = Info.Cache.Tags[i];
                    var newTag = destInfo.Cache.AllocateTag(oldTag != null ? oldTag.Group : TagGroup.Null);

                    if (oldTag == null)
                    {
                        destInfo.Cache.Tags[i] = null;
                        continue;
                    }

                    var srcContext = new TagSerializationContext(srcStream, Info.Cache, Info.StringIDs, oldTag);
                    var destContext = new TagSerializationContext(destStream, destInfo.Cache, Info.StringIDs, newTag);

                    var tagDefinition = Info.Deserializer.Deserialize(srcContext, TagStructureTypes.FindByGroupTag(oldTag.Group.Tag));

                    //
                    // TODO: Extract the resources below from srcResources and import them to destResources...
                    // TODO 2: Update each resource reference to its new index
                    //

                    if (oldTag.IsInGroup("bink"))
                    {
                        var location = ((Bink)tagDefinition).Resource.GetLocation();
                        var index = ((Bink)tagDefinition).Resource.Index;
                    }
                    else if (oldTag.IsInGroup("bitm"))
                    {
                        foreach (var resource in ((Bitmap)tagDefinition).Resources)
                        {
                            var location = resource.Resource.GetLocation();
                            var index = resource.Resource.Index;
                        }
                    }
                    else if (oldTag.IsInGroup("jmad"))
                    {
                        foreach (var resourceGroup in ((ModelAnimationGraph)tagDefinition).ResourceGroups)
                        {
                            var location = resourceGroup.Resource.GetLocation();
                            var index = resourceGroup.Resource.Index;
                        }
                    }
                    else if (oldTag.IsInGroup("Lbsp"))
                    {
                        var location = ((ScenarioLightmapBspData)tagDefinition).Geometry.Resource.GetLocation();
                        var index = ((ScenarioLightmapBspData)tagDefinition).Geometry.Resource.Index;
                    }
                    else if (oldTag.IsInGroup("mode"))
                    {
                        var location = ((RenderModel)tagDefinition).Geometry.Resource.GetLocation();
                        var index = ((RenderModel)tagDefinition).Geometry.Resource.Index;
                    }
                    else if(oldTag.IsInGroup("sbsp"))
                    {
                        var geometryLocation = ((ScenarioStructureBsp)tagDefinition).Geometry.Resource.GetLocation();
                        var geometryIndex = ((ScenarioStructureBsp)tagDefinition).Geometry.Resource.Index;

                        var geometry2Location = ((ScenarioStructureBsp)tagDefinition).Geometry2.Resource.GetLocation();
                        var geometry2Index = ((ScenarioStructureBsp)tagDefinition).Geometry2.Resource.Index;

                        var collisionLocation = ((ScenarioStructureBsp)tagDefinition).CollisionBSPResource.GetLocation();
                        var collisionIndex = ((ScenarioStructureBsp)tagDefinition).CollisionBSPResource.Index;

                        var resource4Location = ((ScenarioStructureBsp)tagDefinition).Resource4.GetLocation();
                        var resource4Index = ((ScenarioStructureBsp)tagDefinition).Resource4.Index;
                    }
                    else if (oldTag.IsInGroup("snd!"))
                    {
                        var location = ((Sound)tagDefinition).Resource.GetLocation();
                        var index = ((Sound)tagDefinition).Resource.Index;
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
