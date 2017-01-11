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
    [TagStructure(Name = "effect_globals", Class = "effg", Size = 0x10)]
    public class EffectGlobals
    {
        public List<UnknownBlock> Unknown;
        public uint Unknown2;

        [TagStructure(Size = 0x14)]
        public class UnknownBlock
        {
            public uint Unknown;
            public uint Unknown2;
            public List<UnknownBlock2> Unknown3;

            [TagStructure(Size = 0x10)]
            public class UnknownBlock2
            {
                public uint Unknown;
                public uint Unknown2;
                public uint Unknown3;
                public uint Unknown4;
            }
        }
    }
}
