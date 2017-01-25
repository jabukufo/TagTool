using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache.HaloOnline;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.RenderMethods
{
    class ListBitmapsCommand : Command
    {
        private GameCacheContext Info { get; }
        private TagInstance Tag { get; }
        private RenderMethod Definition { get; }

        public ListBitmapsCommand(GameCacheContext info, TagInstance tag, RenderMethod definition)
            : base(CommandFlags.Inherit,
                 "listbitmaps",
                 "Lists the bitmaps used by the render_method.",
                 "listbitmaps",
                 "Lists the bitmaps used by the render_method.")
        {
            Info = info;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;

            foreach (var property in Definition.ShaderProperties)
            {
                RenderMethodTemplate template = null;

                using (var cacheStream = Info.TagCacheFile.Open(FileMode.Open, FileAccess.Read))
                {
                    var context = new TagSerializationContext(cacheStream, Info, property.Template);
                    template = Info.Deserializer.Deserialize<RenderMethodTemplate>(context);
                }

                for (var i = 0; i < template.ShaderMaps.Count; i++)
                {
                    var mapTemplate = template.ShaderMaps[i];

                    Console.WriteLine($"Bitmap {i} ({Info.StringIdCache.GetString(mapTemplate.Name)}): {property.ShaderMaps[i].Bitmap.Group.Tag} 0x{property.ShaderMaps[i].Bitmap.Index:X4}");
                }
            }

            return true;
        }
    }
}
