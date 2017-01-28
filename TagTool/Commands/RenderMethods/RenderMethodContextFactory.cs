﻿using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.RenderMethods
{
    static class RenderMethodContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, CachedTagInstance tag, RenderMethod renderMethod)
        {
            var groupName = info.StringIdCache.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, renderMethod);

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, CachedTagInstance tag, RenderMethod renderMethod)
        {
            context.AddCommand(new ListArgumentsCommand(info, tag, renderMethod));
            context.AddCommand(new ListBitmapsCommand(info, tag, renderMethod));
            context.AddCommand(new SpecifyBitmapsCommand(info, tag, renderMethod));
        }
    }
}
