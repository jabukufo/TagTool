using System.Collections.Generic;
using System.IO;
using TagTool.Common;
using TagTool.Geometry;
using TagTool.Serialization;
using TagTool.Tags.Definitions;
using TagTool.Tags;
using TagTool.Cache.HaloOnline;
using TagTool.IO;

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
            resources.LoadCachesFromDirectory(Info.TagCacheFile.DirectoryName);

            var name = Info.StringIdCache.GetString(new StringID(0x1818));

            var jmadDefinitions = new List<ModelAnimationResourceDefinition>();
            var jmadAnimationGroups = new List<List<ModelAnimationResourceDefinition.GroupMember.Animation>>();

            foreach (var resourceGroup in JMAD.ResourceGroups)
            {
                var context = new ResourceSerializationContext(resourceGroup.Resource);
                var jmadDefinition = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition>(context);
                var jmadAnimationGroup = new List<ModelAnimationResourceDefinition.GroupMember.Animation>();

                using (var resourceDataStream = new MemoryStream())
                using (var reader = new EndianReader(resourceDataStream))
                {
                    var dataContext = new DataSerializationContext(reader);

                    resources.Extract(resourceGroup.Resource, resourceDataStream);

                    foreach (var groupMember in jmadDefinition.GroupMembers)
                    {
                        reader.BaseStream.Position = groupMember.AnimationData.Address.Offset;
                        var animation = new ModelAnimationResourceDefinition.GroupMember.Animation();

                        animation.StaticHeader = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition.GroupMember.AnimationHeader>(dataContext);

                        animation.StaticRotations = new ModelAnimationResourceDefinition.GroupMember.Rotation[animation.StaticHeader.RotationCount];

                        for (var i = 0; i < animation.StaticHeader.RotationCount; i++)
                        {
                            animation.StaticRotations[i] = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition.GroupMember.Rotation>(dataContext);
                        }

                        animation.StaticPositions = new ModelAnimationResourceDefinition.GroupMember.Position[animation.StaticHeader.PositionCount];

                        for (var i = 0; i < animation.StaticHeader.PositionCount; i++)
                        {
                            animation.StaticPositions[i] = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition.GroupMember.Position>(dataContext);
                        }

                        animation.AnimatedHeader = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition.GroupMember.AnimationHeader>(dataContext);

                        animation.AnimatedRotations = new ModelAnimationResourceDefinition.GroupMember.Rotation[animation.AnimatedHeader.RotationCount];

                        for (var i = 0; i < animation.AnimatedHeader.RotationCount; i++)
                        {
                            animation.AnimatedRotations[i] = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition.GroupMember.Rotation>(dataContext);
                        }

                        animation.AnimatedPositions = new ModelAnimationResourceDefinition.GroupMember.Position[animation.AnimatedHeader.PositionCount];

                        for (var i = 0; i < animation.AnimatedHeader.PositionCount; i++)
                        {
                            animation.AnimatedPositions[i] = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition.GroupMember.Position>(dataContext);
                        }

                        animation.Footer = Info.Deserializer.Deserialize<ModelAnimationResourceDefinition.GroupMember.AnimationFooter>(dataContext);

                        jmadAnimationGroup.Add(animation);
                    }
                }

                jmadAnimationGroups.Add(jmadAnimationGroup);
                jmadDefinitions.Add(jmadDefinition);
            }

            return true;
        }
    }
}