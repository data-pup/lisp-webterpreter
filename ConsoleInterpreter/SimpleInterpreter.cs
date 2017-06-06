using System;
using System.Collections.Generic;
using InterpreterCore;
using InterpreterCore.Classes.AbstractSyntaxTree;

namespace ConsoleInterpreter
{
    class SimpleInterpreter
    {
        private string promptString;
        public SimpleInterpreter()
        {
            promptString = "> ";
        }
        public void StartRuntime()
        {
            string clientInput;
            var _testInterpreter = new LISPInterpreterCore();
            while(true)
            {
                PrintPromptString(promptString);
                clientInput = Console.ReadLine();
                var parsedExpression = _testInterpreter.ParseInputLine(clientInput);
                PrintParsedExpression(parsedExpression);
            }
        }

        public void StartASTDebugRuntime()
        {
            string clientInput;
            var _testInterpreter = new LISPInterpreterCore();
            LISPAbstractSyntaxTreeNode _testAbstractSyntaxTree;
            while(true)
            {
                PrintPromptString(promptString);
                clientInput = Console.ReadLine();
                var parsedExpression = _testInterpreter.ParseInputLine(clientInput);
                _testAbstractSyntaxTree = new LISPAbstractSyntaxTreeNode(parsedExpression);
                AbstractSyntaxTreePrinter.PrintSyntaxTree(_testAbstractSyntaxTree);
            }
        }

        private static void PrintPromptString(string promptString)
        {
            Console.Write(promptString);
        }

        public static void PrintParsedExpression(string[] parsedExpression)
        {
            var parsedExpressionString = String.Join(",\t", parsedExpression);
            Console.WriteLine("Result: {0}", parsedExpressionString);
        }
    }
}