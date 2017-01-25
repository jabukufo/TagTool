﻿using System;
using System.Collections.Generic;
using TagTool.Cache.HaloOnline;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Tags
{
    class ListStringsCommand : Command
    {
        private GameCacheContext CacheContext { get; }

        public ListStringsCommand(GameCacheContext cacheContext) : base(
            CommandFlags.Inherit,

            "list-strings",
            "Scan unic tags to find a localized string",

            "list-strings <language> [filter]",

            "Scans all unic tags to find the strings belonging to a language.\n" +
            "If a filter is specified, only strings containing the filter will be listed.\n" +
            "\n" +
            "Available languages:\n" +
            "\n" +
            "english, japanese, german, french, spanish, mexican, italian, korean,\n" +
            "chinese-trad, chinese-simp, portuguese, russian")
        {
            CacheContext = cacheContext;
        }
        
        public override bool Execute(List<string> args)
        {
            if (args.Count != 1 && args.Count != 2)
                return false;

            GameLanguage language;
            if (!ArgumentParser.ParseLanguage(args[0], out language))
                return false;

            var filter = (args.Count == 2) ? args[1] : null;
            var found = false;

            using (var stream = CacheContext.OpenCacheRead())
            {
                foreach (var unicTag in CacheContext.TagCache.Tags.FindAllInGroup("unic"))
                {
                    var unic = CacheContext.Deserializer.Deserialize<MultilingualUnicodeStringList>(new TagSerializationContext(stream, CacheContext, unicTag));
                    var strings = LocalizedStringPrinter.PrepareForDisplay(unic, CacheContext.StringIdCache, unic.Strings, language, filter);

                    if (strings.Count == 0)
                        continue;

                    if (found)
                        Console.WriteLine();

                    Console.WriteLine("Strings found in {0:X8}.unic:", unicTag.Index);
                    LocalizedStringPrinter.PrintStrings(strings);

                    found = true;
                }
            }

            if (!found)
                Console.Error.WriteLine("No strings found.");

            return true;
        }
    }
}
