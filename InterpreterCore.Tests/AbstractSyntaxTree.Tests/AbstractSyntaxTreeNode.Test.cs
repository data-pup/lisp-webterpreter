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
            string expectedToken = "1";
            Assert.AreEqual(expectedToken, testObject.Token);
            Assert.IsNull(testObject.Parent);
            Assert.AreEqual(0, testObject.Children.Length);
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanStoreVariableToken()
        {
            var testObject = new LISPAbstractSyntaxTreeNode("x");
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeAddWorksOnEmptyNode()
        {
            var testObject = new LISPAbstractSyntaxTreeNode();
            testObject.Add("+");
            Assert.AreEqual(testObject.Token, "+");
            Assert.IsNull(testObject.Parent);
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
            Assert.IsFalse(parentNode.HasParent);
            var actualArguments = new Stack<LISPAbstractSyntaxTreeNode>(parentNode.Children);
            Assert.AreEqual(expectedArguments.Length, actualArguments.Count);
            foreach(var currentChild in actualArguments)
            {
                Assert.IsTrue(actualArguments.Contains(currentChild));
                Assert.IsTrue(currentChild.HasParent);
                Assert.AreEqual(currentChild.Parent, parentNode);
            }
        }

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanIdentifyIfIsRoot()
        {
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

        [TestMethod]
        public void AbstractSyntaxTreeNodeCanBuildTwoLevelTree()
        {
            // Ex. (* 1 2 (- 3 (+ 4)))
            // -------------------------------------------------------
            var parentNode = new LISPAbstractSyntaxTreeNode();
            var childTree = new LISPAbstractSyntaxTreeNode();
            var grandChildTree = new LISPAbstractSyntaxTreeNode();
            // -------------------------------------------------------
            grandChildTree.Add("+");
            grandChildTree.Add("4");
            childTree.Add("-");
            childTree.Add("3");
            childTree.Add(grandChildTree);
            parentNode.Add("*");
            parentNode.Add("1");
            parentNode.Add("2");
            parentNode.Add(childTree);
            // -------------------------------------------------------
            Assert.IsNull(parentNode.Parent);
            Assert.AreEqual(childTree.Parent, parentNode);
            Assert.AreEqual(grandChildTree.Parent, childTree);
            // -------------------------------------------------------
        }

        private void TestChildrenTokensEqualsGivenTokenList(LISPAbstractSyntaxTreeNode ASTNode, string[] expectedTokensArray)
        {
            var childNodes = ASTNode.Children;
            string[] childTokensArray = GetChildrenTokensList(ASTNode);
            Assert.AreEqual(childTokensArray, expectedTokensArray);
        }

        private string[] GetChildrenTokensList(LISPAbstractSyntaxTreeNode ASTNode)
        {
            var tokensList = new List<string>();
            foreach(var currentChild in ASTNode.Children)
            {
                tokensList.Add(currentChild.Token);
            }
            return tokensList.ToArray();
        }
    }
}