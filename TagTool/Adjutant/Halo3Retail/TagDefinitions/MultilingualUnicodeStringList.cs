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
	[TagStructure(Class = "unic", Size = 0x50)]
	public class MultilingualUnicodeStringList
	{
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public byte[] Unknown4;
		[TagField(Count = 12)] public int[] Strings;
	}
}
