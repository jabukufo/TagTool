using TagTool.Cache.HaloOnline;
using TagTool.Commands.Core;

namespace TagTool.Commands.Tags
{
    static class TagCacheContextFactory
    {
        public static CommandContext Create(CommandContextStack stack, GameCacheContext cacheContext)
        {
            var context = new CommandContext(null, cacheContext.TagCacheFile.Name);

            context.AddCommand(new HelpCommand(stack));
            context.AddCommand(new ClearCommand());
            context.AddCommand(new DumpLogCommand());
            context.AddCommand(new EchoCommand());
            context.AddCommand(new SetLocaleCommand());
            context.AddCommand(new ExecuteCommand(cacheContext));
            context.AddCommand(new CleanCsvFileCommand(cacheContext));
            context.AddCommand(new TagDependencyCommand(cacheContext));
            context.AddCommand(new ExtractCommand(cacheContext));
            context.AddCommand(new ImportCommand(cacheContext));
            context.AddCommand(new InfoCommand(cacheContext));
            context.AddCommand(new ListCommand(cacheContext));
            context.AddCommand(new MapCommand());
            context.AddCommand(new DuplicateTagCommand(cacheContext));
            context.AddCommand(new GetTagAddressCommand());
            context.AddCommand(new ResourceCommand());
            context.AddCommand(new NullTagCommand(cacheContext));
            context.AddCommand(new CleanCacheFilesCommand(cacheContext));
            context.AddCommand(new ListUnreferencedTagsCommand(cacheContext));
            context.AddCommand(new ListNullTagsCommand(cacheContext));
            context.AddCommand(new NewTagCommand(cacheContext));
            context.AddCommand(new ExtractTagsCommand(cacheContext));

            if (cacheContext.StringIdCache != null)
            {
                context.AddCommand(new EditTagCommand(stack, cacheContext));
                context.AddCommand(new CollisionModelTestCommand(cacheContext));
                context.AddCommand(new PhysicsModelTestCommand(cacheContext));
                context.AddCommand(new StringIDCommand(cacheContext));
                context.AddCommand(new ListStringsCommand(cacheContext));
                context.AddCommand(new GenerateLayoutsCommand(cacheContext));
                context.AddCommand(new ModelTestCommand(cacheContext));
                context.AddCommand(new ConvertPluginsCommand(cacheContext));
                context.AddCommand(new GenerateTagNamesCommand(cacheContext));
                context.AddCommand(new OpenCacheCommand(stack, cacheContext));
                context.AddCommand(new MatchTagsCommand(cacheContext));
                context.AddCommand(new ConvertTagCommand(cacheContext));
                context.AddCommand(new UpdateMapFilesCommand(cacheContext));
            }

            return context;
        }
    }
}
