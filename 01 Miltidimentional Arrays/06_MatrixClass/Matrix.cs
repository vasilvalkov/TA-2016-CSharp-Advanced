using System;

class Matrix
{
    public static int[,] CreateNew(int rows, int cols)
    {
        return new int[rows, cols];
    }
    public static int[,] Add(int[,] firstMatrix, int[,] secondMatrix)
    {
        int[,] thirdMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

        for (int row = 0; row < firstMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < firstMatrix.GetLength(1); col++)
            {
                thirdMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
            }
        }

        return thirdMatrix;
    }
    public static int[,] Subtract(int[,] firstMatrix, int[,] secondMatrix)
    {
        int[,] thirdMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

        for (int row = 0; row < firstMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < firstMatrix.GetLength(1); col++)
            {
                thirdMatrix[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
            }
        }

        return thirdMatrix;
    }
    public static int[,] Product(int[,] firstMatrix, int[,] secondMatrix)
    {
        int[,] thirdMatrix = new int[secondMatrix.GetLength(0), secondMatrix.GetLength(1)];

        for (int row = 0; row < firstMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < secondMatrix.GetLength(1); col++)
            {
                for (int i = 0; i < firstMatrix.GetLength(0); i++)
                {
                    thirdMatrix[row, col] += firstMatrix[row, i] * secondMatrix[i, col];
                }
            }
        }

        return thirdMatrix;
    }
    public static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        int[,] m1 = {
                { 2, 2, 2 },
                { 3, 3, 3 },
                { 2, 4, 6 }
            };

        int[,] m2 = {
                { 2, 3, 4 },
                { 3, 5, 7 },
                { 1, 3, 5 }
            };

        int[,] m3 = Matrix.Add(m1, m2);
        int[,] m4 = Matrix.Subtract(m1, m2);
        int[,] m5 = Matrix.Product(m1, m2);

        Matrix.Print(m3);
        Console.WriteLine();
        Matrix.Print(m4);
        Console.WriteLine();
        Matrix.Print(m5);
    }
}