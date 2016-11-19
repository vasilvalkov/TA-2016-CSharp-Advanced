using System;
using System.Linq;

class SortingArray
{
    static int ArrayMaxValue(int[] array, int startIndex, int endIndex)
    {   // Returns the index of the maximal value in array
        int maxValue = int.MinValue;
        int maxIndex = 0;

        for (int i = startIndex; i <= endIndex - 1; i++)
        {
            int max = Math.Max(array[i], array[i + 1]);

            if (maxValue < max)
            {
                maxValue = max;
                maxIndex = array[i] == maxValue ? i : i + 1;
            }
        }

        return maxIndex;
    }

    static int[] SortAscending(int[] array)
    {
        int[] sortedArr = new int[array.Length];

        for (int i = array.Length - 1; i >= 0 ; i--)
        {
            int maxValueIndex = ArrayMaxValue(array, 0, i);

            sortedArr[i] = array[maxValueIndex];

            if (i != maxValueIndex)
            {   
                SwapArrayValues(array, i, maxValueIndex);
            }
        }

        return sortedArr;
    }

    static int[] SortDescending(int[] array)
    {
        int[] sortedArr = new int[array.Length];

        for (int i = array.Length - 1; i >= 0; i--)
        {
            int maxValueIndex = ArrayMaxValue(array, 0, i);

            sortedArr[array.Length - 1 - i] = array[maxValueIndex];

            if (i != maxValueIndex)
            {
                SwapArrayValues(array, i, maxValueIndex);
            }
        }
        
        return sortedArr;
    }

    private static void SwapArrayValues(int[] array, int currentInex, int targetIndex)
    {
        int temp = array[currentInex];
        array[currentInex] = array[targetIndex];
        array[targetIndex] = temp;
    }

    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int[] arr = input.Split(' ').Select(int.Parse).ToArray();

        int[] sorted = SortAscending(arr);

        foreach (var number in sorted)
        {
            Console.Write("{0} ", number);
        }
    }
}