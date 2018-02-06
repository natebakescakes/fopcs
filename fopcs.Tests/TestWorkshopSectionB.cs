using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fopcs_day2;

namespace fopcs.Tests
{
    [TestClass]
    public class TestWorkshopSectionB
    {
        [TestMethod]
        public void TestSBQ01()
        {
            Assert.AreEqual(0, WorkshopSectionB.Question1(0));
            Assert.AreEqual(5, WorkshopSectionB.Question1(25));
            Assert.AreEqual(1.732, WorkshopSectionB.Question1(3), 0.01);
        }

        [TestMethod]
        public void TestSBQ02()
        {
            Assert.AreEqual(0.000, WorkshopSectionB.Question2(0));
            Assert.AreEqual(5.000, WorkshopSectionB.Question2(25));
            Assert.AreEqual(1.732, WorkshopSectionB.Question2(3));
            Assert.AreEqual(17.321, WorkshopSectionB.Question2(300));
        }

        [TestMethod]
        public void TestSBQ03()
        {
            Assert.AreEqual("$1,130.00", WorkshopSectionB.Question3(1000));
            Assert.AreEqual("$0.00", WorkshopSectionB.Question3(0));
            Assert.AreEqual("$2,260.00", WorkshopSectionB.Question3(2000));
        }

        [TestMethod]
        public void TestSBQ04()
        {
            Assert.AreEqual(32, WorkshopSectionB.Question4(0));
            Assert.AreEqual(-148, WorkshopSectionB.Question4(-100));
            Assert.AreEqual(212, WorkshopSectionB.Question4(100));
        }

        [TestMethod]
        public void TestSBQ05()
        {
            Assert.AreEqual(3, WorkshopSectionB.Question5(0));
            Assert.AreEqual(50403, WorkshopSectionB.Question5(-100));
            Assert.AreEqual(49603, WorkshopSectionB.Question5(100));
        }

        [TestMethod]
        public void TestSBQ06()
        {
            Assert.AreEqual(0, WorkshopSectionB.Question6(0, 0, 0, 0));
            Assert.AreEqual(14.142, WorkshopSectionB.Question6(0, 0, 10, 10), 0.001);
            Assert.AreEqual(9, WorkshopSectionB.Question6(1, 1, 10, 1));
        }

        [TestMethod]
        public void TestSBQ07()
        {
            Assert.AreEqual(2.4, WorkshopSectionB.Question7(0));
            Assert.AreEqual(3.72, WorkshopSectionB.Question7(3.3), 0.01);
            Assert.AreEqual(6.492, WorkshopSectionB.Question7(10.23), 0.01);
        }

        [TestMethod]
        public void TestSBQ08()
        {
            Assert.AreEqual("2.40", WorkshopSectionB.Question8(0));
            Assert.AreEqual("3.70", WorkshopSectionB.Question8(3.3));
            Assert.AreEqual("6.50", WorkshopSectionB.Question8(10.23));
        }

        [TestMethod]
        public void TestSBQ09()
        {
            Assert.AreEqual(2.4, WorkshopSectionB.Question9(0));
            Assert.AreEqual(3.8, WorkshopSectionB.Question9(3.3));
            Assert.AreEqual(6.5, WorkshopSectionB.Question9(10.23));
        }

        [TestMethod]
        public void TestSBQ10()
        {
            Assert.AreEqual(0, WorkshopSectionB.Question10(0, 0, 0));
            Assert.AreEqual(6, WorkshopSectionB.Question10(3, 4, 5));
            Assert.AreEqual(Double.NaN, WorkshopSectionB.Question10(1, 1, 3));
        }
    }
}
