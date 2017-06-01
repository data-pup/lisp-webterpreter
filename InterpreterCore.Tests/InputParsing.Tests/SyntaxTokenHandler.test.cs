using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class SyntaxTokenHandlerTest
    {
        private readonly SyntaxTokenHandler _SyntaxTokenHandler;
        public SyntaxTokenHandlerTest()
        {
            _SyntaxTokenHandler = new SyntaxTokenHandler();
        }

        [TestMethod]
        public void SyntaxTokenHandlerCanBeInstantiated()
        {
            var testObject = new SyntaxTokenHandler();
        }

        [TestMethod]
        public void SyntaxTokenHandlerSplitsParenthesesAndPlus()
        {
            var testExpression = "(+";
            var expectedResult = new List<String>(){"(", "+"};
            List<String> actualResult = SyntaxTokenHandler.ParseSingleRawToken(testExpression);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}