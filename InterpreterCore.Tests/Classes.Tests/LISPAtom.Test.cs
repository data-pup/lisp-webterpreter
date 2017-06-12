using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using InterpreterCore.Classes.Lisp;

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

        [TestMethod]
        public void LISPAtomHasWorkingAdditionOperator()
        {
            LISPAtom<int> leftHandAtom = new LISPAtom<int>(1);
            LISPAtom<int> rightHandAtom = new LISPAtom<int>(2);
            var resultAtom = leftHandAtom + rightHandAtom;
            var actualResult = resultAtom.Value;
            var expectedResult = 3;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LISPAtomHasWorkingSubtractionOperator()
        {
            LISPAtom<int> leftHandAtom = new LISPAtom<int>(2);
            LISPAtom<int> rightHandAtom = new LISPAtom<int>(1);
            var resultAtom = leftHandAtom - rightHandAtom;
            var actualResult = resultAtom.Value;
            var expectedResult = 1;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LISPAtomHasWorkingMultiplicationOperator()
        {
            LISPAtom<int> leftHandAtom = new LISPAtom<int>(2);
            LISPAtom<int> rightHandAtom = new LISPAtom<int>(3);
            var resultAtom = leftHandAtom * rightHandAtom;
            var actualResult = resultAtom.Value;
            var expectedResult = 6;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LISPAtomHasWorkingDivisionOperator()
        {
            LISPAtom<int> leftHandAtom = new LISPAtom<int>(6);
            LISPAtom<int> rightHandAtom = new LISPAtom<int>(3);
            var resultAtom = leftHandAtom / rightHandAtom;
            var actualResult = resultAtom.Value;
            var expectedResult = 2;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}