using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "armor", Class = "armr", Size = 0x28, MinVersion = CacheVersion.HaloOnline430475)]
    public class Armor : GameObject
    {
        public TagInstance ParentModel;
        public TagInstance FirstPersonModel;
        public TagInstance ThirdPersonModel;
        public uint Unused1;
    }
}
