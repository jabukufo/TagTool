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
    [TagStructure(Name = "camo", Class = "cmoe", Size = 0x40)]
    public class Camo
    {
        public short Unknown;
        public short Unknown2;
        public StringId Unknown3;
        public uint Unknown4;
        public byte[] Unknown5;
        public StringId Unknown6;
        public uint Unknown7;
        public byte[] Unknown8;
    }
}
