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
	[TagStructure(Class = "sefc", Size = 0xC)]
	public class AreaScreenEffect
	{
		public List<ScreenEffectBlock> ScreenEffect;

		[TagStructure(Size = 0x84)]
		public class ScreenEffectBlock
		{
			public StringID Name;
			public short Unknown;
			public short Unknown2;
			public float Unknown3;
			public byte[] Function;
			public float Duration;
			public byte[] Function2;
			public byte[] Function3;
			public float LightIntensity;
			public uint PrimaryHue;
			public uint SecondaryHue;
			public float Saturation;
			public float ColorMuting;
			public float Brightness;
			public float Darkness;
			public float ShadowBrightness;
			public float TintR;
			public float TintG;
			public float TintB;
			public float ToneR;
			public float ToneG;
			public float ToneB;
		}
	}
}
