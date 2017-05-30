using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class RawTokenSplitter
    {
        private IEnumerable<String> splitTrimmedExpression(string expression)
        {
            if(expression == null)
            {
                throw new NullReferenceException();
            }
            return expression.Split(' ');
        }
    }
}