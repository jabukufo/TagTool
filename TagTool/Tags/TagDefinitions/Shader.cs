using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Tags.TagDefinitions
{
    [TagStructure(Name = "shader", Class = "rmsh", Size = 0x4)]
    public class Shader : RenderMethod
    {
        public StringID Material;
    }
}
