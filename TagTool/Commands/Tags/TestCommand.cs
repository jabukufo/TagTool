using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Common;
using TagTool.Tags;

namespace TagTool.Commands.Tags
{
    class TestCommand : Command
    {
        public GameCacheContext Info { get; }

        public TestCommand(GameCacheContext info)
            : base(CommandFlags.Inherit, "test", "", "test", "")
        {
            Info = info;
        }
        
        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;

            var groups = new Dictionary<Tag, TagGroup>();

            using (var stream = File.Create("groups.txt"))
            using (var writer = new StreamWriter(stream))
            {
                foreach (var t in Info.Cache.Tags)
                {
                    if (t == null)
                        continue;

                    if (!groups.ContainsKey(t.Group.Tag))
                        groups[t.Group.Tag] = t.Group;
                }

                foreach (var entry in groups)
                {
                    var group = entry.Value;

                    writer.WriteLine($"{group.Tag} | {group.ParentTag} | {group.GrandparentTag}");
                }
            }

            return true;
        }
    }
}
