using System;
using System.Collections.Generic;
using TagTool.Cache.HaloOnline;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Geometry
{
    [TagStructure(Name = "model_animation_tag_resource", Size = 0xC)]
    public class ModelAnimationResourceDefinition
    {
        public List<GroupMember> GroupMembers;

        [TagStructure]
        public class GroupMember
        {
            public StringID Name;
            public uint Checksum;
            public short FrameCount;
            public sbyte NodeCount;
            public GroupMemberMovementDataType MovementDataType;
            public sbyte unknown0;
            public sbyte unknown1;
            public short unknown2;
            public uint FramesBlockOffset;
            public int unknown3;
            public uint NodesFlagsOffset;
            public ResourceDataReference AnimationData;

            public enum GroupMemberMovementDataType : sbyte
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
