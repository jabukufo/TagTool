using System;
using System.Collections.Generic;
using TagTool.Serialization;
using TagTool.Tags.Definitions;
using TagTool.Tags;
using TagTool.Cache.HaloOnline;
using System.Globalization;

namespace TagTool.Commands.Tags
{
    class NewTagCommand : Command
    {
        public GameCacheContext Info { get; }

        public NewTagCommand(GameCacheContext info)
            : base(CommandFlags.Inherit,
                  "newtag",
                  "Creates a new tag of the specified tag group in the current tag cache.",
                  "newtag <group tag> [index = *]",
                  "Creates a new tag of the specified tag group in the current tag cache.")
        {
            Info = info;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count < 1 || args.Count > 2)
                return false;

            var groupTag = ArgumentParser.ParseGroupTag(Info.StringIdCache, args[0]);

            if (groupTag == null || !TagGroup.Instances.ContainsKey(groupTag))
                return false;

            TagInstance instance = null;

            using (var stream = Info.OpenCacheReadWrite())
            {
                if (args.Count == 2)
                {
                    int tagIndex;
                    if (!int.TryParse(args[1].Replace("0x", ""), NumberStyles.HexNumber, null, out tagIndex))
                        return false;

                    if (tagIndex > Info.TagCache.Tags.Count)
                        return false;

                    if (tagIndex < Info.TagCache.Tags.Count)
                    {
                        if (Info.TagCache.Tags[tagIndex] != null)
                        {
                            var oldInstance = Info.TagCache.Tags[tagIndex];
                            Info.TagCache.Tags[tagIndex] = null;
                            Info.TagCache.SetTagDataRaw(stream, oldInstance, new byte[] { });
                        }

                        instance = new TagInstance(tagIndex, TagGroup.Instances[groupTag]);
                        Info.TagCache.Tags[tagIndex] = instance;
                    }
                }

                if (instance == null)
                    instance = Info.TagCache.AllocateTag(TagGroup.Instances[groupTag]);

                var context = new TagSerializationContext(stream, Info, instance);
                var data = Activator.CreateInstance(TagStructureTypes.FindByGroupTag(groupTag));
                Info.Serializer.Serialize(context, data);
            }

            var tagName = Info.TagNames.ContainsKey(instance.Index) ?
                Info.TagNames[instance.Index] :
                $"0x{instance.Index:X4}";

            Console.WriteLine($"[Index: 0x{instance.Index:X4}, Offset: 0x{instance.HeaderOffset:X8}, Size: 0x{instance.TotalSize:X4}] {tagName}.{Info.StringIdCache.GetString(instance.Group.Name)}");

            return true;
        }
    }
}
