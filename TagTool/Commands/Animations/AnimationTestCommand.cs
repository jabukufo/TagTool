using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Geometry;
using TagTool.Serialization;
using TagTool.Tags.Definitions;
using TagTool.Tags;
using TagTool.Cache.HaloOnline;

namespace TagTool.Commands.Animations
{
    class AnimationTestCommand : Command
    {
        private GameCacheContext Info { get; }
        private TagInstance Tag { get; }
        private ModelAnimationGraph JMAD { get; }

        public AnimationTestCommand(GameCacheContext info, TagInstance tag, ModelAnimationGraph jmad)
            : base(CommandFlags.Inherit, "animation_test", "", "", "")
        {
            Info = info;
            Tag = tag;
            JMAD = jmad;
        }

        public override bool Execute(List<string> args)
        {
            var resources = new ResourceDataManager();
            resources.LoadCachesFromDirectory(Info.CacheFile.DirectoryName);

            var name = Info.StringIDs.GetString(new StringID(0x1818));

            var jmadDefinitions = new List<ModelAnimationResourceDefinition>();
            var jmadAnimationGroups = new List<List<byte[]>>();

            foreach (var resourceGroup in JMAD.ResourceGroups)
            {
                var context = new ResourceSerializationContext(resourceGroup.Resource);
                var jmadDefinition = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition>(context);
                var jmadAnimationGroup = new List<byte[]>();

                using (var resourceDataStream = new MemoryStream())
                using (var reader = new BinaryReader(resourceDataStream))
                {
                    resources.Extract(resourceGroup.Resource, resourceDataStream);

                    foreach (var groupMember in jmadDefinition.GroupMembers)
                    {
                        reader.BaseStream.Position = groupMember.AnimationData.Address.Offset;
                        jmadAnimationGroup.Add(reader.ReadBytes(groupMember.AnimationData.Size));
                    }
                }

                jmadAnimationGroups.Add(jmadAnimationGroup);
                jmadDefinitions.Add(jmadDefinition);
            }

            return true;
        }
    }
}