using System;
using System.Linq;

namespace _05_EvenDifferences
{
    class EvenDifferences
    {
        static long sum = 0;
        static void Main()
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            EvenSum(numbers);

            Console.WriteLine(sum);
        }
        private static void EvenSum(long[] numbers)
        {
            for (int i = 1; i < numbers.Length;)
            {
                long diff = Math.Abs(numbers[i] - numbers[i - 1]);

                if (diff % 2 == 0)
                {
                    sum += diff;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
