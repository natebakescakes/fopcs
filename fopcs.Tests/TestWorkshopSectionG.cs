using System;
using fopcs_day4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fopcs.Tests
{
    [TestClass]
    public class TestWorkshopSectionG
    {
        double[] testData;
        int[,] markData;

        [TestInitialize]
        public void InitializeTestData()
        {
            testData = new double[12]
            {
                1300.00, // Janaury
                1142.00, // February
                1324.00, // March
                1234.00, // April
                4932.00, // May
                3453.00, // June
                1235.00, // July
                4852.00, // August
                4860.00, // September
                2345.00, // October
                3456.00, // November
                4567.00 // December
            };

            markData = new int[,]
            {
                { 56, 84, 68, 29 },
                { 94, 73, 31, 96 },
                { 41, 63, 36, 90 },
                { 99, 9, 18, 17 },
                { 62, 3, 65, 75 },
                { 40, 96, 53, 23 },
                { 81, 15, 27, 30 },
                { 21, 70, 100, 22 },
                { 88, 50, 13, 12 },
                { 48, 54, 52, 78 },
                { 64, 71, 67, 25 },
                { 16, 93, 46, 72 }
            };
        }

        [TestMethod]
        public void TestMaxSales()
        {
            Assert.AreEqual(4, WorkshopSectionG.MaxSales(testData));
        }

        [TestMethod]
        public void TestMinSales()
        {
            Assert.AreEqual(1, WorkshopSectionG.MinSales(testData));
        }

        [TestMethod]
        public void TestAverageSales()
        {
            Assert.AreEqual(2891.67, WorkshopSectionG.AverageSales(testData), 0.01);
        }
    }
}
