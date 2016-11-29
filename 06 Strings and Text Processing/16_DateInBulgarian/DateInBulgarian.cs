using System;
using System.Globalization;
using System.Threading;

namespace _16_DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");

            DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy HH:mm:ss", CultureInfo.CurrentCulture);

            DateTime amendedDate = inputDate.AddHours(6).AddMinutes(30);

            Console.WriteLine("{0:dddd dd.MM.yyyy HH:mm:ss}", amendedDate);
        }
    }
}
