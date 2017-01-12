using TagTool.GameDefinitions;
using TagTool.Serialization;
using TagTool.TagGroups;

namespace TagTool.Tags.TagDefinitions
{
    [TagStructure(Name = "armor", Class = "armr", Size = 0x28, MinVersion = GameDefinitionSet.HaloOnline430475)]
    public class Armor : GameObject
    {
        public TagInstance ParentModel;
        public TagInstance FirstPersonModel;
        public TagInstance ThirdPersonModel;
        public uint Unused1;
    }
}
