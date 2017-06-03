using System;
using System.Collections.Generic;

namespace InterpreterCore.Tests.TestCases
{
    public class RawInputParserTestCases
    {
        public static readonly Dictionary<string,string[]> emptyExpressions = new Dictionary<string,string[]>
        {
            { "", new string[] {} },
            { " ", new string[] {} },
            { "\t", new string[] {} },
            { "   ", new string[] {} },
        };

        public static readonly Dictionary<string,string[]> simpleAdditionExpressions = new Dictionary<string,string[]>
        {
            { "(+ 1 1)", new string[] {"(", "+", "1", "1", ")"} },
            { " (+ 1 1)", new string[] {"(", "+", "1", "1", ")"} },
            { "(+ 1 1) ", new string[] {"(", "+", "1", "1", ")"} },
            { "( + 1 1 )", new string[] {"(", "+", "1", "1", ")"} },
        };

        public static readonly Dictionary<string,string[]> singleOneWithWhitespace = new Dictionary<string,string[]>
        {
            { "1", new string[] {"1"} },
            { "1 ", new string[] {"1"} },
            { " 1", new string[] {"1"} },
            { "1\t", new string[] {"1"} },
            { "\t1", new string[] {"1"} },
            { "\t1\t", new string[] {"1"} },
            { "1  ", new string[] {"1"} },
            { " 1 ", new string[] {"1"} },
            { "  1", new string[] {"1"} },
        };

        public static readonly Dictionary<string,string[]> singleItemExpressions = new Dictionary<string,string[]>
        {
            { "1", new string[] {"1"} },
            { "(1)", new string[] {"(", "1", ")"} },
            { "( 1 )", new string[] {"(", "1", ")"} },
            { "(\t1\t)", new string[] {"(", "1", ")"} },
            { " ( 1 ) ", new string[] {"(", "1", ")"} },
            { "((1))", new string[] {"(", "(", "1", ")", ")"} },
        };

        public static readonly Dictionary<string,string[]> twoOnesWithWhitespace = new Dictionary<string,string[]>
        {
            { "1 1", new string[] {"1", "1"} },
            { "1  1", new string[] {"1", "1"} },
            { "1   1", new string[] {"1", "1"} },
            { "1\t1", new string[] {"1", "1"} },
            { "1\t\t1", new string[] {"1", "1"} },
        };

        public static readonly Dictionary<string,string[]> miscellaenousWhitespaceTests = new Dictionary<string,string[]>
        {
            { "  \t1 2  3\t\t4 5    ", new string[] {"1", "2", "3", "4", "5"} },
            { "\t1     2 3\t\t4 5", new string[] {"1", "2", "3", "4", "5"} },
            { "\t1\t2\t3\t4\t5\t", new string[] {"1", "2", "3", "4", "5"} },
        };

        public static readonly Dictionary<string,string[]> syntaxTokenTestCases = new Dictionary<string,string[]>
        {
            { "()", new string[] {"(", ")"} },
            { "(())", new string[] {"(", "(", ")", ")"} },
            { "(+", new string[] {"(", "+"} },
            { "((+", new string[] {"(", "(", "+"} },
        };
    }
}