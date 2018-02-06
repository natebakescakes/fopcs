using System;
using fopcs_day3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fopcs.Tests
{
    [TestClass]
    public class TestWorkshopSectionF
    {
        [TestMethod]
        public void TestPalindrome()
        {
            Assert.IsTrue(WorkshopSectionF.Palindrome("ABBA"), "ABBA");
            Assert.IsTrue(WorkshopSectionF.Palindrome("Racecar"), "Racecar");
            Assert.IsTrue(WorkshopSectionF.Palindrome("RACCAR"), "RACCAR");
            Assert.IsFalse(WorkshopSectionF.Palindrome("A"), "A");
            Assert.IsFalse(WorkshopSectionF.Palindrome("HELLO"), "HELLO");
        }
    }
}
