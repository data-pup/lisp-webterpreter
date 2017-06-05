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
            DevelopmentMain(args);
            // Console.WriteLine("Initializing LISP Interpreter Core Module...");
            // var _SimpleInterpreter = new SimpleInterpreter();
            // _SimpleInterpreter.StartRuntime();
        }

        private static void DevelopmentMain(string[] args)
        {
            // Working space:
            // ----------------------------------------------------------------
            // TestingAbstractSyntaxTreePrinter.PrintATwoLevelTree();
            // TestingAbstractSyntaxTreePrinter.PrintAThreeLevelTree();
            TemporaryDevelopmentFunctions.CreateASimpleTreeWithStringArrayConstructor();
            // ----------------------------------------------------------------
        }
    }
}
