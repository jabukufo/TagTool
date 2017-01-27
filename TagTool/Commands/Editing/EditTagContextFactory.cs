using TagTool.Commands.Bitmaps;
using TagTool.Commands.Models;
using TagTool.Commands.RenderModels;
using TagTool.Commands.RenderMethods;
using TagTool.Commands.Scenarios;
using TagTool.Commands.Unicode;
using TagTool.Commands.VFiles;
using TagTool.Serialization;
using TagTool.Tags.Definitions;
using TagTool.Tags;
using TagTool.Commands.Animations;
using TagTool.Commands.BSPs;
using TagTool.Cache;
using System.Reflection;
using System.IO;
using System.Xml;

namespace TagTool.Commands.Editing
{
    static class EditTagContextFactory
    {
        public static XmlDocument Documentation { get; } = new XmlDocument();

        public static CommandContext Create(CommandContextStack contextStack, GameCacheContext cacheContext, TagInstance tag)
        {
            var documentationPath = Assembly.GetExecutingAssembly().Location;
            documentationPath = $"{documentationPath.Substring(0, documentationPath.Length - 4)}.xml";

            if (Documentation.ChildNodes.Count == 0 && File.Exists(documentationPath))
                Documentation.Load(documentationPath);

            var groupName = cacheContext.StringIdCache.GetString(tag.Group.Name);

            var tagName = $"0x{tag.Index:X4}";

            if (cacheContext.TagNames.ContainsKey(tag.Index))
            {
                tagName = cacheContext.TagNames[tag.Index];
                tagName = $"(0x{tag.Index:X4}) {tagName.Substring(tagName.LastIndexOf('\\') + 1)}";
            }

            var commandContext = new CommandContext(contextStack.Context, string.Format("{0}.{1}", tagName, groupName));

            object value = null;

            using (var stream = cacheContext.OpenTagCacheRead())
                value = cacheContext.Deserializer.Deserialize(new TagSerializationContext(stream, cacheContext, tag), TagStructureTypes.FindByGroupTag(tag.Group.Tag));

            switch (tag.Group.Tag.ToString())
            {
                case "vfsl": // vfiles_list
                    VFilesContextFactory.Populate(commandContext, cacheContext, tag, (VFilesList)value);
                    break;

                case "unic": // multilingual_unicode_string_list
                    UnicodeContextFactory.Populate(commandContext, cacheContext, tag, (MultilingualUnicodeStringList)value);
                    break;

                case "bitm": // bitmap
                    BitmapContextFactory.Populate(commandContext, cacheContext, tag, (Bitmap)value);
                    break;

                case "hlmt": // model
                    ModelContextFactory.Populate(commandContext, cacheContext, tag, (Model)value);
                    break;

                case "mode": // render_model
                    RenderModelContextFactory.Populate(commandContext, cacheContext, tag, (RenderModel)value);
                    break;

                case "jmad":
                    AnimationContextFactory.Populate(commandContext, cacheContext, tag, (ModelAnimationGraph)value);
                    break;

                case "rm  ": // render_method
                case "rmsh": // shader
                case "rmd ": // shader_decal
                case "rmfl": // shader_foliage
                case "rmhg": // shader_halogram
                case "rmss": // shader_screen
                case "rmtr": // shader_terrain
                case "rmw ": // shader_water
                case "rmzo": // shader_zonly
                case "rmcs": // shader_custom
                    RenderMethodContextFactory.Populate(commandContext, cacheContext, tag, (RenderMethod)value);
                    break;

                case "scnr":
                    ScnrContextFactory.Populate(commandContext, cacheContext, tag, (Scenario)value);
                    break;

                case "sbsp":
                    BSPContextFactory.Populate(commandContext, cacheContext, tag, (ScenarioStructureBsp)value);
                    break;
            }

            var structure = new TagStructureInfo(TagStructureTypes.FindByGroupTag(tag.Group.Tag));

            commandContext.AddCommand(new ListFieldsCommand(cacheContext, structure, value));
            commandContext.AddCommand(new SetFieldCommand(contextStack, cacheContext, tag, structure, value));
            commandContext.AddCommand(new EditBlockCommand(contextStack, cacheContext, tag, value));
            commandContext.AddCommand(new AddBlockElementsCommand(contextStack, cacheContext, tag, structure, value));
            commandContext.AddCommand(new RemoveBlockElementsCommand(contextStack, cacheContext, tag, structure, value));
            commandContext.AddCommand(new CopyBlockElementsCommand(contextStack, cacheContext, tag, structure, value));
            commandContext.AddCommand(new PasteBlockElementsCommand(contextStack, cacheContext, tag, structure, value));
            commandContext.AddCommand(new SaveTagChangesCommand(cacheContext, tag, value));
            commandContext.AddCommand(new ExecuteCommand(cacheContext, tag, value));
            commandContext.AddCommand(new ExitToCommand(contextStack));

            return commandContext;
        }
    }
}
