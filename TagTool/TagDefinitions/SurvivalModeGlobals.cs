using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "survival_mode_globals", Class = "smdt", Size = 0x48)]
    public class SurvivalModeGlobals
    {
        public uint Unknown;
        public CachedTagInstance InGameStrings;
        public CachedTagInstance TimerSound;
        public CachedTagInstance TimerSoundZero;
        public List<SurvivalEvent> SurvivalEvents;
        public uint Unknown2;
        public uint Unknown3;

        [TagStructure(Size = 0x10C)]
        public class SurvivalEvent
        {
            public ushort Flags;
            public TypeValue Type;
            public StringId Event;
            public AudienceValue Audience;
            public short Unknown;
            public short Unknown2;
            public TeamValue Team;
            public StringId DisplayString;
            public StringId DisplayMedal;
            public uint Unknown3;
            public float DisplayDuration;
            public RequiredFieldValue RequiredField;
            public ExcludedAudienceValue ExcludedAudience;
            public RequiredField2Value RequiredField2;
            public ExcludedAudience2Value ExcludedAudience2;
            public StringId PrimaryString;
            public int PrimaryStringDuration;
            public StringId PluralDisplayString;
            public float SoundDelayAnnouncerOnly;
            public ushort SoundFlags;
            public short Unknown4;
            public CachedTagInstance EnglishSound;
            public CachedTagInstance JapaneseSound;
            public CachedTagInstance GermanSound;
            public CachedTagInstance FrenchSound;
            public CachedTagInstance SpanishSound;
            public CachedTagInstance LatinAmericanSpanishSound;
            public CachedTagInstance ItalianSound;
            public CachedTagInstance KoreanSound;
            public CachedTagInstance ChineseTraditionalSound;
            public CachedTagInstance ChineseSimplifiedSound;
            public CachedTagInstance PortugueseSound;
            public CachedTagInstance PolishSound;
            public uint Unknown5;
            public uint Unknown6;
            public uint Unknown7;
            public uint Unknown8;

            public enum TypeValue : short
            {
                General,
                Flavor,
                Slayer,
                CaptureTheFlag,
                Oddball,
                Unused,
                KingOfTheHill,
                Vip,
                Juggernaut,
                Territories,
                Assault,
                Infection,
                Survival,
                Unknown,
            }

            public enum AudienceValue : short
            {
                CausePlayer,
                CauseTeam,
                EffectPlayer,
                EffectTeam,
                All,
            }

            public enum TeamValue : short
            {
                NonePlayerOnly,
                Cause,
                Effect,
                All,
            }

            public enum RequiredFieldValue : short
            {
                None,
                CausePlayer,
                CauseTeam,
                EffectPlayer,
                EffectTeam,
            }

            public enum ExcludedAudienceValue : short
            {
                None,
                CausePlayer,
                CauseTeam,
                EffectPlayer,
                EffectTeam,
            }

            public enum RequiredField2Value : short
            {
                None,
                CausePlayer,
                CauseTeam,
                EffectPlayer,
                EffectTeam,
            }

            public enum ExcludedAudience2Value : short
            {
                None,
                CausePlayer,
                CauseTeam,
                EffectPlayer,
                EffectTeam,
            }
        }
    }
}
