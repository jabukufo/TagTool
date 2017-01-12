﻿using TagTool.TagGroups;
using TagTool.Tags.TagDefinitions;

namespace TagTool.Commands.RenderModels
{
    static class RenderModelContextFactory
    {
        public static CommandContext Create(CommandContext parent, OpenTagCache info, TagInstance tag, RenderModel renderModel)
        {
            var groupName = info.StringIDs.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, renderModel);

            return context;
        }

        public static void Populate(CommandContext context, OpenTagCache info, TagInstance tag, RenderModel renderModel)
        {
            context.AddCommand(new SpecifyShadersCommand(info, tag, renderModel));
            context.AddCommand(new GetResourceCommand(info, tag, renderModel));
            context.AddCommand(new ReplaceCommand(info, tag, renderModel));
        }
    }
}
