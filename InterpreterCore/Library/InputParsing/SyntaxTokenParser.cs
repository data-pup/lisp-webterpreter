using System;
using System.Collections.Generic;

namespace InterpreterCore.InputParsing
{
    public class SyntaxTokenParser
    {
        /// <summary>
        /// This method will parse a list of raw token strings, and return
        /// a list of syntax tokens. Split reserved characters in the raw
        /// token into separate syntax tokens.
        /// Example: ['(+', '1)'] => ['(', '+', '1', ')']
        /// </summary>
        public static List<String> SplitRawTokens(string[] rawTokens)
        {
            if(rawTokens == null)
            {
                throw new NullReferenceException();
            }
            // Initialize a new string list, to store tokens.
            var syntaxTokens = new List<String>();
            foreach(var currentRawToken in rawTokens)
            {
                syntaxTokens.AddRange(ParseSingleRawToken(currentRawToken));
            }
            return syntaxTokens;
        }

        /// <summary>
        /// This method will handle splitting an individual raw token into
        /// a list of syntax tokens. If the raw token is an exact match with
        /// </summary>
        private static string[] ParseSingleRawToken(string rawToken)
        {
            if(rawToken == null)
            {
                throw new NullReferenceException();
            }
            if(rawToken.Length == 1)
            {
                return new string[] {rawToken};
            }
            var syntaxTokens = new List<String>(); // The list we'll return.
            int previousTokenStartIndex = 0;
            for (int currentCharIndex = 0; currentCharIndex < rawToken.Length;
                                           currentCharIndex++)
            {   // Iterate through the token, looking for reserved characters.
                var currentCharacter = rawToken[currentCharIndex];
                if(ReservedCharacters.Characters.Contains(currentCharacter))
                {   // Handle a reserved character if identified.
                    if(previousTokenStartIndex != currentCharIndex)
                    {   // Identify the previous token prior to this token.
                        string previousToken = GetSyntaxTokenSubstring(rawToken,
                            previousTokenStartIndex, currentCharIndex);
                        syntaxTokens.Add(previousToken);
                    }
                    // Add the current special character to the list.
                    syntaxTokens.Add(currentCharacter.ToString());
                    previousTokenStartIndex = currentCharIndex + 1;
                }
            }
            // If there were trailing characters that were not identified,
            // add these to the list of syntax tokens before returning.
            if(previousTokenStartIndex < rawToken.Length)
            {   // Identify the previous token prior to this token.
                string finalToken = GetSyntaxTokenSubstring(rawToken,
                    previousTokenStartIndex, rawToken.Length);
                syntaxTokens.Add(finalToken);
            }
            return syntaxTokens.ToArray();
        }

        private static string GetSyntaxTokenSubstring(string rawToken,
                                                      int tokenStartIndex,
                                                      int tokenEndIndex)
        {
            int tokenLength = tokenEndIndex - tokenStartIndex;
            string token = rawToken.Substring(tokenStartIndex, tokenLength);
            return token;
        }
    }
}