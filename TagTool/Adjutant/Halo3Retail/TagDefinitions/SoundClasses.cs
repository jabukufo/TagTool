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
	[TagStructure(Class = "sncl", Size = 0xC)]
	public class SoundClasses
	{
		public List<SoundClass> SoundClasses2;

		[TagStructure(Size = 0x98)]
		public class SoundClass
		{
			public short MaxSoundsPerTag;
			public short MaxSoundsPerObject;
			public int PreemptionTime;
			public InternalFlagsValue InternalFlags;
			public FlagsValue Flags;
			public short Priority;
			public CacheMissModeValue CacheMissMode;
			public float ReverbGain;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
			public float Unknown4;
			public float Unknown5;
			public uint Unknown6;
			public uint Unknown7;
			public float Unknown8;
			public float Unknown9;
			public float Unknown10;
			public float DistanceBoundsMin;
			public float DistanceBoundsMax;
			public float GainBoundsMin;
			public float GainBoundsMax;
			public float CutsceneDucking;
			public float CutsceneDuckingFadeInTime;
			public float CutsceneDuckingSustain;
			public float CutsceneDuckingFadeOutTime;
			public float ScriptedDialogDucking;
			public float ScriptedDialogDuckingFadeIn;
			public uint Unknown11;
			public float Unknown12;
			public float Unknown13;
			public float Unknown14;
			public uint Unknown15;
			public float Unknown16;
			public float Unknown17;
			public float DopplerFactor;
			public StereoPlaybackTypeValue StereoPlaybackType;
			public sbyte Unknown18;
			public sbyte Unknown19;
			public sbyte Unknown20;
			public float TransmissionMultiplier;
			public float ObstructionMaxBend;
			public float OcclusionMaxBend;
			public int Unknown21;

			public enum InternalFlagsValue : ushort
			{
				None,
				Valid,
				IsSpeech,
				Scripted = 4,
				StopsWithObject = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Multilingual = 128,
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}

			public enum FlagsValue : ushort
			{
				None,
				PlaysDuringPause,
				DryStereoMix,
				NoObjectObstruction = 4,
				UseCenterSpeakerUnspatialized = 8,
				SendMonoToLfe = 16,
				Deterministic = 32,
				UseHugeTransmission = 64,
				AlwaysUseSpeakers = 128,
				DonTStripFromMainmenu = 256,
				IgnoreStereoHeadroom = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}

			public enum CacheMissModeValue : short
			{
				Discard,
				Postpone,
			}

			public enum StereoPlaybackTypeValue : sbyte
			{
				FirstPerson,
				Ambient,
			}
		}
	}
}
