using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "shader_terrain", Class = "rmtr", Size = 0x1C)]
    public class ShaderTerrain : RenderMethod
    {
        public StringId Material1;
        public StringId Material2;
        public StringId Material3;
        public StringId Material4;
        public short GlobalMaterialIndex1;
        public short GlobalMaterialIndex2;
        public short GlobalMaterialIndex3;
        public short GlobalMaterialIndex4;
        public uint Unknown8;
    }
}
