using System;
using TagTool.Cache;
using TagTool.IO;

namespace TagTool.Serialization
{
    public class DataSerializationContext : ISerializationContext
    {
        public EndianReader Reader { get; }

        public DataSerializationContext(EndianReader reader)
        {
            Reader = reader;
        }

        public uint AddressToOffset(uint currentOffset, uint address)
        {
            return (uint)new ResourceAddress(address).Offset;
        }

        public EndianReader BeginDeserialize(TagStructureInfo info)
        {
            return Reader;
        }

        public void BeginSerialize(TagStructureInfo info)
        {
            throw new NotImplementedException();
        }

        public IDataBlock CreateBlock()
        {
            throw new NotImplementedException();
        }

        public void EndDeserialize(TagStructureInfo info, object obj)
        {
        }

        public void EndSerialize(TagStructureInfo info, byte[] data, uint mainStructOffset)
        {
            throw new NotImplementedException();
        }

        public TagInstance GetTagByIndex(int index)
        {
            throw new NotImplementedException();
        }
    }
}
