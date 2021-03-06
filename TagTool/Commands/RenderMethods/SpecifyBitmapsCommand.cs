﻿using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.TagDefinitions;

namespace TagTool.Commands.RenderMethods
{
    class SpecifyBitmapsCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private CachedTagInstance Tag { get; }
        private RenderMethod Definition { get; }

        public SpecifyBitmapsCommand(GameCacheContext cacheContext, CachedTagInstance tag, RenderMethod definition)
            : base(CommandFlags.Inherit,

                 "SpecifyBitmaps",
                 "Allows the bitmaps of the render_method to be respecified.",

                 "SpecifyBitmaps",

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
            
            var shaderMaps = new Dictionary<StringId, CachedTagInstance>();

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

                    Console.Write(string.Format("Please enter the {0} index: ", CacheContext.GetString(mapTemplate.Name)));
                    shaderMaps[mapTemplate.Name] = ArgumentParser.ParseTagSpecifier(CacheContext, Console.ReadLine());
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
