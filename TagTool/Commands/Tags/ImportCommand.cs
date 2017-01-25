using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache.HaloOnline;
using TagTool.Tags;

namespace TagTool.Commands.Tags
{
    class ImportCommand : Command
    {
        private GameCacheContext Info { get; }

        public ImportCommand(GameCacheContext info)
            : base(CommandFlags.None,
                  "import",
                  "",
                  "import [all] <index> <path>",
                  "")
        {
            Info = info;
        }

        private void ImportTagInstance(TagInstance instance, string path)
        {
            byte[] data;

            using (var inStream = File.OpenRead(path))
            {
                data = new byte[inStream.Length];
                inStream.Read(data, 0, data.Length);
            }

            using (var stream = Info.OpenCacheReadWrite())
                Info.TagCache.SetTagDataRaw(stream, instance, data);

            Console.WriteLine($"Imported 0x{data.Length:X} bytes.");
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count < 2 || args.Count > 3)
                return false;

            if (args.Count == 3)
            {
                if (args[0] != "all")
                    return false;

                var groupTag = ArgumentParser.ParseGroupTag(Info.StringIdCache, args[1]);
                var path = args[2];

                foreach (var instance in Info.TagCache.Tags.FindAllInGroup(groupTag))
                {
                    if (instance == null)
                        continue;

                    ImportTagInstance(instance, Path.Combine(path, $"0x{instance.Index:X}.{groupTag}"));
                }
            }
            else
            {
                var instance = ArgumentParser.ParseTagIndex(Info, args[0]);

                if (instance == null)
                    return false;

                var path = args[1];

                ImportTagInstance(instance, path);
            }

            return true;
        }
    }
}
