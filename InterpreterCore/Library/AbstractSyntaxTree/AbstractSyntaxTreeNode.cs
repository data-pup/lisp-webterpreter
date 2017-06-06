using System;
using System.Collections.Generic;

using InterpreterCore.Classes;

namespace InterpreterCore.AbstractSyntaxTree
{
    public class LISPAbstractSyntaxTreeNode
    {
        private string _token;
        private Stack<LISPAbstractSyntaxTreeNode> _children;
        private LISPAbstractSyntaxTreeNode _parent;

        public LISPAbstractSyntaxTreeNode()
        {
            _token = "";
            _children = new Stack<LISPAbstractSyntaxTreeNode>();
            _parent = null;
        }
        public LISPAbstractSyntaxTreeNode(string token)
        {
            _token = token;
            _children = new Stack<LISPAbstractSyntaxTreeNode>();
            _parent = null;
        }
        public LISPAbstractSyntaxTreeNode(string[] syntaxTokens)
        {
            _children = new Stack<LISPAbstractSyntaxTreeNode>();
            _parent = null;
            string currentToken;
            int nestingDepth = 0;
            for(int currentTokenIndex = 0; currentTokenIndex < syntaxTokens.Length;
                                           currentTokenIndex++)
            {
                currentToken = syntaxTokens[currentTokenIndex];
                if(currentToken == "(")
                {
                    nestingDepth++;
                    string[] splitExpression = GetNestedExpression(
                        syntaxTokens, currentTokenIndex);
                    var newNestedExpression = new LISPAbstractSyntaxTreeNode(splitExpression);
                    Add(newNestedExpression);
                    currentTokenIndex += splitExpression.Length;
                    continue;
                }
                else if(currentToken == ")")
                    nestingDepth--;
                else
                    Add(currentToken);
            }
            if(nestingDepth != 0)
            {
                throw new InvalidProgramException("Unexpected ')' found.");
            }
        }

        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }
        public string Value
        {
            get { return _token; }
        }
        public LISPAbstractSyntaxTreeNode[] Children
        {
            get { return _children.ToArray(); }
            set { _children = new Stack<LISPAbstractSyntaxTreeNode>(value); }
        }
        public LISPAbstractSyntaxTreeNode Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
        public bool HasParent
        {
            get { return !IsRoot(); }
        }

        public void Add(LISPAbstractSyntaxTreeNode newNode)
        {
            if(Token == null || Token == "")
            {
                Token = newNode.Token;
                Children = newNode.Children;
                return;
            }
            else
            {
                newNode.Parent = this;
                _children.Push(newNode);
            }
        }

        public void Add(string rawToken)
        {
            if(Token == null || Token == "")
            {
                Token = rawToken;
                return;
            }
            else
            {
                var newNode = new LISPAbstractSyntaxTreeNode(rawToken);
                Add(newNode);
            }
        }

        public void Push(string rawToken)
        {
            Add(rawToken);
        }

        public bool IsRoot()
        {
            if(Parent == null)
                return true;
            return false;
        }
        public LISPAbstractSyntaxTreeNode GetRootNode()
        {
            var currentNode = this;
            while(this.IsRoot() == false)
                currentNode =  currentNode.Parent;
            return currentNode;
        }
        public static bool IsOperator(string rawToken)
        {
            if(rawToken == "+" || rawToken == "-" ||
               rawToken == "*" || rawToken == "/")
                return true;
            return false;
        }

        /// <summary>
        /// This is a private helper method used to parse nested expressions.
        /// Given a list of LISP syntax tokens and a starting position pointing
        /// to a '(' token, return the tokens that are between the opening
        /// parentheses and the matching ')' token.
        /// </summary>
        private static string[] GetNestedExpression(string[] syntaxTokens, int startingIndex=0)
        {
            ValidateNestedExpressionStartIndex(syntaxTokens, startingIndex);
            int nestingDepth = 1; // Start at the next token after the '('
            int currTokenIndex = startingIndex + 1;
            var expressionTokenList = new List<string>();
            while (currTokenIndex < syntaxTokens.Length)
            {
                string currToken = syntaxTokens[currTokenIndex];
                nestingDepth = GetCurrentExpressionNestingDepth(currToken, nestingDepth);
                if(nestingDepth == 0) break; // Break the loop if end of enclosure found.
                expressionTokenList.Add(currToken); // Otherwise, add the current token.
                currTokenIndex++;
            }
            string[] expressionTokenArray = expressionTokenList.ToArray();
            return expressionTokenArray;
        }

        /// <summary>
        /// Using the current syntax token and the previous nesting depth value,
        /// evaluate and return the new depth. Raises an exception if the
        /// current token string is null, or if the depth parameter is negative.
        /// </summary>
        private static int GetCurrentExpressionNestingDepth(string currentSyntaxToken,
                                                            int previousNestingDepth)
        {
            if(currentSyntaxToken == null)
                throw new NullReferenceException();
            if(previousNestingDepth < 0)
                throw new InvalidProgramException();
            if(currentSyntaxToken == "(")
                return previousNestingDepth + 1;
            else if(currentSyntaxToken == ")")
                return previousNestingDepth - 1;
            else
                return previousNestingDepth;
        }

        /// <summary>
        /// This is a helper method that will raise a NullReferenceException
        /// or an InvalidProgramException if parameters given to the
        /// GetNestedExpression(..) method do not represent a nested expression.
        /// </summary>
        private static void ValidateNestedExpressionStartIndex(string[] syntaxTokens, int startingIndex=0)
        {
            if(syntaxTokens == null)
            {
                throw new NullReferenceException("Null token array given to SplitNestedExpressionToken.");
            }
            if(startingIndex < 0 || startingIndex >= syntaxTokens.Length - 1)
            {   // Check that the starting index is within the array.
                throw new InvalidProgramException("SplitNestedExpressionToken starting index out of bounds.");
            }
            if(syntaxTokens[startingIndex] != "(")
            {   // Check that the starting index points to an opening parentheses.
                throw new InvalidProgramException("Nested expression was not found in syntax token array.");
            }
        }
    }
}