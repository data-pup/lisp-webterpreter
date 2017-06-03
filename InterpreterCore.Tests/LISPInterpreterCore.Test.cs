using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class LISPInterpreterCoreTest
    {
        private readonly LISPInterpreterCore _testInterpreter;
        public LISPInterpreterCoreTest()
        {
            _testInterpreter = new LISPInterpreterCore();
        }

        [TestMethod]
        public void LISPInterpreterCoreCanBeInstantiated()
        {
            var testObject = new LISPInterpreterCore();
        }

        /// <summary>
        /// This is a test used for development, to ensure that the core
        /// interpreter module has been successfuly imported. The greeting
        /// method will return a list of strings, ["hello", "world"]
        /// </summary>
        [TestMethod]
        public void GreetingWorks()
        {
            var testObject = new LISPInterpreterCore();
            var expectedGreeting = new string[] { "hello", "world" };
            var greeting = testObject.Greet();
            Assert.AreEqual(2, greeting.Length);
            for (int currWordIndex = 0; currWordIndex < 2; currWordIndex++)
            {
                Assert.AreEqual(expectedGreeting[currWordIndex],
                                greeting[currWordIndex]);
            }
        }
    }
}
