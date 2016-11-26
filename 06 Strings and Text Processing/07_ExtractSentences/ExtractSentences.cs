using System;
using System.Text;

namespace _07_ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string sentences = Extract(word, text);

            Console.WriteLine(sentences);
        }

        /// <summary>
        /// Extracts sentences which contain given word and returns them in a new text
        /// </summary>
        /// <param name="word"></param>
        /// <param name="text"></param>
        /// <returns>new string containing only the sentences with the word</returns>
        private static string Extract(string word, string text)
        {

            char[] splitChars = { ' ' };
            string[] splitText = text.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder extractedText = new StringBuilder();
            int index = 0;

            for (int i = 0; i < splitText.Length; i++)
            {
                if (string.Equals(splitText[i], word, StringComparison.OrdinalIgnoreCase))
                {
                    do
                    {
                        extractedText.Append(splitText[index]);
                        extractedText.Append(' ');
                        index++;
                    }
                    while (splitText[index] != ".");
                }
            }

            return extractedText.ToString();
        }
    }
}
