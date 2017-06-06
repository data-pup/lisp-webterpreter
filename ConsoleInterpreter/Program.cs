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
            Console.WriteLine("Initializing LISP Interpreter Core Module...");
            Console.WriteLine("--------------------------------------------");
            var _SimpleInterpreter = new SimpleInterpreter();
            // _SimpleInterpreter.StartRuntime();
            _SimpleInterpreter.StartASTDebugRuntime();
        }

        private static void DevelopmentMain(string[] args)
        {
            // Working space:
            // ----------------------------------------------------------------
            // TestingAbstractSyntaxTreePrinter.PrintATwoLevelTree();
            // TestingAbstractSyntaxTreePrinter.PrintAThreeLevelTree();
            // TemporaryDevelopmentFunctions.TestingParsingTokensNestedRecursion();
            // ----------------------------------------------------------------
        }
    }
}
