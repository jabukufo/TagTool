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
	[TagStructure(Class = "bsdt", Size = 0xA0)]
	public class BreakableSurface
	{
		public float MaximumVitality;
		public TagInstance Effect;
		public TagInstance Sound;
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public uint Unknown4;
		public TagInstance CrackBitmap;
		public TagInstance HoleBitmap;
		public uint Unknown5;
		public uint Unknown6;
		public uint Unknown7;
		public uint Unknown8;
		public uint Unknown9;
		public uint Unknown10;
		public uint Unknown11;
		public uint Unknown12;
		public uint Unknown13;
		public List<Unknown0Block> Unknown0;
		public uint Unknown14;
		public uint Unknown15;
		public uint Unknown16;
		public uint Unknown17;
		public List<Unknown1Block> Unknown1;
		public uint Unknown18;
		public uint Unknown19;

		[TagStructure(Size = 0x24)]
		public class Unknown0Block
		{
			public uint Unknown;
			public uint Unknown2;
			public byte[] Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}

		[TagStructure(Size = 0x24)]
		public class Unknown1Block
		{
			public uint Unknown;
			public uint Unknown2;
			public byte[] Unknown3;
			public uint Unknown4;
			public uint Unknown5;
		}
	}
}
