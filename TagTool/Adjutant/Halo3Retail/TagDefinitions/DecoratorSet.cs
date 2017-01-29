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
	[TagStructure(Class = "dctr", Size = 0x80)]
	public class DecoratorSet
	{
		public TagInstance Model;
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public int Unknown4;
		public TagInstance Texture;
		public short AffectsVisibility;
		public short Unknown5;
		public float ColorR;
		public float ColorG;
		public float ColorB;
		public uint Unknown6;
		public uint Unknown7;
		public uint Unknown8;
		public uint Unknown9;
		public uint Unknown10;
		public float BrightnessBase;
		public float BrightnessShadow;
		public uint Unknown11;
		public uint Unknown12;
		public uint Unknown13;
		public uint Unknown14;
		public uint Unknown15;
		public uint Unknown16;
		public uint Unknown17;
		public uint Unknown18;
		public uint Unknown19;
	}
}
