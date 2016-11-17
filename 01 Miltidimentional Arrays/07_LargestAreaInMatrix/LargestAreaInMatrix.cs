using System;
using System.Collections.Generic;
using System.Linq;

class LargestAreaInMatrix
{
    static int IncreaseMaxLen(int current, int max)
    {
        if (max < current)
        {   // Increment maximal found sequence
            max = current;
        }
        return max;
    }
    
    static void Main()
    {
        // INITIALIZE INPUT AND VARIABLES
        string input = Console.ReadLine();
        int[] dimSizes = input.Split(' ').Select(int.Parse).ToArray(); // [0] = rows, [1] = cols
        int[,] matrix = new int[dimSizes[0], dimSizes[1]];
        for (int row = 0; row < dimSizes[0]; row++)
        {
            int[] matrixRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < dimSizes[1]; i++)
            {
                matrix[row, i] = matrixRow[i];
            }
        }
        int maxPathLen = 1;

        // FIND LARGEST AREA OF EQUAL ELEMENTS
        for (int r = 0; r < dimSizes[0]; r++)
        {
            for (int c = 0; c < dimSizes[1]; c++)
            {
                int currentValue = matrix[r, c];
                int matchValueRow = r;
                int matchValueCol = c;
                int pathLength = 0;

                if (matrix[i, j] == currentValue &&
                    Math.Abs(matchValueRow - i) < 2 &&
                    Math.Abs(matchValueCol - j) < 2)
                {
                    pathLength++;
                    matchValueRow = i;
                    matchValueCol = j;
                    maxPathLen = IncreaseMaxLen(pathLength, maxPathLen);
                }
            }
        }
        // Print result
        Console.WriteLine(maxPathLen);
    }
}