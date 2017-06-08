using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore.Classes.AbstractSyntaxTree;
using InterpreterCore.Tests.TestCases;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class LISPAbstractSyntaxTreeTest
    {
        [TestMethod]
        public void LISPAbstractSyntaxTreeDefaultConstructorWorks()
        {
            var testObject = new LISPAbstractSyntaxTree();
        }
    }
}