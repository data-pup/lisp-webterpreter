using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore.AbstractSyntaxTree;
using InterpreterCore.Tests.TestCases;

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
        public void AbstractSyntaxTreeNodeCanStoreAndIdentifyOperatorTokens()
        {
            var operatorTokensAndAnswers = AbstractSyntaxTreeNodeTestCases.AbstractSyntaxTreeNodeOperatorTokenTests;
            foreach(var currentTestCase in operatorTokensAndAnswers)
            {
                string token = currentTestCase.Key;
                bool expectedResult = currentTestCase.Value;
                bool actualResult = LISPAbstractSyntaxTreeNode.IsOperator(token);
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanStoreNumberToken()
        {
            var testObject = new LISPAbstractSyntaxTreeNode("1");
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanStoreVariableToken()
        {
            var testObject = new LISPAbstractSyntaxTreeNode("x");
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
            var rawTokens = new string[]{"+", "1", "2"};
            var expectedToken = "+";
            var expectedArguments = new string[]{"1", "2"};
            foreach(var token in rawTokens)
            {
                parentNode.Add(token);
            }
            var actualToken = parentNode.Token;
            Assert.AreEqual(expectedToken, actualToken);
            var actualArguments = new Stack<LISPAbstractSyntaxTreeNode>(parentNode.Children);
            Assert.AreEqual(expectedArguments.Length, actualArguments.Count);
            foreach(var currentChild in actualArguments)
            {
                Assert.IsTrue(actualArguments.Contains(currentChild));
            }
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanIdentifyRoot()
        {
            //
            var parentNode = new LISPAbstractSyntaxTreeNode();
            var rawTokens = new string[]{"+", "1", "2"};
            var expectedArguments = new string[]{"1", "2"};
            foreach(var token in rawTokens)
            {
                parentNode.Add(token);
            }
            Assert.IsTrue(parentNode.IsRoot());
            foreach(var currentChild in parentNode.Children)
            {
                bool nodeIsRoot = currentChild.IsRoot();
                Assert.IsFalse(nodeIsRoot);
                bool parentIsRoot = currentChild.Parent.IsRoot();
                Assert.IsTrue(parentIsRoot);
            }
        }
    }
}