using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;

namespace TagTool.Commands.Tags
{
    class NameTagCommand : Command
    {
        public GameCacheContext CacheContext { get; }

        public NameTagCommand(GameCacheContext cacheContext)
            : base(CommandFlags.Inherit,
                  
                  "NameTag",
                  "Sets the name of a tag file in the current cache.",
                  
                  "NameTag <tag> <name> [csv path]",
                  
                  "<tag>  - A valid tag index, tag name, or * for the last tag in the current cache. \n" +
                  "\n" +
                  "<name> - The name of the tag. Should be a concise name that resembles the format \n" +
                  "         of existing tag names.\n")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count < 2 || args.Count > 3)
                return false;

            var tag = ArgumentParser.ParseTagSpecifier(CacheContext, args[0]);
            var name = args[1];

            if (tag == null)
            {
                Console.WriteLine($"ERROR: Invalid tag specifier: {args[0]}");
                return false;
            }
            
            CacheContext.TagNames[tag.Index] = name;

            var csvFile = (args.Count == 3) ?
                new FileInfo(args[2]) :
                new FileInfo(Path.Combine(CacheContext.Directory.FullName, "tag_list.csv"));

            if (!csvFile.Directory.Exists)
                csvFile.Directory.Create();

            using (var csvStream = csvFile.Create())
            using (var csvWriter = new StreamWriter(csvStream))
            {
                foreach (var entry in CacheContext.TagNames)
                {
                    var value = entry.Value;

                    csvWriter.WriteLine($"0x{entry.Key:X8},{value}");
                }
            }

            Console.WriteLine($"[Index: 0x{tag.Index:X4}, Offset: 0x{tag.HeaderOffset:X8}, Size: 0x{tag.TotalSize:X4}] {name}.{CacheContext.GetString(tag.Group.Name)}");

            return true;
        }
    }
}
