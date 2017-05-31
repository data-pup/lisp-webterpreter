using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class WhitespaceParserTest
    {
        private readonly WhitespaceParser _WhitespaceParser;
        public WhitespaceParserTest()
        {
            _WhitespaceParser = new WhitespaceParser();
        }

        [TestMethod]
        public void WhitespaceParserCanBeInstantiated()
        {
            var testObject = new WhitespaceParserTest();
        }

        [TestMethod]
        public void BoundaryWhitespaceRemovedCorrectly()
        {
            var testInputsAndAnswers = new Dictionary<String,String>();
            testInputsAndAnswers.Add("1", "1");
            testInputsAndAnswers.Add("1 ", "1");
            testInputsAndAnswers.Add(" 1", "1");
            testInputsAndAnswers.Add("1\t","1");
            testInputsAndAnswers.Add("\t1","1");
            testInputsAndAnswers.Add("\t1\t","1");
            testInputsAndAnswers.Add("1  ","1");
            testInputsAndAnswers.Add(" 1 ","1");
            testInputsAndAnswers.Add("  1","1");
            RunWhitespaceTests(testInputsAndAnswers);
        }

        [TestMethod]
        public void InnerWhitespaceRemovedCorrectly()
        {
            var testInputsAndAnswers = new Dictionary<String,String>();
            testInputsAndAnswers.Add("1 1","1 1");
            testInputsAndAnswers.Add("1  1","1 1");
            testInputsAndAnswers.Add("1   1","1 1");
            testInputsAndAnswers.Add("1\t1","1 1");
            testInputsAndAnswers.Add("1\t\t1","1 1");
            RunWhitespaceTests(testInputsAndAnswers);
        }

        [TestMethod]
        public void OtherWhiteSpaceTests()
        {
            var testInputsAndAnswers = new Dictionary<String,String>();
            testInputsAndAnswers.Add("  \t1 2  3\t\t4 5    ", "1 2 3 4 5");
            testInputsAndAnswers.Add("\t1     2 3\t\t4 5", "1 2 3 4 5");
            testInputsAndAnswers.Add("\t1\t2\t3\t4\t5\t", "1 2 3 4 5");
            RunWhitespaceTests(testInputsAndAnswers);
        }

        private void RunWhitespaceTests(Dictionary<String,String> testInputsAndAnswers)
        {
            foreach(var item in testInputsAndAnswers)
            {
                var expression = item.Key;
                var expectedResult = item.Value;
                var actualResult = WhitespaceParser.TrimWhitespace(expression);
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

    }
}