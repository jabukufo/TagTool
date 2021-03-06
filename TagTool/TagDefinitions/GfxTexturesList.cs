using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "gfx_textures_list", Class = "gfxt", Size = 0x10)]
    public class GfxTexturesList
    {
        public List<Texture> Textures;
        public uint Unknown;

        [TagStructure(Size = 0x110)]
        public class Texture
        {
            [TagField(Length = 256)] public string FileName;
            public CachedTagInstance Bitmap;
        }
    }
}
