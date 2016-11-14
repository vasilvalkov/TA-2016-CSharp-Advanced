using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        // Initialize input and variables
        string input = Console.ReadLine();
        int numberK = int.Parse(Console.ReadLine());
        int[] arr = input.Split(' ').Select(int.Parse).ToArray();
        int index;
        // Binary search
        Array.Sort(arr);
        index = Array.BinarySearch(arr, numberK);
        // Print result
        if (index < 0)
        {   // If the index is negative, it represents the bitwise
            // complement of the next larger element in the array.
            index = ~index;
            Console.WriteLine("Number {2} not found.\nThe largest number found which is lesser than {2} is {0} at index {1}",arr[index - 1], index - 1, numberK);
        }
        else
            Console.WriteLine("Number {1} found at index {0}", index, numberK);
    }
}