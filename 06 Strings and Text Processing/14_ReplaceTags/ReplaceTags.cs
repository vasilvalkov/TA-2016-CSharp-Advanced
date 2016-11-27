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
            StringBuilder sb = new StringBuilder();            
            sb.Append(input);

            while (true)
            {
                if (input.IndexOf("<a href=") < 0 ||
                    input.IndexOf("\">") < 0 ||
                    input.IndexOf("</a>") < 0)
                    break;

                string url = input.Substring(input.IndexOf("<a href=") + 9,
                                             input.IndexOf("\">") - 1 - (input.IndexOf("<a href=") + 8));

                string text = input.Substring(input.IndexOf("\">") + 2,
                                              input.IndexOf("</a>") - (input.IndexOf("\">") + 2));

                int startIndex = input.IndexOf("<a href=\"");

                int endIndex = input.IndexOf("</a>") + 4;

                sb.Remove(startIndex, endIndex - startIndex);
                sb.Insert(startIndex, string.Format("[{0}]({1})", text, url));

                input = sb.ToString();
            }

            return sb.ToString();
        }
    }
}