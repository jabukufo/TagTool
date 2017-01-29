using System;
using System.Collections.Generic;
using System.IO;
using Adjutant.Library.Definitions;
using System.Runtime.Serialization.Formatters.Binary;
using TagTool.Geometry;
using TagTool.Common;

namespace Adjutant.Library
{
    public static class ModelFunctions
    {
        public static List<int> GetTriangleList(int[] Indices, int Start, int Length, int FaceFormat)
        {
            if (FaceFormat == 3)
            {
                var arr = new int[Length];
                Array.Copy(Indices, Start, arr, 0, Length);
                return new List<int>(arr);
            }

            var list = new List<int>();

            for (int n = 0; n < (Length - 2); n++)
            {
                int indx1 = Indices[Start + n + 0];
                int indx2 = Indices[Start + n + 1];
                int indx3 = Indices[Start + n + 2];

                if ((indx1 != indx2) && (indx1 != indx3) && (indx2 != indx3))
                {
                    list.Add(indx1);
                    if (n % 2 == 0)
                    {
                        list.Add(indx2);
                        list.Add(indx3);
                    }
                    else
                    {
                        list.Add(indx3);
                        list.Add(indx2);
                    }
                }
            }
            return list;
        }

        public static void DecompressVertex(ref Vertex v, render_model.BoundingBox bb)
        {
            VertexValue vv;
            if (v.TryGetValue("position", 0, out vv))
            {
                if ((bb.XBounds.Upper - bb.XBounds.Lower) != 0)
                    vv.Data.I = (float)(vv.Data.I * (bb.XBounds.Upper - bb.XBounds.Lower) + bb.XBounds.Lower);

                if ((bb.YBounds.Upper - bb.YBounds.Lower) != 0)
                    vv.Data.J = (float)(vv.Data.J * (bb.YBounds.Upper - bb.YBounds.Lower) + bb.YBounds.Lower);

                if ((bb.ZBounds.Upper - bb.ZBounds.Lower) != 0)
                    vv.Data.K = (float)(vv.Data.K * (bb.ZBounds.Upper - bb.ZBounds.Lower) + bb.ZBounds.Lower);
            }

            if (v.TryGetValue("texcoords", 0, out vv))
            {
                if ((bb.UBounds.Upper - bb.UBounds.Lower) != 0)
                    vv.Data.I = (float)(vv.Data.I * (bb.UBounds.Upper - bb.UBounds.Lower) + bb.UBounds.Lower);

                vv.Data.J = 1f - (((bb.VBounds.Upper - bb.VBounds.Lower) != 0) ?
                    (float)(vv.Data.J * (bb.VBounds.Upper - bb.VBounds.Lower) + bb.VBounds.Lower) :
                    vv.Data.J);
            }
        }

        public static void DecompressVertex(ref Vertex[] vArray, render_model.BoundingBox bb)
        {
            for (int i = 0; i < vArray.Length; i++)
            {
                VertexValue vv;
                if (vArray[i].TryGetValue("position", 0, out vv))
                {
                    if ((bb.XBounds.Upper - bb.XBounds.Lower) != 0)
                        vv.Data.I = (float)(vv.Data.I * (bb.XBounds.Upper - bb.XBounds.Lower) + bb.XBounds.Lower);

                    if ((bb.YBounds.Upper - bb.YBounds.Lower) != 0)
                        vv.Data.J = (float)(vv.Data.J * (bb.YBounds.Upper - bb.YBounds.Lower) + bb.YBounds.Lower);

                    if ((bb.ZBounds.Upper - bb.ZBounds.Lower) != 0)
                        vv.Data.K = (float)(vv.Data.K * (bb.ZBounds.Upper - bb.ZBounds.Lower) + bb.ZBounds.Lower);
                }

                if (vArray[i].TryGetValue("texcoords", 0, out vv))
                {
                    if ((bb.UBounds.Upper - bb.UBounds.Lower) != 0)
                        vv.Data.I = (float)(vv.Data.I * (bb.UBounds.Upper - bb.UBounds.Lower) + bb.UBounds.Lower);

                    vv.Data.J = 1f - (((bb.VBounds.Upper - bb.VBounds.Lower) != 0) ?
                        (float)(vv.Data.J * (bb.VBounds.Upper - bb.VBounds.Lower) + bb.VBounds.Lower) :
                        vv.Data.J);
                }
            }
        }

        public static RealMatrix4x3 RealMatrix4x3FromBounds(RealBoundingBox bb)
        {
            RealMatrix4x3 m = RealMatrix4x3.Identity;

            if ((bb.XBounds.Upper - bb.XBounds.Lower) != 0) m.m11 = (bb.XBounds.Upper - bb.XBounds.Lower);
            if ((bb.YBounds.Upper - bb.YBounds.Lower) != 0) m.m22 = (bb.YBounds.Upper - bb.YBounds.Lower);
            if ((bb.ZBounds.Upper - bb.ZBounds.Lower) != 0) m.m33 = (bb.ZBounds.Upper - bb.ZBounds.Lower);

            m.m41 = bb.XBounds.Lower;
            m.m42 = bb.YBounds.Lower;
            m.m43 = bb.ZBounds.Lower;

            return m;
        }

        public static RealMatrix4x3 RealMatrix4x3FromBounds(RealQuaternion Min, RealQuaternion Max)
        {
            RealMatrix4x3 m = RealMatrix4x3.Identity;

            if (Max.I - Min.I != 0) m.m11 = Max.I - Min.I;
            if (Max.J - Min.J != 0) m.m22 = Max.J - Min.J;
            if (Max.K - Min.K != 0) m.m33 = Max.K - Min.K;

            m.m41 = Min.I;
            m.m42 = Min.J;
            m.m43 = Min.K;

            return m;
        }
        
        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}