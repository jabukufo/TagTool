using System.Collections.Generic;
using TagTool.Cache;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Models
{
    class PortGen3ModelCommand : Command
    {
        public GameCacheContext CacheContext { get; }
        public CachedTagInstance Tag { get; }
        public Model Definition { get; }

        public PortGen3ModelCommand(GameCacheContext cacheContext, CachedTagInstance tag, Model definition)
            : base(CommandFlags.Inherit,
                  
                  "PortGen3Model",
                  "Ports a model from a gen3 cache file.",
                  
                  "PortGen3Model <Gen3 Map File> <Gen3 Tag>",
                  
                  "Ports a model from a gen3 cache file.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 2)
                return false;

            return true;
        }
    }
}
