using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Tags
{
    class NameTagCommand : Command
    {
        public GameCacheContext Info { get; }

        public NameTagCommand(GameCacheContext info)
            : base(CommandFlags.Inherit,
            "name-tag",
            "Renames a tag in memory and in the .csv file",

            "name-tag <tag> <name>",

            "<tag> - a reference to a tag by index, *, or its old tagname. \n" +
            "<name> - should be a concise name that resembles the format of existing tagnames.\n")
        {
            Info = info;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 2)
                return false;

            var tag = ArgumentParser.ParseTagIndex(Info, args[0]);
            var name = args[1];

            if (tag == null)
                return false;

            // Change the tagname in memory so the tag can be referenced by it's new name.
            Info.TagNames[tag.Index] = name;

            // Write the new tagname back to the tagnames.csv file for the loaded cache version.
            var tagNamesPath = "Tags\\tagnames_" + CacheVersionDetection.GetVersionString(Info.Version) + ".csv";
            if (!Directory.Exists("Tags"))
                Directory.CreateDirectory("Tags");
                
            using (var csvStream = File.Create(tagNamesPath))
            {
                var writer = new StreamWriter(csvStream);

                foreach (var entry in Info.TagNames)
                {
                    var value = entry.Value;

                    if (value.StartsWith("0x"))
                        writer.WriteLine($"0x{entry.Key:X8},{value}");
                    else
                        writer.WriteLine($"0x{entry.Key:X8},0x{entry.Key:X4} {value}");
                }

                writer.Close();
            }
            return true;
        }
    }
}
