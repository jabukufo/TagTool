using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.RenderModels
{
    class GetResourceInfoCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private RenderModel Definition { get; }

        public GetResourceInfoCommand(GameCacheContext cacheContext, TagInstance tag, RenderModel definition)
            : base(CommandFlags.None,

                  "get-resource-info",
                  "Gets information about the render_model's resource.",

                  "get-resource-info",

                  "Gets information about the render_model's resource.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;

            Console.WriteLine();
            Console.WriteLine($"[Location: {Definition.Geometry.Resource.GetLocation()}, Index: {Definition.Geometry.Resource.Index}, Compressed Size: {Definition.Geometry.Resource.CompressedSize}]");

            return true;
        }
    }
}
