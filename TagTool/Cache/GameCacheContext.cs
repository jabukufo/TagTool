using System.Collections.Generic;
using System.IO;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.Tags;

namespace TagTool.Cache
{
    /// <summary>
    /// Holds information about an open tag cache file.
    /// </summary>
    public class GameCacheContext
    {
        /// <summary>
        /// Gets or sets the tag cache.
        /// </summary>
        public TagCache TagCache { get; set; }

        /// <summary>
        /// Gets or sets the location of the tag cache file.
        /// </summary>
        public FileInfo TagCacheFile { get; set; }

        /// <summary>
        /// Gets the directory of the current cache context.
        /// </summary>
        public DirectoryInfo Directory => TagCacheFile.Directory;

        /// <summary>
        /// Gets or sets the stringID cache.
        /// Can be <c>null</c>.
        /// </summary>
        public StringIdCache StringIdCache { get; set; }

        /// <summary>
        /// Gets or sets the location of the stringID cache file.
        /// Can be <c>null</c>.
        /// </summary>
        public FileInfo StringIdCacheFile { get; set; }

        /// <summary>
        /// Gets or sets the target engine version.
        /// </summary>
        public CacheVersion Version { get; set; }

        /// <summary>
        /// Gets or sets the tag serializer to use.
        /// </summary>
        public TagSerializer Serializer { get; set; }

        /// <summary>
        /// Gets or sets the tag deserializer to use.
        /// </summary>
        public TagDeserializer Deserializer { get; set; }

        /// <summary>
        /// A dictionary of tag names.
        /// </summary>
        public Dictionary<int, string> TagNames { get; set; } = new Dictionary<int, string>();

        /// <summary>
        /// Opens the tag cache file for reading.
        /// </summary>
        /// <returns>The stream that was opened.</returns>
        public Stream OpenTagCacheRead() => TagCacheFile.OpenRead();

        /// <summary>
        /// Opens the tag cache file for writing.
        /// </summary>
        /// <returns>The stream that was opened.</returns>
        public FileStream OpenTagCacheWrite() => TagCacheFile.Open(FileMode.Open, FileAccess.Write);

        /// <summary>
        /// Opens the tag cache file for reading and writing.
        /// </summary>
        /// <returns>The stream that was opened.</returns>
        public FileStream OpenTagCacheReadWrite() => TagCacheFile.Open(FileMode.Open, FileAccess.ReadWrite);

        /// <summary>
        /// Gets a tag from the tag cache.
        /// </summary>
        /// <param name="index">The index of the tag.</param>
        /// <returns></returns>
        public TagInstance GetTag(int index) => TagCache.Tags[index];

        /// <summary>
        /// Opens the string_id cache file for reading.
        /// </summary>
        /// <returns>The stream that was opened.</returns>
        public FileStream OpenStringIdCacheRead() => StringIdCacheFile.OpenRead();

        /// <summary>
        /// Opens the string_id cache file for writing.
        /// </summary>
        /// <returns>The stream that was opened.</returns>
        public FileStream OpenStringIdCacheWrite() => StringIdCacheFile.Open(FileMode.Open, FileAccess.Write);

        /// <summary>
        /// Opens the string_id cache file for reading and writing.
        /// </summary>
        /// <returns>The stream that was opened.</returns>
        public FileStream OpenStringIdCacheReadWrite() => StringIdCacheFile.Open(FileMode.Open, FileAccess.ReadWrite);

        /// <summary>
        /// Gets a string from the string_id cache.
        /// </summary>
        /// <param name="id">The id of the string.</param>
        /// <returns></returns>
        public string GetString(StringId id) => StringIdCache.GetString(id);

        /// <summary>
        /// Gets the string_id associated with the specified value from the string_id cache.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <returns></returns>
        public StringId GetStringId(string value) => StringIdCache.GetStringId(value);
    }
}
