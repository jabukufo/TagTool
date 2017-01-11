using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Common;
using TagTool.Resources;
using TagTool.Serialization;

namespace TagTool.TagStructures
{
    [TagStructure(Name = "chud_widget_parallax_data", Class = "cprl", Size = 0x10)]
    public class ChudWidgetParallaxData
    {
        public float Unknown;
        public float Unknown2;
        public uint Unknown3;
        public uint Unknown4;
    }
}
