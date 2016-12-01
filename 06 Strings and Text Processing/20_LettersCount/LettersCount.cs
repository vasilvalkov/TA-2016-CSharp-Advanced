using System;
using System.Collections.Generic;
using System.Linq;

namespace _20_LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            string input = "Your reservation is now confirmed.";

            string[,] lettersAppearance = CountLetters(input);

            PrintLetters(lettersAppearance);
        }

        private static void PrintLetters(string[,] lettersAppearance)
        {
            for (int row = 0; row < lettersAppearance.GetLength(0); row++)
            {
                for (int col = 0; col < lettersAppearance.GetLength(1); col++)
                {
                    Console.Write(col == 0 ? string.Format("{0} is used ", lettersAppearance[row, col]) 
                                           : string.Format("{0} times", lettersAppearance[row, col]));
                }

                Console.WriteLine();
            }
        }
        private static char[] DistinctLetters(string text)
        {
            var splitLetters = new List<char>();

            foreach (var symbol in text)
            {
                if (char.IsLetter(symbol))
                {
                    splitLetters.Add(symbol);
                }
            }

            return splitLetters.Distinct().ToArray();
        }
        private static string[,] CountLetters(string text)
        {
            var letters = DistinctLetters(text);             // Find all letters appearing in the text
            var counts = new int[letters.Length];            // Initialize letter counts

            Array.Sort(letters);

            foreach (var symbol in text)                     // Populate letter counts
            {   
                if (char.IsLetter(symbol))
                {
                    counts[Array.IndexOf(letters, symbol)]++;
                }
            }

            var result = new string[letters.Length, 2];      // Initialize output array

            for (int row = 0; row < counts.Length; row++)    // Populate output array to return
            {
                result[row, 0] = letters[row].ToString();
                result[row, 1] = counts[row].ToString();
            }

            return result;
        }
    }
}
