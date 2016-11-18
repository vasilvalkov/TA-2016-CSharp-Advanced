using System;
using System.Collections.Generic;
using System.Linq;

class NumberAsArray
{
    static List<int> SumArrays(int[] firstArray, int[] secondArray)
    {
        int smallerLen = firstArray.Length < secondArray.Length ? firstArray.Length : secondArray.Length;

        int greaterLen = firstArray.Length > secondArray.Length ? firstArray.Length : secondArray.Length;

        int[] shorterArr = firstArray.Length < secondArray.Length ? firstArray : secondArray;

        int[] longerArr = firstArray.Length > secondArray.Length ? firstArray : secondArray;

        List<int> summed = new List<int>();
        int sum = 0;

        for (int i = 0; i < greaterLen; i++)
        {
            if (i < smallerLen)
            {
                sum += shorterArr[i] + longerArr[i];                
            }
            else
            {
                sum += longerArr[i];
            }
            if (sum < 10)
            {
                summed.Add(sum);
                sum = 0;
            }
            else
            {
                summed.Add(sum % 10);
                sum = 1;
            }
        }
        
        if (sum == 1)
        {
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