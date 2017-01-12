using TagTool.GameDefinitions;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.Tags.TagDefinitions
{
    [TagStructure(Name = "bink", Class = "bink", Size = 0x18, MaxVersion = GameDefinitionSet.HaloOnline571627)]
    [TagStructure(Name = "bink", Class = "bink", Size = 0x14, MinVersion = GameDefinitionSet.HaloOnline700123)]
    public class Bink
    {
        public int FrameCount;
        public ResourceReference Resource;
        public int UselessPadding;
        public uint Unknown;
        public uint Unknown2;

        [MaxVersion(GameDefinitionSet.HaloOnline571627)]
        public uint Unknown3;
    }
}
