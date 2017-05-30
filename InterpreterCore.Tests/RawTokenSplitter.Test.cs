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
    }
}