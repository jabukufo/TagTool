using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Tags.TagDefinitions
{
    [TagStructure(Name = "shader_custom", Class = "rmcs", Size = 0x4)]
    public class ShaderCustom : RenderMethod
    {
        public StringID Material;
    }
}
