using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "armor_sounds", Class = "arms", Size = 0x10)]
    public class ArmorSounds
    {
        public List<ArmorSound> ArmorSounds2;
        public uint Unknown;

        [TagStructure(Size = 0x24)]
        public class ArmorSound
        {
            public List<UnknownBlock> Unknown;
            public List<UnknownBlock2> Unknown2;
            public List<UnknownBlock3> Unknown3;

            [TagStructure(Size = 0x10)]
            public class UnknownBlock
            {
                public CachedTagInstance Unknown;
            }

            [TagStructure(Size = 0x10)]
            public class UnknownBlock2
            {
                public CachedTagInstance Unknown;
            }

            [TagStructure(Size = 0x10)]
            public class UnknownBlock3
            {
                public CachedTagInstance Unknown;
            }
        }
    }
}
