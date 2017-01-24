using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Tags.Definitions
{
    [TagStructure(Name = "gui_text_widget_definition", Class = "txt3", Size = 0x40)]
    public class GuiTextWidgetDefinition
    {
        public uint Flags;
        public StringID Name;
        public short Unknown;
        public short Layer;
        public short WidescreenYBoundsMin;
        public short WidescreenXBoundsMin;
        public short WidescreenYBoundsMax;
        public short WidescreenXBoundsMax;
        public short StandardYBoundsMin;
        public short StandardXBoundsMin;
        public short StandardYBoundsMax;
        public short StandardXBoundsMax;
        public TagInstance Animation;
        public StringID DataSourceName;
        public StringID TextString;
        public StringID TextColor;
        public short TextFont;
        public short Unknown2;
        public uint Unknown3;
    }
}
