using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _18_DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main()
        {
            string input = "Marvelous! Your reservation is now confirmed. You booked a double room for 3 days. Your arrival date is 24.12.2016 and you leave our premises on 27.12.2016. On Crhistmas eve (25.12.2016) a programme with a DJ and dinner is included. With this reservation you are granted one free weekend stay at our hotel, for two persons, valid between 15.01.2017 and 30.03.2017. thank you for choosing us!";
            CultureInfo cult = CultureInfo.GetCultureInfo("en-CA");

            List<DateTime> dates = ExtractDates(input, cult);

            PrintTable();

            foreach (var date in dates)
            {
                Console.Write("{0,-18:dd-MM-yyyy}", date);
                Console.Write("{0,-18:yyyy-MM-dd}", date);
                Console.Write("{0,-18:M/dd/yyyy}", date);
                Console.Write("{0,-18:MMM[M] d, yyyy}", date);
                Console.WriteLine();
            }
        }

        private static void PrintTable()
        {
            Console.WriteLine("All main date notation types used in Canada:");
            Console.WriteLine();
            Console.Write("{0,-18}", "Social Insurance");
            Console.Write("{0,-18}", "Passports");
            Console.Write("{0,-18}", "Customs");
            Console.Write("{0,-18}", "Newspapers");
            Console.WriteLine();
        }

        private static List<DateTime> ExtractDates(string text, CultureInfo cult)
        {
            var dates = new List<DateTime>();
            List<char> splitChars = PrepareSplitChars(text);

            string[] splitText = text.Split(splitChars.Distinct().ToArray(), StringSplitOptions.RemoveEmptyEntries);

            splitChars.Add('.');

            foreach (var item in splitText)
            {
                DateTime date = new DateTime();

                if (DateTime.TryParseExact(item.Trim(splitChars.ToArray()), "dd.MM.yyyy", cult, DateTimeStyles.None, out date))
                {
                    dates.Add(date);
                }
            }

            return dates;
        }

        private static List<char> PrepareSplitChars(string text)
        {
            var splitChars = new List<char>();

            foreach (var symbol in text)
            {
                if (!char.IsDigit(symbol) && symbol != '.')
                {
                    splitChars.Add(symbol);
                }
            }

            return splitChars;
        }
    }
}
