using System;
using System.Linq;

class IntegerCalculations
{
    static int SumElements(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static int MinElement(int[] array)
    {
        int minValue = int.MaxValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = array[i] < array[i + 1] ? array[i] : array[i + 1];

            if (minValue > min)
            {
                minValue = min;
            }
        }

        return minValue;
    }

    static int MaxElement(int[] array)
    {
        int maxValue = int.MinValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            int max = array[i] > array[i + 1] ? array[i] : array[i + 1];

            if (maxValue < max)
            {
                maxValue = max;
            }
        }

        return maxValue;
    }

    static long ProductOfElements(int[] array)
    {
        long product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }

    static double AverageOfElements(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return (sum / (double)array.Length);
    }

    static void Main()
    {
        int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(MinElement(inputArr));
        Console.WriteLine(MaxElement(inputArr));
        Console.WriteLine("{0:F2}", AverageOfElements(inputArr));
        Console.WriteLine(SumElements(inputArr));
        Console.WriteLine(ProductOfElements(inputArr));
    }
}