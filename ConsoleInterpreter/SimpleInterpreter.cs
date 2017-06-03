using System;
using System.Collections.Generic;
using InterpreterCore;

namespace ConsoleInterpreter
{
    class SimpleInterpreter
    {
        public static void StartRuntime()
        {
            string clientInput;
            var _testInterpreter = new LISPInterpreterCore();
            while(true)
            {
                clientInput = Console.ReadLine();
                var parsedExpression = _testInterpreter.ParseInputLine(clientInput);
                PrintParsedExpression(parsedExpression);
            }
        }

        private static void PrintParsedExpression(List<string> parsedExpression)
        {
            int tokenCounter = 0;
            foreach(var token in parsedExpression)
            {
                Console.WriteLine("Token #{0}: {1}", tokenCounter, token);
                tokenCounter++;
            }
        }
    }
}