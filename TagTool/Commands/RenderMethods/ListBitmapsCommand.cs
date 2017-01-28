using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Serialization;
using TagTool.TagDefinitions;

namespace TagTool.Commands.RenderMethods
{
    class ListBitmapsCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private RenderMethod Definition { get; }

        public ListBitmapsCommand(GameCacheContext cacheContext, TagInstance tag, RenderMethod definition)
            : base(CommandFlags.Inherit,

                 "ListBitmaps",
                 "Lists the bitmaps used by the render_method.",

                 "ListBitmaps",

                 "Lists the bitmaps used by the render_method.")
        {
            CacheContext = cacheContext;
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

                using (var cacheStream = CacheContext.TagCacheFile.Open(FileMode.Open, FileAccess.Read))
                {
                    var context = new TagSerializationContext(cacheStream, CacheContext, property.Template);
                    template = CacheContext.Deserializer.Deserialize<RenderMethodTemplate>(context);
                }

                for (var i = 0; i < template.ShaderMaps.Count; i++)
                {
                    var mapTemplate = template.ShaderMaps[i];

                    Console.WriteLine($"Bitmap {i} ({CacheContext.StringIdCache.GetString(mapTemplate.Name)}): {property.ShaderMaps[i].Bitmap.Group.Tag} 0x{property.ShaderMaps[i].Bitmap.Index:X4}");
                }
            }

            return true;
        }
    }
}
