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
	[TagStructure(Class = "perf", Size = 0xC)]
	public class PerformanceThrottles
	{
		public List<PerformanceBlock> Performance;

		[TagStructure(Size = 0x38)]
		public class PerformanceBlock
		{
			public FlagsValue Flags;
			public float Water;
			public float Decorators;
			public float Effects;
			public float InstancedGeometry;
			public float ObjectFade;
			public float ObjectLod;
			public float Decals;
			public int CpuLightCount;
			public float CpuLightQuality;
			public int GpuLightCount;
			public float GpuLightQuality;
			public int ShadowCount;
			public float ShadowQuality;

			public enum FlagsValue : int
			{
				None,
				Bit0,
				DisableSelfShadowing,
				DisablePlayerShadows = 4,
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
