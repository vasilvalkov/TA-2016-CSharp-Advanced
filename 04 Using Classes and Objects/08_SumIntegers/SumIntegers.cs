using System;
using System.Linq;

namespace _09_SumIntegers
{
    class SumIntegers
    {
        static int PrepareInput(string input)
        {
            int intSum = input.Split(' ')
                              .Select(int.Parse)
                              .ToArray()
                              .Sum();

            return intSum;
        }

        static void Main()
        {
            Console.WriteLine(PrepareInput(Console.ReadLine()));
        }
    }
}
