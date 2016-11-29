using System;
using System.Text;

namespace _14_ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(MarkdownParse(input));
        }

        private static string MarkdownParse(string input)
        {
            //string parsedHTML = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
            StringBuilder parsedText = new StringBuilder();
            parsedText.Append(input);
            string aTagOpen = "<a href=\"";
            string aTagClose = "</a>";
            string urlTagClose = "\">";

            int startAnchor = input.IndexOf(aTagOpen);
            int endAnchor = input.IndexOf(aTagClose);
            int endUrl = input.IndexOf(urlTagClose);

            while (endUrl > startAnchor + aTagOpen.Length)
            {
                if (input.IndexOf(aTagOpen) < 0 ||
                    input.IndexOf(urlTagClose) < 0 ||
                    input.IndexOf(aTagClose) < 0)
                    break;

                string url = url = input.Substring(startAnchor + aTagOpen.Length, endUrl - (startAnchor + aTagOpen.Length));
                string text = input.Substring(endUrl + urlTagClose.Length, endAnchor - (endUrl + urlTagClose.Length));

                parsedText.Remove(startAnchor, (endAnchor + aTagClose.Length) - startAnchor);
                parsedText.Insert(startAnchor, string.Format("[{0}]({1})", text, url));

                input = parsedText.ToString();
            }

            return parsedText.ToString();
        }
    }
}