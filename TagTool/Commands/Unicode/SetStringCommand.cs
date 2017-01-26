using System;
using System.Collections.Generic;
using System.Linq;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Unicode
{
    class SetStringCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private MultilingualUnicodeStringList Definition { get; }

        public SetStringCommand(GameCacheContext cacheContext, TagInstance tag, MultilingualUnicodeStringList unic)
            : base(CommandFlags.None,

                  "set-string",
                  "Set the value of a string",

                  "set-string <language> <stringid> <value>",

                  "Sets the string associated with a stringID in a language.\n" +
                  "Remember to put the string value in quotes if it contains spaces.\n" +
                  "If the string does not exist, it will be added.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Definition = unic;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 3)
                return false;

            GameLanguage language;
            if (!ArgumentParser.ParseLanguage(args[0], out language))
                return false;

            // Look up the stringID that was passed in
            var stringIdStr = args[1];
            var stringIdIndex = CacheContext.StringIdCache.Strings.IndexOf(stringIdStr);
            if (stringIdIndex < 0)
            {
                Console.WriteLine("Unable to find stringID \"{0}\".", stringIdStr);
                return true;
            }
            var stringId = CacheContext.StringIdCache.GetStringId(stringIdIndex);
            if (stringId == StringId.Null)
            {
                Console.WriteLine("Failed to resolve the stringID.");
                return true;
            }
            var newValue = ArgumentParser.Unescape(args[2]);

            // Look up or create a localized string entry
            var localizedStr = Definition.Strings.FirstOrDefault(s => s.StringID == stringId);
            var added = false;
            if (localizedStr == null)
            {
                // Add a new string
                localizedStr = new LocalizedString { StringID = stringId, StringIDStr = stringIdStr };
                Definition.Strings.Add(localizedStr);
                added = true;
            }

            // Save the tag data
            Definition.SetString(localizedStr, language, newValue);

            if (added)
                Console.WriteLine("String added successfully.");
            else
                Console.WriteLine("String changed successfully.");

            return true;
        }
    }
}
