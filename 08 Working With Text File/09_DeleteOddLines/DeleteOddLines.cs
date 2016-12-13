using System.IO;
using System.Text;

namespace _09_DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main()
        {
            string inputFilePath = "../../input.txt";
            string tempFIlepath = "../../temp.txt";
            bool appendMode = true;
            Encoding enc = Encoding.UTF8;

            using (StreamReader reader = new StreamReader(inputFilePath, enc))
            {
                using (StreamWriter writer = new StreamWriter(tempFIlepath, appendMode, enc))
                {
                    try
                    {
                        writer.AutoFlush = true;
                        int linesCounter = 1;

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();

                            if (linesCounter % 2 == 0)
                            {
                                writer.WriteLine(line);
                            }
                            linesCounter++;
                        }

                        reader.Close();
                        File.Copy(tempFIlepath, inputFilePath, true);
                    }
                    finally
                    {
                        writer.Close();
                        reader.Close();
                        File.Delete(tempFIlepath);
                    }
                }
            }
        }
    }
}
