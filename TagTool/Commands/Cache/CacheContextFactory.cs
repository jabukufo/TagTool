using TagTool.Cache;
using TagTool.Cache.HaloOnline;

namespace TagTool.Commands.Cache
{
    static class CacheContextFactory
    {
        public static CommandContext Create(CommandContext parent, GameCacheContext info, CacheFileOld blamCache)
        {
            var context = new CommandContext(parent, blamCache.Build);
            context.AddCommand(new PortShaderCommand(info, blamCache));
            context.AddCommand(new PortModelCommand(info, blamCache));
            context.AddCommand(new ListBitmapsCommand(info, blamCache));
            context.AddCommand(new PortBspCommand(info, blamCache));
            return context;
        }
    }
}
