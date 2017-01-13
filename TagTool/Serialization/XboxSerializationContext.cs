using System;
using System.IO;
using TagTool.Common;
using TagTool.Tags;
using TagTool.Cache;

namespace TagTool.Serialization
{
    public class XboxSerializationContext : ISerializationContext
    {
        private readonly CacheFile.IndexItem _tag;

        public XboxSerializationContext(CacheFile.IndexItem tag)
        {
            _tag = tag;
        }

        public uint AddressToOffset(uint currentOffset, uint address)
        {
            return (uint)(address - _tag.Cache.Magic);
        }

        public BinaryReader BeginDeserialize(TagStructureInfo info)
        {
            var reader = _tag.Cache.Reader;
            reader.SeekTo(_tag.Offset);
            return reader;
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
            var tag = _tag.Cache.IndexItems.GetItemByID(index);

            if (tag == null)
                return null;

            var groupTag1 = tag.ClassCode == null ? Tag.Null : new Tag(tag.ClassCode);
            var groupTag2 = tag.ParentClass == null ? Tag.Null : new Tag(tag.ParentClass);
            var groupTag3 = tag.ParentClass2 == null ? Tag.Null : new Tag(tag.ParentClass2);
            var groupName = new StringID((uint)_tag.Cache.IndexItems.ClassList[_tag.ClassIndex].StringID);
            
            return new TagInstance(index, new TagGroup(groupTag1, groupTag2, groupTag3, groupName));
        }
    }
}
