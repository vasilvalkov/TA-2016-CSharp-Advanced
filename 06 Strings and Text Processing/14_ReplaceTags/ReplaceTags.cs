using System;
using System.Text;

namespace _14_ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string parsedInput = MarkdownParse(input);
            Console.WriteLine(parsedInput);
        }

        private static string MarkdownParse(string text)
        {
            //string parsedHTML = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
            StringBuilder parsedText = new StringBuilder();
            string aTagOpen = "<a href=\"";
            string aTagClose = "</a>";
            string urlTagClose = "\">";
            int startIndex = 0;

            while (true)
            {
                int startAnchor = text.IndexOf(aTagOpen, startIndex);
                if (startAnchor < 0)
                    break;
                // Append text up to the openning anchor tag
                parsedText.Append(text, startIndex, startAnchor - startIndex);
                // Update position in text
                startIndex = startAnchor + aTagOpen.Length;
                // Get the url
                int endUrl = text.IndexOf(urlTagClose, startIndex);
                string url = text.Substring(startIndex, endUrl - startIndex);
                int endAnchor = text.IndexOf(aTagClose, startIndex);
                // update position in text
                startIndex = endUrl + urlTagClose.Length;
                // Append anchor text and url in md format
                parsedText.Append("[");
                parsedText.Append(text, startIndex, endAnchor - startIndex);
                parsedText.Append("](");
                parsedText.Append(url);
                parsedText.Append(")");
                // Update position in text
                startIndex = endAnchor + aTagClose.Length;
            }

            parsedText.Append(text, startIndex, text.Length - startIndex);

            return parsedText.ToString();
        }
    }
}