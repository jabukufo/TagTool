using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Common;
using TagTool.Bitmaps;
using TagTool.Serialization;
using TagTool.Tags.Definitions;
using TagTool.Cache.HaloOnline;

namespace TagTool.Commands.Tags
{
    class ImportBitmapCommand : Command
    {
        private GameCacheContext Info { get; }

        public ImportBitmapCommand(GameCacheContext info) : base(
            CommandFlags.Inherit,

            "importbitmap",
            "Create a new bitmap tag from a DDS file",

            "importbitmap <tag> <dds file>",

            "The DDS file will be imported into textures.dat as a new resource.\n" +
            "Make sure to add the new bitmap tag as a dependency if you edit a shader!")
        {
            Info = info;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 2)
                return false;
                
            var tag = ArgumentParser.ParseTagIndex(Info, args[0]);
            var imagePath = args[1];

            Console.WriteLine("Loading textures.dat...");
            var resourceManager = new ResourceDataManager();
            resourceManager.LoadCacheFromDirectory(Info.CacheFile.DirectoryName, ResourceLocation.Textures);

            Console.WriteLine("Importing image...");
            var bitmap = new Bitmap
            {
                Flags = Bitmap.RuntimeFlags.UseResource,
                Sequences = new List<Bitmap.Sequence>
                {
                    new Bitmap.Sequence
                    {
                        FirstBitmapIndex = 0,
                        BitmapCount = 1
                    }
                },
                Images = new List<Bitmap.Image>
                {
                    new Bitmap.Image
                    {
                        Signature = new Tag("bitm").Value,
                        Unknown28 = -1,
                    }
                },
                Resources = new List<Bitmap.BitmapResource>
                {
                    new Bitmap.BitmapResource()
                }
            };
            using (var imageStream = File.OpenRead(imagePath))
            {
                var injector = new BitmapDdsInjector(resourceManager);
                injector.InjectDds(Info.Serializer, Info.Deserializer, bitmap, 0, imageStream);
            }

            Console.WriteLine("Creating a new tag...");

            using (var tagsStream = Info.OpenCacheReadWrite())
            {
                var tagContext = new TagSerializationContext(tagsStream, Info, tag);
                Info.Serializer.Serialize(tagContext, bitmap);
            }

            Console.WriteLine();
            Console.WriteLine("All done! The new bitmap tag is:");
            TagPrinter.PrintTagShort(tag);
            return true;
        }
    }
}
