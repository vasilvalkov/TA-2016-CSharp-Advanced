using System;
using System.Globalization;

namespace _15_DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter the first date: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter the second date: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Distance: ");
            Console.WriteLine("{0} days", CalculateDifference(firstDate, secondDate));
        }

        private static int CalculateDifference(DateTime firstDate, DateTime secondDate)
        {
            DateTime greaterDate = firstDate > secondDate ? firstDate : secondDate;
            DateTime smallerDate = firstDate < secondDate ? firstDate : secondDate;

            TimeSpan diff = greaterDate - smallerDate;

            return (int)(diff.TotalDays);
        }
    }
}
