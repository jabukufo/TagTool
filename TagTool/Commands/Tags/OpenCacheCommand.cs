using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Commands.Cache;
using TagTool.Cache.HaloOnline;

namespace TagTool.Commands.Tags
{
    class OpenCacheCommand : Command
    {
        private CommandContextStack ContextStack { get; }
        private GameCacheContext CacheContext { get; }

        public OpenCacheCommand(CommandContextStack contextStack, GameCacheContext cacheContext)
            : base(CommandFlags.Inherit,

                  "open-map-file",
                  "Opens a .map cache file format for data comparison and tag porting.",

                  "open-map-file <path>",

                  "Opens a .map cache file format for data comparison and tag porting.")
        {
            ContextStack = contextStack;
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1)
                return false;

            var mapFilePath = args[0];

            if (!File.Exists(mapFilePath))
            {
                Console.WriteLine("Map file does not exist: " + mapFilePath);
                return false;
            }

            var cacheFile = new CacheFile(new FileInfo(mapFilePath));

            ContextStack.Push(CacheContextFactory.Create(ContextStack.Context, CacheContext, CacheManager.GetCache(mapFilePath)));

            return true;
        }
    }
}
