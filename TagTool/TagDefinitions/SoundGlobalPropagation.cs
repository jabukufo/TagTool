using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "sound_global_propagation", Class = "sgp!", Size = 0x50)]
    public class SoundGlobalPropagation
    {
        public CachedTagInstance UnderwaterEnvironment;
        public CachedTagInstance UnderwaterLoop;
        public uint Unknown;
        public uint Unknown2;
        public CachedTagInstance EnterUnderater;
        public CachedTagInstance ExitUnderwater;
        public uint Unknown3;
        public uint Unknown4;
    }
}
