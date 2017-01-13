using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Commands.Core;

namespace TagTool.Commands.Tags
{
    static class TagCacheContextFactory
    {
        public static CommandContext Create(CommandContextStack stack, GameCacheContext cacheContext)
        {
            var context = new CommandContext(null, cacheContext.CacheFile.Name);
            context.AddCommand(new HelpCommand(stack));
            context.AddCommand(new ClearCommand());
            context.AddCommand(new DumpLogCommand());
            context.AddCommand(new EchoCommand());
            context.AddCommand(new SetLocaleCommand());
            context.AddCommand(new ExecuteCommand(cacheContext));
            context.AddCommand(new DependencyCommand(cacheContext));
            context.AddCommand(new ExtractCommand(cacheContext));
            context.AddCommand(new ImportCommand(cacheContext));
            context.AddCommand(new InfoCommand(cacheContext));
            context.AddCommand(new ListCommand(cacheContext));
            context.AddCommand(new MapCommand());
            context.AddCommand(new DuplicateTagCommand(cacheContext));
            context.AddCommand(new AddressCommand());
            context.AddCommand(new ResourceCommand());
            context.AddCommand(new TestCommand(cacheContext));
            context.AddCommand(new NullTagCommand(cacheContext));
            context.AddCommand(new ListUnreferencedTagsCommand(cacheContext));
            context.AddCommand(new ListNullTagsCommand(cacheContext));
            context.AddCommand(new GenerateCacheCommand(cacheContext));
            context.AddCommand(new NewTagCommand(cacheContext));
            context.AddCommand(new ExportTagsCommand(cacheContext));

            if (cacheContext.StringIDs != null)
            {
                context.AddCommand(new EditCommand(stack, cacheContext));
                context.AddCommand(new ExtractBitmapCommand(cacheContext));
                context.AddCommand(new ExtractBitmapsCommand(cacheContext));
                context.AddCommand(new ImportBitmapCommand(cacheContext));
                context.AddCommand(new CollisionGeometryTestCommand(cacheContext));
                context.AddCommand(new PhysicsModelTestCommand(cacheContext));
                context.AddCommand(new StringIDCommand(cacheContext));
                context.AddCommand(new ListStringsCommand(cacheContext));
                context.AddCommand(new GenerateLayoutsCommand(cacheContext));
                context.AddCommand(new ModelTestCommand(cacheContext));
                context.AddCommand(new ConvertPluginsCommand(cacheContext));
                context.AddCommand(new GenerateTagNamesCommand(cacheContext));
                context.AddCommand(new OpenCacheCommand(stack, cacheContext));
                context.AddCommand(new MatchTagsCommand(cacheContext));
                context.AddCommand(new ConvertCommand(cacheContext));
                context.AddCommand(new ConvertArmorCommand(cacheContext));
            }
            return context;
        }
    }
}
