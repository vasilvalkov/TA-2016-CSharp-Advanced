using System;

namespace _01_LeapYear
{
    public class Year
    {
        public static string IsLeap(int inputYear)
        {
            return DateTime.IsLeapYear(inputYear) ? "Leap" : "Common";
        }
    }

    class LeadpYear
    {
        static void Main()
        {
            Console.WriteLine(Year.IsLeap(int.Parse(Console.ReadLine())));
        }
    }
}
