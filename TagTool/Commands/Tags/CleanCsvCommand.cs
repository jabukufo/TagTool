using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Cache.HaloOnline;
using TagTool.Common;

namespace TagTool.Commands.Tags
{
    class CleanCsvCommand : Command
    {
        public GameCacheContext CacheContext { get; }

        public CleanCsvCommand(GameCacheContext cacheContext) :
            base(CommandFlags.Inherit,
                "clean-csv",
                "",
                "clean-csv <csv file>",
                "")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1)
                return false;

            var csvFile = new FileInfo(args[0]);

            if (!csvFile.Exists)
                throw new FileNotFoundException(csvFile.FullName);

            string versionStringLine = null;
            string versionTimeLine = null;
            string[] tagLines = null;

            using (var csvStream = csvFile.OpenRead())
            using (var csvReader = new StreamReader(csvStream))
            {
                versionStringLine = csvReader.ReadLine();
                versionTimeLine = csvReader.ReadLine();

                tagLines = csvReader.ReadToEnd().Replace("\r\n", "\n").Split('\n');
            }

            using (var csvStream = csvFile.Create())
            using (var csvWriter = new StreamWriter(csvStream))
            {
                csvWriter.WriteLine(versionStringLine);
                csvWriter.WriteLine(versionTimeLine);

                foreach (var tagLine in tagLines)
                {
                    var tagIndices = tagLine.Split(',').ToList();

                    int tagIndex;
                    if (!int.TryParse(tagIndices[0], NumberStyles.HexNumber, null, out tagIndex))
                        continue;

                    if (tagIndex >= CacheContext.Cache.Tags.Count || CacheContext.Cache.Tags[tagIndex] == null)
                        continue;

                    var first = true;
                    foreach (var index in tagIndices)
                    {
                        csvWriter.Write(first ? "" : ",");

                        if (first)
                            first = false;

                        csvWriter.Write("0x" + index);
                    }
                    csvWriter.WriteLine();
                }
            }

            return true;
        }
    }
}
