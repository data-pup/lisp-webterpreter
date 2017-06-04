using System;
using System.Collections.Generic;
using InterpreterCore;

using InterpreterCore.AbstractSyntaxTree;

namespace ConsoleInterpreter
{
    public class TemporaryDevelopmentFunctions
    {
        public static void TempBootstrap()
        {
            // -----------------------------------------------------------------
            // Place temporary work here...
            // -----------------------------------------------------------------
            var parentNode = new LISPAbstractSyntaxTreeNode();
            parentNode.Add("+");
            parentNode.Add("1");
            parentNode.Add("2");
            AbstractSyntaxTreePrinter.PrintSyntaxTree(parentNode);
        }
    }
}