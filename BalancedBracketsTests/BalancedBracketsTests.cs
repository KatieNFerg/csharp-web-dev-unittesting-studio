using BalancedBracketsNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
//1
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
//2
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
//3
        [TestMethod]
        public void OpenBracketReturnsFalse() 
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[()"));
        }
//4
        [TestMethod]
        public void CloseBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("()]"));
        }
//5
        [TestMethod]
        public void StringBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("string[]"));
        }
//6
        [TestMethod]
        public void BracketsStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]string"));
        }
//7
        [TestMethod]
        public void NoBrackets()
        {            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("string"));
        }
//8
        [TestMethod]
        public void MultipleBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[Launchcode]]"));
        }

//9   
        [TestMethod]
        public void BalancedWithinString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("L[aunch]code"));
        }

//10
        [TestMethod]
        public void UnbalancedWithinString()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("L[aunch[code"));
        }
//11
        [TestMethod]
        public void BackwardsBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
//12
        [TestMethod]
        public void TextBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("OpenBracket word ClosedBracket"));
        }

    }
}

