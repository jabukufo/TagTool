using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Serialization;
using TagTool.TagDefinitions;

namespace TagTool.Commands.RenderModels
{
    class SpecifyShadersCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private RenderModel Definition { get; }

        public SpecifyShadersCommand(GameCacheContext cacheContext, TagInstance tag, RenderModel definition)
            : base(CommandFlags.Inherit,

                  "SpecifyShaders",
                  "Allows the shaders of a render_model to be respecified.",

                  "SpecifyShaders",

                  "Allows the shaders of a render_model to be respecified.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            foreach (var material in Definition.Materials)
            {
                if (material.RenderMethod != null)
                    Console.Write("Please enter the replacement {0:X8} index: ", material.RenderMethod.Index);
                else
                    Console.Write("Please enter the replace material #{0} index: ", Definition.Materials.IndexOf(material));

                material.RenderMethod = ArgumentParser.ParseTagIndex(CacheContext, Console.ReadLine());
            }

            using (var cacheStream = CacheContext.TagCacheFile.Open(FileMode.Open, FileAccess.ReadWrite))
            {
                var context = new TagSerializationContext(cacheStream, CacheContext, Tag);
                CacheContext.Serializer.Serialize(context, Definition);
            }

            Console.WriteLine("Done!");

            return true;
        }
    }
}
