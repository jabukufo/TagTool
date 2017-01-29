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
	[TagStructure(Class = "wgtz", Size = 0x3C)]
	public class UserInterfaceGlobalsDefinition
	{
		public TagInstance SharedUiGlobals;
		public TagInstance EditableSettings;
		public TagInstance MatchmakingHopperStrings;
		public List<ScreenWidget> ScreenWidgets;

		[TagStructure(Size = 0x10)]
		public class ScreenWidget
		{
			public TagInstance Widget;
		}
	}
}
