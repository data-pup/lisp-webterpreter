using System;
using System.Collections.Generic;

// using InterpreterCore.Classes.Lisp;

namespace InterpreterCore.Classes.AbstractSyntaxTree
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
        public LISPAbstractSyntaxTree(string rawInputExpression)
        {
            string[] syntaxTokens = InputParsing.RawInputParser
                .ParseExpressionIntoList(rawInputExpression);
            _root = new LISPAbstractSyntaxTreeNode(syntaxTokens);
        }

        public LISPAbstractSyntaxTreeNode Root
        {
            get { return _root; }
            set { _root = value; }
        }

        public void Print()
        {
            AbstractSyntaxTreePrinter.PrintSyntaxTree(Root);
        }

    }
}