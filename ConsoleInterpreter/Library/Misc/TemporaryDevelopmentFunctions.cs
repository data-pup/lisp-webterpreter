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
            var childTree = new LISPAbstractSyntaxTreeNode();
            var grandChildTree = new LISPAbstractSyntaxTreeNode();
            grandChildTree.Add("4");
            childTree.Add("+");
            childTree.Add("3");
            childTree.Add(grandChildTree);
            parentNode.Add("+");
            parentNode.Add("1");
            parentNode.Add("2");
            parentNode.Add(childTree);
            AbstractSyntaxTreePrinter.PrintSyntaxTree(parentNode);
        }
    }
}