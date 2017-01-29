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
	[TagStructure(Class = "effg", Size = 0xC)]
	public class EffectGlobals
	{
		public List<UnknownBlock> Unknown;

		[TagStructure(Size = 0x14)]
		public class UnknownBlock
		{
			public int Unknown;
			public int Unknown2;
			public List<UnknownBlock2> Unknown3;

			[TagStructure(Size = 0x10)]
			public class UnknownBlock2
			{
				public int Unknown;
				public int Unknown2;
				public uint Unknown3;
				public int Unknown4;
			}
		}
	}
}
