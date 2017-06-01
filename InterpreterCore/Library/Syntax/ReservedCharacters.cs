using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class ReservedCharacters
    {
        public static readonly SortedSet<char> Characters = new SortedSet<char>()
        {
            '(', ')'
        };
    }
}