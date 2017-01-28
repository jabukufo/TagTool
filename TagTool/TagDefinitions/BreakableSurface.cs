using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "breakable_surface", Class = "bsdt", Size = 0x60)]
    public class BreakableSurface
    {
        public float MaximumVitality;
        public CachedTagInstance Effect;
        public CachedTagInstance Sound;
        public uint Unknown;
        public uint Unknown2;
        public uint Unknown3;
        public uint Unknown4;
        public CachedTagInstance CrackBitmap;
        public CachedTagInstance HoleBitmap;
        public uint Unknown5;
        public uint Unknown6;
        public uint Unknown7;
    }
}
