using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class OperatorCharacters
    {
        public static readonly SortedSet<char> Tokens = new SortedSet<char>()
        {
            '+', '-', '*', '/',
        };
    }
}