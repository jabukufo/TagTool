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
	[TagStructure(Class = "pmov", Size = 0x20)]
	public class ParticlePhysics
	{
		public TagInstance Template;
		public FlagsValue Flags;
		public List<Movement> Movements;

		public enum FlagsValue : int
		{
			None,
			Physics,
			CollideWithStructure,
			CollideWithMedia = 4,
			CollideWithScenery = 8,
			CollideWithVehicles = 16,
			CollideWithBipeds = 32,
			Swarm = 64,
			Wind = 128,
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

		[TagStructure(Size = 0x18)]
		public class Movement
		{
			public TypeValue Type;
			public short Unknown;
			public List<Parameter> Parameters;
			public short Unknown2;
			public short Unknown3;
			public int Unknown4;

			public enum TypeValue : short
			{
				Physics,
				Collider,
				Swarm,
				Wind,
			}

			[TagStructure(Size = 0x24)]
			public class Parameter
			{
				public int ParameterId;
				public short Unknown;
				public short Unknown2;
				public byte[] Function;
				public float Unknown3;
				public byte Unknown4;
				public sbyte Unknown5;
				public sbyte Unknown6;
				public sbyte Unknown7;
			}
		}
	}
}
