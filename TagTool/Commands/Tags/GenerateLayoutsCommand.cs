﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TagTool.Analysis;
using TagTool.Cache;
using TagTool.Layouts;

namespace TagTool.Commands.Tags
{
    class GenerateLayoutsCommand : Command
    {
        private GameCacheContext CacheContext { get; }

        public GenerateLayoutsCommand(GameCacheContext cacheFile) : base(
            CommandFlags.Inherit,

            "generate-layouts",
            "Generate tag layouts",

            "genlayouts <type> <output dir>",

            "Scans all tags in the file to guess tag layouts.\n" +
            "Layouts will be written to the output directory in the chosen format.\n" +
            "\n" +
            "Supported types: csharp, cpp")
        {
            CacheContext = cacheFile;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 2)
                return false;

            var type = args[0];
            var outDir = args[1];

            TagLayoutWriter writer;

            switch (type)
            {
                case "csharp":
                    writer = new CSharpLayoutWriter();
                    break;
                case "cpp":
                    writer = new CppLayoutWriter();
                    break;
                default:
                    return false;
            }

            Directory.CreateDirectory(outDir);

            var count = 0;
            using (var stream = CacheContext.OpenTagCacheRead())
            {
                foreach (var groupTag in CacheContext.TagCache.Tags.NonNull().Select(t => t.Group.Tag).Distinct())
                {
                    TagLayoutGuess layout = null;
                    TagInstance lastTag = null;

                    foreach (var tag in CacheContext.TagCache.Tags.FindAllInGroup(groupTag))
                    {
                        Console.Write("Analyzing ");
                        TagPrinter.PrintTagShort(tag);

                        lastTag = tag;

                        var analyzer = new TagAnalyzer(CacheContext.TagCache);
                        var data = CacheContext.TagCache.ExtractTag(stream, tag);
                        var tagLayout = analyzer.Analyze(data);

                        if (layout != null)
                            layout.Merge(tagLayout);
                        else
                            layout = tagLayout;
                    }

                    if (layout != null && lastTag != null)
                    {
                        Console.WriteLine("Writing {0} layout", groupTag);

                        var name = CacheContext.StringIdCache.GetString(lastTag.Group.Name);
                        var tagLayout = LayoutGuessFinalizer.MakeLayout(layout, name, groupTag);
                        var path = Path.Combine(outDir, writer.GetSuggestedFileName(tagLayout));

                        writer.WriteLayout(tagLayout, path);

                        count++;
                    }
                }
            }

            Console.WriteLine("Successfully generated {0} layouts!", count);

            return true;
        }
    }
}
