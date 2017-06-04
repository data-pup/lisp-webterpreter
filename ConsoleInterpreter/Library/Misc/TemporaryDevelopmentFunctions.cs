using System;
using System.Collections.Generic;
using InterpreterCore;

using InterpreterCore.AbstractSyntaxTree;

namespace ConsoleInterpreter
{
    public class TemporaryDevelopmentFunctions
    {
        public static void TestingTwoLevelTree()
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
        public static void AbstractSyntaxTreeNodeCanIdentifyIfIsRoot()
        {
            var parentNode = new LISPAbstractSyntaxTreeNode();
            var rawTokens = new string[]{"+", "1", "2"};
            var expectedArguments = new string[]{"1", "2"};
            foreach(var token in rawTokens)
            {
                parentNode.Add(token);
            }
            Console.WriteLine("Testing root...");
            if(parentNode.IsRoot() == true)
                Console.WriteLine("Parent Node passed test.");
            foreach(var currentChild in parentNode.Children)
            {
                bool nodeIsRoot = currentChild.IsRoot();
                if(nodeIsRoot == false)
                    Console.WriteLine("Child Node passed test.");
                bool parentIsRoot = currentChild.Parent.IsRoot();
                if(parentIsRoot == true)
                    Console.WriteLine("Child Parent passed test.");
            }
        }

    }
}