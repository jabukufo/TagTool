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
	[TagStructure(Class = "lst3", Size = 0x70)]
	public class GuiListWidgetDefinition
	{
		public FlagsValue Flags;
		public StringID Name;
		public short Unknown;
		public short Layer;
		public short WidescreenYOffset;
		public short WidescreenXOffset;
		public short WidescreenYUnknown;
		public short WidescreenXUnknown;
		public short StandardYOffset;
		public short StandardXOffset;
		public short StandardYUnknown;
		public short StandardXUnknown;
		public TagInstance Animation;
		public StringID DataSourceName;
		public TagInstance Skin;
		public int RowCount;
		public List<ListWidgetItem> ListWidgetItems;
		public TagInstance UpArrowBitmap;
		public TagInstance DownArrowBitmap;

		public enum FlagsValue : int
		{
			None,
			Bit0,
			Bit1,
			Bit2 = 4,
			Bit3 = 8,
			Horizontal = 16,
			Loops = 32,
			Bit6 = 64,
			Bit7 = 128,
			Bit8 = 256,
			Bit9 = 512,
			Bit10 = 1024,
			Bit11 = 2048,
			Bit12 = 4096,
			Bit13 = 8192,
			Bit14 = 16384,
			Bit15 = 32768,
			Bit16 = 65536,
			Bit17 = 131072,
			Bit18 = 262144,
			Bit19 = 524288,
			Bit20 = 1048576,
			Bit21 = 2097152,
			Bit22 = 4194304,
			Bit23 = 8388608,
			Bit24 = 16777216,
			Bit25 = 33554432,
			Bit26 = 67108864,
			Bit27 = 134217728,
			Bit28 = 268435456,
			Bit29 = 536870912,
			Bit30 = 1073741824,
			Bit31 = -2147483648,
		}

		[TagStructure(Size = 0x30)]
		public class ListWidgetItem
		{
			public FlagsValue Flags;
			public StringID Name;
			public short Unknown;
			public short Layer;
			public short WidescreenYOffset;
			public short WidescreenXOffset;
			public short WidescreenYUnknown;
			public short WidescreenXUnknown;
			public short StandardYOffset;
			public short StandardXOffset;
			public short StandardYUnknown;
			public short StandardXUnknown;
			public TagInstance Animation;
			public StringID Target;

			public enum FlagsValue : int
			{
				None,
				Bit0,
				Bit1,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
				Bit16 = 65536,
				Bit17 = 131072,
				Bit18 = 262144,
				Bit19 = 524288,
				Bit20 = 1048576,
				Bit21 = 2097152,
				Bit22 = 4194304,
				Bit23 = 8388608,
				Bit24 = 16777216,
				Bit25 = 33554432,
				Bit26 = 67108864,
				Bit27 = 134217728,
				Bit28 = 268435456,
				Bit29 = 536870912,
				Bit30 = 1073741824,
				Bit31 = -2147483648,
			}
		}
	}
}
