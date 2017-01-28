using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "gui_widget_animation_definition", Class = "wgan", Size = 0x80)]
    public class GuiWidgetAnimationDefinition
    {
        public uint Unknown;
        public uint Unknown2;
        public CachedTagInstance WidgetColor;
        public CachedTagInstance WidgetPosition;
        public CachedTagInstance WidgetRotation;
        public CachedTagInstance WidgetScale;
        public CachedTagInstance WidgetTextureCoordinate;
        public CachedTagInstance WidgetSprite;
        public CachedTagInstance WidgetFont;
        public uint Unknown3;
        public uint Unknown4;
    }
}
