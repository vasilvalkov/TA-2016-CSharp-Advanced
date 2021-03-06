﻿using System;
using System.IO;
using System.Text;

namespace _02_ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            string file1path = Console.ReadLine().Trim('"');
            string file2path = Console.ReadLine().Trim('"');

            using (var writer = new StreamWriter("../../Concatenated.txt", true, Encoding.UTF8))
            {
                writer.AutoFlush = true;

                using (var reader1 = new StreamReader(file1path, Encoding.UTF8))
                {
                    while (reader1.EndOfStream == false)
                    {
                        writer.WriteLine(reader1.ReadLine());
                    } 
                }
                
                using (var reader2 = new StreamReader(file2path, Encoding.UTF8))
                {
                    while (reader2.EndOfStream == false)
                    {
                        writer.WriteLine(reader2.ReadLine());
                    } 
                }
            }
        }
    }
}
