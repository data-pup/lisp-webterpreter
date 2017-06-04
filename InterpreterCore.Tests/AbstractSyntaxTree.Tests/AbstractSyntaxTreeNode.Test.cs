using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore.AbstractSyntaxTree;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class AbstractSyntaxTreeNodeTest
    {
        [TestMethod]
        public void AbstractSyntaxTreeNodeCanBeInstantiated()
        {
            var testObject = new LISPAbstractSyntaxTreeNode();
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanStoreOperatorToken()
        {
            var testObject = new LISPAbstractSyntaxTreeNode("+");
            Assert.IsTrue(testObject.IsOperator());
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanStoreNumberToken()
        {
            var testObject = new LISPAbstractSyntaxTreeNode("1");
            Assert.IsFalse(testObject.IsOperator());
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanStoreVariableToken()
        {
            var testObject = new LISPAbstractSyntaxTreeNode("x");
            Assert.IsFalse(testObject.IsOperator());
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanSetNext()
        {
            var parentNode = new LISPAbstractSyntaxTreeNode("+");
            var childNode = new LISPAbstractSyntaxTreeNode("1");
            var children = new List<LISPAbstractSyntaxTreeNode> {childNode};
            parentNode.Children = children;
            Assert.IsTrue(NodeListsAreEqual(children, parentNode.Children));
        }

        private static bool NodeListsAreEqual(ICollection<LISPAbstractSyntaxTreeNode> expectedElements,
                                              ICollection<LISPAbstractSyntaxTreeNode> actualElements)
        {
            foreach(var expectedElement in expectedElements)
            {
                if (actualElements.Contains(expectedElement) != true)
                    return false;
            }
            return true;
        }
    }
}