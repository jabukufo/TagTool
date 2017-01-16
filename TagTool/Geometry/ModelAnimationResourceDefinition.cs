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
            public GroupMemberFrameEventType FrameEvents;
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
            public enum GroupMemberFrameEventType : int
            {
                none = 0,
                primary_keyframe = 1 << 0,
                secondary_keyframe = 1 << 1,
                tertiary_keyframe = 1 << 2,
                left_foot = 1 << 3,
                right_foot = 1 << 4,
                allow_interruption = 1 << 5,
                do_not_allow_interruption = 1 << 6,
                both_feet_shuffle = 1 << 7,
                body_impact = 1 << 8,
                left_foot_lock = 1 << 9,
                left_foot_unlock = 1 << 10,
                right_foot_lock = 1 << 11,
                right_foot_unlock = 1 << 12,
                blend_range_marker = 1 << 13,
                stride_expansion = 1 << 14,
                stride_contraction = 1 << 15,
                ragdoll_keyframe = 1 << 16,
                drop_weapon_keyframe = 1 << 17,
                match_a = 1 << 18,
                match_b = 1 << 19,
                match_c = 1 << 20,
                match_d = 1 << 21,
                jetpack_closed = 1 << 22,
                jetpack_open = 1 << 23,
                sound_event = 1 << 24,
                effect_event = 1 << 25,
                left_hand = 1 << 26,
                right_hand = 1 << 27,
                start_bamf = 1 << 28,
                end_bamf = 1 << 29,
                hide = 1 << 30
            }
        }
    }
}
