using System;
using System.Text;

namespace _22_SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(RemoveDuplicates(input));
        }

        private static string RemoveDuplicates(string input)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder noDups = new StringBuilder();

            sb.Append(input);

            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] == sb[i + 1])
                    continue;

                noDups.Append(sb[i]);
            }
            if (noDups[noDups.Length - 1] != sb[sb.Length - 1])
            {
                noDups.Append(sb[sb.Length - 1]);
            }
            return noDups.ToString();
        }
    }
}
