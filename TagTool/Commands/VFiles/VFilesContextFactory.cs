using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.VFiles
{
    static class VFilesContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, CachedTagInstance tag, VFilesList vfsl)
        {
            var groupName = info.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, CachedTagInstance tag, VFilesList vfsl)
        {
            context.AddCommand(new ListFilesCommand(vfsl));
            context.AddCommand(new ExtractFileCommand(vfsl));
            context.AddCommand(new ExtractFilesCommand(vfsl));
            context.AddCommand(new ReplaceFileCommand(info, tag, vfsl));
            context.AddCommand(new ReplaceAllFilesCommand(info, tag, vfsl));
        }
    }
}
