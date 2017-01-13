﻿using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Unicode
{
    static class UnicodeContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, TagInstance tag, MultilingualUnicodeStringList unic)
        {
            var groupName = info.StringIDs.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, unic);

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, TagInstance tag, MultilingualUnicodeStringList unic)
        {
            if (info.StringIDs == null)
                return;

            context.AddCommand(new ListCommand(info, unic));
            context.AddCommand(new GetCommand(info, tag, unic));
            context.AddCommand(new SetCommand(info, tag, unic));
        }
    }
}
