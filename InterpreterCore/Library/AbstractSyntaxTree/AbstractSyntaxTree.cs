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
        public LISPAbstractSyntaxTree(string[] syntaxTokens)
        {
            _root = new LISPAbstractSyntaxTreeNode(syntaxTokens);
        }
        public LISPAbstractSyntaxTreeNode Root
        {
            get { return _root; }
            set { _root = value; }
        }
    }
}