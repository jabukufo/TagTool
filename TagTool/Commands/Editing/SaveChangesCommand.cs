using System;
using System.Collections.Generic;
using TagTool.Cache.HaloOnline;
using TagTool.Serialization;
using TagTool.Tags;

namespace TagTool.Commands.Editing
{
    class SaveChangesCommand : Command
    {
        private GameCacheContext Info { get; }
        private TagInstance Tag { get; }
        private object Value { get; }

        public SaveChangesCommand(GameCacheContext info, TagInstance tag, object value)
            : base(CommandFlags.Inherit,
                  "savechanges",
                  $"Saves changes made to the current {info.StringIDs.GetString(tag.Group.Name)} definition.",
                  "savechanges",
                  $"Saves changes made to the current {info.StringIDs.GetString(tag.Group.Name)} definition.")
        {
            Info = info;
            Tag = tag;
            Value = value;
        }

        public override bool Execute(List<string> args)
        {
            using (var stream = Info.OpenCacheReadWrite())
            {
                var context = new TagSerializationContext(stream, Info, Tag);
                Info.Serializer.Serialize(context, Value);
            }

            Console.WriteLine("Done!");

            return true;
        }
    }
}
