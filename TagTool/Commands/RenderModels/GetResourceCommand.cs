using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.RenderModels
{
    class GetResourceCommand : Command
    {
        private GameCacheContext Info { get; }
        private TagInstance Tag { get; }
        private RenderModel Definition { get; }

        public GetResourceCommand(GameCacheContext info, TagInstance tag, RenderModel definition)
            : base(CommandFlags.None,
                  "getresource",
                  "",
                  "getresource",
                  "")
        {
            Info = info;
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
