using System;
using System.Collections.Generic;
using System.Globalization;

namespace _07_Workdays
{
    class Workdays
    {
        static int CountWorkdaysTo(DateTime date)
        {
            int days = 0;

            DateTime.Today;

            return days;
        }

        static void Main()
        {
            DateTime input = DateTime.ParseExact(string.Format("{0:dd.MM.yyyy}",Console.ReadLine()), CultureInfo.InvariantCulture);

            Console.WriteLine(CountWorkdaysTo(input));
        }
    }
}
