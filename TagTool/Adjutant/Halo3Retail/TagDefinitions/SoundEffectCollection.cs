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
	[TagStructure(Class = "sfx+", Size = 0xC)]
	public class SoundEffectCollection
	{
		public List<SoundEffect> SoundEffects;

		[TagStructure(Size = 0x4C)]
		public class SoundEffect
		{
			public StringID Name;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public FlagsValue Flags;
			public uint Unknown4;
			public uint Unknown5;
			public List<FilterBlock> Filter;
			public List<PitchLfoBlock> PitchLfo;
			public List<FilterLfoBlock> FilterLfo;
			public List<SoundEffectBlock> SoundEffect2;

			public enum FlagsValue : int
			{
				None,
				Use3dRadioHack,
			}

			[TagStructure(Size = 0x48)]
			public class FilterBlock
			{
				public int FilterType;
				public int FilterWidth;
				public uint LeftFreqScaleMin;
				public uint LeftFreqScaleMax;
				public uint LeftFreqRandomBaseVarianceMin;
				public uint LeftFreqRandomBaseVarianceMax;
				public uint LeftGainScaleMin;
				public uint LeftGainScaleMax;
				public uint LeftGainRandomBaseVarianceMin;
				public uint LeftGainRandomBaseVarianceMax;
				public uint RightFreqScaleMin;
				public uint RightFreqScaleMax;
				public uint RightFreqRandomBaseVarianceMin;
				public uint RightFreqRandomBaseVarianceMax;
				public uint RightGainScaleMin;
				public uint RightGainScaleMax;
				public uint RightGainRandomBaseVarianceMin;
				public uint RightGainRandomBaseVarianceMax;
			}

			[TagStructure(Size = 0x30)]
			public class PitchLfoBlock
			{
				public uint DelayScaleMin;
				public uint DelayScaleMax;
				public uint DelayRandomBaseVarianceMin;
				public uint DelayRandomBaseVarianceMax;
				public uint FreqScaleMin;
				public uint FreqScaleMax;
				public uint FreqRandomBaseVarianceMin;
				public uint FreqRandomBaseVarianceMax;
				public uint PitchModScaleMin;
				public uint PitchModScaleMax;
				public uint PitchModRandomBaseVarianceMin;
				public uint PitchModRandomBaseVarianceMax;
			}

			[TagStructure(Size = 0x30)]
			public class FilterLfoBlock
			{
				public uint DelayScaleMin;
				public uint DelayScaleMax;
				public uint DelayRandomBaseVarianceMin;
				public uint DelayRandomBaseVarianceMax;
				public uint FreqScaleMin;
				public uint FreqScaleMax;
				public uint FreqRandomBaseVarianceMin;
				public uint FreqRandomBaseVarianceMax;
				public uint CutoffModScaleMin;
				public uint CutoffModScaleMax;
				public uint CutoffModRandomBaseVarianceMin;
				public uint CutoffModRandomBaseVarianceMax;
				public uint GainModScaleMin;
				public uint GainModScaleMax;
				public uint GainModRandomBaseVarianceMin;
				public uint GainModRandomBaseVarianceMax;
			}

			[TagStructure(Size = 0x48)]
			public class SoundEffectBlock
			{
				public TagInstance Unknown;
				public List<Component> Components;
				public List<TemplateCollectionBlock> TemplateCollection;
				public uint Unknown2;
				public uint Unknown3;
				public uint Unknown4;
				public uint Unknown5;
				public uint Unknown6;
				public uint Unknown7;
				public uint Unknown8;
				public uint Unknown9;

				[TagStructure(Size = 0x18)]
				public class Component
				{
					public TagInstance Sound;
					public uint Gain;
					public int Flags;
				}

				[TagStructure(Size = 0x10)]
				public class TemplateCollectionBlock
				{
					public StringID DspEffect;
					public List<Parameter> Parameters;

					[TagStructure(Size = 0x2C)]
					public class Parameter
					{
						public StringID Name;
						public uint Unknown;
						public uint Unknown2;
						public uint HardwareOffset;
						public uint Unknown3;
						public uint DefaultScalarValue;
						public byte[] Function;
					}
				}
			}
		}
	}
}
