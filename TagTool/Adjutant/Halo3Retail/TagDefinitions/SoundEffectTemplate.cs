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
	[TagStructure(Class = "<fx>", Size = 0x1C)]
	public class SoundEffectTemplate
	{
		public uint TemplateCollectionBlock;
		public uint TemplateCollectionBlock2;
		public uint TemplateCollectionBlock3;
		public int InputEffectName;
		public List<AdditionalSoundInput> AdditionalSoundInputs;

		[TagStructure(Size = 0x1C)]
		public class AdditionalSoundInput
		{
			public StringID DspEffect;
			public byte[] LowFrequencySoundFunction;
			public float TimePeriod;
		}
	}
}
