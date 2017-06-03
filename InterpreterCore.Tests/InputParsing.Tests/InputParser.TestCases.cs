using System;
using System.Collections.Generic;

namespace InterpreterCore.Tests.TestCases
{
    public class InputParserTestCases
    {
        public static readonly Dictionary<string,List<string>> simpleAdditionExpressions = new Dictionary<string,List<string>>
        {
            { "(+ 1 1)", new List<string> {"(", "+", "1", "1", ")"} },
            { " (+ 1 1)", new List<string> {"(", "+", "1", "1", ")"} },
            { "(+ 1 1) ", new List<string> {"(", "+", "1", "1", ")"} },
            { "( + 1 1 )", new List<string> {"(", "+", "1", "1", ")"} },
        };
    }
}