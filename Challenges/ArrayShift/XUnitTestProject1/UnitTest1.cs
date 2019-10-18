using System;
using Xunit;
using static ArrayShift.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8 }, 5, new int[] { 2, 4, 5, 6, 8 })]
        [InlineData(new int[] { 4, 8, 15, 23, 42 }, 16, new int[] { 4, 8, 15, 16, 23, 42 })]
        public void Challenge2TestIfCorrectOutputOfArrayWithInsertedValue(int[] arr, int num, int[] answer)
        {
            Assert.Equal(answer, InsertShiftArray(arr, num));
        }

        [Fact]
        public void Challenge2TestCorrectOutputIfArrayIsEmpty()
        {
            int[] param = new int[0];
            int[] answer = new int[] { 3 };
            Assert.Equal(answer, InsertShiftArray(param, 3));
        }

        [Fact]
        public void Challenge2TestIncorrectOutput()
        {
            int[] param = new int[] { 2, 15, 17, 90, 223, 1 };
            int[] answer = new int[] { 2, 15, 17, 90, 223, 1, 3 };
            Assert.NotEqual(answer, InsertShiftArray(param, 3));
        }
    }
}
