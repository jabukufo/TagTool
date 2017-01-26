using System;
using System.Collections.Generic;
using System.Linq;
using TagTool.Cache;
using TagTool.Tags;

namespace TagTool.Commands.Tags
{
    /// <summary>
    /// Command for managing tag dependencies.
    /// </summary>
    class TagDependencyCommand : Command
    {
        public GameCacheContext CacheContext { get; }

        public TagDependencyCommand(GameCacheContext cacheContext) : base(
            CommandFlags.None,

            "tag-dependency",
            "Manage tag dependencies.",

            "tag-dependency add <tag> {... dependencies ...}\n" +
            "tag-dependency remove <tag> {... dependencies ...}\n" +
            "tag-dependency list <tag>\n" +
            "tag-dependency list-all <tag>\n" +
            "tag-dependency list-on <tag>",

            "\"tag-dependency add\" will cause the first tag to load the other tags.\n" +
            "\"tag-dependency remove\" will prevent the first tag from loading the other tags.\n" +
            "\"tag-dependency list\" will list all immediate dependencies of a tag.\n" +
            "\"tag-dependency list-all\" will recursively list all dependencies of a tag.\n" +
            "\"tag-dependency list-on\" will list all tags that depend on a tag.\n" +
            "\n" +
            "To add dependencies to a map, use the \"map\" command to get its scenario tag\n" +
            "index and then add dependencies to the scenario tag.")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count < 2)
                return false;

            var tag = ArgumentParser.ParseTagIndex(CacheContext, args[1]);

            if (tag == null)
                return false;

            switch (args[0])
            {
                case "add":
                case "remove":
                    return ExecuteAddRemove(tag, args);

                case "list":
                case "list-all":
                    return ExecuteList(tag, (args[0] == "list-all"));

                case "list-on":
                    return ExecuteListDependsOn(tag);

                default:
                    return false;
            }
        }

        private bool ExecuteAddRemove(TagInstance tag, List<string> args)
        {
            if (args.Count < 3)
                return false;

            var dependencies = args.Skip(2).Select(a => ArgumentParser.ParseTagIndex(CacheContext, a)).ToList();

            if (dependencies.Count == 0 || dependencies.Any(d => d == null))
                return false;

            using (var stream = CacheContext.OpenTagCacheReadWrite())
            {
                var data = CacheContext.TagCache.ExtractTag(stream, tag);

                if (args[0] == "add")
                {
                    foreach (var dependency in dependencies)
                    {
                        if (data.Dependencies.Add(dependency.Index))
                            Console.WriteLine("Added dependency on tag {0:X8}.", dependency.Index);
                        else
                            Console.Error.WriteLine("Tag {0:X8} already depends on tag {1:X8}.", tag.Index, dependency.Index);
                    }
                }
                else
                {
                    foreach (var dependency in dependencies)
                    {
                        if (data.Dependencies.Remove(dependency.Index))
                            Console.WriteLine("Removed dependency on tag {0:X8}.", dependency.Index);
                        else
                            Console.Error.WriteLine("Tag {0:X8} does not depend on tag {1:X8}.", tag.Index, dependency.Index);
                    }
                }

                CacheContext.TagCache.SetTagData(stream, tag, data);
            }

            return true;
        }

        private bool ExecuteList(TagInstance tag, bool all)
        {
            if (tag.Dependencies.Count == 0)
            {
                Console.Error.WriteLine("Tag {0:X8} has no dependencies.", tag.Index);
                return true;
            }

            IEnumerable<TagInstance> dependencies;

            if (all)
                dependencies = CacheContext.TagCache.Tags.FindDependencies(tag);
            else
                dependencies = tag.Dependencies.Where(i => CacheContext.TagCache.Tags.Contains(i)).Select(i => CacheContext.TagCache.Tags[i]);

            foreach (var dependency in dependencies)
            {
                var tagName = CacheContext.TagNames.ContainsKey(dependency.Index) ?
                    CacheContext.TagNames[dependency.Index] :
                    $"0x{dependency.Index:X4}";

                Console.WriteLine($"[Index: 0x{dependency.Index:X4}, Offset: 0x{dependency.HeaderOffset:X8}, Size: 0x{dependency.TotalSize:X4}] {tagName}.{CacheContext.StringIdCache.GetString(dependency.Group.Name)}");
            }

            return true;
        }

        private bool ExecuteListDependsOn(TagInstance tag)
        {
            var dependsOn = CacheContext.TagCache.Tags.NonNull().Where(t => t.Dependencies.Contains(tag.Index));

            foreach (var dependency in dependsOn)
            {
                var tagName = CacheContext.TagNames.ContainsKey(dependency.Index) ?
                    CacheContext.TagNames[dependency.Index] :
                    $"0x{dependency.Index:X4}";

                Console.WriteLine($"[Index: 0x{dependency.Index:X4}, Offset: 0x{dependency.HeaderOffset:X8}, Size: 0x{dependency.TotalSize:X4}] {tagName}.{CacheContext.StringIdCache.GetString(dependency.Group.Name)}");
            }

            return true;
        }
    }
}
