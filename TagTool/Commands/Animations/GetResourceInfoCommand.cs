﻿using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Animations
{
    class GetResourceInfoCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private CachedTagInstance Tag { get; }
        private ModelAnimationGraph Definition { get; }

        public GetResourceInfoCommand(GameCacheContext cacheContext, CachedTagInstance tag, ModelAnimationGraph definition)
            : base(CommandFlags.None,

                  "GetResourceInfo",
                  "Gets information about a model_animation_graph's resources.",

                  "GetResourceInfo",

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
