using System;
using System.Collections.Generic;
using InterpreterCore;
using InterpreterCore.Classes.AbstractSyntaxTree;

namespace ConsoleInterpreter.Development
{
    public class TemporaryDevelopmentFunctions
    {
        public static void TestingSyntaxTreePrintMethod()
        {
            string expression = "( + 1 2 3 ( + 1 2 ) )";
            var testTree = new LISPAbstractSyntaxTree(expression);
            testTree.Print();
        }
    }
}