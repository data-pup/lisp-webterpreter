using System;
using System.Collections.Generic;

using InterpreterCore.Classes.AbstractSyntaxTree;

namespace InterpreterCore.Tests.TestCases
{
    public class LISPAbstractSyntaxTreeTestCases
    {
        public static LISPAbstractSyntaxTreeNode GetTreeForOnePlusOne()
        {
            var ASTNode = new LISPAbstractSyntaxTreeNode();
            ASTNode.Add("+");
            ASTNode.Add("1");
            ASTNode.Add("1");
            return ASTNode;
        }
    }
}