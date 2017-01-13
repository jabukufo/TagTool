namespace TagTool.Cache.HaloOnline
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
                return new MS30.StringIdResolver();
            if (CacheVersionDetection.Compare(version, CacheVersion.HaloOnline498295) >= 0)
                return new MS28.StringIdResolver();
            return new MS23.StringIdResolver();
        }
    }
}
