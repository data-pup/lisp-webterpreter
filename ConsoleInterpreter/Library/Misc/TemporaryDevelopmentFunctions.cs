using System;
using System.Collections.Generic;
using InterpreterCore;

using InterpreterCore.AbstractSyntaxTree;

namespace ConsoleInterpreter.Development
{
    public class TemporaryDevelopmentFunctions
    {
        public static void TestingParsingTokensNestedRecursion()
        {
            // var rawTokens = new string[]{"(", "+", "1", "2", "(", "1", ")", "3", ")"};
            var rawTokens = new string[]{"(", "1", ")", "3", ")", "1", ")"};
            int nestingDepth = 1;
            int currTokenIndex = 1;
            var expressionTokenList = new List<string>();
            var remainingTokenList = new List<string>();
            bool hasPassedMatchingEnclosure = false;
            while (currTokenIndex < rawTokens.Length)
            {
                string currToken = rawTokens[currTokenIndex];
                if(currToken == "(")
                {
                    expressionTokenList.Add(currToken);
                    nestingDepth++; // Recursion goes here.
                    continue;
                }
                else
                {
                    if(currToken == ")")
                    {
                        Console.WriteLine("Depth: {0}", nestingDepth);
                        nestingDepth--;
                        if(nestingDepth == 0)
                        {
                            Console.WriteLine("Matching outer brace found at position {0}", currTokenIndex);
                            hasPassedMatchingEnclosure = true;
                            currTokenIndex++;
                            continue;
                        }
                    }
                    if(hasPassedMatchingEnclosure == false)
                        expressionTokenList.Add(currToken);
                    else
                        remainingTokenList.Add(currToken);
                }
                currTokenIndex++;
            }
            string expressionOutput = String.Join(' ', expressionTokenList);
            Console.WriteLine("Selected: {0}", expressionOutput);
            string remainingOutput = String.Join(' ', remainingTokenList);
            Console.WriteLine("Remaining {0}", remainingOutput);
        }
    }
}