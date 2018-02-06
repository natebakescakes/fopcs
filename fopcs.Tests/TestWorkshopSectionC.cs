using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fopcs_day2;

namespace fopcs.Tests
{
    [TestClass]
    public class TestWorkshopSectionC
    {
        [TestMethod]
        public void TestSCQ01()
        {
            Assert.AreEqual("Good Morning Mr. Venkat", WorkshopSectionC.Question1("Venkat", "M"));
            Assert.AreEqual("Good Morning Ms. Nathan", WorkshopSectionC.Question1("Nathan", "F"));
        }

        [TestMethod]
        public void TestSCQ02()
        {
            Assert.AreEqual("Good Morning Uncle Sam", WorkshopSectionC.Question2("Sam", "M", 45));
            Assert.AreEqual("Good Morning Ms. Nathan", WorkshopSectionC.Question2("Nathan", "F", 20));
            Assert.AreEqual("Good Morning Mr. Sam", WorkshopSectionC.Question2("Sam", "M", 30));
            Assert.AreEqual("Good Morning Aunty Christine", WorkshopSectionC.Question2("Christine", "F", 50));
        }

        [TestMethod]
        public void TestSCQ03()
        {
            Assert.AreEqual("A", WorkshopSectionC.Question3(98));
            Assert.AreEqual("B", WorkshopSectionC.Question3(73));
            Assert.AreEqual("C", WorkshopSectionC.Question3(45));
            Assert.AreEqual("F", WorkshopSectionC.Question3(32));
            Assert.AreEqual("**Error**", WorkshopSectionC.Question3(-2));
            Assert.AreEqual("**Error**", WorkshopSectionC.Question3(234));
        }

        [TestMethod]
        public void TestSCQ04()
        {
            Assert.AreEqual(2.4, WorkshopSectionC.Question4(0));
            Assert.AreEqual(2.4, WorkshopSectionC.Question4(0.5));
            Assert.AreEqual(5.8, WorkshopSectionC.Question4(9), 0.01);
            Assert.AreEqual(7.4, WorkshopSectionC.Question4(12.13));
        }

        [TestMethod]
        public void TestSCQ05()
        {
            Assert.IsFalse(WorkshopSectionC.Question5(100), "Output 1");
            Assert.IsTrue(WorkshopSectionC.Question5(370), "Output 2");
            Assert.IsTrue(WorkshopSectionC.Question5(371), "Output 3");
            Assert.IsFalse(WorkshopSectionC.Question5(372), "Output 4");
        }

        [TestMethod]
        public void TestSCQ06()
        {
            Assert.IsFalse(WorkshopSectionC.Question5a("100"), "Output 1");
            Assert.IsTrue(WorkshopSectionC.Question5a("370"), "Output 2");
            Assert.IsTrue(WorkshopSectionC.Question5a("371"), "Output 3");
            Assert.IsFalse(WorkshopSectionC.Question5a("372"), "Output 4");
            Assert.IsTrue(WorkshopSectionC.Question5a("548834"), "Output 5");
            Assert.IsTrue(WorkshopSectionC.Question5a("1741725"), "Output 6");
            Assert.IsTrue(WorkshopSectionC.Question5a("4210818"), "Output 7");
            Assert.IsTrue(WorkshopSectionC.Question5a("9800817"), "Output 8");
            Assert.IsTrue(WorkshopSectionC.Question5a("9926315"), "Output 9");
        }
    }
}
