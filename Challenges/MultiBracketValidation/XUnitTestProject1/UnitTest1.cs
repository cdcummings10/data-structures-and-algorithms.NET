using System;
using Xunit;
using static MultiBracketValidator.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestHappyPathOfBracketValidationToReturnTrue()
        {
            Assert.True(MultiBracketValidation("()[[Extra Characters]]"));
        }
        [Fact]
        public void TestIfAFalseCanBeReturned()
        {
            Assert.False(MultiBracketValidation("()[[Extra Characters]"));
        }
        [Fact]
        public void TestEmptyStringReturnsTrue()
        {
            Assert.True(MultiBracketValidation(""));
        }
    }
}
