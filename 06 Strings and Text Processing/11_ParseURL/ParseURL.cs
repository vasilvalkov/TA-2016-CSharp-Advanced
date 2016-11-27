using System;
using System.Text;

namespace _11_ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            string url = Console.ReadLine();
            Console.WriteLine(Parse(url));
        }

        private static string Parse(string url)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[protocol] = ");
            sb.Append(url, 0, url.IndexOf(':'));

            sb.AppendLine();
            sb.Append("[server] = ");
            sb.Append(url,
                      url.IndexOf('/') + 2,
                      url.IndexOf('/', url.IndexOf('.')) - (url.IndexOf('/') + 2));

            sb.AppendLine();
            sb.Append("[resource] = ");
            sb.Append(url,
                      url.IndexOf('/', url.IndexOf('.')),
                      url.Length - url.IndexOf('/', url.IndexOf('.')));

            return sb.ToString();
        }
    }
}
