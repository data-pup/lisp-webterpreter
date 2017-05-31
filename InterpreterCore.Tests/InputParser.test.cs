using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class InputParserTest
    {
        private readonly InputParser _InputParser;
        public InputParserTest()
        {
            _InputParser = new InputParser();
        }

        [TestMethod]
        public void InputParserCanBeInstantiated()
        {
            var testObject = new InputParser();
        }
    }
}