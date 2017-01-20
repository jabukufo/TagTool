using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Cache.HaloOnline;

namespace TagTool.Commands.Cache
{
    class ListBitmapsCommand : Command
    {
        private GameCacheContext Info { get; }
        private CacheFileOld BlamCache { get; }

        public ListBitmapsCommand(GameCacheContext info, CacheFileOld blamCache)
            : base(CommandFlags.None,
                  "listbitmaps",
                  "",
                  "listbitmaps <blam tag path>",
                  "")
        {
            Info = info;
            BlamCache = blamCache;
        }

        public override bool Execute(List<string> args)
        {
            throw new NotImplementedException();
            /*
            if (args.Count != 1)
                return false;

            CacheFile.IndexItem item = null;

            Console.WriteLine("Verifying blam shader tag...");

            var shaderName = args[0];

            foreach (var tag in BlamCache.IndexItems)
            {
                if ((tag.ParentClass == "rm") && tag.Filename == shaderName)
                {
                    item = tag;
                    break;
                }
            }

            if (item == null)
            {
                Console.WriteLine("Blam shader tag does not exist: " + shaderName);
                return false;
            }

            var renderMethod = DefinitionsManager.rmsh(BlamCache, item);

            var templateItem = BlamCache.IndexItems.Find(i =>
                i.ID == renderMethod.Properties[0].TemplateTagID);

            var template = DefinitionsManager.rmt2(BlamCache, templateItem);

            for (var i = 0; i < template.UsageBlocks.Count; i++)
            {
                var bitmItem = BlamCache.IndexItems.Find(j =>
                j.ID == renderMethod.Properties[0].ShaderMaps[i].BitmapTagID);
                Console.WriteLine(bitmItem);
            }

            return true;
            */
        }
    }
}
