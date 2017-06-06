using System;
using System.Collections.Generic;

using InterpreterCore.Classes.AbstractSyntaxTree;

namespace InterpreterCore.Tests.TestCases
{
    public class AbstractSyntaxTreeNodeTestCases
    {
        public static readonly Dictionary<string,bool> AbstractSyntaxTreeNodeOperatorTokenTests = new Dictionary<string,bool>
        {
            { "+", true },
            { "-", true },
            { "*", true },
            { "/", true },
            { " ", false },
            { "\t", false },
            { "\n", false },
            { "\0", false },
            { "1", false },
            { "a", false },
        };
    }
}