﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Commands;
using TagTool.Commands.Tags;
using TagTool.IO;
using TagTool.Serialization;

namespace TagTool
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("en-US");
            ConsoleHistory.Initialize();

            // Get the file path from the first argument
            // If no argument is given, load tags.dat
            var filePath = (args.Length > 0) ? args[0] : "tags.dat";

            // If there are extra arguments, use them to automatically execute a command
            List<string> autoexecCommand = null;
            if (args.Length > 1)
                autoexecCommand = args.Skip(1).ToList();

            if (autoexecCommand == null)
            {
                Console.WriteLine("Tag Tool [{0}]", Assembly.GetExecutingAssembly().GetName().Version);
                Console.WriteLine();
                Console.WriteLine("Please report any bugs and feature requests at");
                Console.WriteLine("<https://github.com/TheGuardians/TagTool/issues>.");
                Console.WriteLine();
                Console.Write("Reading tags...");
            }

            // Load the tag cache
            FileInfo fileInfo = null;
            TagCache cache = null;

            try
            {
                fileInfo = new FileInfo(filePath);
                using (var stream = fileInfo.Open(FileMode.Open, FileAccess.Read))
                    cache = new TagCache(stream);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
                ConsoleHistory.Dump("hott_*_tags_init.log");
                return;
            }

            if (autoexecCommand == null)
                Console.WriteLine("{0} tags loaded.", cache.Tags.Count);

            // Version detection
            CacheVersion closestVersion;
            var version = CacheVersionDetection.Detect(cache, out closestVersion);
            if (version != CacheVersion.Unknown)
            {
                if (autoexecCommand == null)
                {
                    var buildDate = DateTime.FromFileTime(cache.Timestamp);
                    Console.WriteLine("- Detected target engine version {0}.", CacheVersionDetection.GetVersionString(closestVersion));
                    Console.WriteLine("- This cache file was built on {0} at {1}.", buildDate.ToShortDateString(), buildDate.ToShortTimeString());
                }
            }
            else
            {
                Console.WriteLine("WARNING: The cache file's version was not recognized!");
                Console.WriteLine("Using the closest known version {0}.", CacheVersionDetection.GetVersionString(closestVersion));
                version = closestVersion;
            }

            // Load stringIDs
            Console.Write("Reading stringIDs...");
            var stringIdPath = Path.Combine(fileInfo.DirectoryName ?? "", "string_ids.dat");
            var resolver = StringIdResolverFactory.Create(version);
            StringIdCache stringIds = null;
            try
            {
                using (var stream = File.OpenRead(stringIdPath))
                    stringIds = new StringIdCache(stream, resolver);
            }
            catch (IOException)
            {
                Console.WriteLine("Warning: unable to open string_ids.dat!");
                Console.WriteLine("Commands which require stringID values will be unavailable.");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
                ConsoleHistory.Dump("hott_*_string_ids_init.log");
                return;
            }

            if (autoexecCommand == null && stringIds != null)
            {
                Console.WriteLine("{0} strings loaded.", stringIds.Strings.Count);
                Console.WriteLine();
            }

            var cacheContext = new GameCacheContext
            {
                Cache = cache,
                CacheFile = fileInfo,
                StringIDs = stringIds,
                StringIDsFile = (stringIds != null) ? new FileInfo(stringIdPath) : null,
                Version = version,
                Serializer = new TagSerializer(version),
                Deserializer = new TagDeserializer(version),
            };

            var tagNamesPath = "Tags\\tagnames_" + CacheVersionDetection.GetVersionString(version) + ".csv";

            if (File.Exists(tagNamesPath))
            {
                using (var tagNamesStream = File.Open(tagNamesPath, FileMode.Open, FileAccess.Read))
                {
                    var reader = new StreamReader(tagNamesStream);

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var separatorIndex = line.IndexOf(',');
                        var indexString = line.Substring(2, separatorIndex - 2);

                        int tagIndex;
                        if (!int.TryParse(indexString, NumberStyles.HexNumber, null, out tagIndex))
                            tagIndex = -1;

                        if (tagIndex < 0 || tagIndex >= cache.Tags.Count)
                            continue;

                        var nameString = line.Substring(separatorIndex + 1);

                        if (nameString.Contains(" "))
                        {
                            var lastSpaceIndex = nameString.LastIndexOf(' ');
                            nameString = nameString.Substring(lastSpaceIndex + 1, nameString.Length - lastSpaceIndex - 1);
                        }

                        cacheContext.TagNames[tagIndex] = nameString;
                    }

                    reader.Close();
                }
            }

            foreach (var tag in cacheContext.Cache.Tags)
                if (tag != null && !cacheContext.TagNames.ContainsKey(tag.Index))
                    cacheContext.TagNames[tag.Index] = $"0x{tag.Index:X4}";
            
            // Create command context
            var contextStack = new CommandContextStack();
            var tagsContext = TagCacheContextFactory.Create(contextStack, cacheContext);
            contextStack.Push(tagsContext);

            // If autoexecuting a command, just run it and return
            if (autoexecCommand != null)
            {
                if (!ExecuteCommand(contextStack.Context, autoexecCommand))
                    Console.WriteLine("Unrecognized command: {0}", autoexecCommand[0]);
                return;
            }

            Console.WriteLine("Enter \"help\" to list available commands. Enter \"exit\" to quit.");
            while (true)
            {
                // Read and parse a command
                Console.WriteLine();
                Console.Write("{0}> ", contextStack.GetPath());
                var commandLine = Console.ReadLine();
                if (commandLine == null)
                    break;
                string redirectFile;
                var commandArgs = ArgumentParser.ParseCommand(commandLine, out redirectFile);
                if (commandArgs.Count == 0)
                    continue;

                // If "exit" or "quit" is given, pop the current context
                if (commandArgs[0] == "exit" || commandArgs[0] == "quit")
                {
                    if (!contextStack.Pop())
                        break; // No more contexts - quit
                    continue;
                }

                // Handle redirection
                var oldOut = Console.Out;
                StreamWriter redirectWriter = null;
                if (redirectFile != null)
                {
                    redirectWriter = new StreamWriter(File.Open(redirectFile, FileMode.Create, FileAccess.Write));
                    Console.SetOut(redirectWriter);
                }

                // Try to execute it
                if (!ExecuteCommand(contextStack.Context, commandArgs))
                {
                    Console.WriteLine("Unrecognized command: {0}", commandArgs[0]);
                    Console.WriteLine("Use \"help\" to list available commands.");
                }

                // Undo redirection
                if (redirectFile != null)
                {
                    Console.SetOut(oldOut);
                    redirectWriter.Dispose();
                    Console.WriteLine("Wrote output to {0}.", redirectFile);
                }
            }
        }

        private static bool ExecuteCommand(CommandContext context, List<string> commandAndArgs)
        {
            if (commandAndArgs.Count == 0)
                return true;

            // Look up the command
            var command = context.GetCommand(commandAndArgs[0]);
            if (command == null)
                return false;

            // Execute it
            commandAndArgs.RemoveAt(0);

            try
            {
                ExecuteCommand(command, commandAndArgs);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
                ConsoleHistory.Dump("hott_*_crash.log");
            }

            return true;
        }

        private static void ExecuteCommand(Command command, List<string> args)
        {
            if (command.Execute(args))
                return;

            Console.WriteLine("{0}: {1}", command.Name, command.Description);
            Console.WriteLine();
            Console.WriteLine("Usage:");
            Console.WriteLine("{0}", command.Usage);
            Console.WriteLine();
            Console.WriteLine("Use \"help {0}\" for more information.", command.Name);
        }
    }
}