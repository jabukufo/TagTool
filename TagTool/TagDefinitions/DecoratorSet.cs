using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "decorator_set", Class = "dctr", Size = 0x80)]
    public class DecoratorSet
    {
        public CachedTagInstance Model;
        public uint Unknown;
        public uint Unknown2;
        public uint Unknown3;
        public int Unknown4;
        public CachedTagInstance Texture;
        public short AffectsVisibility;
        public short Unknown5;
        public float ColorR;
        public float ColorG;
        public float ColorB;
        public uint Unknown6;
        public uint Unknown7;
        public uint Unknown8;
        public uint Unknown9;
        public uint Unknown10;
        public float BrightnessBase;
        public float BrightnessShadow;
        public uint Unknown11;
        public uint Unknown12;
        public float Unknown13;
        public float Unknown14;
        public float Unknown15;
        public float Unknown16;
        public uint Unknown17;
        public uint Unknown18;
        public uint Unknown19;
    }
}
