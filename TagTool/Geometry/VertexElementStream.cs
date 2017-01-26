using System;
using System.IO;
using TagTool.Common;

namespace TagTool.Geometry
{
    public class VertexElementStream
    {
        private readonly BinaryReader _reader;
        private readonly BinaryWriter _writer;

        public VertexElementStream(Stream baseStream)
        {
            _reader = new BinaryReader(baseStream);
            _writer = new BinaryWriter(baseStream);
        }

        public float ReadFloat1()
        {
            return _reader.ReadSingle();
        }

        public void WriteFloat1(float v)
        {
            _writer.Write(v);
        }

        public RealPoint2d ReadFloat2()
        {
            return new RealPoint2d(Read(2, () => _reader.ReadSingle()));
        }

        public void WriteFloat2(RealPoint2d v)
        {
            Write(v.ToArray(), 2, e => _writer.Write(e));
        }

        public RealPoint3d ReadFloat3()
        {
            return new RealPoint3d(Read(3, () => _reader.ReadSingle()));
        }

        public void WriteFloat3(RealPoint3d v)
        {
            Write(v.ToArray(), 3, e => _writer.Write(e));
        }

        public RealVector4d ReadFloat4()
        {
            return new RealVector4d(Read(4, () => _reader.ReadSingle()));
        }

        public void WriteFloat4(RealVector4d v)
        {
            Write(v.ToArray(), 4, e => _writer.Write(e));
        }

        public uint ReadColor()
        {
            return _reader.ReadUInt32();
        }

        public void WriteColor(uint v)
        {
            _writer.Write(v);
        }

        public byte[] ReadUByte4()
        {
            return _reader.ReadBytes(4);
        }

        public void WriteUByte4(byte[] v)
        {
            _writer.Write(v, 0, 4);
        }

        public short[] ReadShort2()
        {
            return Read(2, () => _reader.ReadInt16());
        }

        public void WriteShort2(short[] v)
        {
            Write(v, 2, e => _writer.Write(e));
        }

        public short[] ReadShort4()
        {
            return Read(2, () => _reader.ReadInt16());
        }

        public void WriteShort4(short[] v)
        {
            Write(v, 4, e => _writer.Write(e));
        }

        public RealVector4d ReadUByte4N()
        {
            return new RealVector4d(Read(4, () => _reader.ReadByte() / 255.0f));
        }

        public void WriteUByte4N(RealVector4d v)
        {
            Write(v.ToArray(), 4, e => _writer.Write((byte)(Clamp(e) * 255.0f)));
        }

        public RealPoint2d ReadShort2N()
        {
            return new RealPoint2d(Read(2, () => _reader.ReadInt16() / 32767.0f));
        }

        public void WriteShort2N(RealPoint2d v)
        {
            Write(v.ToArray(), 2, e => _writer.Write((short)(Clamp(e) * 32767.0f)));
        }

        public RealVector4d ReadShort4N()
        {
            return new RealVector4d(Read(4, () => _reader.ReadInt16() / 32767.0f));
        }

        public void WriteShort4N(RealVector4d v)
        {
            Write(v.ToArray(), 4, e => _writer.Write((short)(Clamp(e) * 32767.0f)));
        }

        public RealPoint2d ReadUShort2N()
        {
            return new RealPoint2d(Read(2, () => _reader.ReadUInt16() / 65535.0f));
        }

        public void WriteUShort2N(RealPoint2d v)
        {
            Write(v.ToArray(), 2, e => _writer.Write((ushort)(Clamp(e) * 65535.0f)));
        }

        public RealVector4d ReadUShort4N()
        {
            return new RealVector4d(Read(4, () => _reader.ReadUInt16() / 65535.0f));
        }

        public void WriteUShort4N(RealVector4d v)
        {
            Write(v.ToArray(), 4, e => _writer.Write((ushort)(Clamp(e) * 65535.0f)));
        }

        public RealPoint3d ReadUDec3()
        {
            var val = _reader.ReadUInt32();
            var x = (float)(val >> 22);
            var y = (float)((val >> 12) & 0x3FF);
            var z = (float)((val >> 2) & 0x3FF);
            return new RealPoint3d(x, y, z);
        }

        public void WriteUDec3(RealPoint3d v)
        {
            var x = (uint)v.X & 0x3FF;
            var y = (uint)v.Y & 0x3FF;
            var z = (uint)v.Z & 0x3FF;
            _writer.Write((x << 22) | (y << 12) | (z << 2));
        }

        public RealPoint3d ReadDec3N()
        {
            var val = _reader.ReadUInt32();
            var x = ((val >> 22) - 512) / 511.0f;
            var y = (((val >> 12) & 0x3FF) - 512) / 511.0f;
            var z = (((val >> 2) & 0x3FF) - 512) / 511.0f;
            return new RealPoint3d(x, y, z);
        }

        public void WriteDec3N(RealPoint3d v)
        {
            var x = (((uint)(Clamp(v.X) * 511.0f)) + 512) & 0x3FF;
            var y = (((uint)(Clamp(v.Y) * 511.0f)) + 512) & 0x3FF;
            var z = (((uint)(Clamp(v.Z) * 511.0f)) + 512) & 0x3FF;
            _writer.Write((x << 22) | (y << 12) | (z << 2));
        }

        public RealPoint2d ReadFloat16_2()
        {
            return new RealPoint2d(Read(2, () => (float)Half.ToHalf(_reader.ReadUInt16())));
        }

        public void WriteFloat16_2(RealPoint2d v)
        {
            Write(v.ToArray(), 2, e => _writer.Write(Half.GetBytes(new Half(e))));
        }

        public RealVector4d ReadFloat16_4()
        {
            return new RealVector4d(Read(4, () => (float)Half.ToHalf(_reader.ReadUInt16())));
        }

        public void WriteFloat16_4(RealVector4d v)
        {
            Write(v.ToArray(), 4, e => _writer.Write(Half.GetBytes(new Half(e))));
        }

        private static T[] Read<T>(int count, Func<T> readFunc)
        {
            var c = new T[count];
            for (var i = 0; i < count; i++)
                c[i] = readFunc();
            return c;
        }

        private static void Write<T>(T[] elems, int count, Action<T> writeAction)
        {
            for (var i = 0; i < count; i++)
                writeAction(elems[i]);
        }

        private static float Clamp(float e)
        {
            return Math.Max(-1.0f, Math.Min(1.0f, e));
        }
    }
}
