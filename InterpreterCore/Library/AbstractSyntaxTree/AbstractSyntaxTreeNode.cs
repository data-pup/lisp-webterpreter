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
        public LISPAbstractSyntaxTreeNode(string[] token)
        {
            throw new NotImplementedException();
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

        // private static Tuple<string[],string[]> SplitNestedExpressionToken(string[] rawTokens)
        // {
        //     if(rawTokens == null)
        //     {
        //         throw new NullReferenceException("Null token array given to SplitNestedExpressionToken.");
        //     }
        //     if(rawTokens.Length < 2)
        //     {
        //         throw new InvalidProgramException("Token list is missing parentheses.");
        //     }
        //     if(rawTokens[0] != "(")
        //     {
        //         throw new InvalidOperationException("Unexpected first token in SplitNestedExpressionToken.");
        //     }
        //     int nestingDepth = 1;
        //     for (int tokenIndex = 1; tokenIndex < rawTokens.Length; tokenIndex++)
        //     {
        //         //
        //     }
        // }
    }
}