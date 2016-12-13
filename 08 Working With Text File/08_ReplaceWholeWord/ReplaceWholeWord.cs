using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _08_ReplaceWholeWord
{
    class ReplaceWholeWord
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
                        Regex regexLower = new Regex(@"(?=start)\b\w+");
                        Regex regexUpper = new Regex(@"(?=Start)\b\w+");

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (regexLower.IsMatch(line))
                            {
                                line = regexLower.Replace(line, "finish");
                            }
                            if (regexUpper.IsMatch(line))
                            {
                                line = regexUpper.Replace(line, "Finish");
                            }

                            writer.WriteLine(line);
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