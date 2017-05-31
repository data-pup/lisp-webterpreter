using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class Operators
    {
        public static readonly List<string> OperatorTokens = new List<string>()
        {
            "+", "-", "*", "/", // Arithmetic
            "==", "!=", // Equality Checks
        };
    }
}