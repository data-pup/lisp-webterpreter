using System;
using System.Collections.Generic;
using InterpreterCore;
using InterpreterCore.Classes.AbstractSyntaxTree;

namespace ConsoleInterpreter.Development
{
    public class TestingAbstractSyntaxTreePrinter 
    {
        public static void PrintATwoLevelTree()
        {
            var grandChildTree = new LISPAbstractSyntaxTreeNode();
            grandChildTree.Add("+");
            grandChildTree.Add("4");
            var childTree = new LISPAbstractSyntaxTreeNode();
            childTree.Add("-");
            childTree.Add("3");
            childTree.Add(grandChildTree);
            var parentNode = new LISPAbstractSyntaxTreeNode();
            parentNode.Add("*");
            parentNode.Add("1");
            parentNode.Add("2");
            parentNode.Add(childTree);
            AbstractSyntaxTreePrinter.PrintSyntaxTree(parentNode);
            Console.WriteLine();
        }
        public static void PrintAThreeLevelTree()
        {
            var greatGrandChildTree = new LISPAbstractSyntaxTreeNode();
            greatGrandChildTree.Add("/");
            greatGrandChildTree.Add("10");
            greatGrandChildTree.Add("10");
            var secondGrandChildTree = new LISPAbstractSyntaxTreeNode();
            secondGrandChildTree.Add("+");
            secondGrandChildTree.Add("4");
            secondGrandChildTree.Add(greatGrandChildTree);
            var firstGrandChildTree = new LISPAbstractSyntaxTreeNode();
            firstGrandChildTree.Add("+");
            firstGrandChildTree.Add("4");
            var childTree = new LISPAbstractSyntaxTreeNode();
            childTree.Add("-");
            childTree.Add("3");
            childTree.Add(firstGrandChildTree);
            childTree.Add(secondGrandChildTree);
            var parentNode = new LISPAbstractSyntaxTreeNode();
            parentNode.Add("*");
            parentNode.Add("1");
            parentNode.Add("2");
            parentNode.Add(childTree);
            AbstractSyntaxTreePrinter.PrintSyntaxTree(parentNode);
            Console.WriteLine();
        }
        private static void PrintChildTokens(LISPAbstractSyntaxTreeNode ASTNode)
        {
            var tokensList = new List<string>();
            foreach(var currentChild in ASTNode.Children)
            {
                tokensList.Add(currentChild.Token);
            }
            var childrenTokensListString = String.Join(' ', tokensList);
            Console.WriteLine(childrenTokensListString);
        }
    }
}