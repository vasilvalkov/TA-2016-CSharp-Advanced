using System;
using System.Collections.Generic;

namespace _17_ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string text = "In case of any trouoble you can write to us at troubleshooting@risk.com and we will address the issue. If you need help with registration, please contact office@access-cz.net. For all other questions, please refer to info@dot.co.nz. Feel like chatting chat@something.bg.info";
            List<string> emails = Extract(text);

            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }

        private static List<string> Extract(string text)
        {
            List<string> emails = new List<string>();
            int startIndex = 0;

            while (true)
            {
                int atIndex = text.IndexOf('@', startIndex);
                if (atIndex < 0)    // no more e-mails in text
                    break;
                int emailStartIndex = text.LastIndexOf(' ', atIndex);
                int emailLastIndex = text.IndexOf(' ', atIndex) - 1;

                if (emailLastIndex < 0 && text.IndexOf('.', atIndex) >= 0)
                {   // Handle case where end of text == end of e-mail, and . for end of sentence is omitted
                    emailLastIndex = text.Length - 1;
                }
                if (!char.IsLetter(text[emailLastIndex]))
                {   // Handle case where end of sentence == end of e-mail, and . is not part of the e-mail
                    emailLastIndex -= 1;
                }
                // Extract the e-mail
                string email = text.Substring(emailStartIndex + 1, emailLastIndex - emailStartIndex);
                
                emails.Add(email);
                startIndex = emailLastIndex;    // Update start index
            }

            return emails;
        }
    }
}
