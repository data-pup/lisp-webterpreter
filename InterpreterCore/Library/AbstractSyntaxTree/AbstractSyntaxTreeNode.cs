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
            _children = null;
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
        }
        public LISPAbstractSyntaxTreeNode[] Operands
        {
            get { return _children.ToArray(); }
        }
        public LISPAbstractSyntaxTreeNode Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
        public void Add(string rawToken)
        {
            if(Token == null || Token == "")
            {
                Token = rawToken;
                return;
            }
            var newNode = new LISPAbstractSyntaxTreeNode(rawToken);
            newNode.Parent = this;
            _children.Push(newNode);
        }
        public bool IsRoot()
        {
            if(_parent == null)
                return true;
            return false;
        }
        public static bool IsOperator(string rawToken)
        {
            if(rawToken == "+" || rawToken == "-" || rawToken == "*" || rawToken == "/")
                return true;
            return false;
        }
    }
}