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
	[TagStructure(Class = "ligh", Size = 0x94)]
	public class Light
	{
		public FlagsValue Flags;
		public TypeValue Type;
		public short Unknown;
		public float LightRange;
		public float NearWidth;
		public float HeightStretch;
		public Angle FieldOfView;
		public StringID FunctionName;
		public StringID FunctionName2;
		public short Unknown2;
		public short Unknown3;
		public uint Unknown4;
		public byte[] Function;
		public StringID FunctionName3;
		public StringID FunctionName4;
		public short Unknown5;
		public short Unknown6;
		public uint Unknown7;
		public byte[] Function2;
		public TagInstance GelMap;
		public float Unknown8;
		public float Unknown9;
		public float Unknown10;
		public float Unknown11;
		public sbyte Unknown12;
		public sbyte Unknown13;
		public sbyte Unknown14;
		public sbyte Unknown15;
		public TagInstance LensFlare;

		public enum FlagsValue : int
		{
			None,
			Bit0,
			NoShadow,
			OnlyRenderInFirstPerson = 4,
			OnlyRenderInThirdPerson = 8,
			Bit4 = 16,
			Bit5 = 32,
			Bit6 = 64,
			SnapToFirstPersonCameraReqOnlyFirstPerson = 128,
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

		public enum TypeValue : short
		{
			Sphere,
			Projective,
		}
	}
}
