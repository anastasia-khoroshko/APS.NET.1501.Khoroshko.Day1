using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SortArray;

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
            MethodsSortArray.Sort(a, new MethodsSortArray.ComparisonArray((x,y) => x.Sum().CompareTo(y.Sum())));
            Assert.ReferenceEquals(a, b);
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
            MethodsSortArray.Sort(a, new MethodsSortArray.ComparisonArray((x,y) => y.Sum().CompareTo(x.Sum())));
            Assert.ReferenceEquals(a, b);
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
            MethodsSortArray.Sort(a, new MethodsSortArray.ComparisonArray(
                (x,y) => Math.Abs(x.Max()).CompareTo(Math.Abs(y.Max()))));
            Assert.ReferenceEquals(a, b);
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
            MethodsSortArray.Sort(a, new MethodsSortArray.ComparisonArray(
                (x,y) => Math.Abs(y.Max()).CompareTo(Math.Abs(x.Max()))));
            Assert.ReferenceEquals(a, b);
        }

        [TestMethod]
        public void TestSortByLengthIncrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[2] = new int[] { 1, 2, 9 };
            b[1] = new int[] { 2, 11, 0, -4 };
            b[0] = new int[] { 20, 6, 12, -5, 7 };
            MethodsSortArray.Sort(a, new MethodsSortArray.ComparisonArray((x,y) => x.Length.CompareTo(y.Length)));
            Assert.ReferenceEquals(a, b);
        }

        [TestMethod]
        public void TestSortByLengthDecrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[0] = new int[] { 1, 2, 9 };
            b[1] = new int[] { 2, 11, 0, -4 };
            b[2] = new int[] { 20, 6, 12, -5, 7 };
            MethodsSortArray.Sort(a, new MethodsSortArray.ComparisonArray((x,y) => y.Length.CompareTo(x.Length)));
            Assert.ReferenceEquals(a, b);
        }
    }
}
