using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Bitmaps;
using TagTool.Cache;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Bitmaps
{
    class ExtractBitmapCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private Bitmap Bitmap { get; }

        public ExtractBitmapCommand(GameCacheContext cacheContext, TagInstance tag, Bitmap bitmap)
            : base(CommandFlags.None,

                  "extract-bitmap",
                  "Extracts a bitmap to a file.",

                  "extract-bitmap <output directory>",

                  "Extracts a bitmap to a file.")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1)
                return false;
            
            if (Tag == null)
                return false;

            var directory = args[1];

            if (!Directory.Exists(directory))
            {
                Console.Write("Destination directory does not exist. Create it? [y/n] ");
                var answer = Console.ReadLine().ToLower();

                if (answer.Length == 0 || !(answer.StartsWith("y") || answer.StartsWith("n")))
                    return false;

                if (answer.StartsWith("y"))
                    Directory.CreateDirectory(directory);
                else
                    return false;
            }

            Console.Write("Loading resource caches...");
            var resourceManager = new ResourceDataManager();

            try
            {
                resourceManager.LoadCachesFromDirectory(CacheContext.TagCacheFile.DirectoryName);
            }
            catch
            {
                Console.WriteLine("Unable to load the resource .dat files.");
                Console.WriteLine("Make sure that they all exist and are valid.");
                return true;
            }

            Console.WriteLine("done.");

            var extractor = new BitmapDdsExtractor(resourceManager);

            using (var tagsStream = CacheContext.OpenTagCacheRead())
            {
                try
                {
                    var tagContext = new TagSerializationContext(tagsStream, CacheContext, Tag);
                    var bitmap = CacheContext.Deserializer.Deserialize<Bitmap>(tagContext);
                    var ddsOutDir = directory;

                    if (bitmap.Images.Count > 1)
                    {
                        ddsOutDir = Path.Combine(directory, Tag.Index.ToString("X8"));
                        Directory.CreateDirectory(ddsOutDir);
                    }

                    for (var i = 0; i < bitmap.Images.Count; i++)
                    {
                        var outPath = Path.Combine(ddsOutDir, ((bitmap.Images.Count > 1) ? i.ToString() : Tag.Index.ToString("X8")) + ".dds");

                        using (var outStream = File.Open(outPath, FileMode.Create, FileAccess.Write))
                        {
                            extractor.ExtractDds(CacheContext.Deserializer, bitmap, i, outStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: Failed to extract bitmap: " + ex.Message);
                }
            }

            Console.WriteLine("Done!");

            return true;
        }
    }
}
