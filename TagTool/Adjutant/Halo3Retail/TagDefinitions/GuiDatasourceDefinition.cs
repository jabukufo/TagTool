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
	[TagStructure(Class = "dsrc", Size = 0x1C)]
	public class GuiDatasourceDefinition
	{
		public StringID Name;
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public List<Datum> Data;

		[TagStructure(Size = 0x28)]
		public class Datum
		{
			public List<IntegerValue> IntegerValues;
			public List<StringValue> StringValues;
			public List<StringidValue> StringidValues;
			public StringID Unknown;

			[TagStructure(Size = 0x8)]
			public class IntegerValue
			{
				public StringID DataType;
				public int Value;
			}

			[TagStructure(Size = 0x24)]
			public class StringValue
			{
				public StringID DataType;
				[TagField(Length = 20)] public string Value;
			}

			[TagStructure(Size = 0x8)]
			public class StringidValue
			{
				public StringID DataType;
				public StringID Value;
			}
		}
	}
}
