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
	[TagStructure(Class = "scn3", Size = 0xA8)]
	public class GuiScreenWidgetDefinition
	{
		public FlagsValue Flags;
		public StringID Name;
		public short Unknown;
		public short Layer;
		public short WidescreenYBoundsMin;
		public short WidescreenXBoundsMin;
		public short WidescreenYBoundsMax;
		public short WidescreenXBoundsMax;
		public short StandardYBoundsMin;
		public short StandardXBoundsMin;
		public short StandardYBoundsMax;
		public short StandardXBoundsMax;
		public TagInstance Animation;
		public TagInstance Strings;
		public TagInstance Parent;
		public StringID DefaultKeyLegendString;
		public List<DataSource> DataSources;
		public List<GroupWidget> GroupWidgets;
		public List<ButtonKeyLegend> ButtonKeyLegends;
		public TagInstance UiSounds;
		[TagField(Length = 32)] public string ScriptTitle;
		public short ScriptIndex;
		public short Unknown2;

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

		[TagStructure(Size = 0x10)]
		public class DataSource
		{
			public TagInstance DataSource2;
		}

		[TagStructure(Size = 0x6C)]
		public class GroupWidget
		{
			public TagInstance Parent;
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
			public List<ListWidget> ListWidgets;
			public List<TextWidget> TextWidgets;
			public List<BitmapWidget> BitmapWidgets;
			public List<ModelWidget> ModelWidgets;

			public enum FlagsValue : int
			{
				None,
				Bit0,
				Bit1,
				Bit2 = 4,
				InitiallyHidden = 8,
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

			[TagStructure(Size = 0x80)]
			public class ListWidget
			{
				public TagInstance Parent;
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

			[TagStructure(Size = 0x4C)]
			public class TextWidget
			{
				public TagInstance Parent;
				public FlagsValue Flags;
				public StringID Name;
				public short Unknown;
				public short Layer;
				public short WidescreenYBoundsMin;
				public short WidescreenXBoundsMin;
				public short WidescreenYBoundsMax;
				public short WidescreenXBoundsMax;
				public short StandardYBoundsMin;
				public short StandardXBoundsMin;
				public short StandardYBoundsMax;
				public short StandardXBoundsMax;
				public TagInstance Animation;
				public StringID DataSourceName;
				public StringID TextString;
				public StringID TextColor;
				public short TextFont;
				public short Unknown2;

				public enum FlagsValue : int
				{
					None,
					Bit0,
					Bit1,
					Bit2 = 4,
					LeftAlignment = 8,
					RightAlignment = 16,
					Bit5 = 32,
					AllCaps = 64,
					Bit7 = 128,
					Bit8 = 256,
					Bit9 = 512,
					Bit10 = 1024,
					Bit11 = 2048,
					Bit12 = 4096,
					WrapAtBounds = 8192,
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

			[TagStructure(Size = 0x6C)]
			public class BitmapWidget
			{
				public TagInstance Parent;
				public FlagsValue Flags;
				public StringID Name;
				public short Unknown;
				public short Layer;
				public short WidescreenYBoundsMin;
				public short WidescreenXBoundsMin;
				public short WidescreenYBoundsMax;
				public short WidescreenXBoundsMax;
				public short StandardYBoundsMin;
				public short StandardXBoundsMin;
				public short StandardYBoundsMax;
				public short StandardXBoundsMax;
				public TagInstance Animation;
				public TagInstance Bitmap;
				public TagInstance Unknown2;
				public BlendMethodValue BlendMethod;
				public short Unknown3;
				public short SpriteIndex;
				public short Unknown4;
				public StringID DataSourceName;
				public StringID SpriteDataSourceName;

				public enum FlagsValue : int
				{
					None,
					Bit0,
					Bit1,
					Bit2 = 4,
					ScaleToBounds = 8,
					ReplaceWithBlur = 16,
					Bit5 = 32,
					Bit6 = 64,
					Bit7 = 128,
					Bit8 = 256,
					Bit9 = 512,
					ReplaceWithWhite = 1024,
					ReplaceWithBlack = 2048,
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

				public enum BlendMethodValue : short
				{
					Standard,
					Unknown,
					Unknown2,
					Alpha,
					Overlay,
					Unknown3,
					LighterColor,
					Unknown4,
					Unknown5,
					Unknown6,
					InvertedAlpha,
					Unknown7,
					Unknown8,
					Unknown9,
				}
			}

			[TagStructure(Size = 0x48)]
			public class ModelWidget
			{
				public TagInstance Parent;
				public FlagsValue Flags;
				public StringID Name;
				public short Unknown;
				public short Layer;
				public short WidescreenYBoundsMin;
				public short WidescreenXBoundsMin;
				public short WidescreenYBoundsMax;
				public short WidescreenXBoundsMax;
				public short StandardYBoundsMin;
				public short StandardXBoundsMin;
				public short StandardYBoundsMax;
				public short StandardXBoundsMax;
				public TagInstance Animation;
				public List<CameraRefinementBlock> CameraRefinement;

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

				[TagStructure(Size = 0x3C)]
				public class CameraRefinementBlock
				{
					public StringID Biped;
					public float Unknown;
					public float Unknown2;
					public float Unknown3;
					public float Unknown4;
					public float Unknown5;
					public float Unknown6;
					public float Unknown7;
					public float Unknown8;
					public List<ZoomData1Block> ZoomData1;
					public List<ZoomData2Block> ZoomData2;

					[TagStructure(Size = 0x14)]
					public class ZoomData1Block
					{
						public byte[] Unknown;
					}

					[TagStructure(Size = 0x14)]
					public class ZoomData2Block
					{
						public byte[] Unknown;
					}
				}
			}
		}

		[TagStructure(Size = 0x10)]
		public class ButtonKeyLegend
		{
			public TagInstance Legend;
		}
	}
}
