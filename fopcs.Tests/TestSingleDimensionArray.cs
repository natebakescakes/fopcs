using System;
using AdditionalExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fopcs.Tests
{
    [TestClass]
    public class TestSingleDimensionArray
    {
        [TestMethod]
        public void TestIndexSearch()
        {
            Assert.AreEqual(0, SingleDimensionArray.IndexSearch(1, new int[] {
                1, 5, 3, 326, 23, 7, 34, 1, 2, 4, 7
            }));
            Assert.AreEqual(1, SingleDimensionArray.IndexSearch(5, new int[]
            {
                1, 5, 3, 326, 23, 7, 34, 1, 2, 4, 7
            }));
        }

        [TestMethod]
        public void TestSortArray()
        {
            CollectionAssert.AreEqual(new int[]
            {
                1, 1, 2, 3, 4, 5, 7, 7, 23, 34, 326
            }, SingleDimensionArray.SortArray(new int[] {
                1, 5, 3, 326, 23, 7, 34, 1, 2, 4, 7
            }));
        }

        [TestMethod]
        public void TestBinarySearch()
        {
            Assert.AreEqual(0, SingleDimensionArray.IndexSearch(1, new int[] {
                1, 5, 3, 326, 23, 7, 34, 1, 2, 4, 7
            }));
            Assert.AreEqual(1, SingleDimensionArray.IndexSearch(5, new int[]
            {
                1, 5, 3, 326, 23, 7, 34, 1, 2, 4, 7
            }));
        }
    }
}
