using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Common;
using TagTool.IO;
using TagTool.Serialization;

namespace TagTool.Cache
{
    public class CacheFile
    {
        public CacheFileHeader Header { get; private set; }
        public CacheFileIndexHeader IndexHeader { get; private set; }
        
        public CacheFile(FileInfo file)
        {
            if (!file.Exists)
                throw new FileNotFoundException(file.FullName);
            
            using (var stream = file.OpenRead())
            using (var reader = new EndianReader(stream, EndianFormat.Little))
            {
                var headString = new string(reader.ReadChars(4));

                if (headString == "head")
                    reader.Format = EndianFormat.Big;

                reader.BaseStream.Position = 0;

                var deserializer = new TagDeserializer(CacheVersion.Unknown);
                var context = new DataSerializationContext(reader);

                Header = deserializer.Deserialize<CacheFileHeader>(context);

                if (Header.Version == CacheFileVersion.HaloOnline)
                    throw new NotSupportedException(Header.Version.ToString());
            }
        }
    }

    public enum CacheFileVersion : int
    {
        Unknown = -1,
        Halo3Retail = 11,
        HaloOnline = 18
    }

    public enum CacheFileType : short
    {
        None = -1,
        Campaign,
        Multiplayer,
        MainMenu,
        Shared,
        SharedCampaign,

        Unknown5,
        Unknown6
    }

    public enum CacheFileSharedType : short
    {
        None = -1,
        MainMenu = 0,
        Shared,
        Campaign
    }

    [TagStructure(Size = 0x3000)]
    public class CacheFileHeader
    {
        public Tag HeadTag;
        public CacheFileVersion Version;
        public int FileLength;
        public int Unknown1;
        public uint TagIndexAddress;
        public int MemoryBufferOffset;
        public int MemoryBufferSize;
        [TagField(Length = 256)]
        public string SourceFile;
        [TagField(Length = 32)]
        public string Build;
        public CacheFileType CacheType;
        public CacheFileSharedType SharedType;
        public bool Unknown2;
        public bool TrackedBuild;
        public bool Unknown3;
        public byte Unknown4;
        public int Unknown5;
        public int Unknown6;
        public int Unknown7;
        public int Unknown8;
        public int Unknown9;
        public int StringIDsCount;
        public int StringIDsBufferSize;
        public int StringIDsIndicesOffset;
        public int StringIDsBufferOffset;
        public int ExternalDependencies;
        public int HighDateTime;
        public int LowDateTime;
        public int MainMenuDependencies;
        public int Unknown10;
        public int SharedDependencies;
        public int Unknown11;
        public int CampaignDependencies;
        public int Unknown12;
        [TagField(Length = 32)]
        public string Name;
        public int Unknown13;
        [TagField(Length = 256)]
        public string ScenarioPath;
        public int MinorVersion;
        public int TagNamesCount;
        public int TagNamesBufferOffset;
        public int TagNamesBufferSize;
        public int TagNamesIndicesOffset;
        public uint Checksum;
        public int Unknown14;
        public int Unknown15;
        public int Unknown16;
        public int Unknown17;
        public int Unknown18;
        public int Unknown19;
        public int Unknown20;
        public int Unknown21;
        public uint BaseAddress;
        public int XDKVersion;
        public uint CacheResourceBufferAddress;
        public int CacheResourceBufferSize;
        public uint SoundCacheResourceBufferAddress;
        public int SoundCacheResourceBufferSize;
        public uint GlobalTagsBufferAddress;
        public int GlobalTagsBufferSize;
        public uint SharedTagsBufferAddress;
        public int SharedTagsBufferSize;
        public uint BaseBufferAddress;
        public int BaseBufferSize;
        public uint MapTagsBufferAddress;
        public int MapTagsBufferSize;
        public int CountUnknown1;
        public int Unknown22;
        public int Unknown23;
        public int Unknown24;
        [TagField(Count = 5)]
        public int[] SHA1_A;
        [TagField(Count = 5)]
        public int[] SHA1_B;
        [TagField(Count = 5)]
        public int[] SHA1_C;
        [TagField(Count = 64)]
        public int[] RSA;
        public uint ResourceBaseAddress;
        public int DebugSectionSize;
        public uint RuntimeBaseAddress;
        public uint UnknownBaseAddress;
        public uint DebugCacheSectionVirtualAddress;
        public int DebugCacheSectionSize;
        public uint ResourceCacheSectionVirtualAddress;
        public int ResourceCacheSectionSize;
        public uint TagCacheSectionVirtualAddress;
        public int TagCacheSectionSize;
        public uint LocalizationCacheSectionVirtualAddress;
        public int LocalizationCacheSectionSize;
        [TagField(Count = 4)]
        public int[] GUID;
        public short Unknown108;
        public short CountUnknown2;
        public int Unknown109;
        [TagField(Count = 4)]
        public int[] CompressionGUID;
        [TagField(Size = 0x2300)]
        public byte[] Elements1;
        [TagField(Size = 0x708)]
        public byte[] Elements2;
        [TagField(Size = 0x12C)]
        public byte[] Unknown114;
        public uint Unknown115;
        public Tag FootTag;
    }

    [TagStructure(Size = 0x1C)]
    public class CacheFileIndexHeader
    {
        public int TagGroupCount;
        public uint TagGroupTableAddress;
        public int TagCount;
        public uint TagTableAddress;
        public int TagHeirarchyCount;
        public uint TagHeirarchyTableAddress;
        public int Magic;
    }
}
