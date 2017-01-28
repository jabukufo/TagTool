using System.Collections.Generic;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Geometry
{
    [TagStructure(Size = 0x40)]
    public class CollisionMoppCode
    {
        public int Unused1;
        public short Size;
        public short Count;
        public int Address;
        public int Unused2;
        public RealVector4d Offset;
        public int Unused3;
        public int DataSize;
        public int DataCapacityAndFlags;
        public sbyte DataBuildType;
        public short Unused4;
        public short Unused5;
        public List<byte> Data;
        public sbyte MoppBuildType;
        public byte Unused6;
        public short Unused7;
    }
}
