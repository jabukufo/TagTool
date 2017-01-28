using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "rasterizer_globals", Class = "rasg", Size = 0xBC)]
    public class RasterizerGlobals
    {
        public List<DefaultBitmap> DefaultBitmaps;
        public List<DefaultRasterizerBitmap> DefaultRasterizerBitmaps;
        public CachedTagInstance VertexShaderSimple;
        public CachedTagInstance PixelShaderSimple;
        public List<DefaultShader> DefaultShaders;
        public uint Unknown;
        public uint Unknown2;
        public uint Unknown3;
        public int Unknown4;
        public int Unknown5;
        public CachedTagInstance ActiveCamoDistortion;
        public CachedTagInstance DefaultPerformanceTemplate;
        public CachedTagInstance DefaultShieldImpact;
        public CachedTagInstance DefaultVisionMode;
        public int Unknown6;
        public float Unknown7;
        public float Unknown8;
        public float Unknown9;
        public float Unknown10;
        public float Unknown11;
        public float Unknown12;
        public uint Unknown13;
        public uint Unknown14;

        [TagStructure(Size = 0x14)]
        public class DefaultBitmap
        {
            public int Unknown;
            public CachedTagInstance Bitmap;
        }

        [TagStructure(Size = 0x10)]
        public class DefaultRasterizerBitmap
        {
            public CachedTagInstance Bitmap;
        }

        [TagStructure(Size = 0x20)]
        public class DefaultShader
        {
            public CachedTagInstance VertexShader;
            public CachedTagInstance PixelShader;
        }
    }
}
