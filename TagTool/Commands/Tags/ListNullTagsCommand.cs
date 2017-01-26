using System;
using System.Collections.Generic;
using TagTool.Cache;

namespace TagTool.Commands.Tags
{
    class ListNullTagsCommand : Command
    {
        public GameCacheContext CacheContext { get; }

        public ListNullTagsCommand(GameCacheContext cacheContext)
            : base(CommandFlags.None,
                  
                  "list-null-tags",
                  "Lists all null tag indices in the current tag cache",
                  
                  "listnulltags",
                  
                  "Lists all null tag indices in the current tag cache")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;

            for (var i = 0; i < CacheContext.TagCache.Tags.Count; i++)
            {
                if (CacheContext.TagCache.Tags[i] == null)
                    Console.WriteLine($"0x{i:X4}");
            }

            return true;
        }
    }
}
