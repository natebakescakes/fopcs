using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fopcs_day5;

namespace fopcs.Tests
{
    [TestClass]
    public class TestDay5Quiz
    {
        [TestMethod]
        public void TestCalculateIncomeTax()
        {
            Assert.AreEqual(5650, Quiz.CalculateIncomeTax(100000, 3));
            Assert.AreEqual(0, Quiz.CalculateIncomeTax(0, -1));
            Assert.AreEqual(178350, Quiz.CalculateIncomeTax(1000000, 7));
        }

        [TestMethod]
        public void TestGetTaxBracket()
        {
            Assert.AreEqual(-1, Quiz.GetTaxBracket(0));
            Assert.AreEqual(7, Quiz.GetTaxBracket(1000000));
        }
    }
}
