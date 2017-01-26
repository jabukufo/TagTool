using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using TagTool.Cache;
using TagTool.Common;

namespace TagTool.Commands.Tags
{
    class StringIDCommand : Command
    {
        private GameCacheContext CacheContext { get; }

        public StringIDCommand(GameCacheContext cacheContext) : base(
            CommandFlags.Inherit,

            "stringid",
            "Add, look up, or find stringID values",

            "stringid add <string>\n" +
            "stringid get <id>\n" +
            "stringid list [filter]",

            "\"stringid add\" will add a new stringID.\n" +
            "\"stringid get\" will display the string corresponding to an ID value.\n" +
            "\"stringid list\" will list stringIDs, optionally filtering them.")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count == 0)
                return false;

            switch (args[0])
            {
                case "add":
                    return ExecuteAdd(args);

                case "get":
                    return ExecuteGet(args);

                case "list":
                    return ExecuteList(args);
            }

            return false;
        }

        private bool ExecuteAdd(List<string> args)
        {
            if (args.Count != 2)
                return false;

            var str = args[1];
            var id = CacheContext.StringIdCache.Add(str);

            using (var stream = CacheContext.StringIdCacheFile.Open(FileMode.Open, FileAccess.ReadWrite))
                CacheContext.StringIdCache.Save(stream);
            
            Console.WriteLine("Added string \"{0}\" as {1}.", str, id);

            return true;
        }

        private bool ExecuteGet(List<string> args)
        {
            if (args.Count != 2)
                return false;

            uint stringId;
            if (!uint.TryParse(args[1], NumberStyles.HexNumber, null, out stringId))
                return false;

            var str = CacheContext.StringIdCache.GetString(new StringId(stringId));

            if (str != null)
                Console.WriteLine(str);
            else
                Console.Error.WriteLine("Unable to find a string with ID 0x{0:X}.", stringId);

            return true;
        }

        private bool ExecuteList(List<string> args)
        {
            if (args.Count > 2)
                return false;

            var filter = (args.Count == 2) ? args[1] : null;
            var strings = new List<FoundStringID>();

            for (var i = 0; i < CacheContext.StringIdCache.Strings.Count; i++)
            {
                if (CacheContext.StringIdCache.Strings[i] == null)
                    continue;

                if (filter != null && !CacheContext.StringIdCache.Strings[i].Contains(filter))
                    continue;

                var id = CacheContext.StringIdCache.GetStringId(i);

                strings.Add(new FoundStringID
                {
                    ID = id,
                    Display = id.ToString(),
                    Value = CacheContext.StringIdCache.Strings[i]
                });
            }

            if (strings.Count == 0)
            {
                Console.Error.WriteLine("No strings found.");
                return true;
            }

            strings.Sort((a, b) => a.ID.CompareTo(b.ID));

            var idWidth = strings.Max(s => s.Display.Length);
            var formatStr = string.Format("{{0,-{0}}}  {{1}}", idWidth);

            foreach (var str in strings)
                Console.WriteLine(formatStr, str.Display, str.Value);

            return true;
        }

        private class FoundStringID
        {
            public StringId ID { get; set; }
            public string Display { get; set; }
            public string Value { get; set; }
        }
    }
}
