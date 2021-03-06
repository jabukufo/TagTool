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
	[TagStructure(Class = "snmx", Size = 0x70)]
	public class SoundMix
	{
		public float LeftStereoGain;
		public float RightStereoGain;
		public float LeftStereoGain2;
		public float RightStereoGain2;
		public float LeftStereoGain3;
		public float RightStereoGain3;
		public float FrontSpeakerGain;
		public float RearSpeakerGain;
		public float FrontSpeakerGain2;
		public float RearSpeakerGain2;
		public float MonoUnspatializedGain;
		public float StereoTo3dGain;
		public float RearSurroundToFrontStereoGain;
		public float FrontSpeakerGain3;
		public float CenterSpeakerGain;
		public float FrontSpeakerGain4;
		public float CenterSpeakerGain2;
		public float StereoUnspatializedGain;
		public float SoloPlayerFadeOutDelay;
		public float SoloPlayerFadeOutTime;
		public float SoloPlayerFadeInTime;
		public float GameMusicFadeOutTime;
		public TagInstance Unknown;
		public float Unknown2;
		public float Unknown3;
	}
}
