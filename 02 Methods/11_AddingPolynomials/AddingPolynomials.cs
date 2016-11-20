using System;
using System.Collections.Generic;
using System.Linq;

class AddingPolynomials
{
    static List<int> SumArrays(int[] firstArray, int[] secondArray)
    {
        List<int> summed = new List<int>();

        for (int i = 0; i < firstArray.Length; i++)
        {
            int sum = firstArray[i] + secondArray[i];
            summed.Add(sum);
        }

        summed.TrimExcess();

        return summed;
    }

    static void Main()
    {
        string arrSizes = Console.ReadLine();
        string firstInputArr = Console.ReadLine();
        string secondInputArr = Console.ReadLine();
        int[] firstArr = firstInputArr.Split(' ').Select(int.Parse).ToArray();
        int[] secondArr = secondInputArr.Split(' ').Select(int.Parse).ToArray();

        foreach (var sum in SumArrays(firstArr, secondArr))
        {
            Console.Write("{0} ", sum);
        }
    }
}