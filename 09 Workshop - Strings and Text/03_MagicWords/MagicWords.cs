using System;
using System.Collections.Generic;
using System.Text;

namespace _03_MagicWords
{
    class MagicWords
    {
        static void Main()
        {
            int wordsCount = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            for (int i = 0; i < wordsCount; i++)
            {
                words.Add(Console.ReadLine());
            }            

            Reorder(words, wordsCount);

            Console.WriteLine(Print(words));
        }

        static void Reorder(List<string> wordsList, int count)
        {
            for (int i = 0; i < wordsList.Count; i++)
            {
                string temp = wordsList[i];
                int moveAtIndex = wordsList[i].Length % (count + 1);

                wordsList.Insert(moveAtIndex, temp);

                wordsList.RemoveAt(i > moveAtIndex ? i + 1 : i);
            }
        }

        private static int GetMaxWordLenght(List<string> words)
        {
            int max = 0;
            foreach (var word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                }
            }

            return max;
        }

        static string Print(List<string> words)
        {
            StringBuilder printSequence = new StringBuilder();

            int len = GetMaxWordLenght(words);

            for (int i = 0; i < len; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        printSequence.Append(word[i]);
                    }
                }
            }

            return printSequence.ToString();
        }
    }
}
