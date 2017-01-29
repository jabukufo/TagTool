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
	[TagStructure(Class = "jmrq", Size = 0xC)]
	public class SandboxTextValuePairDefinition
	{
		public List<SandboxTextValuePair> SandboxTextValuePairs;

		[TagStructure(Size = 0x10)]
		public class SandboxTextValuePair
		{
			public StringID ParameterName;
			public List<TextValuePair> TextValuePairs;

			[TagStructure(Size = 0x14)]
			public class TextValuePair
			{
				public FlagsValue Flags;
				public ExpectedValueTypeValue ExpectedValueType;
				public short Unknown;
				public int IntValue;
				public StringID RefName;
				public StringID Name;
				public StringID Description;

				public enum FlagsValue : byte
				{
					None,
					Default,
					Unchanged,
					_2 = 4,
					_3 = 8,
					Bit4 = 16,
					Bit5 = 32,
					Bit6 = 64,
					Bit7 = 128,
				}

				public enum ExpectedValueTypeValue : sbyte
				{
					IntegerIndex,
					StringidReference,
					Incremental,
				}
			}
		}
	}
}
