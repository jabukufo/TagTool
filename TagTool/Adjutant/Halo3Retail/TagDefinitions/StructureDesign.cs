using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineTagTool.Common;
using HaloOnlineTagTool.Resources;
using HaloOnlineTagTool.Serialization;

namespace HaloOnlineTagTool.TagStructures
{
	[TagStructure(Class = "sddt", Size = 0x40)]
	public class StructureDesign
	{
		public int Unknown;
		public List<DesignMoppCode> DesignMoppCodes;
		public List<DesignShapes2Block> DesignShapes2;
		public List<WaterMoppCode> WaterMoppCodes;
		public List<WaterName> WaterNames;
		public List<UnderwaterDefinition> UnderwaterDefinitions;

		[TagStructure(Size = 0x40)]
		public class DesignMoppCode
		{
			public int Unknown;
			public short Size;
			public short Count;
			public int Offset;
			public uint Unknown2;
			public float OffsetX;
			public float OffsetY;
			public float OffsetZ;
			public float OffsetScale;
			public uint Unknown3;
			public int DataSize;
			public uint DataCapacity;
			public sbyte Unknown4;
			public sbyte Unknown5;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public List<Datum> Data;
			public uint Unknown8;

			[TagStructure(Size = 0x1)]
			public class Datum
			{
				public byte DataByte;
			}
		}

		[TagStructure(Size = 0x14)]
		public class DesignShapes2Block
		{
			public StringID Name;
			public short Unknown;
			public short Unknown2;
			public List<Unknown2Block> Unknown2_2;

			[TagStructure(Size = 0x44)]
			public class Unknown2Block
			{
				public float Unknown;
				public float Unknown2;
				public float Unknown3;
				public float Unknown4;
				public float Unknown5;
				public float Unknown6;
				public float Unknown7;
				public float Unknown8;
				public float Unknown9;
				public float Unknown10;
				public float Unknown11;
				public float Unknown12;
				public float Unknown13;
				public float Unknown14;
				public float Unknown15;
				public float Unknown16;
				public float Unknown17;
			}
		}

		[TagStructure(Size = 0x40)]
		public class WaterMoppCode
		{
			public int Unknown;
			public short Size;
			public short Count;
			public int Offset;
			public uint Unknown2;
			public float OffsetX;
			public float OffsetY;
			public float OffsetZ;
			public float OffsetScale;
			public uint Unknown3;
			public int DataSize;
			public uint DataCapacity;
			public sbyte Unknown4;
			public sbyte Unknown5;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public List<Datum> Data;
			public uint Unknown8;

			[TagStructure(Size = 0x1)]
			public class Datum
			{
				public byte DataByte;
			}
		}

		[TagStructure(Size = 0x4)]
		public class WaterName
		{
			public StringID Name;
		}

		[TagStructure(Size = 0x2C)]
		public class UnderwaterDefinition
		{
			public short WaterNameIndex;
			public short Unknown;
			public float FlowForceX;
			public float FlowForceY;
			public float FlowForceZ;
			public float FlowForceZ2;
			public List<UnknownBlock> Unknown2;
			public List<Triangle> Triangles;

			[TagStructure(Size = 0x10)]
			public class UnknownBlock
			{
				public float Unknown;
				public float Unknown2;
				public float Unknown3;
				public float Unknown4;
			}

			[TagStructure(Size = 0x24)]
			public class Triangle
			{
				public uint _1X;
				public uint _1Y;
				public uint _1Z;
				public uint _2X;
				public uint _2Y;
				public uint _2Z;
				public uint _3X;
				public uint _3Y;
				public uint _3Z;
			}
		}
	}
}
