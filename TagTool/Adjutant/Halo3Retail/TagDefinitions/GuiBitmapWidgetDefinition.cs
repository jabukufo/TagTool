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
	[TagStructure(Class = "bmp3", Size = 0x5C)]
	public class GuiBitmapWidgetDefinition
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
}
