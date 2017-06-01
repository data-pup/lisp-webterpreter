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
            var testObject = ReservedCharacters.Characters;
        }
        [TestMethod]
        public void SameNumberOfReservedCharacters()
        {
            var reservedTokens = ReservedCharacters.Characters;
            var expectedToken = new SortedSet<char>(){'(', ')'};
            Assert.AreEqual(reservedTokens.Count, expectedToken.Count);
        }
    }
}