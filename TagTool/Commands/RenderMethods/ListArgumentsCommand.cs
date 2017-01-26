using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.Tags;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.RenderMethods
{
    class ListArgumentsCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagInstance Tag { get; }
        private RenderMethod Definition { get; }

        public ListArgumentsCommand(GameCacheContext cacheContext, TagInstance tag, RenderMethod definition)
            : base(CommandFlags.Inherit,

                 "list-arguments",
                 "Lists the arguments of the render_method.",

                 "list-arguments",

                 "Lists the arguments of the render_method.")
        {
            CacheContext = cacheContext;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            foreach (var property in Definition.ShaderProperties)
            {
                RenderMethodTemplate template = null;

                using (var cacheStream = CacheContext.TagCacheFile.Open(FileMode.Open, FileAccess.Read))
                {
                    var context = new TagSerializationContext(cacheStream, CacheContext, property.Template);
                    template = CacheContext.Deserializer.Deserialize<RenderMethodTemplate>(context);
                }

                for (var i = 0; i < template.Arguments.Count; i++)
                {
                    Console.WriteLine("");

                    var argumentName = CacheContext.StringIdCache.GetString(template.Arguments[i].Name);
                    var argumentValue = new Vector4(
                        property.Arguments[i].Arg1,
                        property.Arguments[i].Arg2,
                        property.Arguments[i].Arg3,
                        property.Arguments[i].Arg4);

                    Console.WriteLine(string.Format("{0}:", argumentName));

                    if (argumentName.EndsWith("_map"))
                    {
                        Console.WriteLine(string.Format("\tX Scale: {0}", argumentValue.X));
                        Console.WriteLine(string.Format("\tY Scale: {0}", argumentValue.Y));
                        Console.WriteLine(string.Format("\tX Offset: {0}", argumentValue.Z));
                        Console.WriteLine(string.Format("\tY Offset: {0}", argumentValue.W));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("\tX: {0}", argumentValue.X));
                        Console.WriteLine(string.Format("\tY: {0}", argumentValue.Y));
                        Console.WriteLine(string.Format("\tZ: {0}", argumentValue.Z));
                        Console.WriteLine(string.Format("\tW: {0}", argumentValue.W));
                    }
                }
            }

            return true;
        }
    }
}
