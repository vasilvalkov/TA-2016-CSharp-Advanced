using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        // Initialize input and variables
        string input = Console.ReadLine();  // Read input string
        int[] dimSizes = input.Split(' ').Select(int.Parse).ToArray();   // Split input into array of numbers     
        int[][] matrix = new int[dimSizes[0]][];    // Declare matrix as array of arrays
        for (int i = 0; i < dimSizes[0]; i++)
        {   // Populate matrix
            string inputMatrix = Console.ReadLine();
            matrix[i] = inputMatrix.Split(' ').Select(int.Parse).ToArray(); //Populate each array in matrix
        }
        int currentSum = 0;
        int maxSum = int.MinValue;  // Ensure correct answer if negative values
        // Find maximal sum
        for (int row = 0; row <= dimSizes[0] - 3; row++)
        {
            for (int col = 0; col <= dimSizes[1] - 3; col++)
            {   // Calculate sum of current 3x3 square
                currentSum = matrix[row][col] +
                             matrix[row][col + 1] +
                             matrix[row][col + 2] +
                             matrix[row + 1][col] +
                             matrix[row + 1][col + 1] +
                             matrix[row + 1][col + 2] +
                             matrix[row + 2][col] +
                             matrix[row + 2][col + 1] +
                             matrix[row + 2][col + 2];
                if (maxSum < currentSum)
                {   // Increase maximal sum
                    maxSum = currentSum;
                }
            }
        }
        // Print result
        Console.WriteLine(maxSum);
    }
}