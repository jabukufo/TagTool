using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using TagTool.Cache;
using TagTool.Commands;
using TagTool.Commands.Tags;
using TagTool.IO;
using TagTool.Serialization;

namespace TagTool
{
    static class Program
    {
        enum WindowState : int
        {
            Hidden = 0,
            Normal = 1,
            Minimized = 2,
            Maximized = 3,
            Inactive = 4,
        }

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, WindowState state);

        static void Main(string[] args)
        {
            // Get the file path from the first argument
            // If no argument is given, load tags.dat
            var filePath = (args.Length > 0) ? args[0] : "tags.dat";

            // If there are extra arguments, use them to automatically execute a command
            List<string> autoexecCommand = null;
            if (args.Length > 1)
                autoexecCommand = args.Skip(1).ToList();

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("en-US");
            ConsoleHistory.Initialize();

            if (autoexecCommand != null)
            {
                // Hide the console window
                ShowWindow(Process.GetCurrentProcess().MainWindowHandle, WindowState.Hidden);
            }
            else
            {
                // Maximize the console window
                ShowWindow(Process.GetCurrentProcess().MainWindowHandle, WindowState.Maximized);

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
                TagCache = cache,
                TagCacheFile = fileInfo,
                StringIdCache = stringIds,
                StringIdCacheFile = (stringIds != null) ? new FileInfo(stringIdPath) : null,
                Version = version,
                Serializer = new TagSerializer(version),
                Deserializer = new TagDeserializer(version),
            };

            var tagNamesPath = "tagnames_" + CacheVersionDetection.GetVersionString(version) + ".csv";

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

            foreach (var tag in cacheContext.TagCache.Tags)
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
                Console.WriteLine();
                Console.Write("{0}> ", contextStack.GetPath());

                var commandNames = new List<string> { "exit" };
                var context = contextStack.Context;
                var first = true;

                while (context != null)
                {
                    foreach (var command in context.Commands)
                    {
                        if (!first && command.Flags == CommandFlags.None)
                            continue;

                        commandNames.Add(command.Name);
                    }

                    if (first)
                        first = false;

                    context = context.Parent;
                }

                var commandLine = ReadCommandLine(contextStack, commandNames, s => s);

                if (commandLine == null)
                    break;

                string redirectFile;
                var commandArgs = ArgumentParser.ParseCommand(commandLine, out redirectFile);
                if (commandArgs.Count == 0)
                    continue;

                // If "exit" or "quit" is given, pop the current context
                if (commandArgs[0].ToLower() == "exit" || commandArgs[0].ToLower() == "quit")
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

        public static string ReadCommandLine<T, TResult>(CommandContextStack contextStack, IEnumerable<T> hintSource, Func<T, TResult> hintField, string inputRegex = ".*", ConsoleColor hintColor = ConsoleColor.DarkGray)
        {
            ConsoleKeyInfo input;

            var suggestion = string.Empty;
            var userInput = string.Empty;
            var commandLine = string.Empty;

            while (ConsoleKey.Enter != (input = Console.ReadKey()).Key)
            {
                if (input.Key == ConsoleKey.Backspace)
                    userInput = userInput.Any() ? userInput.Remove(userInput.Length - 1, 1) : string.Empty;

                else if (input.Key == ConsoleKey.Tab)
                    userInput = suggestion ?? userInput;

                else if (input != null && Regex.IsMatch(input.KeyChar.ToString(), inputRegex))
                    userInput += input.KeyChar;

                suggestion = hintSource.Select(item => hintField(item).ToString())
                    .FirstOrDefault(item => item.Length > userInput.Length && item.Substring(0, userInput.Length).ToLower() == userInput.ToLower());

                commandLine = suggestion == null ? userInput : suggestion;

                // Clear the console input line
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
                
                Console.Write("{0}> {1}", contextStack.GetPath(), userInput);

                var originalColor = Console.ForegroundColor;

                Console.ForegroundColor = hintColor;

                if (userInput.Any())
                    Console.Write(commandLine.Substring(userInput.Length, commandLine.Length - userInput.Length));

                Console.ForegroundColor = originalColor;
            }

            Console.Write("{0}> {1}", contextStack.GetPath(), commandLine);
            Console.WriteLine();

            return commandLine;
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