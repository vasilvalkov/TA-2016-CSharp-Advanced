using System;
using System.Linq;

namespace _06_LoverOf3
{
    class LoverOf3
    {
        static ulong sum = 0;
        static ulong rows = 0;
        static ulong cols = 0;
        static ulong[,] field;
        static ulong[] pos = new ulong[2];

        static void Main()
        {
            ulong[] dim = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray();
            rows = dim[0];
            cols = dim[1];

            field = new ulong[rows, cols];
            pos[0] = rows - 1;
            pos[1] = 0;
            FillMatrix(rows, cols);

            int movesCount = int.Parse(Console.ReadLine());

            sum += field[pos[0], pos[1]];
            field[pos[0], pos[1]] = 0;

            for (int i = 0; i < movesCount; i++)
            {
                string[] move = Console.ReadLine().Split(' ');
                MovePawn(move[0], int.Parse(move[1]));
            }

            Console.WriteLine(sum);
        }

        private static void MovePawn(string direction, int movesCount)
        {
            for (int i = 0; i < movesCount - 1 &&
                            pos[0] >= 0 && pos[0] < rows &&
                            pos[1] >= 0 && pos[1] < cols; i++)
            {
                if (((direction == "UR" || direction == "RU") && (pos[0] == 0UL || pos[1] == cols - 1)) ||
                    ((direction == "LU" || direction == "UL") && (pos[0] == 0UL || pos[1] == 0UL)) ||
                    ((direction == "DL" || direction == "LD") && (pos[0] == rows - 1 || pos[1] == 0)) ||
                    ((direction == "DR" || direction == "RD") && (pos[0] == rows - 1 || pos[1] == cols - 1)))
                {
                    continue;
                }
                else
                {
                    switch (direction)
                    {
                        case "UR":
                        case "RU": pos[0]--; pos[1]++; break;
                        case "LU":
                        case "UL": pos[0]--; pos[1]--; break;
                        case "DL":
                        case "LD": pos[0]++; pos[1]--; break;
                        case "DR":
                        case "RD": pos[0]++; pos[1]++; break;
                    }
                }
                sum += field[pos[0], pos[1]];
                field[pos[0], pos[1]] = 0;
            }
        }
        private static void FillMatrix(ulong rows, ulong cols)
        {
            for (ulong r = rows - 1; r >= 0 && r < rows; r--)
            {
                for (ulong c = 0; c < cols; c++)
                {
                    field[r, c] = (rows - r - 1 + c) * 3;
                }
            }
        }
        private static void PrintMatrix(ulong[,] board)
        {
            Console.Clear();
            for (ulong r = 0; r < rows; r++)
            {
                for (ulong c = 0; c < cols; c++)
                {
                    Console.Write("{0,4}", board[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
