using Xunit;

namespace Assignment0.Tests
{
    public class ProgramTests
    {
        [Theory()]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(1040)]
        [InlineData(2004)]
        [InlineData(2012)]
        [InlineData(1992)]
        public void IsLeapYear_DivisibleBy4ButNot100IsTrue(int year)
        {
            Assert.True(
                Assignment0.Program.IsLeapYear(year)
            );
        }

        [Theory()]
        [InlineData(1937)]
        [InlineData(2001)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(2002)]
        public void IsLeapYear_NotDivisibleBy4IsFalse(int year)
        {
            Assert.False(
                Assignment0.Program.IsLeapYear(year)
            );
        }

        [Theory()]
        [InlineData(200)]
        [InlineData(1000)]
        [InlineData(1800)]
        [InlineData(3000)]
        public void IsLeapYear_DivisibleBy4And100ButNot400IsFalse(int year)
        {
            Assert.False(
                Assignment0.Program.IsLeapYear(year)
            );
        }


        [Theory()]
        [InlineData(0)]
        [InlineData(400)]
        [InlineData(1200)]
        [InlineData(2000)]
        [InlineData(2800)]
        public void IsLeapYear_DivisibleBy400IsTrue(int year)
        {
            Assert.True(
                Assignment0.Program.IsLeapYear(year)
            );
        }
    }
}
