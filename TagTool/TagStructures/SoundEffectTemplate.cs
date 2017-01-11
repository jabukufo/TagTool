using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Common;
using TagTool.Resources;
using TagTool.Serialization;

namespace TagTool.TagStructures
{
    [TagStructure(Name = "sound_effect_template", Class = "<fx>", Size = 0x20)]
    public class SoundEffectTemplate
    {
        public float TemplateCollectionBlock;
        public float TemplateCollectionBlock2;
        public float TemplateCollectionBlock3;
        public int InputEffectName;
        public List<AdditionalSoundInput> AdditionalSoundInputs;
        public uint Unknown;

        [TagStructure(Size = 0x1C)]
        public class AdditionalSoundInput
        {
            public StringId DspEffect;
            public byte[] LowFrequencySoundFunction;
            public float TimePeriod;
        }
    }
}
