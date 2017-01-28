using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Unicode
{
    static class UnicodeContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, TagInstance tag, MultilingualUnicodeStringList unic)
        {
            var groupName = info.StringIdCache.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, unic);

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, TagInstance tag, MultilingualUnicodeStringList unic)
        {
            if (info.StringIdCache == null)
                return;

            context.AddCommand(new ListStringsCommand(info, unic));
            context.AddCommand(new GetStringCommand(info, tag, unic));
            context.AddCommand(new SetStringCommand(info, tag, unic));
        }
    }
}
