using System;
using AdditionalExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fopcs.Tests
{
    [TestClass]
    public class TestPrintSeriesOfNumbers
    {
        [TestMethod]
        public void TestFibonacci()
        {
            Assert.AreEqual(1, PrintSeriesOfNumbers.Fibonacci(3));
            Assert.AreEqual(144, PrintSeriesOfNumbers.Fibonacci(13));
            Assert.AreEqual(6765, PrintSeriesOfNumbers.Fibonacci(21));
        }
    }
}
