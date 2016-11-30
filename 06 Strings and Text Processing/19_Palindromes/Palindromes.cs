using System;
using System.Collections.Generic;
using System.Linq;

namespace _19_Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string input = "Marvelous! Your reservation is now confirmed. You booked a double room for 3 days. Your arrival date is 24.12.2016 and you leave our premises on 27.12.2016. On Crhistmas eve (25.12.2016) a programme with a DJ and dinner is ABBA, lamal, exe included. With this reservation you are granted one free weekend stay at our hotel, for two persons, valid between 15.01.2017 and 30.03.2017. thank you for choosing us!";

            var palindromes = ExtractPalindromes(input);

            foreach (var palindrome in palindromes)
            {
                Console.WriteLine(palindrome);
            }
        }

        private static List<string> ExtractPalindromes(string text)
        {
            var palindromes = new List<string>();
            var splitChars = PrepareSplitChars(text);
            var splitText = text.Split(splitChars.Distinct().ToArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in splitText)
            {
                if (IsPalindrom(word))
                {
                    palindromes.Add(word);
                }
            }

            return palindromes;
        }

        private static bool IsPalindrom(string word)
        {
            if (word.Length == 1)
                return false;

            var isSymmetric = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isSymmetric = false;
                    break;
                }
            }

            return isSymmetric;
        }

        private static List<char> PrepareSplitChars(string text)
        {
            var splitChars = new List<char>();

            foreach (var symbol in text)
            {
                if (!char.IsLetter(symbol))
                {
                    splitChars.Add(symbol);
                }
            }

            return splitChars;
        }
    }
}
