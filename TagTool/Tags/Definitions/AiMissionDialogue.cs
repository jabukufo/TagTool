﻿using System.Collections.Generic;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Tags.Definitions
{
    [TagStructure(Name = "ai_mission_dialogue", Class = "mdlg", Size = 0xC)]
    public class AiMissionDialogue
    {
        public List<Line> Lines;

        [TagStructure(Size = 0x14)]
        public class Line
        {
            public StringId Name;
            public List<Variant> Variants;
            public StringId DefaultSoundEffect;

            [TagStructure(Size = 0x18)]
            public class Variant
            {
                public StringId Designation;
                public TagInstance Sound;
                public StringId SoundEffect;
            }
        }
    }
}
