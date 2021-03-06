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
	[TagStructure(Class = "spk!", Size = 0x28)]
	public class SoundDialogueConstants
	{
		public float AlmostNever;
		public float Rarely;
		public float Somewhat;
		public float Often;
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public uint Unknown4;
		public uint Unknown5;
		public uint Unknown6;
	}
}
