using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _10_ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        static void Main()
        {
            string inputFilePath = "../../input.txt";
            string outputFIlePath = "../../output.txt";
            bool appendMode = true;
            Encoding enc = Encoding.UTF8;

            using (StreamReader reader = new StreamReader(inputFilePath, enc))
            {
                using (StreamWriter writer = new StreamWriter(outputFIlePath, appendMode, enc))
                {
                    try
                    {
                        writer.AutoFlush = true;
                        int linesCounter = 1;

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            Regex rx = new Regex(@"<.*?>");

                            string[] splitArr = rx.Replace(line, Environment.NewLine).Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                            line = string.Join(" ", splitArr);
                            writer.WriteLine(line);
                            linesCounter++;
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