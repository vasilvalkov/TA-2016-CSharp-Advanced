using System;
using System.Linq;

class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
            return firstNumber;
        else
            return secondNumber;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        int[] inputArr = input.Split(' ').Select(int.Parse).ToArray();
        int max = int.MinValue;

        for (int i = 0; i < inputArr.Length - 1; i++)
        {
            int currentMax = GetMax(inputArr[i], inputArr[i + 1]);

            if (max < currentMax)
            {
                max = currentMax;
            }
        }

        Console.WriteLine(max);
    }
}