﻿using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache.HaloOnline;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.RenderModels
{
    class SpecifyShadersCommand : Command
    {
        private GameCacheContext Info { get; }
        private TagInstance Tag { get; }
        private RenderModel Definition { get; }

        public SpecifyShadersCommand(GameCacheContext info, TagInstance tag, RenderModel definition)
            : base(CommandFlags.Inherit,
                  "specifyshaders",
                  "Allows the shaders of a render_model to be respecified.",
                  "specifyshaders",
                  "Allows the shaders of a render_model to be respecified.")
        {
            Info = info;
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

                material.RenderMethod = ArgumentParser.ParseTagIndex(Info, Console.ReadLine());
            }

            using (var cacheStream = Info.CacheFile.Open(FileMode.Open, FileAccess.ReadWrite))
            {
                var context = new TagSerializationContext(cacheStream, Info, Tag);
                Info.Serializer.Serialize(context, Definition);
            }

            Console.WriteLine("Done!");

            return true;
        }
    }
}
