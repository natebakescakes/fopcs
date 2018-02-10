using System;
using fopcs_day3;
using fopcs_day4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fopcs.Tests
{
    [TestClass]
    public class TestWorkshopSectionF
    {
        [TestMethod]
        public void TestPalindrome()
        {
            Assert.IsTrue(fopcs_day3.WorkshopSectionF.Palindrome("ABBA"), "ABBA");
            Assert.IsTrue(fopcs_day3.WorkshopSectionF.Palindrome("Racecar"), "Racecar");
            Assert.IsTrue(fopcs_day3.WorkshopSectionF.Palindrome("RACCAR"), "RACCAR");
            Assert.IsFalse(fopcs_day3.WorkshopSectionF.Palindrome("A"), "A");
            Assert.IsFalse(fopcs_day3.WorkshopSectionF.Palindrome("HELLO"), "HELLO");
        }

        [TestMethod]
        public void TestPalindrome2()
        {
            Assert.IsTrue(fopcs_day4.WorkshopSectionF.Palindrome("ABBA"), "ABBA");
            Assert.IsTrue(fopcs_day4.WorkshopSectionF.Palindrome("Racecar"), "Racecar");
            Assert.IsTrue(fopcs_day4.WorkshopSectionF.Palindrome("RACCAR"), "RACCAR");
            Assert.IsFalse(fopcs_day4.WorkshopSectionF.Palindrome("A"), "A");
            Assert.IsFalse(fopcs_day4.WorkshopSectionF.Palindrome("HELLO"), "HELLO");
            Assert.IsTrue(fopcs_day4.WorkshopSectionF.Palindrome("A Santa at NASA"), "A Santa at NASA");
            Assert.IsTrue(fopcs_day4.WorkshopSectionF.Palindrome("Mr. Owl ate my metal worm"), "Mr. Owl ate my metal worm");
        }

        [TestMethod]
        public void TestQuestion4()
        {
            Assert.AreEqual("Institute Of System Science", fopcs_day4.WorkshopSectionF.Question4("institute of system science"));
            Assert.AreEqual("A", fopcs_day4.WorkshopSectionF.Question4("a"));
            Assert.AreEqual("", fopcs_day4.WorkshopSectionF.Question4(""));
        }

        [TestMethod]
        public void TestQuestion6()
        {
            Assert.IsFalse(fopcs_day4.WorkshopSectionF.CheckSum("A56742A"));
            Assert.IsTrue(fopcs_day4.WorkshopSectionF.CheckSum("A56742S"));
            Assert.IsTrue(fopcs_day4.WorkshopSectionF.CheckSum("a56742s"));
        }
    }
}
