using System.IO;
using TagTool.GameDefinitions;

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
        public static IVertexStream Create(GameDefinitionSet version, Stream stream)
        {
            if (GameDefinition.Compare(version, GameDefinitionSet.HaloOnline235640) >= 0)
                return new GameDefinitions.HaloOnline235640.VertexStream(stream);
            return new GameDefinitions.HaloOnline106708.VertexStream(stream);
        }
    }
}
