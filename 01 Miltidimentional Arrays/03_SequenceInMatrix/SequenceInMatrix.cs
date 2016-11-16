using System;
using System.Linq;

class SequenceInMatrix
{
    private static int IncreaseMaxLen(int current, int max)
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
        string input = Console.ReadLine();                // Read matrix dimentions
        int[] dimSizes = input.Split(' ').Select(int.Parse).ToArray();   // Save dimentions sizes - [0] for rows, [1] for cols
        string[][] matrix = new string[dimSizes[0]][];    // Declare matrix as array of arrays
        for (int i = 0; i < dimSizes[0]; i++)
        {   // Populate matrix
            string inputMatrix = Console.ReadLine();
            matrix[i] = inputMatrix.Split(' ').ToArray(); // Populate each array in matrix
        }
        int currentLen = 1;
        int maxLen = 1;
        string currentValue = string.Empty;
        // FIND LONGEST SEQUENCE
        for (int r = 0; r < dimSizes[0]; r++)
        {
            for (int c = 0; c < dimSizes[1]; c++)
            {
                currentValue = matrix[r][c];
                currentLen = 1;
                int row = r;
                int col = c;

                while (col < dimSizes[1] - 1)
                {   // Check to the right
                    if (currentValue == matrix[row][col + 1])
                    {   // Equal element found
                        currentLen++;
                        maxLen = IncreaseMaxLen(currentLen, maxLen);
                    }
                    col++;  // Move right to it and make it current
                }

                col = c;

                while (col < dimSizes[1] - 1 && row < dimSizes[0] - 1)
                {   // Check right diagonal
                    if (currentValue == matrix[row + 1][col + 1])
                    {   // Equal element found                    
                        currentLen++;
                        maxLen = IncreaseMaxLen(currentLen, maxLen);
                    }
                    row++; col++;   // Move diagonally to it and make it current
                }

                row = r;
                col = c;

                while (row < dimSizes[0] - 1)
                {   // Check below
                    if (currentValue == matrix[row + 1][col])
                    {   // Equal element found                    
                        currentLen++;
                        maxLen = IncreaseMaxLen(currentLen, maxLen);
                    }
                    row++;  // Move down to it and make it current
                }

                row = r;

                while (row < dimSizes[0] - 1 && col > 0)
                {   // Check left diagonal
                    if (currentValue == matrix[row + 1][col - 1])
                    {   // Equal element found                       
                        currentLen++;
                        maxLen = IncreaseMaxLen(currentLen, maxLen);
                    }
                    row++; col--;   // Move diagonally to it and make it current
                }
            }
        }
        // PRINT RESULT
        Console.WriteLine(maxLen);
    }
}