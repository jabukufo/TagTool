using System.Collections.Generic;
using System.IO;
using TagTool.Common;
using TagTool.Geometry;
using TagTool.Serialization;
using TagTool.TagDefinitions;
using TagTool.Cache;
using TagTool.IO;
using TagTool.TagResources;

namespace TagTool.Commands.Animations
{
    class AnimationTestCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private CachedTagInstance Tag { get; }
        private ModelAnimationGraph JMAD { get; }

        public AnimationTestCommand(GameCacheContext cacheContext, CachedTagInstance tag, ModelAnimationGraph jmad)
            : base(CommandFlags.Inherit,
                  
                  "AnimationTest",
                  "A test resource-loading command for 'jmad' tags.",

                  "AnimationTest",

                  "A test resource-loading command for 'jmad' tags.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            JMAD = jmad;
        }

        public override bool Execute(List<string> args)
        {
            var resources = new ResourceDataManager();
            resources.LoadCachesFromDirectory(CacheContext.TagCacheFile.DirectoryName);

            var name = CacheContext.StringIdCache.GetString(new StringId(0x1818));

            var jmadDefinitions = new List<ModelAnimationTagResource>();
            var jmadAnimationGroups = new List<List<ModelAnimationTagResource.GroupMember.Animation>>();

            foreach (var resourceGroup in JMAD.ResourceGroups)
            {
                var context = new ResourceSerializationContext(resourceGroup.Resource);
                var jmadDefinition = CacheContext.Deserializer.Deserialize<ModelAnimationTagResource>(context);
                var jmadAnimationGroup = new List<ModelAnimationTagResource.GroupMember.Animation>();

                using (var resourceDataStream = new MemoryStream())
                using (var reader = new EndianReader(resourceDataStream))
                {
                    var dataContext = new DataSerializationContext(reader);

                    resources.Extract(resourceGroup.Resource, resourceDataStream);

                    foreach (var groupMember in jmadDefinition.GroupMembers)
                    {
                        reader.BaseStream.Position = groupMember.AnimationData.Address.Offset;
                        var animation = new ModelAnimationTagResource.GroupMember.Animation();

                        animation.StaticHeader = CacheContext.Deserializer.Deserialize<ModelAnimationTagResource.GroupMember.AnimationHeader>(dataContext);

                        animation.StaticRotations = new ModelAnimationTagResource.GroupMember.Rotation[animation.StaticHeader.RotationCount];

                        for (var i = 0; i < animation.StaticHeader.RotationCount; i++)
                        {
                            animation.StaticRotations[i] = CacheContext.Deserializer.Deserialize<ModelAnimationTagResource.GroupMember.Rotation>(dataContext);
                        }

                        animation.StaticPositions = new ModelAnimationTagResource.GroupMember.Position[animation.StaticHeader.PositionCount];

                        for (var i = 0; i < animation.StaticHeader.PositionCount; i++)
                        {
                            animation.StaticPositions[i] = CacheContext.Deserializer.Deserialize<ModelAnimationTagResource.GroupMember.Position>(dataContext);
                        }

                        animation.AnimatedHeader = CacheContext.Deserializer.Deserialize<ModelAnimationTagResource.GroupMember.AnimationHeader>(dataContext);

                        animation.AnimatedRotations = new ModelAnimationTagResource.GroupMember.Rotation[animation.AnimatedHeader.RotationCount];

                        for (var i = 0; i < animation.AnimatedHeader.RotationCount; i++)
                        {
                            animation.AnimatedRotations[i] = CacheContext.Deserializer.Deserialize<ModelAnimationTagResource.GroupMember.Rotation>(dataContext);
                        }

                        animation.AnimatedPositions = new ModelAnimationTagResource.GroupMember.Position[animation.AnimatedHeader.PositionCount];

                        for (var i = 0; i < animation.AnimatedHeader.PositionCount; i++)
                        {
                            animation.AnimatedPositions[i] = CacheContext.Deserializer.Deserialize<ModelAnimationTagResource.GroupMember.Position>(dataContext);
                        }

                        animation.Footer = CacheContext.Deserializer.Deserialize<ModelAnimationTagResource.GroupMember.AnimationFooter>(dataContext);

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