﻿using TagTool.Cache.HaloOnline;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Scenarios
{
    static class ScnrContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, TagInstance tag, Scenario scenario)
        {
            var groupName = info.StringIDs.GetString(tag.Group.Name);

            var context = new CommandContext(parent,
                string.Format("{0:X8}.{1}", tag.Index, groupName));

            Populate(context, info, tag, scenario);

            return context;
        }

        public static void Populate(CommandContext context, GameCacheContext info, TagInstance tag, Scenario scenario)
        {
            context.AddCommand(new CopyForgePaletteCommand(info, scenario));
        }
    }
}

