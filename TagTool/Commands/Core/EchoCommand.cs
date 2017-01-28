﻿using System;
using System.Collections.Generic;

namespace TagTool.Commands.Core
{
    class EchoCommand : Command
    {
        public EchoCommand()
            : base(CommandFlags.Inherit,

                  "Echo",
                  "Prints arguments to the console.",

                  "Echo <arg1> <arg2> ... <argN>",

                  "Prints arguments to the console.")
        {
        }

        public override bool Execute(List<string> args)
        {
            foreach (var arg in args)
                Console.Write($"{arg} ");
            
            return true;
        }
    }
}
