using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Bitmaps
{
    static class BitmapContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, TagInstance tag, Bitmap bitmap)
        {
            var groupName = info.StringIDs.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, bitmap);

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, TagInstance tag, Bitmap bitmap)
        {
            context.AddCommand(new ImportCommand(info, tag, bitmap));
        }
    }
}
