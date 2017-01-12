using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Geometry;
using TagTool.Serialization;
using TagTool.Tags.TagDefinitions;
using TagTool.TagGroups;

namespace TagTool.Commands.Animations
{
    class AnimationTestCommand : Command
    {
        private OpenTagCache Info { get; }
        private TagInstance Tag { get; }
        private ModelAnimationGraph JMAD { get; }

        public AnimationTestCommand(OpenTagCache info, TagInstance tag, ModelAnimationGraph jmad)
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

            foreach (var resourceGroup in JMAD.ResourceGroups)
            {
                var context = new ResourceSerializationContext(resourceGroup.Resource);
                var jmadDefinition = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition>(context);

                using (var resourceDataStream = new MemoryStream())
                using (var reader = new BinaryReader(resourceDataStream))
                {
                    resources.Extract(resourceGroup.Resource, resourceDataStream);

                    //
                    // TODO: Load data from the extracted resource
                    //
                }

                jmadDefinitions.Add(jmadDefinition);
            }

            return true;
        }
    }
}