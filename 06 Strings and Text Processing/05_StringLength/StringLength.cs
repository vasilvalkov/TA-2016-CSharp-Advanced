using System;

namespace _05_StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(CheckLength(input));
        }

        static string CheckLength(string text)
        {
            if (text.Length <= 20)
            {
                text = string.Concat(text, new string('*', 20 - text.Length));
            }
            return text;
        }
    }
}
