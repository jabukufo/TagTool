using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache.HaloOnline;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.RenderMethods
{
    class SpecifyBitmapsCommand : Command
    {
        private GameCacheContext Info { get; }
        private TagInstance Tag { get; }
        private RenderMethod Definition { get; }

        public SpecifyBitmapsCommand(GameCacheContext info, TagInstance tag, RenderMethod definition)
            : base(CommandFlags.Inherit,
                 "specifybitmaps",
                 "Allows the bitmaps of the render_method to be respecified.",
                 "specifybitmaps",
                 "Allows the bitmaps of the render_method to be respecified.")
        {
            Info = info;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;
            
            var shaderMaps = new Dictionary<StringID, TagInstance>();

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

                    Console.Write(string.Format("Please enter the {0} index: ", Info.StringIdCache.GetString(mapTemplate.Name)));
                    shaderMaps[mapTemplate.Name] = ArgumentParser.ParseTagIndex(Info, Console.ReadLine());
                    property.ShaderMaps[i].Bitmap = shaderMaps[mapTemplate.Name];
                }
            }

            foreach (var import in Definition.ImportData)
                if (shaderMaps.ContainsKey(import.MaterialType))
                    import.Bitmap = shaderMaps[import.MaterialType];

            using (var cacheStream = Info.TagCacheFile.Open(FileMode.Open, FileAccess.ReadWrite))
            {
                var context = new TagSerializationContext(cacheStream, Info, Tag);
                Info.Serializer.Serialize(context, Definition);
            }

            Console.WriteLine("Done!");

            return true;
        }
    }
}
