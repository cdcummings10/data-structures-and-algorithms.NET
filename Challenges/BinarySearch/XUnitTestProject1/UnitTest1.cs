using System;
using Xunit;
using static BinarySearch.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckIfIndexReturnedMatchesValue()
        {
            Assert.Equal(4, BinarySearchMethod(new int[] { 1, 2, 3, 4, 5, 6 }, 5));
        }
        [Fact]
        public void CheckIfIncorrectValueIsReturnedMinusOne()
        {
            Assert.NotEqual(6, BinarySearchMethod(new int[] { 11, 14, 31, 42, 54, 66, 88, 100 }, 31));
        }
        [Fact]
        public void CheckIfReturnsMinusOneIfNullArray()
        {
            Assert.Equal(-1, BinarySearchMethod(new int[] { }, 15));
        }
    }
}
