using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineTagTool.Serialization;

namespace HaloOnlineTagTool.Resources.Geometry
{
    [TagStructure(Name = "model_animation_tag_resource", Size = 0xC)]
    public class ModelAnimationResourceDefinition
    {
        public List<Animation> GroupMembers;

        [TagStructure]
        public class Animation
        {
            public StringId Name;
            public uint Checksum;
            public short FrameCount;
            public sbyte NodeCount;
            public AnimationMovementDataType MovementDataType;

            public byte BlockType;
            public byte Unknown4;
            public byte Unknown5;
            public byte Unknown6;
            public int Size;
            public int Unknown7;
            public int Unknown8;
            public int Unknown9;
            public int Unknown10;

            public enum AnimationMovementDataType : sbyte
            {
                None,
                dx_dy,
                dx_dy_dyaw,
                dx_dy_dz_dyaw,
                dx_dy_dz_dangleaxis,
                x_y_z_absolute,
                Auto
            }
        }
    }
}
