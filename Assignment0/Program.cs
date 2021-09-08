using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type in a year to find out whether it's a leap year. Then hit [enter]:");
            var line = Console.ReadLine().Trim();
            var stderr = Console.Error;
            try
            {
                int year = int.Parse(line);
                Console.WriteLine(IsLeapYear(year) ? "yay" : "nay");
            }
            catch (FormatException)
            {
                stderr.WriteLine($"{line} is not a valid year.");
            }
            catch (ArgumentOutOfRangeException e)
            {
                stderr.WriteLine($"{line} is not a valid year. {e.ParamName}");
            }
            
        }

        public static bool IsLeapYear(int year) {
            if (year < 1582) {
                throw new ArgumentOutOfRangeException($"Year {year} is out of range. Years must not be before 1582.");
            }
            return year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
        }
    }
}
