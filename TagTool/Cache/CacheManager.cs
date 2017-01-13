using System;
using System.IO;
using TagTool.IO;

namespace TagTool.Cache
{
    public static class CacheManager
    {
        public static CacheFile GetCache(string Filename)
        {
            CacheFile retCache = null;
            using (var fs = new FileStream(Filename, FileMode.Open, FileAccess.Read))
            {
                var Reader = new EndianReader((Stream)fs, EndianFormat.Big);

                var head = Reader.ReadInt32();
                if (head == 1684104552) Reader.Format = EndianFormat.Little;
                var v = Reader.ReadInt32();

                switch (v)
                {
                    case 5:   //H1X
                    case 7:   //HPC
                    case 609: //HCE
                        Reader.SeekTo(64);
                        break;
                    case 8:   //H2?
                        Reader.SeekTo(36);
                        switch (Reader.ReadInt32())
                        {
                            case 0: //H2X
                                Reader.SeekTo(288);
                                break;
                            case -1: //H2V
                                Reader.SeekTo(300);
                                break;
                        }
                        break;
                    default:  //360
                        Reader.SeekTo(284);
                        break;
                }

                var build = Reader.ReadString(32);
                var node = CacheFile.GetBuildNode(build);
                switch (node.Attributes["definitions"].Value)
                {
                    case "Halo3": retCache = new Halo3.CacheFile(Filename, build); break;
                    case "HaloODST":   retCache = new HaloODST.CacheFile(Filename, build); break;
                }
            }

            if (retCache != null)
            {
                retCache.LoadPlayZone();
                return retCache;
            }
            else throw new NotSupportedException("Cache version is unknown, unsupported or invalid.");
        }
    }
}
