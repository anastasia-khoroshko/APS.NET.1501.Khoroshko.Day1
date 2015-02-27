using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestSortArray
{
    [TestClass]
    public class TestSort
    {
        [TestMethod]
        public void TestSortBySumIncrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[0] = new int[] { 2, 11, 0, -4 };
            b[1] = new int[] { 1, 2, 9 };
            b[2] = new int[] { 20, 6, 12, -5, 7 };
            Assert.ReferenceEquals(SortArray.MethodsSortArray.IncreaseSort(a, new SortArray.MethodsSortArray.ComparisonArray(SortArray.MethodsSortArray.CompareSum)), b);
        }
        [TestMethod]
        public void TestSortBySumDecrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[2] = new int[] { 2, 11, 0, -4 };
            b[1] = new int[] { 1, 2, 9 };
            b[0] = new int[] { 20, 6, 12, -5, 7 };
            Assert.ReferenceEquals(SortArray.MethodsSortArray.IncreaseSort(a, new SortArray.MethodsSortArray.ComparisonArray(SortArray.MethodsSortArray.CompareSum)), b);
        }

        [TestMethod]
        public void TestSortByMaxElemIncrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[0] = new int[] { 1, 2, 9 };
            b[1] = new int[] { 2, 11, 0, -4 };            
            b[2] = new int[] { 20, 6, 12, -5, 7 };
            Assert.ReferenceEquals(SortArray.MethodsSortArray.IncreaseSort(a, new SortArray.MethodsSortArray.ComparisonArray(SortArray.MethodsSortArray.CompareMaxElement)), b);
        }

        [TestMethod]
        public void TestSortByMaxElemDecrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[2] = new int[] { 1, 2, 9 };
            b[1] = new int[] { 2, 11, 0, -4 };
            b[0] = new int[] { 20, 6, 12, -5, 7 };
            Assert.ReferenceEquals(SortArray.MethodsSortArray.DecreaseSort(a, new SortArray.MethodsSortArray.ComparisonArray(SortArray.MethodsSortArray.CompareMaxElement)), b);
        }

        [TestMethod]
        public void TestSortByMinElemIncrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[2] = new int[] { 1, 2, 9 };
            b[1] = new int[] { 2, 11, 0, -4 };
            b[0] = new int[] { 20, 6, 12, -5, 7 };
            Assert.ReferenceEquals(SortArray.MethodsSortArray.IncreaseSort(a, new SortArray.MethodsSortArray.ComparisonArray(SortArray.MethodsSortArray.CompareMinElement)), b);
        }

        [TestMethod]
        public void TestSortByMinElemDecrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[0] = new int[] { 1, 2, 9 };
            b[1] = new int[] { 2, 11, 0, -4 };
            b[2] = new int[] { 20, 6, 12, -5, 7 };
            Assert.ReferenceEquals(SortArray.MethodsSortArray.DecreaseSort(a, new SortArray.MethodsSortArray.ComparisonArray(SortArray.MethodsSortArray.CompareMinElement)), b);
        }
    }
}
