﻿using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.Commands.Editing
{
    class SaveTagChangesCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private object Value { get; }

        public SaveTagChangesCommand(GameCacheContext cacheContext, TagInstance tag, object value)
            : base(CommandFlags.Inherit,

                  "save-tag-changes",
                  $"Saves changes made to the current {cacheContext.StringIdCache.GetString(tag.Group.Name)} definition.",

                  "save-tag-changes",

                  $"Saves changes made to the current {cacheContext.StringIdCache.GetString(tag.Group.Name)} definition.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Value = value;
        }

        public override bool Execute(List<string> args)
        {
            using (var stream = CacheContext.OpenTagCacheReadWrite())
            {
                var context = new TagSerializationContext(stream, CacheContext, Tag);
                CacheContext.Serializer.Serialize(context, Value);
            }

            Console.WriteLine("Done!");

            return true;
        }
    }
}
