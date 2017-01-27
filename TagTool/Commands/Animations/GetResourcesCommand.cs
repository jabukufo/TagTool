using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Animations
{
    class GetResourcesCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private ModelAnimationGraph Definition { get; }

        public GetResourcesCommand(GameCacheContext cacheContext, TagInstance tag, ModelAnimationGraph definition)
            : base(CommandFlags.None,

                  "get-resource-info",
                  "Gets information about a model_animation_graph's resources.",

                  "get-resource-info",

                  "Gets information about a model_animation_graph's resources.")
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

            foreach (var resourceGroup in Definition.ResourceGroups)
            {
                Console.WriteLine($"{Definition.ResourceGroups.IndexOf(resourceGroup)}: [Location: {resourceGroup.Resource.GetLocation()}, Index: 0x{resourceGroup.Resource.Index:X}, Compressed Size: 0x{resourceGroup.Resource.CompressedSize:X}]");
            }

            return true;
        }
    }
}
