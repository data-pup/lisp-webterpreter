using System;
using System.Collections.Generic;
using InterpreterCore;

using InterpreterCore.AbstractSyntaxTree;

namespace ConsoleInterpreter.Development
{
    public class TemporaryDevelopmentFunctions
    {
        public static void CreateASimpleTreeWithStringArrayConstructor()
        {
            var rawTokens = new string[]{"+", "1", "2"};
            var parentNode = new LISPAbstractSyntaxTreeNode();
        }
    }
}