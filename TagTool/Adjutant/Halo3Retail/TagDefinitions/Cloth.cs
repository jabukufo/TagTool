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
	[TagStructure(Class = "clwd", Size = 0x94)]
	public class Cloth
	{
		public FlagsValue Flags;
		public StringID MarkerAttachmentName;
		public StringID SecondMarkerAttachmentName;
		public TagInstance Shader;
		public short GridXDimension;
		public short GridYDimension;
		public float GridSpacingX;
		public float GridSpacingY;
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public IntegrationTypeValue IntegrationType;
		public short NumberIterations;
		public float Weight;
		public float Drag;
		public float WindScale;
		public float WindFlappinessScale;
		public float LongestRod;
		public uint Unknown4;
		public uint Unknown5;
		public uint Unknown6;
		public uint Unknown7;
		public uint Unknown8;
		public uint Unknown9;
		public List<Vertex> Vertices;
		public List<Index> Indices;
		public uint Unknown10;
		public uint Unknown11;
		public uint Unknown12;
		public List<Link> Links;

		public enum FlagsValue : int
		{
			None,
			DoesnTUseWind,
			UsesGridAttachTop,
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

		public enum IntegrationTypeValue : short
		{
			Verlet,
		}

		[TagStructure(Size = 0x14)]
		public class Vertex
		{
			public float InitialPositionX;
			public float InitialPositionY;
			public float InitialPositionZ;
			public float UvI;
			public float UvJ;
		}

		[TagStructure(Size = 0x2)]
		public class Index
		{
			public short Index2;
		}

		[TagStructure(Size = 0x8)]
		public class Link
		{
			public short Index1;
			public short Index2;
			public float DefaultDistance;
		}
	}
}
