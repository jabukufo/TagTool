using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Class = "devi", Size = 0x98)]
    public class Device : GameObject
    {
        public uint Flags2;
        public float PowerTransitionTime;
        public float PowerAccelerationTime;
        public float PositionTransitionTime;
        public float PositionAccelerationTime;
        public float DepoweredPositionTransitionTime;
        public float DepoweredPositionAccelerationTime;
        public uint LightmapFlags;
        public CachedTagInstance OpenUp;
        public CachedTagInstance CloseDown;
        public CachedTagInstance Opened;
        public CachedTagInstance Closed;
        public CachedTagInstance Depowered;
        public CachedTagInstance Repowered;
        public float DelayTime;
        public CachedTagInstance DelayEffect;
        public float AutomaticActivationRadius;
    }
}
