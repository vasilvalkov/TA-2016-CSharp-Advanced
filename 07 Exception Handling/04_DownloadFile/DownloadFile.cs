using System;
using System.Net;

namespace _04_DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string fileName = path.Substring(path.LastIndexOf('/') + 1);

            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(path, fileName);
                }
                catch
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }
    }
}