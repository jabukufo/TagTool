using System;
using System.Collections.Generic;
using TagTool.Common;
using TagTool.Geometry;
using TagTool.Serialization;

namespace TagTool.Tags.Definitions
{
    [TagStructure(Name = "collision_model", Class = "coll", Size = 0x44)]
    public class CollisionModel
    {
        public int CollisionModelChecksum;
        public List<Error> Errors;
        public uint Flags;
        public List<Material> Materials;
        public List<Region> Regions;
        public List<PathfindingSphere> PathfindingSpheres;
        public List<Node> Nodes;

        [TagStructure]
        public class Error
        {
            [TagField(Length = 32)]
            public string Name;
            public ErrorType ReportType;
            public byte Unused1;
            public ErrorFlags Flags;
            public short RuntimeGenerationFlags;
            public short Unused2;
            public int Unused3;
            public List<Report> Reports;

            [Flags]
            public enum ErrorFlags : ushort
            {
                None = 0,
                Rendered = 1 << 0,
                TangentSpace = 1 << 1,
                NonCritical = 1 << 2,
                LightmapLight = 1 << 3,
                ReportKeyIsValid = 1 << 4
            }

            public enum ErrorType : sbyte
            {
                Silent,
                Comment,
                Warning,
                Error
            }

            public enum ErrorSource : sbyte
            {
                None,
                Structure,
                Poop,
                Lightmap,
                Pathfinding
            }
            
            [TagStructure]
            public class ErrorVertex
            {
                public RealPoint3d Point;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices;
                [TagField(Count = 4)]
                public float[] NodeWeights;
                public RealArgbColor Color;
                public float ScreenSize;
            }

            [TagStructure]
            public class ErrorVector
            {
                public RealPoint3d Point;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices;
                [TagField(Count = 4)]
                public float[] NodeWeights;
                public RealArgbColor Color;
                public RealPoint3d Normal;
                public float ScreenSize;
            }

            [TagStructure]
            public class ErrorLine
            {
                public RealPoint3d Point1;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices1;
                [TagField(Count = 4)]
                public float[] NodeWeights1;
                public RealPoint3d Point2;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices2;
                [TagField(Count = 4)]
                public float[] NodeWeights2;
                public RealArgbColor Color;
            }

            [TagStructure]
            public class ErrorTriangle
            {
                public RealPoint3d Point1;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices1;
                [TagField(Count = 4)]
                public float[] NodeWeights1;
                public RealPoint3d Point2;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices2;
                [TagField(Count = 4)]
                public float[] NodeWeights2;
                public RealPoint3d Point3;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices3;
                [TagField(Count = 4)]
                public float[] NodeWeights3;
                public RealArgbColor Color;
            }

            [TagStructure]
            public class ErrorQuad
            {
                public RealPoint3d Point1;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices1;
                [TagField(Count = 4)]
                public float[] NodeWeights1;
                public RealPoint3d Point2;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices2;
                [TagField(Count = 4)]
                public float[] NodeWeights2;
                public RealPoint3d Point3;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices3;
                [TagField(Count = 4)]
                public float[] NodeWeights3;
                public RealPoint3d Point4;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices4;
                [TagField(Count = 4)]
                public float[] NodeWeights4;
                public RealArgbColor Color;
            }

            [TagStructure]
            public class ErrorComment
            {
                public byte[] TextData;
                public RealPoint3d Point;
                [TagField(Count = 4)]
                public sbyte[] NodeIndices;
                [TagField(Count = 4)]
                public float[] NodeWeights;
            }

            [TagStructure]
            public class Report
            {
                public ErrorType Type;
                public ErrorSource Source;
                public ErrorFlags Flags;
                public byte[] TextData;
                public int SourceIdentifier;
                public List<ErrorVertex> Vertices;
                public List<ErrorVector> Vectors;
                public List<ErrorLine> Lines;
                public List<ErrorTriangle> Triangles;
                public List<ErrorComment> Comments;
                public int ReportKey;
                public int NodeIndex;
                public Range<float> BoundsX;
                public Range<float> BoundsY;
                public Range<float> BoundsZ;
                public RealArgbColor Color;
            }
        }

        [TagStructure(Size = 0x4)]
        public class Material
        {
            public StringId Name;
        }

        [TagStructure(Size = 0x10)]
        public class Region
        {
            public StringId Name;
            public List<Permutation> Permutations;

            [TagStructure(Size = 0x28)]
            public class Permutation
            {
                public StringId Name;
                public List<Bsp> Bsps;
                public List<BspPhysic> BspPhysics;
                public List<CollisionMoppCode> BspMoppCodes;

                [TagStructure(Size = 0x64)]
                public class Bsp
                {
                    public short NodeIndex;
                    public short Padding;
                    public CollisionGeometry Geometry;
                }

                [TagStructure(Size = 0x80)]
                public class BspPhysic
                {
                    public uint Unknown;
                    public short Size;
                    public short Count;
                    public int Offset;
                    public int Unknown2;
                    public uint Unknown3;
                    public uint Unknown4;
                    public uint Unknown5;
                    public uint Unknown6;
                    public uint Unknown7;
                    public uint Unknown8;
                    public uint Unknown9;
                    public uint Unknown10;
                    public uint Unknown11;
                    public uint Unknown12;
                    public uint Unknown13;
                    public uint Unknown14;
                    [TagField(Flags = TagFieldFlags.Short)] public TagInstance Model;
                    public uint Unknown15;
                    public uint Unknown16;
                    public short Unknown17;
                    public short Unknown18;
                    public uint Unknown19;
                    public uint Unknown20;
                    public uint Unknown21;
                    public uint Unknown22;
                    public uint Unknown23;
                    public short Size2;
                    public short Count2;
                    public int Offset2;
                    public int Unknown24;
                    public uint Unknown25;
                    public uint Unknown26;
                    public uint Unknown27;
                    public uint Unknown28;
                }
            }
        }

        [Flags]
        public enum PathfindingSphereFlags : ushort
        {
            None = 0,
            RemainsWhenOpen = 1 << 0,
            VehicleOnly = 1 << 1,
            WithSectors = 1 << 2
        }

        [TagStructure(Size = 0x14)]
        public class PathfindingSphere
        {
            public short Node;
            public PathfindingSphereFlags Flags;
            public RealPoint3d Center;
            public float Radius;
        }

        [Flags]
        public enum NodeFlags : ushort
        {
            None = 0,
            GenerateNavMesh = 1 << 0
        }

        [TagStructure(Size = 0xC)]
        public class Node
        {
            public StringId Name;
            public NodeFlags Flags;
            public short ParentNode;
            public short NextSiblingNode;
            public short FirstChildNode;
        }
    }
}
