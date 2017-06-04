using System;
using System.Collections.Generic;
using InterpreterCore;

namespace ConsoleInterpreter
{
    public class TemporaryDevelopmentFunctions
    {
        public static void TempBootstrap()
        {
            // -----------------------------------------------------------------
            // Place temporary work here...
            // -----------------------------------------------------------------
            var expression = "(+ 1 (+ 2))";
            var testCore = new LISPInterpreterCore();
            string[] rawTokens = testCore.ParseInputLine(expression);
            BuildAST(rawTokens);
            return;
        }

        public static void BuildAST(string[] rawTokens)
        {
            var ast = new LinkedList<string[]>();
            LinkedList<string> currentExpression;
            for(int currenRawTokenIndex = 0; currenRawTokenIndex < rawTokens.Length;
                                             currenRawTokenIndex++)
            {
                if(currentToken == "(")
                {
                    currentExpression = new LinkedList<string>();
                }
            }
        }
    }
}