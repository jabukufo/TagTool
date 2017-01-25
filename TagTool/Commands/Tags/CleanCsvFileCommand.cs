using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using TagTool.Cache.HaloOnline;

namespace TagTool.Commands.Tags
{
    class CleanCsvFileCommand : Command
    {
        public GameCacheContext CacheContext { get; }

        public CleanCsvFileCommand(GameCacheContext cacheContext) :
            base(CommandFlags.Inherit,

                "clean-csv-file",
                "Removes any unfound tag indices from a tag conversion .csv file.",

                "clean-csv-file <csv file>",

                "Removes any unfound tag indices from a tag conversion .csv file.")
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

                    if (tagIndex >= CacheContext.TagCache.Tags.Count || CacheContext.TagCache.Tags[tagIndex] == null)
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
