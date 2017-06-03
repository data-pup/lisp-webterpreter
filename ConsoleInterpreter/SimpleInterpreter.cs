using System;
using System.Collections.Generic;
using InterpreterCore;

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

        private static void PrintPromptString(string promptString)
        {
            Console.Write(promptString);
        }

        private static void PrintParsedExpression(string[] parsedExpression)
        {
            var parsedExpressionString = String.Join(",\t", parsedExpression);
            Console.WriteLine("Result: {0}", parsedExpressionString);
        }
    }
}