﻿using System.IO;
using System.Linq;
using static System.BitConverter;
using static TagTool.IO.EndianFormat;

namespace TagTool.IO
{
    public class EndianWriter : BinaryWriter
    {
        public EndianFormat Format { get; set; }
        
        public EndianWriter(Stream stream, EndianFormat format)
            : base(stream)
        {
            Format = format;
        }

        public override void Write(short value) =>
            Write(value, Format);

        public override void Write(int value) =>
            Write(value, Format);

        public override void Write(long value) =>
            Write(value, Format);

        public override void Write(ushort value) =>
            Write(value, Format);

        public override void Write(uint value) =>
            Write(value, Format);

        public override void Write(ulong value) =>
            Write(value, Format);

        public override void Write(float value) =>
            Write(value, Format);

        public override void Write(double value) =>
            Write(value, Format);

        public void Write(short value, EndianFormat format) =>
            Write(format == Big ?
                GetBytes(value).Reverse().ToArray() :
                GetBytes(value));

        public void Write(int value, EndianFormat format) =>
            Write(format == Big ?
                GetBytes(value).Reverse().ToArray() :
                GetBytes(value));

        public void Write(long value, EndianFormat format) =>
            Write(format == Big ?
                GetBytes(value).Reverse().ToArray() :
                GetBytes(value));

        public void Write(ushort value, EndianFormat format) =>
            Write(format == Big ?
                GetBytes(value).Reverse().ToArray() :
                GetBytes(value));

        public void Write(uint value, EndianFormat format) =>
            Write(format == Big ?
                GetBytes(value).Reverse().ToArray() :
                GetBytes(value));

        public void Write(ulong value, EndianFormat format) =>
            Write(format == Big ?
                GetBytes(value).Reverse().ToArray() :
                GetBytes(value));

        public void Write(float value, EndianFormat format) =>
            Write(format == Big ?
                GetBytes(value).Reverse().ToArray() :
                GetBytes(value));

        public void Write(double value, EndianFormat format) =>
            Write(format == Big ?
                GetBytes(value).Reverse().ToArray() :
                GetBytes(value));

        public void WriteBlock(byte[] data) =>
            BaseStream.Write(data, 0, data.Length);

        public void WriteBlock(byte[] data, int offset, int length) =>
            BaseStream.Write(data, offset, length);
    }
}
