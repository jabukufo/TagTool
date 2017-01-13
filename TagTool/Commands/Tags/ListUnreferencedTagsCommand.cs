using System;
using System.Collections.Generic;
using System.Linq;
using TagTool.Cache;
using TagTool.Cache.HaloOnline;

namespace TagTool.Commands.Tags
{
    class ListUnreferencedTagsCommand : Command
    {
        public GameCacheContext Info { get; }

        public ListUnreferencedTagsCommand(GameCacheContext info)
            : base(CommandFlags.None,
                  "listunreferencedtags",
                  "Lists all unreferenced tags in the current tag cache",
                  "listunreferencedtags",
                  "Lists all unreferenced tags in the current tag cache")
        {
            Info = info;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;

            foreach (var tag in Info.Cache.Tags)
            {
                if (tag == null)
                    continue;

                var dependsOn = Info.Cache.Tags.NonNull().Where(t => t.Dependencies.Contains(tag.Index));

                if (dependsOn.Count() == 0)
                {
                    Console.Write($"{Info.TagNames[tag.Index]} ");
                    TagPrinter.PrintTagShort(tag);
                }
            }

            return true;
        }
    }
}
