using System;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        // Initialize input and variables
        string input = Console.ReadLine();
        string[] arr = input.Split(' ').ToArray();
        // Sort array by string length
        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));        
        // Print sorted array
        foreach (string str in arr)
        {
            Console.WriteLine(str);
        }
    }
}