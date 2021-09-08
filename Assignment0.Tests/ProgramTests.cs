using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class ProgramTests
    {
        [Theory()]
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
        [InlineData(2002)]
        public void IsLeapYear_NotDivisibleBy4IsFalse(int year)
        {
            Assert.False(Assignment0.Program.IsLeapYear(year));
        }

        [Theory()]
        [InlineData(2200)]
        [InlineData(1800)]
        [InlineData(3000)]
        public void IsLeapYear_DivisibleBy4And100ButNot400IsFalse(int year)
        {
            Assert.False(Assignment0.Program.IsLeapYear(year));
        }


        [Theory()]
        [InlineData(2000)]
        [InlineData(2800)]
        public void IsLeapYear_DivisibleBy400IsTrue(int year)
        {
            Assert.True(Assignment0.Program.IsLeapYear(year));
        }

        [Fact]
        public void IsLeapYear_ThrowsExceptionOnEarlyYear()
        {
            var stdin = new StringReader("1000\n");
            Console.SetIn(stdin);
            var e = Assert.Throws<ArgumentOutOfRangeException>(() => Program.IsLeapYear(1066));
            Assert.Equal(typeof(ArgumentOutOfRangeException), e.GetType());
            
        }

        [Fact]
        public void Main_PrintsPrompt()
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
        public void Main_PrintsYayOnTrue()
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
        public void Main_PrintsNayOnFalse()
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

        [Fact]
        public void Main_PrintsInvalidYearOnString()
        {
            var stderr = new StringWriter();
            Console.SetError(stderr);
            
            var stdin = new StringReader("1xy9\n");
            Console.SetIn(stdin);
            Program.Main(new string[0]);
            var errorMessage = stderr.ToString().Trim();
            Assert.Equal("1xy9 is not a valid year.", errorMessage);
        }

        [Fact]
        public void Main_PrintsOutOfRangeOnEarlyYear()
        {
            var stderr = new StringWriter();
            Console.SetError(stderr);
            
            var stdin = new StringReader("1407\n");
            Console.SetIn(stdin);
            Program.Main(new string[0]);
            var errorMessage = stderr.ToString().Trim();
            Assert.Equal("1407 is not a valid year. Year 1407 is out of range. Years must not be before 1582.", errorMessage);
        }

        
    }
}
