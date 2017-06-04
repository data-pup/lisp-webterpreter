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
        public LISPAbstractSyntaxTreeNode[] Operands
        {
            get { return _children.ToArray(); }
        }
        public LISPAbstractSyntaxTreeNode Parent
        {
            get { return _parent; }
            set { _parent = value; }
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
                newNode.Parent = this; // A ha! It's always 'this'.
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

        public bool IsRoot()
        {
            Console.WriteLine("IsRoot Called! Parent is: {0}", Parent);
            Console.WriteLine("Parent token is: {0}", Parent.Token);
            if(Parent == null)
                return true;
            return false;
        }
        public LISPAbstractSyntaxTreeNode GetRootNode()
        {
            var currentNode = this;
            Console.WriteLine("Current Node Value: {0}", currentNode.Token);
            while(this.IsRoot() == false)
                Console.WriteLine("Current Node Value: {0}", currentNode.Token);
                currentNode =  currentNode.Parent;
            Console.WriteLine("Returning Value: {0}", currentNode.Token);
            return currentNode;
        }
        public static bool IsOperator(string rawToken)
        {
            if(rawToken == "+" || rawToken == "-" || rawToken == "*" || rawToken == "/")
                return true;
            return false;
        }
    }
}