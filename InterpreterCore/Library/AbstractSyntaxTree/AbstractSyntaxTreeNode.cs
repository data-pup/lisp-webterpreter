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
            for(int currentTokenIndex = 0; currentTokenIndex < syntaxTokens.Length;
                                           currentTokenIndex++)
            {
                currentToken = syntaxTokens[currentTokenIndex];
                if(currentToken == "(")
                {
                    string[] splitExpression = GetNestedExpression(
                        syntaxTokens, currentTokenIndex);
                    var newNestedExpression = new LISPAbstractSyntaxTreeNode(splitExpression);
                    Add(newNestedExpression);
                    currentTokenIndex += splitExpression.Length;
                    continue;
                }
                else if(currentToken == ")")
                    break;
                else
                    Add(currentToken);
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
            if(rawToken == "+" || rawToken == "-" || rawToken == "*" || rawToken == "/")
                return true;
            return false;
        }

        private static string[] GetNestedExpression(string[] syntaxTokens, int startingIndex=0)
        {
            if(syntaxTokens == null)
            {
                throw new NullReferenceException("Null token array given to SplitNestedExpressionToken.");
            }
            if(startingIndex < 0 || startingIndex >= syntaxTokens.Length - 1)
            {
                throw new InvalidProgramException("SplitNestedExpressionToken starting index out of bounds.");
            }
            if(syntaxTokens[startingIndex] != "(")
            {
                throw new InvalidProgramException("Nested expression was not found in syntax token array.");
            }
            int nestingDepth = 1;
            int currTokenIndex = startingIndex + 1;
            var expressionTokenList = new List<string>();
            while (currTokenIndex < syntaxTokens.Length)
            {
                string currToken = syntaxTokens[currTokenIndex];
                if(currToken == "(")
                {
                    nestingDepth++; // Recursion goes here.
                    expressionTokenList.Add(currToken);
                    currTokenIndex++;
                    continue;
                }
                else
                {
                    if(currToken == ")")
                    {
                        nestingDepth--;
                        if(nestingDepth == 0)
                            break;
                    }
                    expressionTokenList.Add(currToken);
                }
                currTokenIndex++;
            }
            string[] expressionTokenArray = expressionTokenList.ToArray();
            return expressionTokenArray;
        }
    }
}