using System;
using System.Collections.Generic;

namespace InterpreterCore.InputParsing
{
    public class InputParser
    {
        /// <summary>
        /// This class is a wrapper around the helper methods used to parse
        /// a string input from the interpreter into a list of arguments
        /// for runtime. Note that this does not implement an abstract syntax
        /// tree. The list returned is a flat list of strings, with superfluous
        /// characters removed.
        /// </summary>
        public static List<String> ParseExpressionIntoList(string expression)
        {
            if(expression == null)
            {   // Null parameter check.
                throw new NullReferenceException();
            }
            if(expression.Length == 0)
            {   // Empty parameter check.
                return new List<String>();
            }
            // First, remove any extraneous whitespace from the expression.
            string trimmedExpression = WhitespaceParser.TrimWhitespace(expression);
            // Next, split the trimmed expression into raw tokens based on whitespace.
            List<String> rawTokens = RawTokenParser.SplitTrimmedExpression(trimmedExpression);
            // Handle the raw token list, splitting raw tokens by syntactical meaning.
            List<String> tokens = SyntaxTokenParser.SplitRawTokens(rawTokens);
            return tokens;   // Return the ordered list of syntax tokens.
        }
    }
}