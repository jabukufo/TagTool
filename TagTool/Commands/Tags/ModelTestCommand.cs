using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Assimp;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Geometry;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Tags.Definitions;
using PrimitiveType = TagTool.Geometry.PrimitiveType;

namespace TagTool.Commands.Tags
{
    class ModelTestCommand : Command
    {
        private GameCacheContext CacheContext { get; }

        public ModelTestCommand(GameCacheContext cacheContext)
            : base(CommandFlags.Inherit,
                  
                  "model-test",
                  "Model injection test",

                  "model-test [location = resources] [tag index = 0x3317] <model file>",

                  "Injects the model over the traffic cone.\n" +
                  "The model must only have a single material and no nodes.")
        {
            CacheContext = cacheContext;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count < 1 || args.Count > 3)
                return false;

            ResourceLocation location = ResourceLocation.Resources;
            TagInstance destination = CacheContext.TagCache.Tags[0x3317];

            if (args.Count == 3)
            {
                var value = args[0];

                switch (value)
                {
                    case "resources":
                        location = ResourceLocation.Resources;
                        break;

                    case "textures":
                        location = ResourceLocation.Textures;
                        break;

                    case "textures_b":
                        location = ResourceLocation.TexturesB;
                        break;

                    case "audio":
                        location = ResourceLocation.Audio;
                        break;

                    case "video":
                        location = ResourceLocation.Video;
                        break;

                    case "render_models":
                        location = ResourceLocation.RenderModels;
                        break;

                    case "lightmaps":
                        location = ResourceLocation.Lightmaps;
                        break;

                    default:
                        Console.WriteLine("Invalid resource location: " + value);
                        return false;
                }

                args.RemoveAt(0);
            }

            if (args.Count == 2)
            {
                destination = ArgumentParser.ParseTagIndex(CacheContext, args[0]);

                if (!destination.IsInGroup("mode"))
                {
                    Console.WriteLine("Specified tag is not a render_model: " + args[0]);
                    return false;
                }

                args.RemoveAt(0);
            }

            var builder = new RenderModelBuilder(CacheContext.Version);

            // Add a root node
            var node = builder.AddNode(new RenderModel.Node
            {
                Name = CacheContext.StringIdCache.GetStringId("street_cone"),
                ParentNode = -1,
                FirstChildNode = -1,
                NextSiblingNode = -1,
                DefaultRotation = new Vector4(0, 0, 0, -1),
                DefaultScale = 1,
                InverseForward = new Vector3(1, 0, 0),
                InverseLeft = new Vector3(0, 1, 0),
                InverseUp = new Vector3(0, 0, 1),
            });

            // Begin building the default region and permutation
            builder.BeginRegion(CacheContext.StringIdCache.GetStringId("default"));
            builder.BeginPermutation(CacheContext.StringIdCache.GetStringId("default"));

            using (var importer = new AssimpContext())
            {
                Scene model;
                using (var logStream = new LogStream((msg, userData) => Console.WriteLine(msg)))
                {
                    logStream.Attach();
                    model = importer.ImportFile(args[0],
                        PostProcessSteps.CalculateTangentSpace |
                        PostProcessSteps.GenerateNormals |
                        PostProcessSteps.JoinIdenticalVertices |
                        PostProcessSteps.SortByPrimitiveType |
                        PostProcessSteps.PreTransformVertices |
                        PostProcessSteps.Triangulate);
                    logStream.Detach();
                }

                Console.WriteLine("Assembling vertices...");

                // Build a multipart mesh from the model data,
                // with each model mesh mapping to a part of one large mesh and having its own material
                builder.BeginMesh();
                ushort partStartVertex = 0;
                ushort partStartIndex = 0;
                var vertices = new List<RigidVertex>();
                var indices = new List<ushort>();
                foreach (var mesh in model.Meshes)
                {
                    for (var i = 0; i < mesh.VertexCount; i++)
                    {
                        var position = mesh.Vertices[i];
                        var normal = mesh.Normals[i];
                        var uv = mesh.TextureCoordinateChannels[0][i];
                        var tangent = mesh.Tangents[i];
                        var bitangent = mesh.BiTangents[i];
                        vertices.Add(new RigidVertex
                        {
                            Position = new Vector4(position.X, position.Y, position.Z, 1),
                            Normal = new Vector3(normal.X, normal.Y, normal.Z),
                            Texcoord = new Vector2(uv.X, uv.Y),
                            Tangent = new Vector4(tangent.X, tangent.Y, tangent.Z, 1),
                            Binormal = new Vector3(bitangent.X, bitangent.Y, bitangent.Z),
                        });
                    }

                    // Build the index buffer
                    var meshIndices = mesh.GetIndices();
                    indices.AddRange(meshIndices.Select(i => (ushort)(i + partStartVertex)));

                    // Define a material and part for this mesh
                    var material = builder.AddMaterial(new RenderMaterial
                    {
                        RenderMethod = CacheContext.TagCache.Tags[0x101F],
                    });


                    builder.BeginPart(material, partStartIndex, (ushort)meshIndices.Length, (ushort)mesh.VertexCount);
                    builder.DefineSubPart(partStartIndex, (ushort)meshIndices.Length, (ushort)mesh.VertexCount);
                    builder.EndPart();

                    // Move to the next part
                    partStartVertex += (ushort)mesh.VertexCount;
                    partStartIndex += (ushort)meshIndices.Length;
                }

                // Bind the vertex and index buffers
                builder.BindRigidVertexBuffer(vertices, node);
                builder.BindIndexBuffer(indices, PrimitiveType.TriangleList);
                builder.EndMesh();
            }

            builder.EndPermutation();
            builder.EndRegion();

            Console.WriteLine("Building Blam mesh data...");

            var resourceStream = new MemoryStream();
            var renderModel = builder.Build(CacheContext.Serializer, resourceStream);

            Console.WriteLine("Writing resource data...");

            // Add a new resource for the model data
            var resources = new ResourceDataManager();
            resources.LoadCachesFromDirectory(CacheContext.TagCacheFile.DirectoryName);
            resourceStream.Position = 0;
            resources.Add(renderModel.Geometry.Resource, location, resourceStream);

            Console.WriteLine("Writing tag data...");

            using (var cacheStream = CacheContext.OpenTagCacheReadWrite())
            {
                var tag = destination;
                var context = new TagSerializationContext(cacheStream, CacheContext, tag);
                CacheContext.Serializer.Serialize(context, renderModel);
            }

            Console.WriteLine("Model imported successfully!");

            return true;
        }
    }
}
