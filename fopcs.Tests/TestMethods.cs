using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionalExercises;

namespace fopcs.Tests
{
    [TestClass]
    public class TestMethods
    {
        [TestMethod]
        public void TestResizeArray()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2 }, Methods.ResizeArray(new int[] { 1, 2, 3 }, 2), "Reduce Size");
            CollectionAssert.AreEqual(new int[] { 1, 2, 0 }, Methods.ResizeArray(new int[] { 1, 2 }, 3), "Increase Size");
            CollectionAssert.AreEqual(new int[] { 1, 2 }, Methods.ResizeArray(new int[] { 1, 2 }, 2), "Same Size");
        }

        [TestMethod]
        public void TestSwap()
        {
            int a = 6;
            int b = 5;
            Methods.Swap(ref a, ref b);
            Assert.AreEqual(5, a, "Swap");
            int c = 7;
            int d = 8;
            Methods.Swap(ref c, ref d);
            Assert.AreEqual(7, c, "Do not swap");
        }

        [TestMethod]
        public void TestPassswordCheck()
        {
            Assert.IsTrue(Methods.PasswordCheck("aB000000"));
            Assert.IsFalse(Methods.PasswordCheck("SSSSSSSSSSSSS"));
        }

        [TestMethod]
        public void TestFormatCheck()
        {
            Assert.IsTrue(Methods.FormatCheck("AB00000"));
            Assert.IsFalse(Methods.FormatCheck("0000000"));
            Assert.IsFalse(Methods.FormatCheck("AAAAAAA"));
            Assert.IsFalse(Methods.FormatCheck("AB"));
        }

        [TestMethod]
        public void TestEmailCheckTrue()
        {
            Assert.IsTrue(Methods.EmailCheck("natebakescakes@gmail.com"), "Normal email address");
            Assert.IsTrue(Methods.EmailCheck("nathan.khoo@gmail.com"), "Email address with period");
            Assert.IsTrue(Methods.EmailCheck("nathan-khoo@gmail.com"), "Email address with hyphen");
        }

        [TestMethod]
        public void TestEmailCheckFalse()
        {
            Assert.IsFalse(Methods.EmailCheck("natebakescakes@@@gmail.com"), "Multiple @ symbols");
            Assert.IsFalse(Methods.EmailCheck("n@tebakescakes@gmail.com"), "@ symbol at the beginning");
            Assert.IsFalse(Methods.EmailCheck("natebakescakes@gmail..com"), "Multiple . symbols after hostname");
            Assert.IsFalse(Methods.EmailCheck("natebakescakes@gmail.com@"), "@ symbol at the end");
            Assert.IsFalse(Methods.EmailCheck("www.google.com"), "URL");
        }
    }
}
