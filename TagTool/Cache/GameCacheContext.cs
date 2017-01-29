using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.Cache
{
    /// <summary>
    /// Holds information about an open tag cache file.
    /// </summary>
    public class GameCacheContext
    {
        /// <summary>
        /// Gets the directory of the current cache context.
        /// </summary>
        public DirectoryInfo Directory { get; }

        /// <summary>
        /// Gets or sets the tag cache.
        /// </summary>
        public TagCache TagCache { get; set; }

        /// <summary>
        /// Gets the tag cache file information.
        /// </summary>
        public FileInfo TagCacheFile => Directory.GetFiles("tags.dat")?[0];

        /// <summary>
        /// A dictionary of tag names.
        /// </summary>
        public Dictionary<int, string> TagNames { get; set; } = new Dictionary<int, string>();

        /// <summary>
        /// Gets or sets the stringID cache.
        /// Can be <c>null</c>.
        /// </summary>
        public StringIdCache StringIdCache { get; set; }

        /// <summary>
        /// Gets the string_id cache file information.
        /// </summary>
        public FileInfo StringIdCacheFile => Directory.GetFiles("string_ids.dat")?[0];

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

        public GameCacheContext(DirectoryInfo directory)
        {
            Directory = directory;

            using (var stream = OpenTagCacheRead())
                TagCache = new TagCache(stream);
            
            CacheVersion closestVersion;
            if (CacheVersion.Unknown == (Version = CacheVersionDetection.Detect(TagCache, out closestVersion)))
                Version = closestVersion;

            Deserializer = new TagDeserializer(Version);
            Serializer = new TagSerializer(Version);

            var stringIdResolver = StringIdResolverFactory.Create(Version);

            using (var stream = OpenStringIdCacheRead())
                StringIdCache = new StringIdCache(stream, stringIdResolver);

            LoadTagNames();
        }

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
        public CachedTagInstance GetTag(int index) => TagCache.Index[index];

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

        /// <summary>
        /// Gets the string_id associated with the specified index from the string_id cache.
        /// </summary>
        /// <param name="index">The index of the string.</param>
        /// <returns></returns>
        public StringId GetStringId(int index) => StringIdCache.GetStringId(index);

        /// <summary>
        /// Loads tag file names from the appropriate tagnames.csv file.
        /// </summary>
        public void LoadTagNames()
        {
            var tagNamesPath = Path.Combine(Directory.FullName, "tag_list.csv");

            if (File.Exists(tagNamesPath))
            {
                using (var tagNamesStream = File.Open(tagNamesPath, FileMode.Open, FileAccess.Read))
                {
                    var reader = new StreamReader(tagNamesStream);

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var separatorIndex = line.IndexOf(',');
                        var indexString = line.Substring(2, separatorIndex - 2);

                        int tagIndex;
                        if (!int.TryParse(indexString, NumberStyles.HexNumber, null, out tagIndex))
                            tagIndex = -1;

                        if (tagIndex < 0 || tagIndex >= TagCache.Index.Count)
                            continue;

                        var nameString = line.Substring(separatorIndex + 1);

                        if (nameString.Contains(" "))
                        {
                            var lastSpaceIndex = nameString.LastIndexOf(' ');
                            nameString = nameString.Substring(lastSpaceIndex + 1, nameString.Length - lastSpaceIndex - 1);
                        }

                        TagNames[tagIndex] = nameString;
                    }

                    reader.Close();
                }
            }

            foreach (var tag in TagCache.Index)
                if (tag != null && !TagNames.ContainsKey(tag.Index))
                    TagNames[tag.Index] = $"0x{tag.Index:X4}";
        }
    }
}
