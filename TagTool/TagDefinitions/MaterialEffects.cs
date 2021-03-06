using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "material_effects", Class = "foot", Size = 0xC)]
    public class MaterialEffects
    {
        public List<Effect> Effects;

        [TagStructure(Size = 0x24)]
        public class Effect
        {
            public List<OldMaterial> OldMaterials;
            public List<Sound> Sounds;
            public List<Effect2> Effects;

            [TagStructure(Size = 0x2C)]
            public class OldMaterial
            {
                public CachedTagInstance Effect;
                public CachedTagInstance Sound;
                public StringId MaterialName;
                public short GlobalMaterialIndex;
                public SweetenerModeValue SweetenerMode;
                public sbyte Unknown;
                public uint Unknown2;

                public enum SweetenerModeValue : sbyte
                {
                    SweetenerDefault,
                    SweetenerEnabled,
                    SweetenerDisabled,
                }
            }

            [TagStructure(Size = 0x2C)]
            public class Sound
            {
                public CachedTagInstance Tag;
                public CachedTagInstance SecondaryTag;
                public StringId MaterialName;
                public short GlobalMaterialIndex;
                public SweetenerModeValue SweetenerMode;
                public sbyte Unknown;
                public uint Unknown2;

                public enum SweetenerModeValue : sbyte
                {
                    SweetenerDefault,
                    SweetenerEnabled,
                    SweetenerDisabled,
                }
            }

            [TagStructure(Size = 0x2C)]
            public class Effect2
            {
                public CachedTagInstance Tag;
                public CachedTagInstance SecondaryTag;
                public StringId MaterialName;
                public short GlobalMaterialIndex;
                public SweetenerModeValue SweetenerMode;
                public sbyte Unknown;
                public uint Unknown2;

                public enum SweetenerModeValue : sbyte
                {
                    SweetenerDefault,
                    SweetenerEnabled,
                    SweetenerDisabled,
                }
            }
        }
    }
}
