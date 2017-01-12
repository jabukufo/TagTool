using System.Collections.Generic;
using TagTool.GameDefinitions;
using TagTool.Serialization;
using TagTool.TagGroups;

namespace TagTool.Tags.TagDefinitions
{
    [TagStructure(Name = "user_interface_globals_definition", Class = "wgtz", Size = 0x50, MaxVersion = GameDefinitionSet.HaloOnline449175)]
    [TagStructure(Name = "user_interface_globals_definition", Class = "wgtz", Size = 0x60, MinVersion = GameDefinitionSet.HaloOnline498295)]
    public class UserInterfaceGlobalsDefinition
    {
        public TagInstance SharedUiGlobals;
        public TagInstance EditableSettings;
        public TagInstance MatchmakingHopperStrings;
        public List<ScreenWidget> ScreenWidgets;
        public TagInstance TextureRenderList;
        [MinVersion(GameDefinitionSet.HaloOnline498295)] public TagInstance SwearFilter; // TODO: Version number
        public uint Unknown;

        [TagStructure(Size = 0x10)]
        public class ScreenWidget
        {
            public TagInstance Widget;
        }
    }
}
