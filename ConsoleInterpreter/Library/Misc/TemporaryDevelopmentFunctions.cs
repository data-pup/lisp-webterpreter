using System;
using System.Collections.Generic;
using InterpreterCore;

using InterpreterCore.AbstractSyntaxTree;

namespace ConsoleInterpreter.Development
{
    public class TemporaryDevelopmentFunctions
    {
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