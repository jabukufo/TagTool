using System;
using System.Collections.Generic;
using TagTool.Serialization;
using TagTool.TagDefinitions;
using TagTool.Cache;
using System.Globalization;

namespace TagTool.Commands.Tags
{
    class CreateTagCommand : Command
    {
        public GameCacheContext CacheContext { get; }

        public CreateTagCommand(GameCacheContext cacheContext)
            : base(CommandFlags.Inherit,

                  "create-tag",
                  "Creates a new tag of the specified tag group in the current tag cache.",

                  "create-tag <group tag> [index = *]",

                  "Creates a new tag of the specified tag group in the current tag cache.")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count < 1 || args.Count > 2)
                return false;

            var groupTag = ArgumentParser.ParseGroupTag(CacheContext.StringIdCache, args[0]);

            if (groupTag == null || !TagGroup.Instances.ContainsKey(groupTag))
                return false;

            TagInstance instance = null;

            using (var stream = CacheContext.OpenTagCacheReadWrite())
            {
                if (args.Count == 2)
                {
                    int tagIndex;
                    if (!int.TryParse(args[1].Replace("0x", ""), NumberStyles.HexNumber, null, out tagIndex))
                        return false;

                    if (tagIndex > CacheContext.TagCache.Tags.Count)
                        return false;

                    if (tagIndex < CacheContext.TagCache.Tags.Count)
                    {
                        if (CacheContext.TagCache.Tags[tagIndex] != null)
                        {
                            var oldInstance = CacheContext.TagCache.Tags[tagIndex];
                            CacheContext.TagCache.Tags[tagIndex] = null;
                            CacheContext.TagCache.SetTagDataRaw(stream, oldInstance, new byte[] { });
                        }

                        instance = new TagInstance(tagIndex, TagGroup.Instances[groupTag]);
                        CacheContext.TagCache.Tags[tagIndex] = instance;
                    }
                }

                if (instance == null)
                    instance = CacheContext.TagCache.AllocateTag(TagGroup.Instances[groupTag]);

                var context = new TagSerializationContext(stream, CacheContext, instance);
                var data = Activator.CreateInstance(TagStructureTypes.FindByGroupTag(groupTag));
                CacheContext.Serializer.Serialize(context, data);
            }

            var tagName = CacheContext.TagNames.ContainsKey(instance.Index) ?
                CacheContext.TagNames[instance.Index] :
                $"0x{instance.Index:X4}";

            Console.WriteLine($"[Index: 0x{instance.Index:X4}, Offset: 0x{instance.HeaderOffset:X8}, Size: 0x{instance.TotalSize:X4}] {tagName}.{CacheContext.StringIdCache.GetString(instance.Group.Name)}");

            return true;
        }
    }
}
