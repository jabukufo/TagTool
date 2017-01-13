using System.IO;
using TagTool.Cache;

namespace TagTool.Geometry
{
    public static class VertexStreamFactory
    {
        /// <summary>
        /// Creates a vertex stream for a given engine version.
        /// </summary>
        /// <param name="version">The engine version.</param>
        /// <param name="stream">The base stream.</param>
        /// <returns>The created vertex stream.</returns>
        public static IVertexStream Create(CacheVersion version, Stream stream)
        {
            if (CacheVersionDetection.Compare(version, CacheVersion.HaloOnline235640) >= 0)
                return new Cache.HaloOnline.MS25.VertexStream(stream);
            return new Cache.HaloOnline.MS23.VertexStream(stream);
        }
    }
}
