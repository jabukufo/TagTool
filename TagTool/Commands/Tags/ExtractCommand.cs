using System;
using System.Collections.Generic;
using System.IO;
using TagTool.TagGroups;

namespace TagTool.Commands.Tags
{
    class ExtractCommand : Command
    {
        private OpenTagCache Info { get; }

        public ExtractCommand(OpenTagCache info)
            : base(CommandFlags.Inherit,
                  "extract",
                  "",
                  "extract [all] <index|group> <path>",
                  "")
        {
            Info = info;
        }

        private void ExtractTagInstance(TagInstance tag, string path)
        {
            var info = new FileInfo(path);

            if (!info.Directory.Exists)
                info.Directory.Create();

            byte[] data;

            using (var stream = Info.OpenCacheRead())
                data = Info.Cache.ExtractTagRaw(stream, tag);

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

                var groupTag = ArgumentParser.ParseGroupTag(Info.StringIDs, args[1]);
                var path = args[2];

                foreach (var instance in Info.Cache.Tags.FindAllInGroup(groupTag))
                {
                    if (instance == null)
                        continue;

                    ExtractTagInstance(instance, Path.Combine(path, $"0x{instance.Index:X}.{groupTag}"));
                }
            }
            else
            {
                var instance = ArgumentParser.ParseTagIndex(Info, args[0]);

                if (instance == null)
                    return false;

                var path = args[1];

                ExtractTagInstance(instance, Path.Combine(path, $"0x{instance.Index:X}.{instance.Group.Tag}"));
            }

            return true;
        }
    }
}
