using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Serialization;
using TagTool.TagDefinitions;

namespace TagTool.Commands.VFiles
{
    class ReplaceAllFilesCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private CachedTagInstance Tag { get; }
        private VFilesList Definition { get; }

        public ReplaceAllFilesCommand(GameCacheContext cacheContext, CachedTagInstance tag, VFilesList definition)
            : base(CommandFlags.None,

                  "ReplaceAllFiles",
                  "Replace all files stored in the tag",

                  "ReplaceAllFiles [directory]",
                  "Replaces all file stored in the tag. The tag will be resized as necessary.\n" +
                  "If no directory is specified, files will be loaded from the current directory.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count > 1)
                return false;

            var baseDir = (args.Count == 1) ? args[0] : Directory.GetCurrentDirectory();
            var imported = 0;

            foreach (var file in Definition.Files)
            {
                var inputPath = Path.Combine(baseDir, file.Folder, file.Name);
                byte[] data;

                try
                {
                    data = File.ReadAllBytes(inputPath);
                }
                catch (IOException)
                {
                    Console.WriteLine("Unable to read from {0}!", inputPath);
                    continue;
                }

                Definition.Replace(file, data);
                imported++;
            }
            using (var stream = CacheContext.OpenTagCacheReadWrite())
                CacheContext.Serializer.Serialize(new TagSerializationContext(stream, CacheContext, Tag), Definition);

            Console.WriteLine("Imported {0} files.", imported);

            return true;
        }
    }
}
