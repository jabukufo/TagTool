﻿using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.TagDefinitions;

namespace TagTool.Commands.Tags
{
    class UpdateMapFilesCommand : Command
    {
        public GameCacheContext CacheContext { get; }

        public UpdateMapFilesCommand(GameCacheContext cacheContext)
            : base(CommandFlags.Inherit,

                  "UpdateMapFiles",
                  "Updates the game's .map files to contain valid scenario tag indices.",

                  "UpdateMapFiles",

                  "Updates the game's .map files to contain valid scenario tag indices.")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 0)
                return false;

            var mapIndices = new Dictionary<int, int>();

            using (var cacheStream = CacheContext.OpenTagCacheRead())
            {
                foreach (var scnrTag in CacheContext.TagCache.Tags.FindAllInGroup("scnr"))
                {
                    var tagContext = new TagSerializationContext(cacheStream, CacheContext, scnrTag);
                    var scnr = CacheContext.Deserializer.Deserialize<Scenario>(tagContext);
                    mapIndices[scnr.MapId] = scnrTag.Index;
                }
            }

            foreach (var mapFile in CacheContext.Directory.GetFiles("*.map"))
            {
                try
                {
                    using (var stream = mapFile.Open(FileMode.Open, FileAccess.ReadWrite))
                    using (var reader = new BinaryReader(stream))
                    using (var writer = new BinaryWriter(stream))
                    {
                        if (reader.ReadInt32() != new Tag("head").Value)
                        {
                            Console.Error.WriteLine("Invalid map file");
                            return true;
                        }

                        reader.BaseStream.Position = 0x2DEC;
                        var mapId = reader.ReadInt32();

                        if (mapIndices.ContainsKey(mapId))
                        {
                            var mapIndex = mapIndices[mapId];

                            writer.BaseStream.Position = 0x2DF0;
                            writer.Write(mapIndex);

                            Console.WriteLine($"Scenario tag index for {mapFile.Name}: {mapIndex:X8}");
                        }

                    }
                }
                catch (IOException)
                {
                    Console.Error.WriteLine("Unable to open the map file for reading.");
                }
            }

            Console.WriteLine("Done!");

            return true;
        }
    }
}
