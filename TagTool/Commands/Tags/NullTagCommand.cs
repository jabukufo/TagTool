﻿using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using static TagTool.Commands.ArgumentParser;

namespace TagTool.Commands.Tags
{
    class NullTagCommand : Command
    {
        public GameCacheContext Info { get; }

        public NullTagCommand(GameCacheContext info)
            : base(CommandFlags.None,
                  "nulltag",
                  "Nulls a tag in the current tag cache.",
                  "nulltag <tag index>",
                  "Nulls a tag in the current tag index. The tag's data will be removed from cache.")
        {
            Info = info;
        }

        private void LoadTagDependencies(int index, ref HashSet<int> tags)
        {
            var queue = new List<int> { index };

            while (queue.Count != 0)
            {
                var nextQueue = new List<int>();

                foreach (var entry in queue)
                {
                    if (!tags.Contains(entry))
                    {
                        if (Info.Cache.Tags[entry] == null)
                            continue;

                        tags.Add(entry);

                        foreach (var dependency in Info.Cache.Tags[entry].Dependencies)
                            if (!nextQueue.Contains(dependency))
                                nextQueue.Add(dependency);
                    }
                }

                queue = nextQueue;
            }
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1)
                return false;

            var instance = ParseTagIndex(Info, args[0]);

            if (instance == null)
            {
                Console.WriteLine($"ERROR: invalid tag index specified: {args[0]}");
                return false;
            }

            var dependencies = new HashSet<int>();
            LoadTagDependencies(instance.Index, ref dependencies);
            
            foreach (var index in dependencies)
            {
                var tag = Info.Cache.Tags[index];

                if (tag == null)
                    continue;

                Console.Write($"Nulling {Info.StringIDs.GetString(tag.Group.Name)} tag 0x{tag.Index:X4}...");

                using (var stream = Info.OpenCacheReadWrite())
                {
                    Info.Cache.SetTagDataRaw(stream, tag, new byte[] { });
                    Info.Cache.Tags[tag.Index] = null;

                    using (var writer = new BinaryWriter(stream))
                        Info.Cache.UpdateTagOffsets(writer);
                }

                Console.WriteLine("done.");
            }

            return true;
        }

    }
}
