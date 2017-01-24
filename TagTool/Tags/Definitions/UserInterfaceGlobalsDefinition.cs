using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.Tags.Definitions
{
    [TagStructure(Name = "user_interface_globals_definition", Class = "wgtz", Size = 0x50, MaxVersion = CacheVersion.HaloOnline449175)]
    [TagStructure(Name = "user_interface_globals_definition", Class = "wgtz", Size = 0x60, MinVersion = CacheVersion.HaloOnline498295)]
    public class UserInterfaceGlobalsDefinition
    {
        public TagInstance SharedUiGlobals;
        public TagInstance EditableSettings;
        public TagInstance MatchmakingHopperStrings;
        public List<ScreenWidget> ScreenWidgets;
        public TagInstance TextureRenderList;
        [MinVersion(CacheVersion.HaloOnline498295)] public TagInstance SwearFilter; // TODO: Version number
        public uint Unknown;

        [TagStructure(Size = 0x10)]
        public class ScreenWidget
        {
            public TagInstance Widget;
        }
    }
}
