using System;
using System.Collections.Generic;

namespace InterpreterCore.Tests.TestCases
{
    public class RawInputParserTestCases
    {
        public static readonly Dictionary<string,List<string>> emptyExpressions = new Dictionary<string,List<string>>
        {
            { "", new List<string> {} },
            { " ", new List<string> {} },
            { "\t", new List<string> {} },
            { "   ", new List<string> {} },
        };

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

        public static readonly Dictionary<string,List<string>> singleItemExpressions = new Dictionary<string,List<string>>
        {
            { "1", new List<string> {"1"} },
            { "(1)", new List<String>() {"(", "1", ")"} },
            { "( 1 )", new List<String>() {"(", "1", ")"} },
            { "(\t1\t)", new List<String>() {"(", "1", ")"} },
            { " ( 1 ) ", new List<String>() {"(", "1", ")"} },
            { "((1))", new List<String>() {"(", "(", "1", ")", ")"} },
        };

        public static readonly Dictionary<string,List<string>> twoOnesWithWhitespace = new Dictionary<string,List<string>>
        {
            { "1 1", new List<string> {"1", "1"} },
            { "1  1", new List<string> {"1", "1"} },
            { "1   1", new List<string> {"1", "1"} },
            { "1\t1", new List<string> {"1", "1"} },
            { "1\t\t1", new List<string> {"1", "1"} },
        };

        public static readonly Dictionary<string,List<string>> miscellaenousWhitespaceTests = new Dictionary<string,List<string>>
        {
            { "  \t1 2  3\t\t4 5    ", new List<string> {"1", "2", "3", "4", "5"} },
            { "\t1     2 3\t\t4 5", new List<string> {"1", "2", "3", "4", "5"} },
            { "\t1\t2\t3\t4\t5\t", new List<string> {"1", "2", "3", "4", "5"} },
        };

        public static readonly Dictionary<string,List<string>> syntaxTokenTestCases = new Dictionary<string,List<string>>
        {
            { "()", new List<String>(){"(", ")"} },
            { "(())", new List<String>(){"(", "(", ")", ")"} },
            { "(+", new List<String>(){"(", "+"} },
            { "((+", new List<String>(){"(", "(", "+"} },
        };
    }
}