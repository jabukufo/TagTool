using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Animations
{
    static class AnimationContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, CachedTagInstance tag, ModelAnimationGraph animation)
        {
            var groupName = info.StringIdCache.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, animation);

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, CachedTagInstance tag, ModelAnimationGraph animation)
        {
            context.AddCommand(new GetResourceInfoCommand(info, tag, animation));
            context.AddCommand(new AnimationTestCommand(info, tag, animation));
        }
    }
}
