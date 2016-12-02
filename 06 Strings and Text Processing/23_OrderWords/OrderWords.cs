using System;

namespace _23_OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            string input = "marvelous your reservation is now confirmed you booked a double room for days your arrival date is and you leave our premises on Crhistmas eve a programme with and dinner is lamal exe included with this Reservation you are granted one free weekend stay at our hotel for two persons valid between and thank you for choosing us";

            string sortedInput = SortWords(input);

            Console.WriteLine(sortedInput);
        }
        private static string SortWords(string text)
        {
            var splits = text.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(splits);

            return string.Join(" ", splits);
        }
    }
}
