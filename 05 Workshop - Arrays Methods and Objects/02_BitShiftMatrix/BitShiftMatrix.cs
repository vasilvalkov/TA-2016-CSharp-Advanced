using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_BitShiftMatrix
{
    struct Pos
    {
        public int Row { get; set; }
        public int Col { get; set; }
    }
    class BitShiftMatrix
    {
        public int sum;
        public Pos void SetPosition(int row, int col)
        {
            this.Row = row;
            this.Col = col;            
        }

        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            short moves = short.Parse(Console.ReadLine());
            int[] codes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int coef = Math.Max(rows, cols);

            int[,] matrix = GenerateMatrix(rows, cols);
            Pos currentPos = Pos(0,0);

            foreach (int code in codes)
            { 
                Pos target = DecodePos(code, coef);
            }


            Pos currentPos = MoveTo(Pos target);

        }

        private static Pos DecodePos(int code, int coef)
        {
            Pos pos = new Pos();

            pos.Row = code / coef;
            pos.Col = code % coef;

            return pos;
        }

        private static int[,] GenerateMatrix(int rows, int cols)
        {
            int[,] m = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    m[i, j] = 1;
                }
            }

            return m;
        }
    }
}
