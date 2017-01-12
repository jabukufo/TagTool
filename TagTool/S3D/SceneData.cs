﻿using System.Collections.Generic;
using TagTool.IO;
using TagTool.Common;

namespace TagTool.S3D
{
    public class SceneData
    {
        public byte[] unmapped0;
        public int x0700;
        public int xADDE;
        public BoundingBox unkBounds;
        public List<int> indices;
        public List<struct0> unkS0;
        public byte[] unmapped1;

        public SceneData(PakFile Pak, PakFile.PakTag Item)
        {
            var reader = Pak.Reader;
            reader.Format = EndianFormat.Little;
            reader.SeekTo(Item.Offset);

            unmapped0 = reader.ReadBytes(16);
            x0700 = reader.ReadInt16(); //0700
            xADDE = reader.ReadInt16(); //ADDE

            var min = new Vector(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            var max = new Vector(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            unkBounds = new BoundingBox()
            {
                XBounds = new Range<float>(min.X, max.X),
                YBounds = new Range<float>(min.Y, max.Y),
                ZBounds = new Range<float>(min.Z, max.Z),
            };

            var count = reader.ReadInt32(); //always bsp object count + 1
            indices = new List<int>();
            for (int i = 0; i < count; i++)
                indices.Add(reader.ReadInt32()); //last value is always struct0 count

            count = reader.ReadInt32();
            unkS0 = new List<struct0>();
            for (int i = 0; i < count; i++)
                unkS0.Add(new struct0(Pak, Item));

            unmapped1 = reader.ReadBytes(13); //always the same
        }

        public class struct0
        {
            public int[] unk0;

            public struct0(PakFile Pak, PakFile.PakTag Item)
            {
                unk0 = new int[12];

                //not sure if signed or not
                //appears to be compressed floats, might be
                //coordinates relative to the bounds values
                for (int i = 0; i < 12; i++)
                    unk0[i] = Pak.Reader.ReadInt16();
            }
        }
    }
}
