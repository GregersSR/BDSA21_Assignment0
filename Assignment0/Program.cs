using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type in a year to find out whether it's a leap year. Then hit [enter]:");
            var line = Console.ReadLine();
            int year = int.Parse(line.Trim());
            Console.WriteLine(IsLeapYear(year) ? "yay" : "nay");
        }

        public static bool IsLeapYear(int year) {
            return year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
        }
    }
}
