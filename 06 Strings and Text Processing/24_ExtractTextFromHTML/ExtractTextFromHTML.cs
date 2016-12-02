using System;
using System.Text.RegularExpressions;

namespace _24_ExtractTextFromHTML
{
    class Article
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }

    class ExtractTextFromHTML
    {
        static void Main()
        {
            string input = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a> aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

            Article extractedText = ExtractText(input);

            Console.WriteLine("Title: {0}\r\n\r\nText: {1}", extractedText.Title, extractedText.Body);
        }

        private static Article ExtractText(string html)
        {
            Article htmlExtract = new Article();            
            int titleStart = html.IndexOf("<title>");
            int titleEnd = html.IndexOf("</title>");

            if (titleStart != -1)
            {
                htmlExtract.Title = html.Substring(titleStart + 7, titleEnd - (titleStart + 7));
            }
            
            int bodyStart = html.IndexOf("<body>");
            int bodyEnd = html.IndexOf("</body>");

            string body = html.Substring(bodyStart + 6, bodyEnd - (bodyStart + 6));

            htmlExtract.Body = Regex.Replace(body, @"<[^>]+>\s+(?=<)|<[^>]+>", "");

            return htmlExtract;
        }
    }
}
