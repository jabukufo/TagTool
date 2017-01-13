using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Tags;

namespace TagTool.Commands.Editing
{
    class ExecuteCommand : Command
    {
        public GameCacheContext Context { get; }
        public TagInstance Tag { get; }
        public object Definition { get; }

        public ExecuteCommand(GameCacheContext context, TagInstance tag, object definition)
            : base(CommandFlags.None,
                  "execute",
                  "Executes a C# plugin.",
                  "execute <plugin path>",
                  "Executes a C# plugin. This allows the user access to the current " +
                  "game cache context to do as they please.")
        {
            Context = context;
            Tag = tag;
            Definition = definition;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count != 1)
                return false;

            var file = new FileInfo(args[0]);
            var name = file.Name.Substring(0, file.Name.LastIndexOf('.'));
            var source = "";

            using (var reader = new StreamReader(file.OpenRead()))
                source = reader.ReadToEnd();

            var provider = new CSharpCodeProvider();

            var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll", "TagTool.exe" });
            parameters.GenerateInMemory = true;

            var results = provider.CompileAssemblyFromSource(parameters, source);

            var errors = results.Errors.Cast<CompilerError>().ToList();
            errors.ForEach(error => Console.WriteLine(error.ErrorText));

            if (errors.Count != 0)
                return false;

            var pluginType = results.CompiledAssembly.GetType(name);
            var pluginMethod = pluginType.GetMethod("Execute", BindingFlags.Static | BindingFlags.NonPublic);

            if (pluginMethod == null)
                throw new InvalidProgramException("Plugin does not contain an \"Execute\" method.");

            return (bool)pluginMethod.Invoke(null, new[] { Context, Tag, Definition });
        }
    }
}
