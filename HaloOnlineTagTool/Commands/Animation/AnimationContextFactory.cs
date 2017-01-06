using HaloOnlineTagTool.TagStructures;

namespace HaloOnlineTagTool.Commands.Animation
{
    static class AnimationContextFactory
    {
        public static CommandContext Create(CommandContext parent, OpenTagCache info, TagInstance tag, ModelAnimationGraph jmad)
        {
            var groupName = info.StringIds.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, jmad);

            return context;
        }

        public static void Populate(CommandContext context, OpenTagCache info, TagInstance tag, ModelAnimationGraph jmad)
        {
            context.AddCommand(new AnimationCommand(info, tag, jmad));
        }
    }
}
