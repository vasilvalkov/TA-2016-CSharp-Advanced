using System;
using System.Linq;

class AppearanceCount
{
    static int TimesAppear(int[] numbers, int target)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        string arrNumbers = Console.ReadLine();
        int[] arr = arrNumbers.Split(' ').Select(int.Parse).ToArray();
        int target = int.Parse(Console.ReadLine());

        Console.WriteLine(TimesAppear(arr, target));
    }
}