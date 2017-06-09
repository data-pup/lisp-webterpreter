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

        public static LISPAbstractSyntaxTreeNode GetTreeForNestedExpression()
        {
            var childNode = new LISPAbstractSyntaxTreeNode();
            childNode.Add("+");
            childNode.Add("10");
            childNode.Add("5");
            var ASTNode = new LISPAbstractSyntaxTreeNode();
            ASTNode.Add("+");
            ASTNode.Add("2");
            ASTNode.Add("3");
            ASTNode.Add(childNode);
            return ASTNode;
        }
    }
}