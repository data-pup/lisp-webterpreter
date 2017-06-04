using System;
using System.Collections.Generic;
using InterpreterCore;

using InterpreterCore.AbstractSyntaxTree;

namespace ConsoleInterpreter.Development
{
    public class TestingAbstractSyntaxTreePrinter 
    {
        //
        public static void PrintATwoLevelTree()
        {
            // -----------------------------------------------------------------
            // Place temporary work here...
            // -----------------------------------------------------------------
            // Ex. (* 1 2 (- 3 (+ 4)))
            var parentNode = new LISPAbstractSyntaxTreeNode();
            var childTree = new LISPAbstractSyntaxTreeNode();
            var grandChildTree = new LISPAbstractSyntaxTreeNode();
            grandChildTree.Add("+");
            grandChildTree.Add("4");
            childTree.Add("-");
            childTree.Add("3");
            childTree.Add(grandChildTree);
            parentNode.Add("*");
            parentNode.Add("1");
            parentNode.Add("2");
            parentNode.Add(childTree);
            AbstractSyntaxTreePrinter.PrintSyntaxTree(parentNode);

            var tokensList = new List<string>();
            foreach(var currentChild in parentNode.Children)
            {
                tokensList.Add(currentChild.Token);
            }
            var childrenTokensListString = String.Join(' ', tokensList);
            Console.WriteLine(childrenTokensListString);
        }
    }
}