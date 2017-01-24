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
using TagTool.Cache.HaloOnline;

namespace TagTool.Commands.Editing
{
    static class EditTagContextFactory
    {
        public static CommandContext Create(CommandContextStack stack, GameCacheContext info, TagInstance tag)
        {
            var groupName = info.StringIDs.GetString(tag.Group.Name);

            var tagName = $"0x{tag.Index:X4}";

            if (info.TagNames.ContainsKey(tag.Index))
            {
                tagName = info.TagNames[tag.Index];
                tagName = $"(0x{tag.Index:X4}) {tagName.Substring(tagName.LastIndexOf('\\') + 1)}";
            }

            var context = new CommandContext(stack.Context,
                string.Format("{0}.{1}", tagName, groupName));

            object value = null;

            using (var stream = info.OpenCacheRead())
                value = info.Deserializer.Deserialize(
                    new TagSerializationContext(stream, info, tag),
                    TagStructureTypes.FindByGroupTag(tag.Group.Tag));

            switch (tag.Group.Tag.ToString())
            {
                case "vfsl": // vfiles_list
                    VFilesContextFactory.Populate(context, info, tag, (VFilesList)value);
                    break;

                case "unic": // multilingual_unicode_string_list
                    UnicodeContextFactory.Populate(context, info, tag, (MultilingualUnicodeStringList)value);
                    break;

                case "bitm": // bitmap
                    BitmapContextFactory.Populate(context, info, tag, (Bitmap)value);
                    break;

                case "hlmt": // model
                    ModelContextFactory.Populate(context, info, tag, (Model)value);
                    break;

                case "mode": // render_model
                    RenderModelContextFactory.Populate(context, info, tag, (RenderModel)value);
                    break;

                case "jmad":
                    AnimationContextFactory.Populate(context, info, tag, (ModelAnimationGraph)value);
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
                    RenderMethodContextFactory.Populate(context, info, tag, (RenderMethod)value);
                    break;

                case "scnr":
                    ScnrContextFactory.Populate(context, info, tag, (Scenario)value);
                    break;

                case "sbsp":
                    BSPContextFactory.Populate(context, info, tag, (ScenarioStructureBsp)value);
                    break;
            }

            var structure = new TagStructureInfo(
                TagStructureTypes.FindByGroupTag(tag.Group.Tag));

            context.AddCommand(new ListFieldsCommand(info, structure, value));
            context.AddCommand(new SetFieldCommand(stack, info, tag, structure, value));
            context.AddCommand(new EditBlockCommand(stack, info, tag, value));
            context.AddCommand(new AddToCommand(stack, info, tag, structure, value));
            context.AddCommand(new RemoveFromCommand(stack, info, tag, structure, value));
            context.AddCommand(new CopyElementsCommand(stack, info, tag, structure, value));
            context.AddCommand(new PasteElementsCommand(stack, info, tag, structure, value));
            context.AddCommand(new SaveChangesCommand(info, tag, value));
            context.AddCommand(new ExecuteCommand(info, tag, value));
            context.AddCommand(new ExitToCommand(stack));

            return context;
        }
    }
}
