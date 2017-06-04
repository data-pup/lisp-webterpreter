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
        public void AbstractSyntaxTreeNodeAddWorksOnEmptyNode()
        {
            var parentNode = new LISPAbstractSyntaxTreeNode();
            parentNode.Add("+");
            Assert.AreEqual(parentNode.Token, "+");
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeAddPlacesTwoChildrenCorrectly()
        {
            var parentNode = new LISPAbstractSyntaxTreeNode();
            parentNode.Add("+");
            parentNode.Add("1");
            parentNode.Add("2");
            Assert.AreEqual(parentNode.Token, "+");
            Assert.AreEqual(parentNode.Children[0], "1");
            Assert.AreEqual(parentNode.Children[1], "2");
        }

        // [TestMethod]
        // public void AbstractSyntaxTreeNodeChildrenCanBeSetToMultipleElements()
        // {
        //     var parentNode = new LISPAbstractSyntaxTreeNode("+");
        //     var children = new List<LISPAbstractSyntaxTreeNode>
        //     {
        //         new LISPAbstractSyntaxTreeNode("1"),
        //         new LISPAbstractSyntaxTreeNode("2"),
        //     };
        //     var expectedChildrenTokens = new List<string> { "1", "2" };
        //     parentNode.Children = children.ToArray();
        //     Assert.AreEqual(parentNode.Token,"+");
        //     int currExpectedChildIndex = 0;
        //     foreach(var currentChild in children)
        //     {
        //         var actualNodeToken = currentChild.Token;
        //         var expectedToken = expectedChildrenTokens[currExpectedChildIndex];
        //         Assert.AreEqual(expectedToken, actualNodeToken);
        //         currExpectedChildIndex++;
        //     }
        // }
    }
}