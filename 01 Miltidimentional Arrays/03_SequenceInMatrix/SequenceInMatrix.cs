using System;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        // Initialize input and variables
        string input = Console.ReadLine();                // Read input string
        int[] dimSizes = input.Split(' ').Select(int.Parse).ToArray();   // Split input into array of numbers     
        string[][] matrix = new string[dimSizes[0]][];    // Declare matrix as array of arrays
        for (int i = 0; i < dimSizes[0]; i++)
        {   // Populate matrix
            string inputMatrix = Console.ReadLine();
            matrix[i] = inputMatrix.Split(' ').ToArray(); // Populate each array in matrix
        }
        int currentLen = 1;
        int maxLen = 1;
        int row = 0;
        int col = 0;
        // Find longest sequence
        while (row < dimSizes[0] - 1 && col < dimSizes[1])
        {
            if (col > 0)
            {
                if (matrix[row][col] == matrix[row][col - 1])
                {   // Element at diagonal to the left is equal to current
                    //col++;      // Move right to it and make it current
                    currentLen++;
                    if (maxLen < currentLen)
                    {   // Increment maximal found sequence
                        maxLen = currentLen;
                    }
                }
            }
            if (col != dimSizes[1] - 1)
            {                
                if (matrix[row][col] == matrix[row][col + 1])
                {   // Element to the rigth is equal
                    col++;      // Move right to it and make it current
                    currentLen++;
                    if (maxLen < currentLen)
                    {   // Increment maximal found sequence
                        maxLen = currentLen;
                    }
                }
                else if (matrix[row][col] == matrix[row + 1][col])
                {   // Element below is equal to current
                    row++;      // Move down to it and make it current
                    currentLen++;
                    if (maxLen < currentLen)
                    {
                        maxLen = currentLen;
                    }
                }
                else if (matrix[row][col] == matrix[row + 1][col + 1])
                {   // Element at diagonal to the right is equal to current
                    row++; col++;     // Move diagonally to it and make it current
                    currentLen++;
                    if (maxLen < currentLen)
                    {
                        maxLen = currentLen;
                    }
                }
                else
                {   // No equal elemnts. Go one column ahead and start a new sequence
                    currentLen = 1;
                    col++;
                }
            }
            else
            {   // Last column reached
                if (matrix[row][col] == matrix[row + 1][col])
                {   // Element below is equal to current
                    row++;      // Move down to it and make it current
                    currentLen++;
                    if (maxLen < currentLen)
                    {
                        maxLen = currentLen;
                    }
                }
                else
                {   // Element below is not equal to current. Start from begining of new row
                    currentLen = 1;
                    row++;
                    col = 0;
                }
            }
        }
        // Print result
        Console.WriteLine(maxLen);
    }
}