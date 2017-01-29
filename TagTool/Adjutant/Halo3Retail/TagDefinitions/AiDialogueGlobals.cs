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
	[TagStructure(Class = "adlg", Size = 0x4C)]
	public class AiDialogueGlobals
	{
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public uint Unknown4;
		public List<Vocalization> Vocalizations;
		public List<Pattern> Patterns;
		public uint Unknown5;
		public uint Unknown6;
		public uint Unknown7;
		public List<DialogDatum> DialogData;
		public List<InvoluntaryDatum> InvoluntaryData;

		[TagStructure(Size = 0x5C)]
		public class Vocalization
		{
			public StringID Vocalization2;
			public short ParentIndex;
			public short Priority;
			public FlagsValue Flags;
			public short GlanceBehavior;
			public short GlanceRecipient;
			public PerceptionTypeValue PerceptionType;
			public short MaxCombatStatus;
			public short AnimationImpulse;
			public short OverlapPriority;
			public float SoundRepetitionDelay;
			public float AllowableQueueDelay;
			public float PreVocalizationDelay;
			public float NotificationDelay;
			public float PostVocalizationDelay;
			public float RepeatDelay;
			public float Weight;
			public float SpeakerFreezeTime;
			public float ListenerFreezeTime;
			public short SpeakerEmotion;
			public short ListenerEmotion;
			public float SkipFraction1;
			public float SkipFraction2;
			public float SkipFraction3;
			public StringID SampleLine;
			public List<Respons> Responses;

			public enum FlagsValue : int
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
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
				Bit16 = 65536,
				Bit17 = 131072,
				Bit18 = 262144,
				Bit19 = 524288,
				Bit20 = 1048576,
				Bit21 = 2097152,
				Bit22 = 4194304,
				Bit23 = 8388608,
				Bit24 = 16777216,
				Bit25 = 33554432,
				Bit26 = 67108864,
				Bit27 = 134217728,
				Bit28 = 268435456,
				Bit29 = 536870912,
				Bit30 = 1073741824,
				Bit31 = -2147483648,
			}

			public enum PerceptionTypeValue : short
			{
				None,
				Speaker,
				Listener,
			}

			[TagStructure(Size = 0xC)]
			public class Respons
			{
				public StringID VocalizationName;
				public FlagsValue Flags;
				public short VocalizationIndex;
				public short ResponseType;
				public short ImportDialogueIndex;

				public enum FlagsValue : ushort
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
					Bit8 = 256,
					Bit9 = 512,
					Bit10 = 1024,
					Bit11 = 2048,
					Bit12 = 4096,
					Bit13 = 8192,
					Bit14 = 16384,
					Bit15 = 32768,
				}
			}
		}

		[TagStructure(Size = 0x34)]
		public class Pattern
		{
			public short DialogueType;
			public short VocalizationsIndex;
			public StringID VocalizationName;
			public short SpeakerType;
			public FlagsValue Flags;
			public short Hostility;
			public UnknownValue Unknown;
			public short Unknown2;
			public short CauseType;
			public StringID CauseAiTypeName;
			public uint Unknown3;
			public short Unknown4;
			public short Unknown5;
			public short Attitude;
			public short Unknown6;
			public ConditionsValue Conditions;
			public short SpacialRelationship;
			public short DamageType;
			public short Unknown7;
			public short SubjectType;
			public StringID SubjectAiTypeName;

			public enum FlagsValue : ushort
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
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}

			public enum UnknownValue : ushort
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
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}

			public enum ConditionsValue : int
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
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
				Bit16 = 65536,
				Bit17 = 131072,
				Bit18 = 262144,
				Bit19 = 524288,
				Bit20 = 1048576,
				Bit21 = 2097152,
				Bit22 = 4194304,
				Bit23 = 8388608,
				Bit24 = 16777216,
				Bit25 = 33554432,
				Bit26 = 67108864,
				Bit27 = 134217728,
				Bit28 = 268435456,
				Bit29 = 536870912,
				Bit30 = 1073741824,
				Bit31 = -2147483648,
			}
		}

		[TagStructure(Size = 0x4)]
		public class DialogDatum
		{
			public short StartIndex;
			public short Length;
		}

		[TagStructure(Size = 0x4)]
		public class InvoluntaryDatum
		{
			public short InvoluntaryVocalizationIndex;
			public short Unknown;
		}
	}
}
