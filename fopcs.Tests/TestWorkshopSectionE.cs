using System;
using fopcs_day3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fopcs.Tests
{
    [TestClass]
    public class TestWorkshopSectionE
    {
        [TestMethod]
        public void TestQuestion1a()
        {
            Assert.AreEqual(120, WorkshopSectionE.Question1a(5));
            Assert.AreEqual(362880, WorkshopSectionE.Question1a(9));
            Assert.AreEqual(1, WorkshopSectionE.Question1a(1));
        }

        [TestMethod]
        public void TestQuestion1b()
        {
            Assert.AreEqual(120, WorkshopSectionE.Question1b(5));
            Assert.AreEqual(362880, WorkshopSectionE.Question1b(9));
            Assert.AreEqual(1, WorkshopSectionE.Question1b(1));
        }

        [TestMethod]
        public void TestQuestion3()
        {
            Assert.AreEqual("Prime", WorkshopSectionE.Question3(5));
            Assert.AreEqual("Not Prime", WorkshopSectionE.Question3(6));
            Assert.AreEqual("Prime", WorkshopSectionE.Question3(997));
            Assert.AreEqual("Prime", WorkshopSectionE.Question3(7351));
        }

        [TestMethod]
        public void TestQuestion4()
        {
            Assert.IsTrue(WorkshopSectionE.Question4(6));
            Assert.IsTrue(WorkshopSectionE.Question4(33550336));
            Assert.IsFalse(WorkshopSectionE.Question4(10));
            Assert.IsTrue(WorkshopSectionE.Question4(8128));
        }
    }
}
