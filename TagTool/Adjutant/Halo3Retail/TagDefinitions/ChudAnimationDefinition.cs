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
	[TagStructure(Class = "chad", Size = 0x5C)]
	public class ChudAnimationDefinition
	{
		public FlagsValue Flags;
		public short Unknown;
		public List<PositionBlock> Position;
		public List<RotationBlock> Rotation;
		public List<SizeBlock> Size;
		public List<ColorBlock> Color;
		public List<AlphaBlock> Alpha;
		public List<AlphaUnknownBlock> AlphaUnknown;
		public List<BitmapBlock> Bitmap;
		public int NumberOfFrames;

		public enum FlagsValue : ushort
		{
			None,
			Bit0,
			Loops,
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
		}

		[TagStructure(Size = 0x20)]
		public class PositionBlock
		{
			public List<AnimationBlock> Animation;
			public byte[] Function;

			[TagStructure(Size = 0x10)]
			public class AnimationBlock
			{
				public int FrameNumber;
				public float PositionX;
				public float PositionY;
				public float PositionZ;
			}
		}

		[TagStructure(Size = 0x20)]
		public class RotationBlock
		{
			public List<AnimationBlock> Animation;
			public byte[] Function;

			[TagStructure(Size = 0x10)]
			public class AnimationBlock
			{
				public int FrameNumber;
				public Angle XAngle;
				public Angle YAngle;
				public Angle ZAngle;
			}
		}

		[TagStructure(Size = 0x20)]
		public class SizeBlock
		{
			public List<AnimationBlock> Animation;
			public byte[] Unknown;

			[TagStructure(Size = 0xC)]
			public class AnimationBlock
			{
				public int FrameNumber;
				public float StretchX;
				public float StretchY;
			}
		}

		[TagStructure(Size = 0x20)]
		public class ColorBlock
		{
			public List<AnimationBlock> Animation;
			public byte[] Function;

			[TagStructure(Size = 0x8)]
			public class AnimationBlock
			{
				public int FrameNumber;
				public uint Unknown;
			}
		}

		[TagStructure(Size = 0x20)]
		public class AlphaBlock
		{
			public List<AnimationBlock> Animation;
			public byte[] Function;

			[TagStructure(Size = 0x8)]
			public class AnimationBlock
			{
				public int FrameNumber;
				public float Alpha;
			}
		}

		[TagStructure(Size = 0x20)]
		public class AlphaUnknownBlock
		{
			public List<AnimationBlock> Animation;
			public byte[] Function;

			[TagStructure(Size = 0x8)]
			public class AnimationBlock
			{
				public int FrameNumber;
				public float Alpha;
			}
		}

		[TagStructure(Size = 0x20)]
		public class BitmapBlock
		{
			public List<AnimationBlock> Animation;
			public byte[] Function;

			[TagStructure(Size = 0x14)]
			public class AnimationBlock
			{
				public int FrameNumber;
				public float Movement1X;
				public float Movement1Y;
				public float Movement2X;
				public float Movement2Y;
			}
		}
	}
}
