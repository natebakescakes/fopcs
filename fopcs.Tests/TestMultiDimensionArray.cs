using System;
using AdditionalExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fopcs.Tests
{
    public class Comparer : System.Collections.IComparer
    {
        private readonly double _epsilon;

        public Comparer(double epsilon)
        {
            _epsilon = epsilon;
        }

        public int Compare(object x, object y)
        {
            var a = (double)x;
            var b = (double)y;

            double delta = System.Math.Abs(a - b);
            if (delta < _epsilon)
            {
                return 0;
            }
            return a.CompareTo(b);
        }
    }

    [TestClass]
    public class TestMultiDimensionArray
    {

        [TestMethod]
        public void TestAverageArray()
        {
            CollectionAssert.AreEqual(new double[] { 2, 4, 8, 5.67, 7 }, MultiDimensionArray.AverageArray(new int[,] {
                { 1, 2, 3 },
                { 3, 4, 5 },
                { 7, 8, 9 },
                { 8, 7, 2 },
                { 7, 7, 7 }
            }), new Comparer(0.01));
        }

        [TestMethod]
        public void TestMaxArray()
        {
            CollectionAssert.AreEqual(new int[] { 3, 5, 9, 8, 7 }, MultiDimensionArray.MaxArray(new int[,] {
                { 1, 2, 3 },
                { 3, 4, 5 },
                { 7, 8, 9 },
                { 8, 7, 2 },
                { 7, 7, 7 }
            }));
        }

        [TestMethod]
        public void TestAverageTwoDimension()
        {
            CollectionAssert.AreEqual(new double[,]
            {
                { 2, 4, 5 },
                { 5, 9, 6 },
                { 5, 6, 9 }
            }, MultiDimensionArray.AverageTwoDimension(new int[,,] {
                { { 1, 2, 3 }, { 3, 4, 5 }, { 4, 5, 6 } },
                { { 10, 5, 0 }, { 10, 9, 8 }, { 10, 4, 4 } },
                { { 5, 5, 5 }, { 0, 9, 9 }, { 9, 9, 9} }
            }), new Comparer(0.01));
        }
    }
}
