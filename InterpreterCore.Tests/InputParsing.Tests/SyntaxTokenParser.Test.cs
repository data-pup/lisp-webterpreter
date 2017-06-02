using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class SyntaxTokenParserTest
    {
        private readonly SyntaxTokenParser _SyntaxTokenParser;
        public SyntaxTokenParserTest()
        {
            _SyntaxTokenParser = new SyntaxTokenParser();
        }

        [TestMethod]
        public void SyntaxTokenParserCanBeInstantiated()
        {
            var testObject = new SyntaxTokenParser();
        }

        [TestMethod]
        public void SyntaxTokenParserSplitsParenthesesAndPlus()
        {
            var testExpression = "(+";
            var expectedResult = new List<String>(){"(", "+"};
            List<String> actualResult = SyntaxTokenParser.ParseSingleRawToken(testExpression);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}