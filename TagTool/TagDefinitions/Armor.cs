using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "armor", Class = "armr", Size = 0x28, MinVersion = CacheVersion.HaloOnline430475)]
    public class Armor : GameObject
    {
        public CachedTagInstance ParentModel;
        public CachedTagInstance FirstPersonModel;
        public CachedTagInstance ThirdPersonModel;

        [TagField(Padding = true, Count = 4)]
        public sbyte[] Unused;
    }
}
