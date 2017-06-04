using System;
using System.Collections.Generic;

using InterpreterCore.Classes;

namespace InterpreterCore.InputParsing
{
    public class LISPAbstractSyntaxTree
    {
        private LinkedList<LISPAbstractSyntaxTreeNode> _AST;
        public LISPAbstractSyntaxTree()
        {
        }

        public LinkedList<LISPAbstractSyntaxTreeNode> AST
        {
            get { return _AST; }
        }

    }
}