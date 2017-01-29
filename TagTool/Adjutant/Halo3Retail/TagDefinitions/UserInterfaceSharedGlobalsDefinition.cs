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
	[TagStructure(Class = "wigl", Size = 0x160)]
	public class UserInterfaceSharedGlobalsDefinition
	{
		public short IncTextUpdatePeriod;
		public short IncTextBlockCharacter;
		public float NearClipPlaneDistance;
		public float ProjectionPlaneDistance;
		public float FarClipPlaneDistance;
		public TagInstance GlobalStrings;
		public TagInstance DamageTypeStrings;
		public TagInstance MainMenuMusic;
		public int MusicFadeTime;
		public float ColorA;
		public float ColorR;
		public float ColorG;
		public float ColorB;
		public float TextStrokeColorA;
		public float TextStrokeColorR;
		public float TextStrokeColorG;
		public float TextStrokeColorB;
		public List<TextColor> TextColors;
		public List<PlayerColor> PlayerColors;
		public TagInstance UiSounds;
		public List<Alert> Alerts;
		public List<Dialog> Dialogs;
		public List<GlobalDataSource> GlobalDataSources;
		public float WidescreenBitmapScaleX;
		public float WidescreenBitmapScaleY;
		public float StandardBitmapScaleX;
		public float StandardBitmapScaleY;
		public float MenuBlurX;
		public float MenuBlurY;
		[TagField(Length = 32)] public string UiSpartanBipedName;
		[TagField(Length = 32)] public string UiSpartanAiSquadName;
		public StringID UiSpartanAiLocationName;
		[TagField(Length = 32)] public string UiEliteBipedName;
		[TagField(Length = 32)] public string UiEliteAiSquadName;
		public StringID UiEliteAiLocationName;
		public int SingleScrollSpeed;
		public int ScrollSpeedTransitionWaitTime;
		public int HeldScrollSpeed;
		public int AttractVideoIdleWait;

		[TagStructure(Size = 0x14)]
		public class TextColor
		{
			public StringID Name;
			public float ColorA;
			public float ColorR;
			public float ColorG;
			public float ColorB;
		}

		[TagStructure(Size = 0x30)]
		public class PlayerColor
		{
			public List<PlayerTextColorBlock> PlayerTextColor;
			public List<TeamTextColorBlock> TeamTextColor;
			public List<PlayerUiColorBlock> PlayerUiColor;
			public List<TeamUiColorBlock> TeamUiColor;

			[TagStructure(Size = 0x10)]
			public class PlayerTextColorBlock
			{
				public float ColorA;
				public float ColorR;
				public float ColorG;
				public float ColorB;
			}

			[TagStructure(Size = 0x10)]
			public class TeamTextColorBlock
			{
				public float ColorA;
				public float ColorR;
				public float ColorG;
				public float ColorB;
			}

			[TagStructure(Size = 0x10)]
			public class PlayerUiColorBlock
			{
				public float ColorA;
				public float ColorR;
				public float ColorG;
				public float ColorB;
			}

			[TagStructure(Size = 0x10)]
			public class TeamUiColorBlock
			{
				public float ColorA;
				public float ColorR;
				public float ColorG;
				public float ColorB;
			}
		}

		[TagStructure(Size = 0x10)]
		public class Alert
		{
			public StringID Name;
			public FlagsValue Flags;
			public sbyte Unknown;
			public IconValue Icon;
			public sbyte Unknown2;
			public StringID Title;
			public StringID Body;

			public enum FlagsValue : byte
			{
				None,
				Bit0,
				Bit1,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
			}

			public enum IconValue : sbyte
			{
				None,
				Download,
				Pause,
				Upload,
				Checkbox,
			}
		}

		[TagStructure(Size = 0x28)]
		public class Dialog
		{
			public StringID Name;
			public short Unknown;
			public short Unknown2;
			public StringID Title;
			public StringID Body;
			public StringID Option1;
			public StringID Option2;
			public StringID Option3;
			public StringID Option4;
			public StringID KeyLegend;
			public DefaultOptionValue DefaultOption;
			public short Unknown3;

			public enum DefaultOptionValue : short
			{
				Option1,
				Option2,
				Option3,
				Option4,
			}
		}

		[TagStructure(Size = 0x10)]
		public class GlobalDataSource
		{
			public TagInstance DataSource;
		}
	}
}
