﻿using TagTool.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Common
{
    [TagStructure(Size = 0x10)]
    public class TagReferenceBlock
    {
        public TagInstance Reference;
    }
}
