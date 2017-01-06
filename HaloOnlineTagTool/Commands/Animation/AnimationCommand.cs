using System.Collections.Generic;
using System.IO;
using HaloOnlineTagTool.Resources;
using HaloOnlineTagTool.Serialization;
using HaloOnlineTagTool.TagStructures;
using HaloOnlineTagTool.Resources.Geometry;
using System;

namespace HaloOnlineTagTool.Commands.Animation
{
    class AnimationCommand : Command
    {
        private OpenTagCache Info { get; }
        private TagInstance Tag { get; }
        private ModelAnimationGraph JMAD { get; }

        public AnimationCommand(OpenTagCache info, TagInstance tag, ModelAnimationGraph jmad)
            : base(CommandFlags.Inherit, "animation", "", "", "")
        {
            Info = info;
            Tag = tag;
            JMAD = jmad;
        }

        public override bool Execute(List<string> args)
        {
            var resources = new ResourceDataManager();
            resources.LoadCachesFromDirectory(Info.CacheFile.DirectoryName);

            var name = Info.StringIds.GetString(new StringId(0x1818));

            var jmadDefinitions = new List<ModelAnimationResourceDefinition>();

            foreach (var jmadDefinition in JMAD.ResourceGroups)
            {
                var context = new ResourceSerializationContext(jmadDefinition.Resource);
                jmadDefinitions.Add(Info.Deserializer.Deserialize<ModelAnimationResourceDefinition>(context));
            }
            
            return true;
        }
    }
}
