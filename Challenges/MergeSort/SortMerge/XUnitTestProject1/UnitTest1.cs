using System;
using Xunit;
using static SortMerge.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestHappyPathToSortArray()
        {
            int[] testArr = new int[] { 8, 4, 23, 42, 16, 15 };

            Assert.Equal("4,8,15,16,23,42", String.Join(',', MergeSort(testArr)));
        }
        [Fact]
        public void TestSortExpectedFailure()
        {
            int[] testArr = new int[] { 5, 12, 7, 5, 5, 7 };

            Assert.NotEqual("5,12,7,5,5,7", String.Join(',', MergeSort(testArr)));
        }
        [Fact]
        public void TestEmptyArray()
        {
            int[] testArr = new int[6];

            Assert.Equal("0,0,0,0,0,0", String.Join(',', MergeSort(testArr)));
        }
    }
}
