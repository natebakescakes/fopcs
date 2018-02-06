using System;
using fopcs_day3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fopcs.Tests
{
    [TestClass]
    public class TestWorkshopSectionD
    {
        [TestMethod]
        public void TestFindHCF()
        {
            Assert.AreEqual(4, WorkshopSectionD.findHCF(8, 4), "Finds the correct HCF");
            Assert.AreEqual(4, WorkshopSectionD.findHCF(4, 8), "Finds the correct HCF with reversed input parameters");
            Assert.AreEqual(40, WorkshopSectionD.findHCF(120, 2000), "Finds the correct HCF with larger integers");
            Assert.AreEqual(21, WorkshopSectionD.findHCF(1071, 462), "Finds another correct HCF");
        }

        [TestMethod]
        public void TestFindLCM()
        {
            Assert.AreEqual(8, WorkshopSectionD.findLCM(8, 4), "Finds the correct LCM");
            Assert.AreEqual(8, WorkshopSectionD.findLCM(4, 8), "Finds the correct LCM with reversed input parameters");
            Assert.AreEqual(6000, WorkshopSectionD.findLCM(120, 2000), "Finds the correct LCM with larger integers");
            Assert.AreEqual(23562, WorkshopSectionD.findLCM(1071, 462), "Finds another correct LCM");
        }

        [TestMethod]
        public void Question4()
        {
            Assert.AreEqual(0, WorkshopSectionD.Question4(0), 0.00001, "0 input case");
            Assert.AreEqual(5, WorkshopSectionD.Question4(25), 0.00001, "Sqrt(25) == 5");
            Assert.AreEqual(1.73205, WorkshopSectionD.Question4(3), 0.00001, "Sqrt(3)");
        }
    }
}
