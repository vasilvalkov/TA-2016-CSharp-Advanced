using System.IO;
using System.Text;

namespace _03_LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            string readPath = "../../TestFileRead.txt";
            string writePath = "../../TestFileWrite.txt";
            bool shouldAppend = false;
            Encoding utf8 = Encoding.UTF8;

            using (StreamReader reader = new StreamReader(readPath, utf8))
            {
                using (StreamWriter writer = new StreamWriter(writePath, shouldAppend, utf8))
                {
                    writer.AutoFlush = true;
                    int lineNumber = 1;

                    try
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            writer.WriteLine("{0}. {1}", lineNumber, line);
                            lineNumber++;
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
