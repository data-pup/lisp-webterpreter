using System;
using System.Collections.Generic;
using InterpreterCore;
using InterpreterCore.Classes.AbstractSyntaxTree;

namespace ConsoleInterpreter.Development
{
    public class TemporaryDevelopmentFunctions
    {
        public static void TestingParsingTokensNestedRecursion()
        {
            // var rawTokens = new string[]{"(", "+", "1", "2", "(", "1", ")", "3", ")"};
            // var rawTokens = new string[]{"(", "1", ")", "3", ")", "1", ")"};
            // string expression = "( + 1 ( + 2 3 ) 4 )";
            string expression = "( + 1 2 3 ( + 1 2 ) )";
            string[] expressionTokens = expression.Split(' ');
            var testTree = new LISPAbstractSyntaxTreeNode(expressionTokens);
            AbstractSyntaxTreePrinter.PrintSyntaxTree(testTree);
        }
    }
}