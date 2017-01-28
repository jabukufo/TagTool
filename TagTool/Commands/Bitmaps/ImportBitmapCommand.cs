using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TagTool.Bitmaps;
using TagTool.Serialization;
using TagTool.TagDefinitions;
using TagTool.Cache;

namespace TagTool.Commands.Bitmaps
{
    class ImportBitmapCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private Bitmap Bitmap { get; }

        public ImportBitmapCommand(GameCacheContext cacheContext, TagInstance tag, Bitmap bitmap)
            : base(CommandFlags.None,

                  "ImportBitmap",
                  "Imports an image from a DDS file.",

                  "ImportBitmap <image index> <dds file>",

                  "The image index must be in hexadecimal.\n" +
                  "No conversion will be done on the data in the DDS file.\n" +
                  "The pixel format must be supported by the game.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Bitmap = bitmap;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 2)
                return false;

            int imageIndex;
            if (!int.TryParse(args[0], NumberStyles.HexNumber, null, out imageIndex))
                return false;

            if (imageIndex < 0 || imageIndex >= Bitmap.Images.Count)
            {
                Console.Error.WriteLine("Invalid image index.");
                return true;
            }

            var imagePath = args[1];

            Console.WriteLine("Loading resource caches...");
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

            Console.WriteLine("Importing image data...");

            try
            {
                using (var imageStream = File.OpenRead(imagePath))
                {
                    var injector = new BitmapDdsInjector(resourceManager);
                    injector.InjectDds(CacheContext.Serializer, CacheContext.Deserializer, Bitmap, imageIndex, imageStream);
                }

                using (var tagsStream = CacheContext.OpenTagCacheReadWrite())
                {
                    var tagContext = new TagSerializationContext(tagsStream, CacheContext, Tag);
                    CacheContext.Serializer.Serialize(tagContext, Bitmap);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Importing image data failed: " + ex.Message);
                return true;
            }

            Console.WriteLine("Done!");

            return true;
        }
    }
}
