using System;
using System.Text.RegularExpressions;

namespace InterpreterCore
{
    public class WhitespaceParser
    {
        public static string trimWhitespace(string expression)
        {
            if(expression == null) // Check for a null parameter.
            {
                throw new NullReferenceException();
            }
            // Replace all whitespace regions with a single ' ' character.
            string cleanedExpression = Regex.Replace(expression, @"\s+", " ");
            // Trim leading and/or trailing whitespace from the expression.
            string trimmedExpression = cleanedExpression.Trim();
            return trimmedExpression;
        }
    }
}