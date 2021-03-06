﻿using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;

namespace TagTool.Commands.Tags
{
    class ExtractTagCommand : Command
    {
        private GameCacheContext CacheContext { get; }

        public ExtractTagCommand(GameCacheContext cacheContext)
            : base(CommandFlags.Inherit,

                  "ExtractTag",
                  "",

                  "ExtractTag [all] <index|group> <path>",

                  "")
        {
            CacheContext = cacheContext;
        }

        private void ExtractTagInstance(CachedTagInstance tag, string path)
        {
            var info = new FileInfo(path);

            if (!info.Directory.Exists)
                info.Directory.Create();

            byte[] data;

            using (var stream = CacheContext.OpenTagCacheRead())
                data = CacheContext.TagCache.ExtractTagRaw(stream, tag);

            using (var outStream = File.Open(path, FileMode.Create, FileAccess.Write))
            {
                outStream.Write(data, 0, data.Length);
                Console.WriteLine("Wrote 0x{0:X} bytes to {1}.", outStream.Position, path);
                Console.WriteLine("The tag's main struct will be at offset 0x{0:X}.", tag.MainStructOffset);
            }
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count < 2 || args.Count > 3)
                return false;
            
            if (args.Count == 3)
            {
                if (args[0] != "all")
                    return false;

                var groupTag = ArgumentParser.ParseGroupTag(CacheContext.StringIdCache, args[1]);
                var path = args[2];

                foreach (var instance in CacheContext.TagCache.Index.FindAllInGroup(groupTag))
                {
                    if (instance == null)
                        continue;

                    ExtractTagInstance(instance, Path.Combine(path, $"0x{instance.Index:X}.{groupTag}"));
                }
            }
            else
            {
                var instance = ArgumentParser.ParseTagSpecifier(CacheContext, args[0]);

                if (instance == null)
                    return false;

                var path = args[1];

                ExtractTagInstance(instance, Path.Combine(path, $"0x{instance.Index:X}.{instance.Group.Tag}"));
            }

            return true;
        }
    }
}
