using TagTool.Cache.HaloOnline;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.RenderModels
{
    static class RenderModelContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, TagInstance tag, RenderModel renderModel)
        {
            var groupName = info.StringIdCache.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, renderModel);

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, TagInstance tag, RenderModel renderModel)
        {
            context.AddCommand(new SpecifyShadersCommand(info, tag, renderModel));
            context.AddCommand(new GetResourceCommand(info, tag, renderModel));
            context.AddCommand(new ReplaceCommand(info, tag, renderModel));
        }
    }
}
