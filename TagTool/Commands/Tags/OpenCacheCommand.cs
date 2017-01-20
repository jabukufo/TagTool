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
        private CommandContextStack Stack { get; }
        private GameCacheContext Info { get; }

        public OpenCacheCommand(CommandContextStack stack, GameCacheContext info)
            : base(CommandFlags.Inherit,
                  "opencache",
                  "Opens a cache file format comparison and porting",
                  "opencache <cache file>",
                  "Opens a cache file format comparison and porting")
        {
            Stack = stack;
            Info = info;
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

            Stack.Push(CacheContextFactory.Create(Stack.Context, Info, CacheManager.GetCache(mapFilePath)));

            return true;
        }
    }
}
