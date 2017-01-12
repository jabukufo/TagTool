using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Tags.TagDefinitions
{
    [TagStructure(Name = "shader_foliage", Class = "rmfl", Size = 0x4)]
    public class ShaderFoliage : RenderMethod
    {
        public StringID Material;
    }
}
