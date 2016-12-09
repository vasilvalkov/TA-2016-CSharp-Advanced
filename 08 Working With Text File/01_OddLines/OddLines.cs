using System;
using System.IO;
using System.Text;

namespace _01_OddLines
{
    class OddLines
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            using (StreamReader reader = new StreamReader("../../TestFile.txt", Encoding.UTF8))
            {
                string line = reader.ReadLine();
                int i = 1;

                while (line != null)
                {
                    if (i % 2 == 0)
                    {
                        i++;
                        continue;
                    }
                    Console.WriteLine("Line {0}: {1}", i++, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
