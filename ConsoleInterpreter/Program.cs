using System;
using System.Collections.Generic;
using InterpreterCore;

namespace ConsoleInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing LISP Interpreter Core Module...");
            SimpleInterpreter.StartRuntime();
            // DevelopmentTest();
        }
        public static void DevelopmentTest()
        {
            // -----------------------------------------------------------------
            var testExpression = "(+ 1 2 (+ 10))";
            List<String> rawTokens = RawTokenParser.SplitTrimmedExpression(testExpression);
            List<String> result = SyntaxTokenParser.SplitRawTokens(rawTokens);
            Console.WriteLine("Single Token Parse Results:");
            Console.WriteLine("Input string: {0}", testExpression);
            int tokenCounter = 0;
            foreach(var token in result)
            {
                Console.WriteLine("Token #{0}: {1}", tokenCounter, token);
                tokenCounter++;
            }
            // -----------------------------------------------------------------
        }
        public static void GreetCoreModule()
        {
            LISPInterpreterCore coreModule = new LISPInterpreterCore();
            Console.WriteLine("Requesting a greeting...");
            List<String> response = coreModule.Greet();
            Console.WriteLine("Received the following greeting:");
            foreach(var currentValue in response)
            {
                Console.WriteLine(currentValue);
            }
        }
    }
}
