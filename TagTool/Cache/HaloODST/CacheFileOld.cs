namespace TagTool.Cache.HaloODST
{
    public class CacheFileOld : Halo3.CacheFileOld
    {
        public CacheFileOld(string Filename, string Build)
            : base(Filename, Build)
        {
            Version = CacheVersion.HaloODST;
        }
    }
}
