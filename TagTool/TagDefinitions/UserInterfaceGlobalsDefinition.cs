using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "user_interface_globals_definition", Class = "wgtz", Size = 0x50, MaxVersion = CacheVersion.HaloOnline449175)]
    [TagStructure(Name = "user_interface_globals_definition", Class = "wgtz", Size = 0x60, MinVersion = CacheVersion.HaloOnline498295)]
    public class UserInterfaceGlobalsDefinition
    {
        public CachedTagInstance SharedUiGlobals;
        public CachedTagInstance EditableSettings;
        public CachedTagInstance MatchmakingHopperStrings;
        public List<ScreenWidget> ScreenWidgets;
        public CachedTagInstance TextureRenderList;
        [MinVersion(CacheVersion.HaloOnline498295)] public CachedTagInstance SwearFilter; // TODO: Version number
        public uint Unknown;

        [TagStructure(Size = 0x10)]
        public class ScreenWidget
        {
            public CachedTagInstance Widget;
        }
    }
}
