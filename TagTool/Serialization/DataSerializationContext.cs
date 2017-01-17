using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Cache.HaloOnline;
using TagTool.Tags;

namespace TagTool.Serialization
{
    public class DataSerializationContext : ISerializationContext
    {
        public BinaryReader Reader { get; }

        public DataSerializationContext(BinaryReader reader)
        {
            Reader = reader;
        }

        public uint AddressToOffset(uint currentOffset, uint address)
        {
            return (uint)new ResourceAddress(address).Offset;
        }

        public BinaryReader BeginDeserialize(TagStructureInfo info)
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
