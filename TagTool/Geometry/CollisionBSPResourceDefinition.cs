using System.Collections.Generic;
using TagTool.Serialization;

namespace TagTool.Geometry
{
    [TagStructure(Size = 0x30)]
    public class CollisionBspResourceDefinition
    {
        public List<CollisionGeometry> CollisionBsps;
        public List<CollisionGeometry> LargeCollisionBsps;
        public List<Compression> Compressions;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;
        
        [TagStructure(Size = 0xC8)]
        public class Compression
        {
            public float X;
            public float Y;
            public float Z;
            public float W;
            public float R;
            public CollisionGeometry CollisionBsp;
            public int Unknown13;
            public List<CollisionGeometry> CollisionBsps;
            public List<CollisionMoppCode> CollisionMoppCodes;
            public List<Unknown1Block> Unknown1;
            public List<Unknown2Block> Unknown2;
            public List<Unknown3Block> Unknown3;
            public short Index01;
            public short Index02;
            public int Unknown10;
            public List<CollisionMoppCode> CollisionMoppCodes2;
            public int Unknown11;

            [TagStructure]
            public class Unknown1Block
            {
                public uint Unknown;
            }

            [TagStructure]
            public class Unknown2Block
            {
                public uint Unknown;
                public uint Unknown2;
            }

            [TagStructure]
            public class Unknown3Block
            {
                public uint Unknown;
            }
        }
    }
}