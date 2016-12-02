using System;

namespace _02_EnterNumbers
{
    class EnterNumbers
    {
        static void ReadNumber(int start, int end)
        {
            string output = "1";
            int compareNumber = start;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (compareNumber < number && number < end)
                    {
                        output += string.Format(" < {0}", number);
                        compareNumber = number;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch
                {
                    Console.WriteLine("Exception");
                    return;
                }
            }

            Console.WriteLine(output + " < 100");
        }

        static void Main()
        {
            ReadNumber(1, 100);
        }
    }
}
