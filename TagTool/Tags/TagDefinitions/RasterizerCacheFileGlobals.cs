using TagTool.Serialization;

namespace TagTool.Tags.TagDefinitions
{
    [TagStructure(Name = "rasterizer_cache_file_globals", Class = "draw", Size = 0x10)]
    public class RasterizerCacheFileGlobals
    {
        public uint Unknown;
        public uint Unknown2;
        public uint Unknown3;
        public uint Unknown4;
    }
}
