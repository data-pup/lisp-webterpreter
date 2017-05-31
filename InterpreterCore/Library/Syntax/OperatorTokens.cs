using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class OperatorTokens
    {
        public static readonly List<string> Tokens = new List<string>()
        {
            "+", "-", "*", "/", // Arithmetic
            "==", "!=", // Equality Checks
        };
    }
}