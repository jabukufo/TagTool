namespace TagTool.GameDefinitions.HaloODST
{
    public class CacheFile : Halo3.CacheFile
    {
        public CacheFile(string Filename, string Build)
            : base(Filename, Build)
        {
            Version = GameDefinitionSet.HaloODST;
        }
    }
}
