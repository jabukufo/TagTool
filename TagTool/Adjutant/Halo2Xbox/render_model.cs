﻿using System.IO;



using mode = Adjutant.Library.Definitions.render_model;
using TagTool.Common;
using TagTool.IO;
using TagTool.Geometry;

namespace Adjutant.Library.Definitions.Halo2Xbox
{
    public class render_model : mode
    {
        public render_model(CacheBase Cache, int Address)
        {
            cache = Cache;
            EndianReader Reader = Cache.Reader;
            Reader.SeekTo(Address);

            Name = Cache.Strings.GetItemByID(Reader.ReadInt16());
            //Flags = new Bitmask(Reader.ReadInt32());

            #region BoundingBox Block
            Reader.SeekTo(Address + 20);
            int iCount = Reader.ReadInt32();
            int iOffset = Reader.ReadInt32() - Cache.Magic;
            for (int i = 0; i < iCount; i++)
                BoundingBoxes.Add(new BoundingBox(Cache, iOffset + 56 * i));
            #endregion

            #region Regions Block
            Reader.SeekTo(Address + 28);
            iCount = Reader.ReadInt32();
            iOffset = Reader.ReadInt32() - Cache.Magic;
            for (int i = 0; i < iCount; i++)
                Regions.Add(new Region(Cache, iOffset + 16 * i));
            #endregion

            #region ModelParts Block
            Reader.SeekTo(Address + 36);
            iCount = Reader.ReadInt32();
            iOffset = Reader.ReadInt32() - Cache.Magic;
            for (int i = 0; i < iCount; i++)
                ModelSections.Add(new ModelSection(Cache, iOffset + 92 * i) { FacesIndex = i, VertsIndex = i, NodeIndex = 255 });
            Reader.SeekTo(Address + 72);
            #endregion

            #region Nodes Block
            iCount = Reader.ReadInt32();
            iOffset = Reader.ReadInt32() - Cache.Magic;
            for (int i = 0; i < iCount; i++)
                Nodes.Add(new Node(Cache, iOffset + 96 * i));
            #endregion

            #region MarkerGroups Block
            Reader.SeekTo(Address + 88);
            iCount = Reader.ReadInt32();
            iOffset = Reader.ReadInt32() - Cache.Magic;
            for (int i = 0; i < iCount; i++)
                MarkerGroups.Add(new MarkerGroup(Cache, iOffset + 12 * i));
            #endregion

            #region Shaders Block
            Reader.SeekTo(Address + 96);
            iCount = Reader.ReadInt32();
            iOffset = Reader.ReadInt32() - Cache.Magic;
            for (int i = 0; i < iCount; i++)
                Shaders.Add(new Shader(Cache, iOffset + 32 * i));
            #endregion
        }

        public override void LoadRaw()
        {
            if (RawLoaded) return;

            for (int i = 0; i < ModelSections.Count; i++)
            {
                var section = (Halo2Xbox.render_model.ModelSection)ModelSections[i];
                var data = cache.GetRawFromID(section.rawOffset, section.rawSize);
                var ms = new MemoryStream(data);
                var reader = new EndianReader(ms, EndianFormat.LittleEndian);

                #region Read Submeshes
                for (int j = 0; j < section.rSize[0] / 72; j++)
                {
                    var mesh = new ModelSection.Submesh();
                    reader.SeekTo(section.hSize + section.rOffset[0] + j * 72 + 4);
                    mesh.ShaderIndex = reader.ReadUInt16();
                    mesh.FaceIndex = reader.ReadUInt16();
                    mesh.FaceCount = reader.ReadUInt16();
                    section.Submeshes.Add(mesh);
                }
                #endregion

                reader.SeekTo(40);
                section.Indices = new int[reader.ReadUInt16()];
                section.Vertices = new Vertex[section.vertcount];

                var facetype = 5;
                if (section.facecount * 3 == section.Indices.Length) facetype = 3;
                IndexInfoList.Add(new IndexBufferInfo() { FaceFormat = facetype });
                VertInfoList.Add(new VertexBufferInfo() { VertexCount = section.vertcount });

                #region Get Resource Indices
                int iIndex = 0, vIndex = 0, uIndex = 0, nIndex = 0, bIndex = 0;

                for (int j = 0; j < section.rType.Length; j++)
                {
                    switch (section.rType[j] & 0x0000FFFF)
                    {
                        case 32: iIndex = j;
                            break;

                        case 56:
                            switch ((section.rType[j] & 0xFFFF0000) >> 16)
                            {
                                case 0: vIndex = j;
                                    break;
                                case 1: uIndex = j;
                                    break;
                                case 2: nIndex = j;
                                    break;
                            }
                            break;

                        case 100: bIndex = j;
                            break;
                    }
                }
                #endregion

                reader.SeekTo(108);
                int bCount = reader.ReadUInt16();
                int[] bArr = new int[bCount];
                if (bCount > 0)
                {
                    reader.SeekTo(section.hSize + section.rOffset[bIndex]);
                    for (int j = 0; j < bCount; j++)
                        bArr[j] = reader.ReadByte();
                }

                #region Read Vertices
                for (int j = 0; j < section.vertcount; j++)
                {
                    reader.SeekTo(section.hSize + section.rOffset[vIndex] + ((section.rSize[vIndex] / section.vertcount) * j));
                    var v = new Vertex() { FormatName = "" };
                    var p = new RealQuaternion(
                        ((float)reader.ReadInt16() + (float)0x7FFF) / (float)0xFFFF, 
                        ((float)reader.ReadInt16() + (float)0x7FFF) / (float)0xFFFF, 
                        ((float)reader.ReadInt16() + (float)0x7FFF) / (float)0xFFFF, 0);

                    v.Values.Add(new VertexValue(p, 0, "position", 0));
                    
                    var b = new RealQuaternion();
                    var w = new RealQuaternion();

                    switch (section.type)
                    {
                        case 1:
                            switch (section.bones)
                            {
                                case 0:
                                    section.NodeIndex = 0;
                                    break;
                                case 1:
                                    section.NodeIndex = (bCount > 0) ? bArr[0] : 0;
                                    break;
                            }
                            section.Vertices[j] = v;
                            continue;
                        case 2:
                            switch (section.bones)
                            {
                                case 1:
                                    b = new RealQuaternion(reader.ReadByte(), reader.ReadByte(), 0, 0);
                                    w = new RealQuaternion(1, 0, 0, 0);
                                    break;
                            }
                            break;
                        case 3:
                            switch (section.bones)
                            {
                                case 2:
                                    reader.ReadInt16();
                                    b = new RealQuaternion(reader.ReadByte(), reader.ReadByte(), 0, 0);
                                    w = new RealQuaternion((float)reader.ReadByte() / 255f, (float)reader.ReadByte() / 255f, 0, 0);
                                    break;
                                case 3:
                                    b = new RealQuaternion(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), 0);
                                    w = new RealQuaternion((float)reader.ReadByte() / 255f, (float)reader.ReadByte() / 255f, (float)reader.ReadByte() / 255f, 0);
                                    break;
                                case 4:
                                    reader.ReadInt16();
                                    b = new RealQuaternion(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
                                    w = new RealQuaternion((float)reader.ReadByte() / 255f, (float)reader.ReadByte() / 255f, (float)reader.ReadByte() / 255f, (float)reader.ReadByte() / 255f);
                                    break;
                            }
                            break;
                    }

                    if (bCount > 0)
                    {
                        b.I = (w.I == 0) ? 0 : bArr[(int)b.I];
                        b.J = (w.J == 0) ? 0 : bArr[(int)b.J];
                        b.K = (w.K == 0) ? 0 : bArr[(int)b.K];
                        b.W = (w.W == 0) ? 0 : bArr[(int)b.W];
                    }

                    v.Values.Add(new VertexValue(b, 0, "blendindices", 0));
                    v.Values.Add(new VertexValue(w, 0, "blendweight", 0));

                    section.Vertices[j] = v;
                }
                #endregion

                #region Read UVs and Normals
                for (int j = 0; j < section.vertcount; j++)
                {
                    reader.SeekTo(section.hSize + section.rOffset[uIndex] + (4 * j));
                    var v = section.Vertices[j];
                    var uv = new RealQuaternion(((float)reader.ReadInt16() + (float)0x7FFF) / (float)0xFFFF, ((float)reader.ReadInt16() + (float)0x7FFF) / (float)0xFFFF);
                    v.Values.Add(new VertexValue(uv, 0, "texcoords", 0));
                }
                
                for (int j = 0; j < section.vertcount; j++)
                {
                    reader.SeekTo(section.hSize + section.rOffset[nIndex] + (12 * j));
                    var v = section.Vertices[j];
                    var n = RealQuaternion.FromHenDN3(reader.ReadUInt32());
                    v.Values.Add(new VertexValue(n, 0, "normal", 0));
                }
                #endregion

                ModelFunctions.DecompressVertex(ref section.Vertices, BoundingBoxes[0]);

                reader.SeekTo(section.hSize + section.rOffset[iIndex]);
                for (int j = 0; j < section.Indices.Length; j++)
                    section.Indices[j] = reader.ReadUInt16();
            }

            RawLoaded = true;
        }

        new public class Region : mode.Region
        {
            public Region(CacheBase Cache, int Address)
            {
                EndianReader Reader = Cache.Reader;
                Reader.SeekTo(Address);

                Name = Cache.Strings.GetItemByID(Reader.ReadInt16());
                Reader.ReadInt16();
                Reader.ReadInt32();

                int iCount = Reader.ReadInt32();
                int iOffset = Reader.ReadInt32() - Cache.Magic;
                for (int i = 0; i < iCount; i++)
                    Permutations.Add(new Permutation(Cache, iOffset + 16 * i));
            }

            new public class Permutation : mode.Region.Permutation
            {
                public Permutation(CacheBase Cache, int Address)
                {
                    EndianReader Reader = Cache.Reader;
                    Reader.SeekTo(Address);

                    Name = Cache.Strings.GetItemByID(Reader.ReadInt16());
                    Reader.ReadInt16();
                    
                    Reader.Skip(4);
                    Reader.Skip(6);
                    PieceIndex = Reader.ReadInt16();
                    PieceCount = 1;
                }
            }
        }

        new public class Node : mode.Node
        {
            public Node(CacheBase Cache, int Address)
            {
                EndianReader Reader = Cache.Reader;
                Reader.SeekTo(Address);

                Name = Cache.Strings.GetItemByID(Reader.ReadInt16());
                Reader.ReadInt16();
                ParentIndex = Reader.ReadInt16();
                FirstChildIndex = Reader.ReadInt16();
                NextSiblingIndex = Reader.ReadInt16();
                Reader.ReadInt16();
                Position = new RealQuaternion(
                    Reader.ReadSingle(), 
                    Reader.ReadSingle(),
                    Reader.ReadSingle());
                Rotation = new RealQuaternion(
                    Reader.ReadSingle(),
                    Reader.ReadSingle(),
                    Reader.ReadSingle(),
                    Reader.ReadSingle());

                TransformScale = Reader.ReadSingle();

                TransformMatrix = new RealMatrix4x3();

                TransformMatrix.m11 = Reader.ReadSingle();
                TransformMatrix.m12 = Reader.ReadSingle();
                TransformMatrix.m13 = Reader.ReadSingle();

                TransformMatrix.m21 = Reader.ReadSingle();
                TransformMatrix.m22 = Reader.ReadSingle();
                TransformMatrix.m23 = Reader.ReadSingle();

                TransformMatrix.m31 = Reader.ReadSingle();
                TransformMatrix.m32 = Reader.ReadSingle();
                TransformMatrix.m33 = Reader.ReadSingle();

                TransformMatrix.m41 = Reader.ReadSingle();
                TransformMatrix.m42 = Reader.ReadSingle();
                TransformMatrix.m43 = Reader.ReadSingle();

                DistanceFromParent = Reader.ReadSingle();
            }
        }

        new public class MarkerGroup : mode.MarkerGroup
        {
            public MarkerGroup(CacheBase Cache, int Address)
            {
                EndianReader Reader = Cache.Reader;
                Reader.SeekTo(Address);

                Name = Cache.Strings.GetItemByID(Reader.ReadInt16());
                Reader.ReadInt16();

                int iCount = Reader.ReadInt32();
                int iOffset = Reader.ReadInt32() - Cache.Magic;
                for (int i = 0; i < iCount; i++)
                    Markers.Add(new Marker(Cache, iOffset + 36 * i));
            }

            new public class Marker : mode.MarkerGroup.Marker
            {
                public Marker(CacheBase Cache, int Address)
                {
                    EndianReader Reader = Cache.Reader;
                    Reader.SeekTo(Address);

                    RegionIndex = Reader.ReadByte();
                    PermutationIndex = Reader.ReadByte();
                    NodeIndex = Reader.ReadByte();
                    Reader.ReadByte();
                    Position = new RealQuaternion(
                        Reader.ReadSingle(),
                        Reader.ReadSingle(),
                        Reader.ReadSingle());
                    Rotation = new RealQuaternion(
                        Reader.ReadSingle(),
                        Reader.ReadSingle(),
                        Reader.ReadSingle(),
                        Reader.ReadSingle());
                    Scale = Reader.ReadSingle();
                }
            }
        }

        new public class Shader : mode.Shader
        {
            public Shader(CacheBase Cache, int Address)
            {
                EndianReader Reader = Cache.Reader;
                Reader.SeekTo(Address);

                Reader.Skip(12);

                tagID = Reader.ReadInt32();
            }
        }

        new public class ModelSection : mode.ModelSection
        {
            public int vertcount;
            public int facecount;

            public int rawOffset;
            public int rawSize;
            public int hSize;

            public int[] rSize;
            public int[] rOffset;
            public int[] rType;

            public int type;
            public int bones;

            public ModelSection(CacheBase Cache, int Address)
            {
                EndianReader Reader = Cache.Reader;
                Reader.SeekTo(Address);
                    
                type = Reader.ReadInt16();
                Reader.ReadUInt16();
                vertcount = Reader.ReadUInt16();
                facecount = Reader.ReadUInt16();
                Reader.SeekTo(Address + 20);
                bones = Reader.ReadByte();
                Reader.SeekTo(Address + 56);
                rawOffset = Reader.ReadInt32();
                rawSize = Reader.ReadInt32();
                Reader.ReadUInt32();
                hSize = rawSize - Reader.ReadInt32() - 4;

                int iCount = Reader.ReadInt32();
                int iOffset = Reader.ReadInt32() - Cache.Magic;
                
                rSize = new int[iCount];
                rOffset = new int[iCount];
                rType = new int[iCount];

                for (int i = 0; i < iCount; i++)
                {
                    Reader.SeekTo(iOffset + 16 * i + 4);
                    rType[i] = Reader.ReadInt32();
                    rSize[i] = Reader.ReadInt32();
                    rOffset[i] = Reader.ReadInt32();
                }
            }
        }

        new public class BoundingBox : mode.BoundingBox
        {
            public BoundingBox(CacheBase Cache, int Address)
            {
                EndianReader Reader = Cache.Reader;
                Reader.SeekTo(Address);

                XBounds = new Bounds<float>(Reader.ReadSingle(), Reader.ReadSingle());
                YBounds = new Bounds<float>(Reader.ReadSingle(), Reader.ReadSingle());
                ZBounds = new Bounds<float>(Reader.ReadSingle(), Reader.ReadSingle());
                UBounds = new Bounds<float>(Reader.ReadSingle(), Reader.ReadSingle());
                VBounds = new Bounds<float>(Reader.ReadSingle(), Reader.ReadSingle());
            }
        }
    }
}
