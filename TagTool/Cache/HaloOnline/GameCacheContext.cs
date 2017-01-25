using System.Collections.Generic;
using System.IO;
using TagTool.Serialization;

namespace TagTool.Cache.HaloOnline
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
        public Stream OpenCacheRead()
        {
            return TagCacheFile.OpenRead();
        }

        /// <summary>
        /// Opens the tag cache file for writing.
        /// </summary>
        /// <returns>The stream that was opened.</returns>
        public Stream OpenCacheWrite()
        {
            return TagCacheFile.Open(FileMode.Open, FileAccess.Write);
        }

        /// <summary>
        /// Opens the tag cache file for reading and writing.
        /// </summary>
        /// <returns>The stream that was opened.</returns>
        public Stream OpenCacheReadWrite()
        {
            return TagCacheFile.Open(FileMode.Open, FileAccess.ReadWrite);
        }
    }
}
