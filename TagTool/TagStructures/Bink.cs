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
    [TagStructure(Name = "bink", Class = "bink", Size = 0x18, MaxVersion = EngineVersion.V11_1_571627_Live)]
    [TagStructure(Name = "bink", Class = "bink", Size = 0x14, MinVersion = EngineVersion.V12_1_700123_cert_ms30_oct19)]
    public class Bink
    {
        public int FrameCount;
        public ResourceReference Resource;
        public int UselessPadding;
        public uint Unknown;
        public uint Unknown2;

        [MaxVersion(EngineVersion.V11_1_571627_Live)]
        public uint Unknown3;
    }
}
