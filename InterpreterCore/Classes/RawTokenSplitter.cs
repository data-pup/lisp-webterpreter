using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class RawTokenSplitter
    {
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