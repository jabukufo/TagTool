﻿using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.RenderModels
{
    static class RenderModelContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, CachedTagInstance tag, RenderModel renderModel)
        {
            var groupName = info.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, renderModel);

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, CachedTagInstance tag, RenderModel renderModel)
        {
            context.AddCommand(new SpecifyShadersCommand(info, tag, renderModel));
            context.AddCommand(new GetResourceInfoCommand(info, tag, renderModel));
        }
    }
}
