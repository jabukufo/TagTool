using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.RenderMethods
{
    class SpecifyBitmapsCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private RenderMethod Definition { get; }

        public SpecifyBitmapsCommand(GameCacheContext cacheContext, TagInstance tag, RenderMethod definition)
            : base(CommandFlags.Inherit,

                 "specify-bitmaps",
                 "Allows the bitmaps of the render_method to be respecified.",

                 "specify-bitmaps",

                 "Allows the bitmaps of the render_method to be respecified.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;
            
            var shaderMaps = new Dictionary<StringId, TagInstance>();

            foreach (var property in Definition.ShaderProperties)
            {
                RenderMethodTemplate template = null;

                using (var cacheStream = CacheContext.OpenTagCacheRead())
                {
                    var context = new TagSerializationContext(cacheStream, CacheContext, property.Template);
                    template = CacheContext.Deserializer.Deserialize<RenderMethodTemplate>(context);
                }

                for (var i = 0; i < template.ShaderMaps.Count; i++)
                {
                    var mapTemplate = template.ShaderMaps[i];

                    Console.Write(string.Format("Please enter the {0} index: ", CacheContext.StringIdCache.GetString(mapTemplate.Name)));
                    shaderMaps[mapTemplate.Name] = ArgumentParser.ParseTagIndex(CacheContext, Console.ReadLine());
                    property.ShaderMaps[i].Bitmap = shaderMaps[mapTemplate.Name];
                }
            }

            foreach (var import in Definition.ImportData)
                if (shaderMaps.ContainsKey(import.MaterialType))
                    import.Bitmap = shaderMaps[import.MaterialType];

            using (var cacheStream = CacheContext.OpenTagCacheReadWrite())
            {
                var context = new TagSerializationContext(cacheStream, CacheContext, Tag);
                CacheContext.Serializer.Serialize(context, Definition);
            }

            Console.WriteLine("Done!");

            return true;
        }
    }
}
