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
            List<List<string>> nestedTokens = new List<List<string>>();
            for(int currentTokenIndex = 0; currentTokenIndex < numberOfTokens; currentTokenIndex++)
            {
                string currentToken = rawTokens[currentTokenIndex];
                if(currentToken == "(")
                {   // Open a new nested list, and increase the nesting level.
                    nestedTokens.Add(new List<string>());
                    nestingIndex++;
                    continue;
                }
                else if(currentToken == ")")
                {   // Decrease the nesting level, check for miscmatched parentheses.
                    nestingIndex--;
                    if(nestingIndex < 0)
                    {
                        throw new InvalidProgramException("Syntax error: Parentheses do not match.");
                    }
                    continue;
                }
                else
                {
                    nestedTokens[nestingIndex].Add(currentToken);
                }
            }
        }

        public LISPAbstractSyntaxTreeNode Root
        {
            get { return _root; }
            set { _root = value; }
        }
    }
}