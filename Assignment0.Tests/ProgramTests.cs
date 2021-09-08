using System;
using System.IO;
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
            Assert.True(Assignment0.Program.IsLeapYear(year));
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
            Assert.False(Assignment0.Program.IsLeapYear(year));
        }

        [Theory()]
        [InlineData(200)]
        [InlineData(1000)]
        [InlineData(1800)]
        [InlineData(3000)]
        public void IsLeapYear_DivisibleBy4And100ButNot400IsFalse(int year)
        {
            Assert.False(Assignment0.Program.IsLeapYear(year));
        }


        [Theory()]
        [InlineData(0)]
        [InlineData(400)]
        [InlineData(1200)]
        [InlineData(2000)]
        [InlineData(2800)]
        public void IsLeapYear_DivisibleBy400IsTrue(int year)
        {
            Assert.True(Assignment0.Program.IsLeapYear(year));
        }

        [Fact]
        public void IsLeapYear_PrintsPrompt()
        {
            var stdout = new StringWriter();
            var stdin = new StringReader("0\n");
            Console.SetOut(stdout);
            Console.SetIn(stdin);
            Program.Main(new string[0]);
            var firstLine = stdout.ToString().Split("\n")[0].Trim();
            Assert.Equal("Please type in a year to find out whether it's a leap year. Then hit [enter]:", 
                        firstLine);

        }

        [Fact]
        public void IsLeapYear_PrintsYayOnTrue()
        {
            var stdout = new StringWriter();
            var stdin = new StringReader("2000\n");
            Console.SetOut(stdout);
            Console.SetIn(stdin);
            Program.Main(new string[0]);
            var lastLine = stdout.ToString().Split("\n")[1].Trim();
            Assert.Equal("yay", 
                        lastLine);

        }


        [Fact]
        public void IsLeapYear_PrintsNayOnFalse()
        {
            var stdout = new StringWriter();
            var stdin = new StringReader("1997\n");
            Console.SetOut(stdout);
            Console.SetIn(stdin);
            Program.Main(new string[0]);
            var lastLine = stdout.ToString().Split("\n")[1].Trim();
            Assert.Equal("nay", 
                        lastLine);

        }
    }
}
