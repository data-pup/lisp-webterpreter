using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class RawTokenSplitterTest
    {
        private readonly RawTokenSplitter _RawTokenSplitter;
        public RawTokenSplitterTest()
        {
            _RawTokenSplitter = new RawTokenSplitter();
        }

        [TestMethod]
        public void RawTokenSplitterCanBeInstantiated()
        {
            var testObject = new RawTokenSplitter();
        }

        public void testSimpleExpressionsRawTokens()
        {
            var testCasesAndAnswers = new Dictionary<String,List<String>>();
            testCasesAndAnswers.Add(
                "1", new List<String>(){"1"}
            );
            testCasesAndAnswers.Add(
                "(1)", new List<String>(){"(1)"}
            );
            testCasesAndAnswers.Add(
                "(+ 1 2)", new List<String>(){"(+","1","2)"}
            );
            testCasesAndAnswers.Add(
                "(+ 1 2)", new List<String>(){"(+","1","2)"}
            );
            testCasesAndAnswers.Add(
                "\t(+\t1\t2)", new List<String>(){"(+","1","2)"}
            );
            runSplittingTests(testCasesAndAnswers);
        }

        /// <summary>
        /// This method is used to pass test cases into the raw token splitter.
        /// The exposed interface of this class primarily revolves around
        // passing in a string, and returning a collection of strings. This
        /// method will run a series of tests sequentially.
        /// </summary>
        private void runSplittingTests(Dictionary<String,List<String>> testCasesAndAnswers)
        {
            foreach (var currentTestCase in testCasesAndAnswers)
            {
                // Get the current test case input, correct output, and real output.
                string expression = currentTestCase.Key;
                List<String> expectedResults = currentTestCase.Value;
                List<String> actualResults = RawTokenSplitter.splitTrimmedExpression(expression);
                Assert.AreEqual(expectedResults.Count, actualResults.Count); // Check lists are equal size.
                for (int currentTokenIndex = 0; currentTokenIndex < actualResults.Count; currentTokenIndex++)
                {
                    var expectedToken = expectedResults[currentTokenIndex];
                    var actualToken = actualResults[currentTokenIndex];
                    Assert.AreEqual(expectedToken, actualToken);
                }
            }
        }
    }
}