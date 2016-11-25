using System;
using System.Globalization;

namespace _07_Workdays
{
    class Workdays
    {
        static DateTime[] Holidays =
        {
            new DateTime(2016, 12, 24),
            new DateTime(2016, 12, 25),
            new DateTime(2016, 12, 26),
            new DateTime(2016, 12, 31),
            new DateTime(2017, 1, 1),
            new DateTime(2017, 1, 2),
            new DateTime(2017, 3, 3)
        };

        static bool IsHoliday(DateTime[] dates, DateTime day)
        {
            bool isHoliday = false;
            foreach (var date in dates)
            {
                if (date == day)
                {
                    isHoliday = true;
                }
            }

            return isHoliday;
        }
        static int CountWorkdaysTo(DateTime date)
        {
            int days = 0;

            for (DateTime i = DateTime.Today; i <= date; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && 
                    i.DayOfWeek != DayOfWeek.Sunday && 
                    IsHoliday(Holidays,i))
                {
                    days++;
                }
            }

            return days;
        }
        static void Main()
        {
            DateTime input = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(CountWorkdaysTo(input));
        }
    }
}
