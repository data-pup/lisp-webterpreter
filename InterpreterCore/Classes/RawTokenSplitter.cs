using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class RawTokenSplitter
    {
        /// <summary>
        /// This method will handle a string that has been treated by the
        /// WhitespaceParser module. This splits the string into a list of
        /// raw tokens, based on whitespace characters in the expression.
        /// <summary>
        public static List<String> splitTrimmedExpression(string expression)
        {
            if(expression == null)
            {
                throw new NullReferenceException();
            }
            List<String> rawTokens = new List<String>(expression.Split(' '));
            return rawTokens;
        }
    }
}