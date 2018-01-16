using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingHomework;

namespace Tests
{
    [TestClass]
    public class LinearSearchTests
    {
        [TestMethod]
        public void IntLinearSearch_Found()
        {
            SortableCollection<int> intCollection = new SortableCollection<int>(new int[] { 1, 4, 7, 2, 24, 213456, 234 });

            Assert.AreEqual(intCollection.LinearSearch(7), true);
        }

        [TestMethod]
        public void StringLinearSearch_Found()
        {
            SortableCollection<string> stringCollection = new SortableCollection<string>(new string[] { "go6o", "ivan", "Dimitar", "Petkan", "StaMat", "Mitko" });

            Assert.IsTrue(stringCollection.LinearSearch("StaMat"));
        }

        [TestMethod]
        public void IntLinearSearch_NotFound()
        {
            SortableCollection<int> intCollection = new SortableCollection<int>(new int[] { 1, 4, 7, 2, 24, 213456, 234 });

            Assert.AreNotEqual(intCollection.LinearSearch(4), false);
        }

        [TestMethod]
        public void StringLinearSearch_NotFound()
        {
            SortableCollection<string> stringCollection = new SortableCollection<string>(new string[] { "dragan", "dimitri4ka", "pe6o", "mar4o" });

            Assert.IsFalse(stringCollection.LinearSearch("telerik"));
        }
    }
}
