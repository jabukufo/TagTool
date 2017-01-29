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
	[TagStructure(Class = "lens", Size = 0x98)]
	public class LensFlare
	{
		public Angle FalloffAngle;
		public Angle CutoffAngle;
		public float OcclusionRadius;
		public int Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public float NearFadeDistance;
		public float FarFadeDistance;
		public TagInstance Bitmap;
		public short Unknown4;
		public short Unknown5;
		public short Unknown6;
		public short Unknown7;
		public Angle RotationFunctionScale;
		public short Unknown8;
		public short Unknown9;
		public List<Reflection> Reflections;
		public uint Unknown10;
		public List<BrightnessBlock> Brightness;
		public List<ColorBlock> Color;
		public List<UnknownBlock> Unknown11;
		public List<RotationBlock> Rotation;
		public uint Unknown12;
		public uint Unknown13;
		public uint Unknown14;
		public uint Unknown15;
		public uint Unknown16;
		public uint Unknown17;

		[TagStructure(Size = 0x30)]
		public class Reflection
		{
			public FlagsValue Flags;
			public short BitmapIndex;
			public float PositionAlongFlareAxis;
			public float RotationOffset;
			public float RadiusMin;
			public float RadiusMax;
			public float BrightnessMin;
			public float BrightnessMax;
			public float TintModulationFactor;
			public float TintColorR;
			public float TintColorG;
			public float TintColorB;
			public float Unknown;

			public enum FlagsValue : ushort
			{
				None,
				AlignRotationWithScreenCenter,
				RadiusNotScaledByDistance,
				RadiusScaledByOcclusionFactor = 4,
				OccludedBySolidObjects = 8,
				IgnoreLightColor = 16,
				NotAffectedByInnerOcclusion = 32,
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
		}

		[TagStructure(Size = 0x14)]
		public class BrightnessBlock
		{
			public byte[] Function;
		}

		[TagStructure(Size = 0x14)]
		public class ColorBlock
		{
			public byte[] Function;
		}

		[TagStructure(Size = 0x24)]
		public class UnknownBlock
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public byte[] Function;
		}

		[TagStructure(Size = 0x24)]
		public class RotationBlock
		{
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public uint Unknown4;
			public byte[] Function;
		}
	}
}
