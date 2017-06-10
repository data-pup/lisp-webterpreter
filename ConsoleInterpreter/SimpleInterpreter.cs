using ConsoleInterpreter.InterpreterGreeting;
using InterpreterCore;
using InterpreterCore.Classes.AbstractSyntaxTree;
using System;
using System.Collections.Generic;

namespace ConsoleInterpreter
{
    class SimpleInterpreter
    {
        private string promptString;
        public SimpleInterpreter()
        {
            promptString = "> ";
        }
        public void StartRuntime()
        {
            InterpreterGreeting.Greeting.PrintIntroductoryBanner();
            string clientInput;
            var _testInterpreter = new LISPInterpreterCore();
            while(true)
            {
                PrintPromptString(promptString);
                clientInput = Console.ReadLine();
                _testInterpreter.ParseAndPrintInputLine(clientInput);
            }
        }

        public void StartASTDebugRuntime()
        {
            InterpreterGreeting.Greeting.PrintDebuggingBanner();
            string clientInput;
            var _testInterpreter = new LISPInterpreterCore();
            // Begin the simple interpreter runtime.
            while(true)
            {
                PrintPromptString(promptString);
                clientInput = Console.ReadLine();
                _testInterpreter.ParseAndPrintInputLine(clientInput);
            }
        }

        private static void PrintPromptString(string promptString)
        {
            Console.Write(promptString);
        }
    }
}