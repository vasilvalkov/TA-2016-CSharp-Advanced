using System;

class FillTheMatrix
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int counter = 1;
        // Populate matrix with numbers from 1 to size * size
        switch (ch)
        {   // Choosing pattern for populating
            case 'a': // Column by column
                for (int cols = 0; cols < size; cols++)
                {
                    for (int rows = 0; rows < size; rows++)
                    {
                        matrix[rows, cols] = counter;
                        counter++;
                    }
                }
                break;
            case 'b': // Zig-zag column by column
                for (int cols = 0; cols < size; cols++)
                {
                    for (int rows = 0; rows < size; rows++)
                    {
                        if (cols % 2 != 0)
                        {
                            matrix[size - rows - 1, cols] = counter;
                            counter++;
                        }
                        else
                        {
                            matrix[rows, cols] = counter;
                            counter++;
                        }
                    }
                }
                break;
            case 'c': // Diagonal by diagonal starting from bottom-left
                for (int i = 1; i <= size; i++)
                {
                    int rows = size - i;
                    int cols = 0;

                    for (int j = 0; j < i; j++)
                    {
                        matrix[rows, cols] = counter;
                        counter++;

                        if (cols == i)
                        {
                            cols = 0;
                            rows = size - i;
                        }
                        else
                        {
                            cols++;
                            rows++;
                        }
                    }
                }
                for (int i = size - 1; i > 0; i--)
                {
                    int cols = size - i;
                    int rows = 0;

                    for (int j = 0; j < i; j++)
                    {
                        matrix[rows, cols] = counter;
                        counter++;

                        if (rows == i)
                        {
                            rows = 0;
                            cols = size - i;
                        }
                        else
                        {
                            cols++;
                            rows++;
                        }
                    }
                }
                break;
            case 'd': // Spiral counterclock-wise
                int row = 0;
                int col = 0;
                char direction = 'd';

                for (int i = 0; i < size * size; i++)
                {
                    matrix[row, col] = counter;
                    counter++;                    

                    if (row + col == size - 1 &&
                        direction == 'd')
                    {
                        direction = 'r';
                    }
                    if (row == col && // == (size - 1) * 2 &&
                        direction == 'r')
                    {
                        direction = 'u';
                    }
                    if (row + col == size - 1 &&
                        direction == 'u')
                    {
                        direction = 'l';
                    }
                    if (col == row + 1 &&
                        direction == 'l')
                    {
                        direction = 'd';
                    }

                    switch (direction)
                    {
                        case 'd': row++; break; // down
                        case 'l': col--; break; // left
                        case 'r': col++; break; // right
                        case 'u': row--; break; // up
                        default: break;
                    }
                }
                break;
            default:
                break;
        }
        // Print matrix
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (j > 0)
                {
                    Console.Write(" ");
                }
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}