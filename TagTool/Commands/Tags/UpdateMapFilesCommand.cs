using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Cache.HaloOnline;
using TagTool.Serialization;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Tags
{
    class UpdateMapFilesCommand : Command
    {
        public GameCacheContext CacheContext { get; }

        public UpdateMapFilesCommand(GameCacheContext cacheContext)
            : base(CommandFlags.Inherit,

                  "update-map-files",
                  "Updates the game's .map files to contain valid scenario tag indices.",

                  "update-map-files",

                  "Updates the game's .map files to contain valid scenario tag indices.")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;

            using (var cacheStream = CacheContext.OpenCacheRead())
            {
                foreach (var scnrTag in CacheContext.TagCache.Tags.FindAllInGroup("scnr"))
                {
                    var tagContext = new TagSerializationContext(cacheStream, CacheContext, scnrTag);
                    var scnr = CacheContext.Deserializer.Deserialize<Scenario>(tagContext);
                }
            }

            return true;
        }
    }
}
