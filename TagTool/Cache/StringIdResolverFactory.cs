using TagTool.GameDefinitions;

namespace TagTool.Cache
{
    public static class StringIDResolverFactory
    {
        /// <summary>
        /// Creates a stringID resolver for a given engine version.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns>The resolver.</returns>
        public static StringIDResolverBase Create(GameDefinitionSet version)
        {
            if (GameDefinition.Compare(version, GameDefinitionSet.HaloOnline700123) >= 0)
                return new GameDefinitions.HaloOnline700123.StringIDResolver();
            if (GameDefinition.Compare(version, GameDefinitionSet.HaloOnline498295) >= 0)
                return new GameDefinitions.HaloOnline498295.StringIDResolver();
            return new GameDefinitions.HaloOnline106708.StringIDResolver();
        }
    }
}
