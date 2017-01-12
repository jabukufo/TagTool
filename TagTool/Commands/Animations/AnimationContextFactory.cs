﻿using TagTool.TagGroups;
using TagTool.Tags.TagDefinitions;

namespace TagTool.Commands.Animations
{
    static class AnimationContextFactory
    {
        public static CommandContext Create(CommandContext parent, OpenTagCache info, TagInstance tag, ModelAnimationGraph animation)
        {
            var groupName = info.StringIDs.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, animation);

            return context;
        }

        public static void Populate(CommandContext context, OpenTagCache info, TagInstance tag, ModelAnimationGraph animation)
        {
            context.AddCommand(new GetResourcesCommand(info, tag, animation));
            context.AddCommand(new AnimationTestCommand(info, tag, animation));
        }
    }
}
