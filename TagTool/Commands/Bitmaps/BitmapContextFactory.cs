﻿using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Bitmaps
{
    static class BitmapContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext cacheContext, CachedTagInstance tag, Bitmap bitmap)
        {
            var groupName = cacheContext.StringIdCache.GetString(tag.Group.Name);
            var commandContext = new CommandContext(parent, string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(commandContext, cacheContext, tag, bitmap);

            return commandContext;
        }

        public static void Populate(CommandContext commandContext, GameCacheContext cacheContext, CachedTagInstance tag, Bitmap bitmap)
        {
            commandContext.AddCommand(new ExtractBitmapCommand(cacheContext, tag, bitmap));
            commandContext.AddCommand(new ImportBitmapCommand(cacheContext, tag, bitmap));
        }
    }
}
