using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache.HaloOnline;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Tags
{
    class NullTagCommand : Command
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

        public NullTagCommand(GameCacheContext info)
            : base(CommandFlags.None,
                  "null-tag",
                  "Nulls and removes a tag and its and resources from cache.",
                  "null-tag",
                  "Nulls and removes a tag and its and resources from cache.")
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
                        if (Info.TagCache.Tags[entry] == null)
                            continue;

                        tags.Add(entry);

                        foreach (var dependency in Info.TagCache.Tags[entry].Dependencies)
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

        private void NullTags(Stream stream, ref HashSet<int> tags, ref HashSet<int> retainedTags)
        {
            for (var i = 0; i < Info.TagCache.Tags.Count; i++)
            {
                var tag = Info.TagCache.Tags[i];

                if (tag == null)
                    continue;

                if (!retainedTags.Contains(i) && tags.Contains(i))
                {
                    Console.Write($"Nulling {Info.TagNames[tag.Index]}.{Info.StringIdCache.GetString(tag.Group.Name)}...");
                    Info.TagCache.Tags[tag.Index] = null;
                    Info.TagCache.SetTagDataRaw(stream, tag, new byte[] { });
                }
                else
                {
                    var context = new TagSerializationContext(stream, Info, tag);

                    if (tag.IsInGroup("bink"))
                    {
                        Console.Write($"Loading {Info.TagNames[tag.Index]}.{Info.StringIdCache.GetString(tag.Group.Name)}...");
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing video resource for recache...");
                        AddResource(((Bink)tagDefinition).Resource);
                    }
                    else if (tag.IsInGroup("bitm"))
                    {
                        Console.Write($"Loading {Info.TagNames[tag.Index]}.{Info.StringIdCache.GetString(tag.Group.Name)}...");
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing bitmap resources for recache...");

                        foreach (var resource in ((Bitmap)tagDefinition).Resources)
                            AddResource(resource.Resource);
                    }
                    else if (tag.IsInGroup("jmad"))
                    {
                        Console.Write($"Loading {Info.TagNames[tag.Index]}.{Info.StringIdCache.GetString(tag.Group.Name)}...");
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing animation resources for recache...");

                        foreach (var resourceGroup in ((ModelAnimationGraph)tagDefinition).ResourceGroups)
                            AddResource(resourceGroup.Resource);
                    }
                    else if (tag.IsInGroup("Lbsp"))
                    {
                        Console.Write($"Loading {Info.TagNames[tag.Index]}.{Info.StringIdCache.GetString(tag.Group.Name)}...");
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing geometry resource for recache...");
                        AddResource(((ScenarioLightmapBspData)tagDefinition).Geometry.Resource);
                    }
                    else if (tag.IsInGroup("mode"))
                    {
                        Console.Write($"Loading {Info.TagNames[tag.Index]}.{Info.StringIdCache.GetString(tag.Group.Name)}...");
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing geometry resource for recache...");
                        AddResource(((RenderModel)tagDefinition).Geometry.Resource);
                    }
                    else if (tag.IsInGroup("sbsp"))
                    {
                        Console.Write($"Loading {Info.TagNames[tag.Index]}.{Info.StringIdCache.GetString(tag.Group.Name)}...");
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));

                        try
                        {
                            Console.WriteLine($"preparing small geometry resource for recache...");
                            AddResource(((ScenarioStructureBsp)tagDefinition).Geometry.Resource);
                        }
                        catch { }

                        try
                        {
                            Console.Write($"preparing large geometry resource for recache...");
                            AddResource(((ScenarioStructureBsp)tagDefinition).Geometry2.Resource);
                        }
                        catch { }

                        try
                        {
                            Console.Write($"preparing collision resource for recache...");
                            AddResource(((ScenarioStructureBsp)tagDefinition).CollisionBspResource);
                        }
                        catch { }

                        try
                        {
                            Console.Write($"preparing unknown resource for recache...");
                            AddResource(((ScenarioStructureBsp)tagDefinition).Resource4);
                        }
                        catch { }
                    }
                    else if (tag.IsInGroup("snd!"))
                    {
                        Console.Write($"Loading {Info.TagNames[tag.Index]}.{Info.StringIdCache.GetString(tag.Group.Name)}...");
                        var tagDefinition = Info.Deserializer.Deserialize(context, TagStructureTypes.FindByGroupTag(tag.Group.Tag));
                        Console.Write($"preparing sound resource for recache...");
                        AddResource(((Sound)tagDefinition).Resource);
                    }
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
            var resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "audio.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!AudioResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling audio resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.TagCacheFile.Directory}/audio.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "audio.dat")));

            //
            // Main Resources
            //

            Console.WriteLine("Deserializing resources.dat");
            resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "resources.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!ResourcesResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling resources resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.TagCacheFile.Directory}/resources.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "resources.dat")));

            //
            // Textures Resources
            //

            Console.WriteLine("Deserializing textures.dat");
            resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "textures.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!TexturesResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling textures resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.TagCacheFile.Directory}/textures.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "textures.dat")));

            //
            // TexturesB Resources
            //

            Console.WriteLine("Deserializing textures_b.dat");
            resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "textures_b.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!TexturesBResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling textures_b resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.TagCacheFile.Directory}/textures_b.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "textures_b.dat")));

            //
            // Video Resources
            //

            Console.WriteLine("Deserializing video.dat");
            resourceFile = new ResourceFile(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "video.dat")));

            foreach (var resource in resourceFile.Resources)
            {
                if (!VideoResourceIndices.Contains(resource.Index))
                {
                    Console.WriteLine("nulling video resource at index: " + resource.Index);
                    resourceFile.NullResource(resource.Index);
                }
            }

            Console.WriteLine($"Serializing to {Info.TagCacheFile.Directory}/video.dat");
            resourceFile.Serialize(new FileInfo(Path.Combine(Info.TagCacheFile.DirectoryName, "video.dat")));
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1)
                return false;

            var tag = ArgumentParser.ParseTagIndex(Info, args[0]);

            if (tag == null)
                return false;

            using (var stream = Info.OpenCacheReadWrite())
            {
                var retainedTags = new HashSet<int>();
                LoadTagDependencies(Info.TagCache.Tags.FindFirstInGroup("cfgt").Index, ref retainedTags);

                foreach (var scnr in Info.TagCache.Tags.FindAllInGroup("scnr"))
                    LoadTagDependencies(scnr.Index, ref retainedTags);

                var tags = new HashSet<int>();
                LoadTagDependencies(tag.Index, ref tags);

                NullTags(stream, ref tags, ref retainedTags);
                NullResources();
            }

            return true;
        }
    }
}
