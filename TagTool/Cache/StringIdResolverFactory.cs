namespace TagTool.Cache
{
    public static class StringIdResolverFactory
    {
        /// <summary>
        /// Creates a stringID resolver for a given engine version.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns>The resolver.</returns>
        public static StringIdResolverBase Create(CacheVersion version)
        {
            if (CacheVersionDetection.Compare(version, CacheVersion.HaloOnline700123) >= 0)
                return new StringIdResolverMS30();
            if (CacheVersionDetection.Compare(version, CacheVersion.HaloOnline498295) >= 0)
                return new StringIdResolverMS28();
            return new StringIdResolverMS23();
        }
    }
}
