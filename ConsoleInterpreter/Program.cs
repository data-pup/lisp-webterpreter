using System;
using System.Collections.Generic;
using InterpreterCore;
using ConsoleInterpreter.Development;

namespace ConsoleInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // DevelopmentMain(args);
            Console.WriteLine(InterpreterGreeting.Greeting.initStartMessage);
            var _SimpleInterpreter = new SimpleInterpreter();
            Console.WriteLine(InterpreterGreeting.Greeting.initCompleteMessage);
            InterpreterGreeting.Greeting.PrintRuling();

            DevelopmentMain(args); // Enter the development function.
            // _SimpleInterpreter.StartRuntime(); // Enter the standard runtime.
            // _SimpleInterpreter.StartASTDebugRuntime(); // Enter the debug runtime.
        }

        private static void DevelopmentMain(string[] args)
        {
            // Working space:
            // ----------------------------------------------------------------
            // TestingAbstractSyntaxTreePrinter.PrintATwoLevelTree();
            // TestingAbstractSyntaxTreePrinter.PrintAThreeLevelTree();
            // TemporaryDevelopmentFunctions.TestingParsingTokensNestedRecursion();
            TemporaryDevelopmentFunctions.TestingSyntaxTreePrintMethod();
            // ----------------------------------------------------------------
        }
    }
}
