using System;
using System.Linq;

class LargerThanNeighbours
{
    static int LargerThanNeigboursCount(int[] numbers)
    {
        int count = 0;

        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]))
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        int elemCount = int.Parse(Console.ReadLine());
        string inputArr = Console.ReadLine();
        int[] arr = inputArr.Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(LargerThanNeigboursCount(arr));
    }
}