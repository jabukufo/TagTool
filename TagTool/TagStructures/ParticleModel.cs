using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Common;
using TagTool.Resources;
using TagTool.Resources.Geometry;
using TagTool.Serialization;

namespace TagTool.TagStructures
{
    [TagStructure(Name = "particle_model", Class = "pmdf", Size = 0x90)]
    public class ParticleModel
    {
        public GeometryReference Geometry;
        public List<UnknownBlock3> Unknown10;

        [TagStructure(Size = 0x10)]
        public class UnknownBlock3
        {
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;
        }
    }
}
