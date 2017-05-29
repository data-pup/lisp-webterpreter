using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class LISPInterpreterCoreTest
    {
        private readonly LISPInterpreterCore _InterpreterCore;
        public LISPInterpreterCoreTest()
        {
            _InterpreterCore = new LISPInterpreterCore();
        }

        [TestMethod]
        public void GreetingWorks()
        {
            var expectedGreeting = new List<string>(){ "hello", "world" };
            var greeting = LISPInterpreterCore.Greet();
            Assert.AreEqual(2, greeting.Count);
            for (int currWordIndex = 0; currWordIndex < 2; currWordIndex++)
            {
                Assert.AreEqual(expectedGreeting[currWordIndex],
                                greeting[currWordIndex]);
            }
        }
    }
}
