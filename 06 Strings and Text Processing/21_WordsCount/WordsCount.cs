using System;
using System.Collections.Generic;
using System.Linq;

namespace _21_WordsCount
{
    class WordsCount
    {
        static void Main()
        {
            string input = "Marvelous! Your reservation is now confirmed. You booked a double room for 3 days. Your arrival date is 24.12.2016 and you leave our premises on 27.12.2016. On Crhistmas eve (25.12.2016) a programme with a DJ and dinner is ABBA, lamal, exe included. With this reservation you are granted one free weekend stay at our hotel, for two persons, valid between 15.01.2017 and 30.03.2017. thank you for choosing us!";

            string[,] wordAppearance = CountWords(input);

            PrintWords(wordAppearance);
        }
        private static void PrintWords(string[,] wordsAppearance)
        {
            for (int row = 0; row < wordsAppearance.GetLength(0); row++)
            {
                for (int col = 0; col < wordsAppearance.GetLength(1); col++)
                {
                    Console.Write(col == 0 ? string.Format("'{0}' is used ", wordsAppearance[row, col])
                                           : string.Format("{0} times", wordsAppearance[row, col]));
                }

                Console.WriteLine();
            }
        }
        private static string[] SeparateWords(string text)
        {
            var splits = new List<char>();


            foreach (var symbol in text)
            {
                if (!char.IsLetter(symbol))
                {
                    splits.Add(symbol);
                }
            }

            char[] splitChars = splits.Distinct().ToArray();

            var splitWords = text.Split(splitChars, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(x => x.ToLower())
                                 .ToArray();

            return splitWords;
        }
        private static string[,] CountWords(string text)
        {
            var words = SeparateWords(text);                    // Find all words appearing in the text
            var distinctWords = words.Distinct().ToArray();
            var counts = new int[distinctWords.Length];         // Initialize letter counts

            Array.Sort(words);

            foreach (var word in words)                         // Populate letter counts
            {
                counts[Array.IndexOf(distinctWords, word)]++;
            }

            var result = new string[distinctWords.Length, 2];           // Initialize output array

            for (int row = 0; row < counts.Length; row++)       // Populate output array to return
            {
                result[row, 0] = distinctWords[row];
                result[row, 1] = counts[row].ToString();
            }

            return result;
        }
    }
}
