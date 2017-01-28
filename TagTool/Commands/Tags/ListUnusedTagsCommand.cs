using System;
using System.Collections.Generic;
using System.Linq;
using TagTool.Cache;

namespace TagTool.Commands.Tags
{
    class ListUnusedTagsCommand : Command
    {
        public GameCacheContext CacheContext { get; }

        public ListUnusedTagsCommand(GameCacheContext cacheContext)
            : base(CommandFlags.None,

                  "ListUnusedTags",
                  "Lists all unreferenced tags in the current tag cache",

                  "ListUnusedTags",

                  "Lists all unreferenced tags in the current tag cache")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;

            foreach (var tag in CacheContext.TagCache.Index)
            {
                if (tag == null)
                    continue;

                var dependsOn = CacheContext.TagCache.Index.NonNull().Where(t => t.Dependencies.Contains(tag.Index));

                if (dependsOn.Count() == 0)
                {
                    Console.Write($"{CacheContext.TagNames[tag.Index]} ");
                    TagPrinter.PrintTagShort(tag);
                }
            }

            return true;
        }
    }
}
