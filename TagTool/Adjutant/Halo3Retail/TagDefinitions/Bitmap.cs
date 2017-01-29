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
	[TagStructure(Class = "bitm", Size = 0xA4)]
	public class Bitmap
	{
		public int Unknown;
		public short Unknown2;
		public short Unknown3;
		public float Unknown4;
		public float Unknown5;
		public short Unknown6;
		public short Unknown7;
		public List<UnknownBlock> Unknown8;
		public List<UnknownSequence> UnknownSequences;
		public byte[] Unknown9;
		public byte[] Unknown10;
		public List<Sequence> Sequences;
		public List<Bitmap2> Bitmaps;
		public byte[] Unknown11;
		public uint Unknown12;
		public uint Unknown13;
		public uint Unknown14;
		public List<RawInformationNormalBlock> RawInformationNormal;
		public List<RawInformationInterleavedBlock> RawInformationInterleaved;

		[TagStructure(Size = 0x28)]
		public class UnknownBlock
		{
			public uint Unknown;
			public int Unknown2;
			public short Unknown3;
			public short Unknown4;
			public sbyte Unknown5;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public sbyte Unknown8;
			public short Unknown9;
			public short Unknown10;
			public float Unknown11;
			public float Unknown12;
			public float Unknown13;
			public uint Unknown14;
			public int Unknown15;
		}

		[TagStructure(Size = 0x40)]
		public class UnknownSequence
		{
			[TagField(Length = 32)] public string Name;
			public short FirstBitmapIndex;
			public short BitmapCount;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public List<Sprite> Sprites;

			[TagStructure(Size = 0x20)]
			public class Sprite
			{
				public short BitmapIndex;
				public short Unknown;
				public uint Unknown2;
				public float Left;
				public float Right;
				public float Top;
				public float Bottom;
				public float RegistrationPointX;
				public float RegistrationPointY;
			}
		}

		[TagStructure(Size = 0x40)]
		public class Sequence
		{
			[TagField(Length = 32)] public string Name;
			public short FirstBitmapIndex;
			public short BitmapCount;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public List<Sprite> Sprites;

			[TagStructure(Size = 0x20)]
			public class Sprite
			{
				public short BitmapIndex;
				public short Unknown;
				public uint Unknown2;
				public float Left;
				public float Right;
				public float Top;
				public float Bottom;
				public float RegistrationPointX;
				public float RegistrationPointY;
			}
		}

		[TagStructure(Size = 0x30)]
		public class Bitmap2
		{
			[TagField(Length = 4)] public string Signature;
			public short Width;
			public short Height;
			public sbyte Depth;
			public FormatFlagsValue FormatFlags;
			public TypeValue Type;
			public FormatValue Format;
			public FlagsValue Flags;
			public short RegistrationPointX;
			public short RegistrationPointY;
			public sbyte MipmapCount;
			public sbyte Unknown;
			public sbyte Unknown2;
			public sbyte Unknown3;
			public int PixelsOffset;
			public int PixelsCount;
			public uint Unknown4;
			public sbyte Unknown5;
			public sbyte Unknown6;
			public sbyte Unknown7;
			public sbyte Unknown8;
			public int Unknown9;
			public uint Unknown10;

			public enum FormatFlagsValue : byte
			{
				None,
				Bit0,
				Bit1,
				Bit2 = 4,
				IsTiled = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
			}

			public enum TypeValue : short
			{
				_2dTexture,
				_3dTexture,
				CubeMap,
				Unknown,
			}

			public enum FormatValue : short
			{
				A8,
				Y8,
				Ay8,
				A8y8,
				Unused4,
				Unused5,
				R5g6b5,
				Unused7,
				A1r5g5b5,
				A4r4g4b4,
				X8r8g8b8,
				A8r8g8b8,
				Unused12,
				Unused13,
				Dxt1,
				Dxt3,
				Dxt5,
				P8Bump,
				P8,
				Argbfp32,
				Rgbfp32,
				Rgbfp16,
				V8u8,
				Unknown23,
				Unknown24,
				Unknown25,
				Unknown26,
				Unknown27,
				Unknown28,
				Unknown29,
				Unknown30,
				Dxt5a,
				Unknown32,
				Dxn,
				Ctx1,
				Dxt3aAlpha,
				Dxt3aMono,
				Dxt5aAlpha,
				Dxt5aMono,
				DxnMonoAlpha,
				Unknown40,
				Unknown41,
				Unknown42,
				Unknown43,
				Unknown44,
			}

			public enum FlagsValue : ushort
			{
				None,
				PowerOfTwoDimensions,
				Compressed,
				Palettized = 4,
				Swizzled = 8,
				Linear = 16,
				V16u16 = 32,
				MipMapDebugLevel = 64,
				PreferStutterPreferLowDetail = 128,
				Bit8 = 256,
				AlwaysOn = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Interlaced = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}
		}

		[TagStructure(Size = 0x8)]
		public class RawInformationNormalBlock
		{
			public ushort ZoneAssetSalt;
			public ushort ZoneAssetIndex;
			public int UselessPadding;
		}

		[TagStructure(Size = 0x8)]
		public class RawInformationInterleavedBlock
		{
			public ushort ZoneAssetSalt;
			public ushort ZoneAssetIndex;
			public int UselessPadding;
		}
	}
}
