﻿using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Models
{
    static class ModelContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, CachedTagInstance tag, Model model)
        {
            var groupName = info.StringIdCache.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, model);

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, CachedTagInstance tag, Model model)
        {
            context.AddCommand(new ListVariantsCommand(info, model));
            context.AddCommand(new ExtractModelCommand(info, model));
        }
    }
}
