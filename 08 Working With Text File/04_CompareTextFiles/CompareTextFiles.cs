using System;
using System.IO;
using System.Text;

namespace _04_CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main()
        {
            string file1path = "../../TestFile1.txt";
            string file2path = "../../TestFile2.txt";
            Encoding enc = Encoding.UTF8;
            int sameLinesCount = 0;
            int differentLinesCount = 0;

            using (var reader1 = new StreamReader(file1path, enc))
            {
                using (var reader2 = new StreamReader(file2path, enc))
                {
                    try
                    {
                        while (!reader1.EndOfStream)
                        {
                            string file1Line = reader1.ReadLine();
                            string file2Line = reader2.ReadLine();

                            if (file1Line == file2Line)
                            {
                                sameLinesCount++;
                            }
                            else
                            {
                                differentLinesCount++;
                            }
                        }
                    }
                    finally
                    {
                        reader1.Close();
                        reader2.Close();
                    }
                }
            }

            Console.WriteLine("There are {0} identical and {1} different lines", sameLinesCount, differentLinesCount);
        }
    }
}