using System;
using System.Collections.Generic;
using System.IO;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;
using TagTool.TagDefinitions;

namespace TagTool.Commands.RenderMethods
{
    class ListArgumentsCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private CachedTagInstance Tag { get; }
        private RenderMethod Definition { get; }

        public ListArgumentsCommand(GameCacheContext cacheContext, CachedTagInstance tag, RenderMethod definition)
            : base(CommandFlags.Inherit,

                 "ListArguments",
                 "Lists the arguments of the render_method.",

                 "ListArguments",

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

                    var argumentName = CacheContext.GetString(template.Arguments[i].Name);
                    var argumentValue = new RealVector4d(
                        property.Arguments[i].Arg1,
                        property.Arguments[i].Arg2,
                        property.Arguments[i].Arg3,
                        property.Arguments[i].Arg4);

                    Console.WriteLine(string.Format("{0}:", argumentName));

                    if (argumentName.EndsWith("_map"))
                    {
                        Console.WriteLine(string.Format("\tX Scale: {0}", argumentValue.I));
                        Console.WriteLine(string.Format("\tY Scale: {0}", argumentValue.J));
                        Console.WriteLine(string.Format("\tX Offset: {0}", argumentValue.K));
                        Console.WriteLine(string.Format("\tY Offset: {0}", argumentValue.W));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("\tX: {0}", argumentValue.I));
                        Console.WriteLine(string.Format("\tY: {0}", argumentValue.J));
                        Console.WriteLine(string.Format("\tZ: {0}", argumentValue.K));
                        Console.WriteLine(string.Format("\tW: {0}", argumentValue.W));
                    }
                }
            }

            return true;
        }
    }
}
