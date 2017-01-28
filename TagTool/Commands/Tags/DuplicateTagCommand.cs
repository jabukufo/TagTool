﻿using System;
using System.Collections.Generic;
using TagTool.Cache;

namespace TagTool.Commands.Tags
{
    class DuplicateTagCommand : Command
    {
        private GameCacheContext CacheContext { get; }

        public DuplicateTagCommand(GameCacheContext cacheContext)
            : base(CommandFlags.None,
                  
                  "DuplicateTag",
                  "Creates a new copy of a tag in the tag cache.",
                  
                  "DuplicateTag <tag index>",
                  
                  "All of the tag's data, including tag blocks, will be copied into a new tag.\n" +
                  "The new tag can then be edited independently of the old tag.")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1)
                return false;

            var tag = ArgumentParser.ParseTagIndex(CacheContext, args[0]);

            if (tag == null)
                return false;

            CachedTagInstance newTag;
            using (var stream = CacheContext.OpenTagCacheReadWrite())
                newTag = CacheContext.TagCache.DuplicateTag(stream, tag);

            Console.WriteLine("Tag duplicated successfully!");
            Console.Write("New tag: ");
            TagPrinter.PrintTagShort(newTag);

            return true;
        }
    }
}
