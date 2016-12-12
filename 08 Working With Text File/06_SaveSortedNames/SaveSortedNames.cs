using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _06_SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main()
        {
            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";
            bool append = false;
            Encoding enc = Encoding.UTF8;
            List<string> names = new List<string>();

            using (StreamReader reader = new StreamReader(inputFilePath, enc))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath, append, enc))
                {
                    try
                    {
                        while (!reader.EndOfStream)
                        {
                            names.Add(reader.ReadLine());
                        }

                        names.Sort();
                        writer.AutoFlush = true;

                        foreach (var name in names)
                        {
                            writer.WriteLine(name);
                        }
                    }
                    finally
                    {
                        writer.Close();
                        reader.Close();
                    }
                }
            }
        }
    }
}