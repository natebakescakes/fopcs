using System;
using fopcs_day5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fopcs.Tests
{
    [TestClass]
    public class TestWorkshopSectionH
    {
        [TestMethod]
        public void TestInString()
        {
            Assert.IsTrue(WorkshopSectionH.InString("The brown fox", "O"), "First Test");
            Assert.IsTrue(WorkshopSectionH.InString("The brown fox", "FOX"), "Second Test");
            Assert.IsTrue(WorkshopSectionH.InString("The brown fox", "bRO"), "Third Test");
            Assert.IsFalse(WorkshopSectionH.InString("T", "bRO"), "Fourth Test");
            Assert.IsFalse(WorkshopSectionH.InString("The bras basah complex", "bRO"), "Fifth Test");
        }

        [TestMethod]
        public void TestFindWord()
        {
            Assert.AreEqual(6, WorkshopSectionH.FindWord("The brown fox", "O"), "First Test");
            Assert.AreEqual(10, WorkshopSectionH.FindWord("The brown fox", "FOX"), "Second Test");
            Assert.AreEqual(4, WorkshopSectionH.FindWord("The brown fox", "bRO"), "Third Test");
            Assert.AreEqual(-1, WorkshopSectionH.FindWord("T", "bRO"), "Fourth Test");
            Assert.AreEqual(-1, WorkshopSectionH.FindWord("The bras basah complex", "bRO"), "Fifth Test");
        }

        [TestMethod]
        public void TestHexadecimal()
        {
            Assert.AreEqual("0", WorkshopSectionH.Hexadecimal(0));
            Assert.AreEqual("F", WorkshopSectionH.Hexadecimal(15));
            Assert.AreEqual("10", WorkshopSectionH.Hexadecimal(16));
            Assert.AreEqual("64", WorkshopSectionH.Hexadecimal(100));
        }

        [TestMethod]
        public void TestSubstitute()
        {
            Assert.AreEqual("Hewwo", WorkshopSectionH.Substitute("Hello", 'l', 'w'));
            Assert.AreEqual("Hellw", WorkshopSectionH.Substitute("Hello", 'o', 'w'));
            Assert.AreEqual("Wello", WorkshopSectionH.Substitute("Hello", 'H', 'W'));
        }

        [TestMethod]
        public void TestResizeArray()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 0 }, WorkshopSectionH.ResizeArray(new int[] { 1, 2 }, 3), "Smaller to Larger");
            CollectionAssert.AreEqual(new int[] { 1 }, WorkshopSectionH.ResizeArray(new int[] { 1 }, 1), "Equal size");
            CollectionAssert.AreEqual(new int[] { 1, 2 }, WorkshopSectionH.ResizeArray(new int[] { 1, 2, 3 }, 2), "Larger to Smaller");
        }

        [TestMethod]
        public void TestIsPrime()
        {
            Assert.IsTrue(WorkshopSectionH.IsPrime(3));
            Assert.IsFalse(WorkshopSectionH.IsPrime(4));
        }

        [TestMethod]
        public void TestMatrixMultiplication()
        {
            CollectionAssert.AreEqual(new int[,]
            {
                { 42, 29 },
                { 35, 20 },
                { 17, 10 }
            }, WorkshopSectionH.MatrixMultiply(new int[,]
            {
                { 2, 3, 4, 5 },
                { 5, 4, 3, 2 },
                { 1, 2, 1, 2 }
            }, new int[,]
            {
                { 1, 3, },
                { 3, -2 },
                { 4, 1 },
                { 3, 5 }
            }), "3x4 and 4x2");

            CollectionAssert.AreEqual(new int[,]
            {
                { 7, 4 },
                { 8, 5 }
            }, WorkshopSectionH.MatrixMultiply(new int[,]
            {
                { 1, 2 },
                { 2, 1 }
            }, new int[,]
            {
                { 3, 2 },
                { 2, 1 }
            }), "2x2 and 2x2");
        }
    }
}
