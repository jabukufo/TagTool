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
            public sbyte Unknown0;
            public sbyte Unknown1;
            public short Unknown2;
            public uint FramesBlockOffset;
            public int Unknown3;
            public uint NodesFlagsOffset;
            
            // public PrimaryNodeFlags StaticNodesPrimary;
            // public SecondaryNodeFlags StaticNodesSecondary;
            // public PrimaryNodeFlags AnimatedNodesPrimary;
            // public SecondaryNodeFlags AnimatedNodesSecondary;

            public ResourceDataReference AnimationData; // this will point to an Animation object

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
            
            [Flags]
            public enum PrimaryNodeFlags : int
            {
                None = 0,
                Node0 = 1 << 0,
                Node1 = 1 << 1,
                Node2 = 1 << 2,
                Node3 = 1 << 3,
                Node4 = 1 << 4,
                Node5 = 1 << 5,
                Node6 = 1 << 6,
                Node7 = 1 << 7,
                Node8 = 1 << 8,
                Node9 = 1 << 9,
                Node10 = 1 << 10,
                Node11 = 1 << 11,
                Node12 = 1 << 12,
                Node13 = 1 << 13,
                Node14 = 1 << 14,
                Node15 = 1 << 15,
                Node16 = 1 << 16,
                Node17 = 1 << 17,
                Node18 = 1 << 18,
                Node19 = 1 << 19,
                Node20 = 1 << 20,
                Node21 = 1 << 21,
                Node22 = 1 << 22,
                Node23 = 1 << 23,
                Node24 = 1 << 24,
                Node25 = 1 << 25,
                Node26 = 1 << 26,
                Node27 = 1 << 27,
                Node28 = 1 << 28,
                Node29 = 1 << 29,
                Node30 = 1 << 30,
                Node31 = 1 << 31
            }

            [Flags]
            public enum SecondaryNodeFlags : int
            {
                None = 0,
                Node32 = 1 << 32,
                Node33 = 1 << 33,
                Node34 = 1 << 34,
                Node35 = 1 << 35,
                Node36 = 1 << 36,
                Node37 = 1 << 37,
                Node38 = 1 << 38,
                Node39 = 1 << 39,
                Node40 = 1 << 40,
                Node41 = 1 << 41,
                Node42 = 1 << 42,
                Node43 = 1 << 43,
                Node44 = 1 << 44,
                Node45 = 1 << 45,
                Node46 = 1 << 46,
                Node47 = 1 << 47,
                Node48 = 1 << 48,
                Node49 = 1 << 49,
                Node50 = 1 << 50,
                Node51 = 1 << 51,
                Node52 = 1 << 52,
                Node53 = 1 << 53,
                Node54 = 1 << 54,
                Node55 = 1 << 55,
                Node56 = 1 << 56,
                Node57 = 1 << 57,
                Node58 = 1 << 58,
                Node59 = 1 << 59,
                Node60 = 1 << 60,
                Node61 = 1 << 61,
                Node62 = 1 << 62,
                Node63 = 1 << 63
            }

            public class Animation
            {
                // idk if this is the best way to declare this byte, honestly
                public byte[] unknown = new byte[0xc];

                // this used to be default_block
                public uint rotational_positional_size;
                public uint default_block_size;
                public Rotation[] default_node_rotations;
                public Position[] default_node_positions;
                public byte unknown1;
                public byte unknown2;
                public byte unknown3;
                public byte unknown4;
                public float unknown5;
                public float unknown6;

                // this used to be frames_block
                public uint camera_frames_size; // the size of all camera frames
                public uint frames_block_size; // the size of all frames, plus this header + the footer
                public uint unknown7;
                public uint unknown8;
                public uint unknown9;
                public Frame[] frames;
                public uint unknown10;

                // this used to be footer
                public NodesBitfield StaticNodesPrimary; 
                public NodesBitfield StaticNodesSecondary;
                public NodesBitfield UnknownBitfield; // might not be a bitfield, but its right between bitfields so assuming so
                public NodesBitfield AnimatedNodesPrimary;
                public NodesBitfield AnimatedNodesSecondary;
                public uint unknown11;
            }

            public class Rotation
            {
                public short x;
                public short y;
                public short z;
                public short w;
            }

            public class Position
            {
                public float x;
                public float y;
                public float z;
            }

            public class Frame
            {
                public Rotation rotational_data;
            }

            public class NodesBitfield
            {
                public PrimaryNodeFlags primary;
                public SecondaryNodeFlags secondary;
            }
        }
    }
}
