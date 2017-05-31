using System;
using System.Collections.Generic;

namespace InterpreterCore
{
    public class SyntaxTokenHandler
    {
        /// <summary>
        /// This method will handle a list of raw token strings, and return
        /// a list of syntax tokens.
        /// </summary>
        public static List<String> splitRawTokens(List<String> rawTokens)
        {
            throw new NotImplementedException(); // TEMP

            if(rawTokens == null)
            {
                throw new NullReferenceException();
            }
            // Initialize a new string list, to store tokens.
            var syntaxTokens = new List<String>();

            // TODO: Handle syntax tokens.

            return syntaxTokens;
        }
    }
}