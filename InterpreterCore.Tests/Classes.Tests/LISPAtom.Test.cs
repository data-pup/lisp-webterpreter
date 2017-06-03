using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using InterpreterCore.Classes;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class LISPAtom
    {
        [TestMethod]
        public void LISPAtomDefaultCanBeInstantiated()
        {
            var testObject = new LISPAtom();
        }

        [TestMethod]
        public void LISPAtomConstructorAcceptsIntParameter()
        {
            var testObject = new LISPAtom<int>(1);
            Assert.AreEqual(testObject.Value, 1);
        }

        [TestMethod]
        public void LISPAtomConstructorAcceptsDoubleParameter()
        {
            var testObject = new LISPAtom<double>(1.1);
            Assert.AreEqual(testObject.Value, 1.1);
        }

        [TestMethod]
        public void LISPAtomCanBeAssignedNewValue()
        {
            LISPAtom<int> testObject = new LISPAtom<int>(1);
            testObject.Value = 5;
            Assert.AreEqual(testObject.Value, 5);
        }
    }
}