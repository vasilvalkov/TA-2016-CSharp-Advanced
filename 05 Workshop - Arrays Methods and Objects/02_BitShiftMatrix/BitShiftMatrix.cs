using System;
using System.Linq;
using System.Numerics;

namespace _02_BitShiftMatrix
{
    class BitShiftMatrix
    {
        static int rows;
        static int cols;
        static int[] moves;
        static BigInteger[,] field;

        static void Main()
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int movesCount = int.Parse(Console.ReadLine());
            moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            field = new BigInteger[rows, cols];
            FillMatrix();

            BigInteger sum = BigInteger.Zero;
            int[] pos = { rows - 1, 0 };
            int coef = rows > cols ? rows : cols;

            sum += field[pos[0], pos[1]];
            field[pos[0], pos[1]] = 0;

            foreach (var code in moves)
            {
                int[] tarPos = { code / coef, code % coef };

                int stepRow = Math.Sign(tarPos[0] - pos[0]);
                int stepCol = Math.Sign(tarPos[1] - pos[1]);

                do
                {
                    pos[1] += stepCol;
                    sum += field[pos[0], pos[1]];
                    field[pos[0], pos[1]] = 0;
                } while (pos[1] != tarPos[1] && pos[1] >= 0 && pos[1] < cols);

                do
                {
                    pos[0] += stepRow;
                    sum += field[pos[0], pos[1]];
                    field[pos[0], pos[1]] = 0;
                } while (pos[0] != tarPos[0] && pos[0] >= 0 && pos[0] < rows);
            }

            Console.WriteLine(sum);
        }
        private static void FillMatrix()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    field[r, c] = BigInteger.One << (rows - 1 - r + c);
                }
            }
        }

        private static void PrintMatrix(BigInteger[,] board)
        {
            Console.Clear();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write("{0,4}", board[r, c]);
                }
                Console.WriteLine();
            }

        }
    }
}
