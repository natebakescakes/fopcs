using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fopcs_day2;

namespace fopcs.Tests
{
    [TestClass]
    public class TestQuiz
    {
        [TestMethod]
        public void TestInitialAnswer()
        {
            Assert.AreEqual(500, Quiz.InitialAnswer(1));
            Assert.AreEqual(2425, Quiz.InitialAnswer(5));
            Assert.AreEqual(4750, Quiz.InitialAnswer(10));
        }

        [TestMethod]
        public void TestCorrectAnswer()
        {
            Assert.AreEqual(500, Quiz.CorrectAnswer(1));
            Assert.AreEqual(2425, Quiz.CorrectAnswer(5));
            Assert.AreEqual(4750, Quiz.CorrectAnswer(10));
        }

        [TestMethod]
        public void TestAlternativeAnswer()
        {
            Assert.AreEqual(500, Quiz.AlternativeAnswer(1));
            Assert.AreEqual(2425, Quiz.AlternativeAnswer(5));
            Assert.AreEqual(4750, Quiz.AlternativeAnswer(10));
        }
    }
}
