using System;
using System.Collections.Generic;

using InterpreterCore.Classes;

namespace InterpreterCore.AbstractSyntaxTree
{
    public class LISPAbstractSyntaxTree
    {
        private LISPAbstractSyntaxTreeNode _root;
        public LISPAbstractSyntaxTree()
        {
            _root = new LISPAbstractSyntaxTreeNode();
        }

        public LISPAbstractSyntaxTree(string[] rawTokens)
        {
            if(rawTokens.Length == 0)
            {
                return;
            }
            int numberOfTokens = rawTokens.Length;
            int nestingIndex = 0;
            var currentNode = _root;
            for(int currentTokenIndex = 0; currentTokenIndex < numberOfTokens; currentTokenIndex++)
            {
                string currentToken = rawTokens[currentTokenIndex];
                if(currentToken == "(")
                {   // Open a new nested list, and increase the nesting level.
                    // TODO Add token
                    // 
                    nestingIndex++;
                    continue;
                }
                else if(currentToken == ")")
                {   // Decrease the nesting level, check for miscmatched parentheses.
                    nestingIndex--;
                    if(nestingIndex < 0)
                    {   // Parentheses do not match if nesting level ever drops below 0.
                        throw new InvalidProgramException("Syntax error: Parentheses do not match.");
                    }
                    continue;
                }
                else
                {   // 
                    // TODO Add token
                }
            }
            if(nestingIndex != 0)
            {   // Check that the nesting index is 0 after reaching the end of the token list.
                throw new InvalidProgramException("Syntax error: Parentheses do not match.");
            }
        }

        public LISPAbstractSyntaxTreeNode Root
        {
            get { return _root; }
            set { _root = value; }
        }
    }
}