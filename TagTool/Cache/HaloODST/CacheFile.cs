namespace TagTool.Cache.HaloODST
{
    public class CacheFile : Halo3.CacheFile
    {
        public CacheFile(string Filename, string Build)
            : base(Filename, Build)
        {
            Version = CacheVersion.HaloODST;
        }
    }
}
