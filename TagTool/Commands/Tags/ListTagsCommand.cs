using System;
using System.Collections.Generic;
using System.Linq;
using TagTool.Cache;
using TagTool.Tags;

namespace TagTool.Commands.Tags
{
    class ListTagsCommand : Command
    {
        private GameCacheContext CacheContext { get; }

        public ListTagsCommand(GameCacheContext cacheContext)
            : base(CommandFlags.Inherit,

                  "list-tags",
                  "Lists tag instances that are of the specified tag group.",

                  "list-tags <group tag 1> ... <group tag n>",

                  "Lists tag instances that are of the specified tag group." +
                  "Multiple group tags to list tags from can be specified.\n" +
                  "Tags of a group which inherit from the given group tags will also\n" +
                  "be printed. If no group tag is specified, all tags in the current\n" +
                  "tag cache file will be listed.")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            var searchClasses = ArgumentParser.ParseGroupTags(CacheContext.StringIdCache, args);

            if (searchClasses == null)
                return false;

            TagInstance[] tags;
            if (args.Count > 0)
                tags = CacheContext.TagCache.Tags.FindAllInGroups(searchClasses).ToArray();
            else
                tags = CacheContext.TagCache.Tags.NonNull().ToArray();

            if (tags.Length == 0)
            {
                Console.Error.WriteLine("No tags found.");
                return true;
            }

            foreach (var tag in tags)
            {
                var tagName = CacheContext.TagNames.ContainsKey(tag.Index) ?
                    CacheContext.TagNames[tag.Index] :
                    $"0x{tag.Index:X4}";

                Console.WriteLine($"[Index: 0x{tag.Index:X4}, Offset: 0x{tag.HeaderOffset:X8}, Size: 0x{tag.TotalSize:X4}] {tagName}.{CacheContext.StringIdCache.GetString(tag.Group.Name)}");
            }

            return true;
        }
    }
}
