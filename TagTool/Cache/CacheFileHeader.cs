using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Cache
{
    [TagStructure(Name = "cache_file_header", Size = 0x3000)]
    public class CacheFileHeader
    {
        public Tag HeadTag;
        public int Version;
        public int FileLength;
        public int Unknown1;
        public uint TagIndexAddress;
        public int MemoryBufferOffset;
        public int MemoryBufferSize;
        [TagField(Length = 256)] public string SourceFile;
        [TagField(Length = 32)] public string Build;
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
        [TagField(Length = 32)] public string Name;
        public int Unknown13;
        [TagField(Length = 256)] public string ScenarioPath;
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
        [TagField(Count = 5)] public int[] SHA1_A;
        [TagField(Count = 5)] public int[] SHA1_B;
        [TagField(Count = 5)] public int[] SHA1_C;
        [TagField(Count = 64)] public int[] RSA;
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
        [TagField(Count = 4)] public int[] GUID;
        public short Unknown108;
        public short CountUnknown2;
        public int Unknown109;
        [TagField(Count = 4)] public int[] CompressionGUID;
        [TagField(Size = 0x2300)] public byte[] Elements1;
        [TagField(Size = 0x708)] public byte[] Elements2;
        [TagField(Size = 0x12C)] public byte[] Unknown114;
        public uint Unknown115;
        public Tag FootTag;
    }

    /// <summary>
    /// Types of cache files the engine uses
    /// </summary>
    public enum CacheFileType : short
    {
        /// <summary>
        /// Internal value, not a value the actual engine uses
        /// </summary>
        None = -1,

        /// <summary>
        /// Single player \ story-related scenario
        /// </summary>
        Campaign,

        /// <summary>
        /// Scenario that makes use of a engine variant, like CTF
        /// </summary>
        Multiplayer,

        /// <summary>
        /// Scenario that interfaces the user with settings and selecting a map to load to play.
        /// Starting in Halo 2 it also holds shared UI resources
        /// </summary>
        MainMenu,

        /// <summary>
        /// Cache file that can be played (or stripped of run-time data, a la Halo 3+) and holds shared 
        /// resources used abroad
        /// </summary>
        Shared,

        /// <summary>
        /// Cache file that can be played (or stripped of run-time data, a la Halo 3+) and holds shared 
        /// resources used in campaign cache files
        /// </summary>
        SharedCampaign,

        Unknown5,
        Unknown6
    }

    /// <summary>
    /// Types of shared cache files the engine uses
    /// </summary>
    public enum CacheFileSharedType : short
    {
        /// <summary>
        /// Not a shared cache file
        /// </summary>
        None = -1,

        MainMenu = 0,
        Shared,
        Campaign
    }
}