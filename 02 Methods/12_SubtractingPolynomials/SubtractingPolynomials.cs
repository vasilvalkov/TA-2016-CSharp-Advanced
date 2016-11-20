using System;
using System.Collections.Generic;
using System.Linq;

class SubtractingPolynomials
{
    static List<int> SubtractArrays(int[] firstArray, int[] secondArray)
    {
        List<int> subtracted = new List<int>();

        for (int i = 0; i < firstArray.Length; i++)
        {
            int sub = firstArray[i] - secondArray[i];
            subtracted.Add(sub);
        }

        subtracted.TrimExcess();

        return subtracted;
    }

    static List<int> MultiplyArrays(int[] firstArray, int[] secondArray)
    {
        List<int> multiplied = new List<int>();

        for (int i = 0; i < firstArray.Length; i++)
        {
            int prod = firstArray[i] * secondArray[i];
            multiplied.Add(prod);
        }

        multiplied.TrimExcess();

        return multiplied;
    }

    static void Main()
    {
        string arrSizes = Console.ReadLine();
        string firstInputArr = Console.ReadLine();
        string secondInputArr = Console.ReadLine();
        int[] firstArr = firstInputArr.Split(' ').Select(int.Parse).ToArray();
        int[] secondArr = secondInputArr.Split(' ').Select(int.Parse).ToArray();

        foreach (var sum in SubtractArrays(firstArr, secondArr))
        {
            Console.Write("{0} ", sum);
        }

        foreach (var sum in MultiplyArrays(firstArr, secondArr))
        {
            Console.Write("{0} ", sum);
        }
    }
}