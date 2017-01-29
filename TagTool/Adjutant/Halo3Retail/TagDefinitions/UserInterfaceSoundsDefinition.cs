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
	[TagStructure(Class = "uise", Size = 0x140)]
	public class UserInterfaceSoundsDefinition
	{
		public TagInstance Error;
		public TagInstance VerticalNavigation;
		public TagInstance HorizontalNavigation;
		public TagInstance AButton;
		public TagInstance BButton;
		public TagInstance XButton;
		public TagInstance YButton;
		public TagInstance StartButton;
		public TagInstance BackButton;
		public TagInstance LeftBumper;
		public TagInstance RightBumper;
		public TagInstance LeftTrigger;
		public TagInstance RightTrigger;
		public TagInstance TimerSound;
		public TagInstance TimerSoundZero;
		public TagInstance AltTimerSound;
		public TagInstance SecondAltTimerSound;
		public TagInstance MatchmakingAdvanceSound;
		public TagInstance RankUp;
		public TagInstance MatchmakingPartyUpSound;
	}
}
