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

        /// <summary>
        /// This is a private helper method that will examine two syntax
        /// token lists, assert that they have equal lengths, and then
        /// assert that each element in the list is identical. If the
        /// 'verbosity' parameter is set to true, the two token lists
        /// will be printed in full before comparing.
        /// </summary>
        private void SyntaxTokenListsAreEqual()
        {
            //
        }


    }
}