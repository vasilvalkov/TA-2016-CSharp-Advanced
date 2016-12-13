using System.IO;
using System.Text;

namespace _07_ReplaceSubstring
{
    class ReplaceSubstring
    {
        static void Main()
        {
            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";
            bool append = false;
            Encoding enc = Encoding.UTF8;

            using (StreamReader reader = new StreamReader(inputFilePath, enc))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath, append, enc))
                {
                    try
                    {
                        writer.AutoFlush = true;

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            writer.WriteLine(line.Replace("start", "finish"));
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