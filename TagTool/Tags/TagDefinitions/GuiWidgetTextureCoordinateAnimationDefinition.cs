using System.Collections.Generic;
using TagTool.Serialization;

namespace TagTool.Tags.TagDefinitions
{
    [TagStructure(Name = "gui_widget_texture_coordinate_animation_definition", Class = "wtuv", Size = 0x2C)]
    public class GuiWidgetTextureCoordinateAnimationDefinition
    {
        public uint AnimationFlags;
        public List<AnimationDefinitionBlock> AnimationDefinition;
        public byte[] Data;
        public uint Unknown;
        public uint Unknown2;

        [TagStructure(Size = 0x18)]
        public class AnimationDefinitionBlock
        {
            public uint Frame;
            public float CoordinateX;
            public float CoordinateY;
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
        }
    }
}
