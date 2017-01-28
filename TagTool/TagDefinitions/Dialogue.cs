using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "dialogue", Class = "udlg", Size = 0x30)]
    public class Dialogue
    {
        public CachedTagInstance GlobalDialogueInfo;
        public uint Flags;
        public List<Vocalization> Vocalizations;
        public StringId MissionDialogueDesignator;
        public uint Unknown;
        public uint Unknown2;
        public uint Unknown3;

        [TagStructure(Size = 0x18)]
        public class Vocalization
        {
            public ushort Flags;
            public short Unknown;
            public StringId Vocalization2;
            public CachedTagInstance Sound;
        }
    }
}
