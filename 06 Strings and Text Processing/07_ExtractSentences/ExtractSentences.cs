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

        private static string Extract(string word, string text)
        {
            char[] splitChars = { '.' };
            string[] splitText = text.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder extractedText = new StringBuilder();

            foreach (var sentence in splitText)
            {
                StringBuilder nonLetters = new StringBuilder();

                foreach (var _char in sentence)
                {   // Find non-letter characters in the sentence
                    if (!char.IsLetter(_char))
                    {
                        nonLetters.Append(_char);
                    }
                }
                char[] splitBy = nonLetters.ToString().ToCharArray();
                // Split sentence into word by all non-letter characters
                string[] splitSentence = sentence.Split(splitBy, StringSplitOptions.RemoveEmptyEntries);
                // Check if searched word matches any split-word in the sentence
                if (Array.IndexOf(splitSentence, word) > -1)
                {   // Match found
                    extractedText.Append(sentence.Trim());
                    extractedText.Append(". ");
                }
            }

            return extractedText.ToString();
        }
    }
}
