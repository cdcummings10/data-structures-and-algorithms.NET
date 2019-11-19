using System;
using Xunit;
using static InsertionSort.Program;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestHappyPathForSorting()
        {
            int[] arr = new int[] { 20, 18, 12, 8, 5, -2 };

            Assert.Equal("-2,5,8,12,18,20", String.Join(',', InsertionSorter(arr)));
        }
        [Fact]
        public void TestArrayGetsSortedNotEqual()
        {
            int[] arr = new int[] { 5, 12, 7, 5, 5, 7 };

            Assert.NotEqual("5,12,7,5,5,7", String.Join(',', InsertionSorter(arr)));
        }
        [Fact]
        public void TestIfArrayIsEmpty()
        {
            int[] arr = new int[6];

            Assert.Equal("0,0,0,0,0,0",String.Join(',', InsertionSorter(arr)));
        }
    }
}
