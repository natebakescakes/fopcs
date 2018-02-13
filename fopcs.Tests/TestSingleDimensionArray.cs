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
                326, 34, 23, 7, 7, 5, 4, 3, 2, 1, 1
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
