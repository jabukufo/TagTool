using System;
using System.Collections.Generic;
using System.Linq;
using TagTool.Cache.HaloOnline;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Models
{
    class ListVariantsCommand : Command
    {
        private GameCacheContext Info { get; }
        private Model Definition { get; }

        public ListVariantsCommand(GameCacheContext info, Model model) : base(
            CommandFlags.Inherit,
            "listvariants",
            "List available variants of the current model definition.",
            "listvariants",
            "Lists available variants of the current model definition which can be used with \"extractmodel\".")
        {
            Info = info;
            Definition = model;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;
            var variantNames = Definition.Variants.Select(v => Info.StringIDs.GetString(v.Name) ?? v.Name.ToString()).OrderBy(n => n).ToList();
            if (variantNames.Count == 0)
            {
                Console.WriteLine("Model has no variants");
                return true;
            }
            foreach (var name in variantNames)
                Console.WriteLine(name);
            return true;
        }
    }
}
