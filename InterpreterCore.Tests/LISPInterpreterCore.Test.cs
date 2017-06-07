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
    }
}
