using System;
using System.Text;

namespace _04_ParseTags
{
    class ParseTags
    {
        static string openingTag = "<upcase>";
        static string closingTag = "</upcase>";

        static void Main()
        {
            string text = Console.ReadLine();            

            Console.WriteLine(ParseText(text));
        }

        private static string ParseText(string text)
        {
            StringBuilder parsedText = new StringBuilder();
            parsedText.Append(text);

            int index = 0;

            while (0 <= index && index < text.Length)
            {
                int currentOpenIndex = text.IndexOf(openingTag, index);
                int currentCloseIndex = text.IndexOf(closingTag, index);

                if (currentOpenIndex < 0 || index >= text.Length)
                    break;

                for (int i = currentOpenIndex + openingTag.Length; i < currentCloseIndex; i++)
                {
                    parsedText[i] = char.ToUpper(text[i]);
                }
                index = currentCloseIndex + closingTag.Length;
            }

            parsedText = parsedText.Replace(openingTag, string.Empty);
            parsedText = parsedText.Replace(closingTag, string.Empty);
            return parsedText.ToString();
        }
    }
}
