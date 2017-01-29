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
	[TagStructure(Class = "sgp!", Size = 0x48)]
	public class SoundGlobalPropagation
	{
		public TagInstance UnderwaterEnvironment;
		public TagInstance UnderwaterLoop;
		public uint Unknown;
		public uint Unknown2;
		public TagInstance EnterUnderater;
		public TagInstance ExitUnderwater;
	}
}
