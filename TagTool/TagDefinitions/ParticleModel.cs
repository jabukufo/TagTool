using System.Collections.Generic;
using TagTool.Geometry;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
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
