using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;

namespace TagTool.Commands.Tags
{
    class ImportTagCommand : Command
    {
        private GameCacheContext CacheContext { get; }

        public ImportTagCommand(GameCacheContext cacheContext)
            : base(CommandFlags.None,

                  "ImportTag",
                  "",

                  "ImportTag <index> <path>",

                  "")
        {
            CacheContext = cacheContext;
        }

        private void ImportTagInstance(CachedTagInstance instance, string path)
        {
            byte[] data;

            using (var inStream = File.OpenRead(path))
            {
                data = new byte[inStream.Length];
                inStream.Read(data, 0, data.Length);
            }

            using (var stream = CacheContext.OpenTagCacheReadWrite())
                CacheContext.TagCache.SetTagDataRaw(stream, instance, data);

            Console.WriteLine($"Imported 0x{data.Length:X} bytes.");
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 2)
                return false;

            var instance = ArgumentParser.ParseTagIndex(CacheContext, args[0]);

            if (instance == null)
                return false;

            var path = args[1];

            ImportTagInstance(instance, path);

            return true;
        }
    }
}
