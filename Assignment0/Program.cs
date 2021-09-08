using System;

namespace Assignment0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year) {
            return year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
        }
    }
}
