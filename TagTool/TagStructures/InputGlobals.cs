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
    [TagStructure(Name = "input_globals", Class = "inpg", Size = 0x34)]
    public class InputGlobals
    {
        public int Unknown;
        public float Unknown2;
        public byte[] Unknown3;
        public byte[] Unknown4;
        public int Unknown5;
    }
}
