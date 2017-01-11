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
    [TagStructure(Name = "sound_global_propagation", Class = "sgp!", Size = 0x50)]
    public class SoundGlobalPropagation
    {
        public TagInstance UnderwaterEnvironment;
        public TagInstance UnderwaterLoop;
        public uint Unknown;
        public uint Unknown2;
        public TagInstance EnterUnderater;
        public TagInstance ExitUnderwater;
        public uint Unknown3;
        public uint Unknown4;
    }
}
