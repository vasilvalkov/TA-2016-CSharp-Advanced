using System;

namespace _08_ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP CLR Microsoft";

            Console.WriteLine(Consor(text, words));
        }

        private static string Consor(string text, string words)
        {
            string[] splitWords = words.Split(' ');

            foreach (var word in splitWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            return text;
        }
    }
}
