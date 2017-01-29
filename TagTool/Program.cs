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

namespace TagTool
{
    static class Program
    {
        private enum WindowState : int
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
            var filePath = (args.Length > 0) ? args[0] : "C:\\AnvilOnline\\maps\\tags.dat";

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

                Console.WriteLine("TagTool [{0}]", Assembly.GetExecutingAssembly().GetName().Version);
                Console.WriteLine();
                Console.WriteLine("Please report any bugs and feature requests at");
                Console.WriteLine("<https://github.com/TheGuardians/TagTool/issues>.");
                Console.WriteLine();
            }

            var cacheContext = new GameCacheContext(new FileInfo(filePath).Directory);

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

            Console.WriteLine("Enter \"Help\" to list available commands, enter \"Exit\" to leave\n" +
                              "the current editing context, or enter \"Quit\" to quit.");
            while (true)
            {
                var originalColor = Console.ForegroundColor;
                var contextPath = contextStack.GetPath();

                Console.WriteLine();

                if (contextStack.Context.Name.Length < contextPath.Length)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(contextPath.Substring(0, contextPath.Length - contextStack.Context.Name.Length));
                }

                Console.ForegroundColor = originalColor;
                Console.Write(contextStack.Context.Name);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("> ");
                Console.ForegroundColor = originalColor;

                var commandNames = new List<string> { "Exit", "Quit" };
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

                commandNames.Sort();

                var commandLine = ReadCommandLine(contextStack, commandNames, s => s);

                if (commandLine == null)
                    break;

                string redirectFile;
                var commandArgs = ArgumentParser.ParseCommand(commandLine, out redirectFile);
                if (commandArgs.Count == 0)
                    continue;
                
                if (commandArgs[0].ToLower() == "quit")
                {
                    break;
                }

                if (commandArgs[0].ToLower() == "exit")
                {
                    if (!contextStack.Pop())
                        break;

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

        private static string ReadCommandLine<T, TResult>(CommandContextStack contextStack, IEnumerable<T> hintSource, Func<T, TResult> hintField, string inputRegex = ".*", ConsoleColor hintColor = ConsoleColor.DarkCyan)
        {
            ConsoleKeyInfo input;

            var suggestion = string.Empty;
            var lastSuggestion = string.Empty;
            var userInput = string.Empty;
            var commandLine = string.Empty;

            var originalColor = Console.ForegroundColor;
            var contextPath = contextStack.GetPath();
            
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

                if (suggestion != null)
                    lastSuggestion = suggestion;

                commandLine = suggestion ?? userInput;

                // Clear the console input line
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);

                if (contextStack.Context.Name.Length < contextPath.Length)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(contextPath.Substring(0, contextPath.Length - contextStack.Context.Name.Length));
                }

                Console.ForegroundColor = originalColor;
                Console.Write(contextStack.Context.Name);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("> ");
                Console.ForegroundColor = originalColor;

                Console.Write(userInput);

                Console.ForegroundColor = hintColor;

                if (userInput.Any())
                    Console.Write(commandLine.Substring(userInput.Length, commandLine.Length - userInput.Length));

                Console.ForegroundColor = originalColor;
            }

            Console.Write($"{contextStack.GetPath()}> ");

            if (lastSuggestion != string.Empty && commandLine.StartsWith(lastSuggestion))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(lastSuggestion);
                Console.ForegroundColor = originalColor;
                Console.Write(commandLine.Substring(lastSuggestion.Length, commandLine.Length - lastSuggestion.Length));
            }
            else
            {
                Console.Write(commandLine);
            }

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

            ExecuteCommand(command, commandAndArgs);

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