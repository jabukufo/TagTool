using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Common;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Unicode
{
    class ListStringsCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private MultilingualUnicodeStringList Definition { get; }

        public ListStringsCommand(GameCacheContext cacheContext, MultilingualUnicodeStringList definition)
            : base(CommandFlags.Inherit,
                  "ListStrings",
                  "Lists the unicode strings belonging to a certain language.",
                  
                  "ListStrings <language> [filter]",

                  "Lists the unicode strings belonging to a certain language.\n" +
                  "If a filter is specified, only strings containing the filter will be listed.\n" +
                  "\n" +
                  "Available languages:\n" +
                  "\n" +
                  "english, japanese, german, french, spanish, mexican, italian, korean,\n" +
                  "chinese-trad, chinese-simp, portuguese, russian")
        {
            // TODO: Can we dynamically generate the language list from the dictionary in ArgumentParser?
            CacheContext = cacheContext;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1 && args.Count != 2)
                return false;

            GameLanguage language;
            if (!ArgumentParser.ParseLanguage(args[0], out language))
                return false;

            var filter = (args.Count == 2) ? args[1] : null;
            var strings = LocalizedStringPrinter.PrepareForDisplay(Definition, CacheContext.StringIdCache, Definition.Strings, language, filter);

            if (strings.Count > 0)
                LocalizedStringPrinter.PrintStrings(strings);
            else
                Console.WriteLine("No strings found.");
            
            return true;
        }
    }
}
