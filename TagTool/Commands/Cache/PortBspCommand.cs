using System;
using System.Collections.Generic;
using System.IO;
using TagTool.GameDefinitions.Base;
using TagTool.Cache;
using TagTool.Serialization;
using TagTool.Tags.TagDefinitions;

namespace TagTool.Commands.Cache
{
    class PortBspCommand : Command
    {
        private OpenTagCache Info { get; }
        private CacheFile BlamCache { get; }

        public PortBspCommand(OpenTagCache info, CacheFile blamCache)
            : base(CommandFlags.Inherit,
                  "portbsp",
                  "",
                  "portbsp <blam tag path> <Halo Online tag index>",
                  "")
        {
            Info = info;
            BlamCache = blamCache;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 2)
                return false;

            //
            // Verify the xbox scenario_structure_bsp tag
            //

            var bspName = args[0];
            var newTagIndex = ArgumentParser.ParseTagIndex(Info, args[1]);

            CacheFile.IndexItem item = null;

            Console.WriteLine("Verifying xbox tag...");

            foreach (var tag in BlamCache.IndexItems)
            {
                if (tag.ClassCode == "sbsp" && tag.Filename == bspName)
                {
                    item = tag;
                    break;
                }
            }

            if (item == null)
            {
                Console.WriteLine("Xbox tag does not exist: " + args[0]);
                return false;
            }

            //
            // Load the xbox scenario_structure_bsp tag
            //

            var xboxContext = new XboxSerializationContext(item);
            var deserializer = new TagDeserializer(BlamCache.Version);
            var sbsp = deserializer.Deserialize<ScenarioStructureBsp>(xboxContext);

            // blank resources that will be generated/converted from ODST automatically later
            var Resource1 = new ResourceReference() { Index = 1337, Owner = newTagIndex }; // render geo 1
            var Resource2 = new ResourceReference() { Index = 1337, Owner = newTagIndex }; // render geo 2
            var Resource3 = new ResourceReference() { Index = 1337, Owner = newTagIndex }; // collision BSP tag data
            var Resource4 = new ResourceReference() { Index = 1337, Owner = newTagIndex }; // other tag data and shit (unknown raw 3rd in halo 3, etc.)

            // Set the resource refs in the tag to the blank ones we just made
            sbsp.Geometry.Resource = Resource1;
            sbsp.Geometry2.Resource = Resource2;
            sbsp.CollisionBSPResource = Resource3;
            sbsp.Resource4 = Resource4;

            using (var cacheStream = Info.CacheFile.Open(FileMode.Open, FileAccess.ReadWrite))
            {
                Console.WriteLine("Writing ElDewrito tag to tag " + newTagIndex+"...");

                var context = new TagSerializationContext(cacheStream, Info.Cache, Info.StringIDs, Info.Cache.Tags[newTagIndex.Index]);
                Info.Serializer.Serialize(context, sbsp);
            }

            return true;
        }
    }
}
