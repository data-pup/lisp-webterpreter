using System;
using System.Collections.Generic;

using InterpreterCore.Classes;

namespace InterpreterCore.InputParsing
{
    public class LISPAbstractSyntaxTreeNode
    {
        private string _token;
        public LISPAbstractSyntaxTreeNode()
        {
            _token = null;
        }
        public LISPAbstractSyntaxTreeNode(string token)
        {
            _token = token;
        }
        public string Token
        {
            get { return _token; }
        }
    }
}