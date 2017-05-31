using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using InterpreterCore;

namespace InterpreterCore.Tests
{
    [TestClass]
    public class ReservedCharactersTest
    {
        [TestMethod]
        public void CanInstantiateReservedCharacters()
        {
            var testObject = ReservedCharacters.Tokens;
        }
        [TestMethod]
        public void SameNumberOfReservedCharacters()
        {
            var reservedTokens = ReservedCharacters.Tokens;
            var expectedToken = new List<String>(){"(", ")"};
            Assert.AreEqual(reservedTokens.Count, expectedToken.Count);
        }
    }
}