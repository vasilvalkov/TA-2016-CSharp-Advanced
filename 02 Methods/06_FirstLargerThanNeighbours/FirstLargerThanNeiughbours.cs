using System;
using System.Linq;

class FirstLargerThanNeiughbours
{
    static int FirstLargerThanNeighbors(int[] numbers)
    {
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]))
            {
                return i;
            }
        }

        return -1;
    }

    static void Main()
    {
        int elemCount = int.Parse(Console.ReadLine());
        string inputArr = Console.ReadLine();
        int[] arr = inputArr.Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(FirstLargerThanNeighbors(arr));
    }
}