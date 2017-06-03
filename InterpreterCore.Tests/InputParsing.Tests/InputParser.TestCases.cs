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

        public static readonly Dictionary<string,List<string>> singleOneWithWhitespace = new Dictionary<string,List<string>>
        {
            { "1", new List<string> {"1"} },
            { "1 ", new List<string> {"1"} },
            { " 1", new List<string> {"1"} },
            { "1\t", new List<string> {"1"} },
            { "\t1", new List<string> {"1"} },
            { "\t1\t", new List<string> {"1"} },
            { "1  ", new List<string> {"1"} },
            { " 1 ", new List<string> {"1"} },
            { "  1", new List<string> {"1"} },
        };

        public static readonly Dictionary<string,List<string>> twoOnesWithWhitespace = new Dictionary<string,List<string>>
        {
            { "1 1", new List<string> {"1", "1"} },
            { "1  1", new List<string> {"1", "1"} },
            { "1   1", new List<string> {"1", "1"} },
            { "1\t1", new List<string> {"1", "1"} },
            { "1\t\t1", new List<string> {"1", "1"} },
        };
    }
}