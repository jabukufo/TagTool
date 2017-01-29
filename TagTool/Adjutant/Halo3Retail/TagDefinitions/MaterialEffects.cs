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
	[TagStructure(Class = "foot", Size = 0xC)]
	public class MaterialEffects
	{
		public List<Effect> Effects;

		[TagStructure(Size = 0x24)]
		public class Effect
		{
			public List<OldMaterial> OldMaterials;
			public List<Sound> Sounds;
			public List<Effect2> Effects;

			[TagStructure(Size = 0x28)]
			public class OldMaterial
			{
				public TagInstance Effect;
				public TagInstance Sound;
				public StringID MaterialName;
				public short GlobalMaterialIndex;
				public SweetenerModeValue SweetenerMode;
				public sbyte Unknown;

				public enum SweetenerModeValue : sbyte
				{
					SweetenerDefault,
					SweetenerEnabled,
					SweetenerDisabled,
				}
			}

			[TagStructure(Size = 0x28)]
			public class Sound
			{
				public TagInstance Tag;
				public TagInstance SecondaryTag;
				public StringID MaterialName;
				public short GlobalMaterialIndex;
				public SweetenerModeValue SweetenerMode;
				public sbyte Unknown;

				public enum SweetenerModeValue : sbyte
				{
					SweetenerDefault,
					SweetenerEnabled,
					SweetenerDisabled,
				}
			}

			[TagStructure(Size = 0x28)]
			public class Effect2
			{
				public TagInstance Tag;
				public TagInstance SecondaryTag;
				public StringID MaterialName;
				public short GlobalMaterialIndex;
				public SweetenerModeValue SweetenerMode;
				public sbyte Unknown;

				public enum SweetenerModeValue : sbyte
				{
					SweetenerDefault,
					SweetenerEnabled,
					SweetenerDisabled,
				}
			}
		}
	}
}
