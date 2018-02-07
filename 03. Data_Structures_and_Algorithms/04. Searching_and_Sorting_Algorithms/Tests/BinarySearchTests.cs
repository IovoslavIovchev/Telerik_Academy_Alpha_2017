using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingHomework;

namespace Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void IntBinarySearch_Found()
        {
            SortableCollection<int> testCollection = new SortableCollection<int>(new int[] { 1, 5, 2, 4, 6, 2, 12423 });

            Assert.IsTrue(testCollection.BinarySearch(5));
        }

        [TestMethod]
        public void DecimalBinarySearch_Found()
        {
            SortableCollection<decimal> testCollection = new SortableCollection<decimal>(new decimal[] { 3.14M, 5M, 8.2423M, 3.45M, 0.123M });

            Assert.AreEqual(testCollection.BinarySearch(3.14M), true);
        }

        [TestMethod]
        public void IntBinarySearch_NotFound()
        {
            SortableCollection<int> testCollection = new SortableCollection<int>(new int[] { 1, 5, 2, 4, 6, 2, 12423 });

            Assert.IsTrue(testCollection.BinarySearch(1));
        }

        [TestMethod]
        public void DecimalBinarySearch_NotFound()
        {
            SortableCollection<decimal> testCollection = new SortableCollection<decimal>(new decimal[] { 3.14M, 5M, 8.2423M, 3.45M, 0.123M });

            Assert.AreNotEqual(testCollection.BinarySearch(3.104M), true);
        }
    }
}
