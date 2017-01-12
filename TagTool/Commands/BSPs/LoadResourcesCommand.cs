using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Geometry;
using TagTool.Serialization;
using TagTool.Tags.TagDefinitions;
using TagTool.TagGroups;

namespace TagTool.Commands.BSPs
{
    class LoadResourcesCommand : Command
    {
        public OpenTagCache Info { get; }
        public TagInstance Tag { get; }
        public ScenarioStructureBsp BSP { get; }

        public LoadResourcesCommand(OpenTagCache info, TagInstance tag, ScenarioStructureBsp bsp)
            : base(CommandFlags.Inherit,
                  "loadresources",
                  "",
                  "loadresources",
                  "")
        {
            Info = info;
            Tag = tag;
            BSP = bsp;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;

            // Load resource caches
            Console.WriteLine("Loading resource caches...");
            var resourceManager = new ResourceDataManager();
            try
            {
                resourceManager.LoadCachesFromDirectory(Info.CacheFile.DirectoryName);
            }
            catch
            {
                Console.WriteLine("Unable to load the resource .dat files.");
                Console.WriteLine("Make sure that they all exist and are valid.");
                return true;
            }

            if (BSP.CollisionBSPResource == null)
            {
                Console.WriteLine("Collision BSP does not have a resource associated with it.");
                return true;
            }

            // Deserialize the collision resource definition
            var resourceContext = new ResourceSerializationContext(BSP.CollisionBSPResource);
            var definition = Info.Deserializer.Deserialize<CollisionBspResourceDefinition>(resourceContext);

            // Reserialize the collision resource definition
            Info.Serializer.Serialize(resourceContext, definition);

            // Reserialize the tag definition
            using (var cacheStream = Info.OpenCacheReadWrite())
            {
                var tagContext = new TagSerializationContext(cacheStream, Info.Cache, Info.StringIDs, Tag);
                Info.Serializer.Serialize(tagContext, BSP);
            }

            return true;
        }
    }
}
