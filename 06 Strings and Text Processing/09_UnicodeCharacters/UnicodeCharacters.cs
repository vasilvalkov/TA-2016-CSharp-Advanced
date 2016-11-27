using System;
using System.Text;

namespace _09_UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(ToUnicode(input));
        }

        private static string ToUnicode(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                sb.AppendFormat("{0}{1:X4}", "\\u", (int)text[i]);
            }

            return sb.ToString();
        }
    }
}
