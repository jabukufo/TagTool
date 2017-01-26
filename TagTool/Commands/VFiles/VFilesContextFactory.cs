using TagTool.Cache;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.VFiles
{
    static class VFilesContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, TagInstance tag, VFilesList vfsl)
        {
            var groupName = info.StringIdCache.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, TagInstance tag, VFilesList vfsl)
        {
            context.AddCommand(new ListCommand(vfsl));
            context.AddCommand(new ExtractFileCommand(vfsl));
            context.AddCommand(new ExtractFilesCommand(vfsl));
            context.AddCommand(new ImportFileCommand(info, tag, vfsl));
            context.AddCommand(new ImportFilesCommand(info, tag, vfsl));
        }
    }
}
