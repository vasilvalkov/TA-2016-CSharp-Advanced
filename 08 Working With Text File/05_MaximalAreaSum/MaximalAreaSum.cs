using System.IO;
using System.Linq;
using System.Text;

namespace _05_MaximalAreaSum
{
    class MaximalAreaSum
    {
        static void Main()
        {
            string inputFilePath = "../../TestInput.txt";
            string outputFilePath = "../../TestOutput.txt";
            bool append = false;
            Encoding enc = Encoding.UTF8;

            using (StreamReader reader = new StreamReader(inputFilePath, enc))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath, append, enc))
                {
                    try
                    {
                        int dimSizes = int.Parse(reader.ReadLine());
                        int[][] matrix = new int[dimSizes][];

                        for (int i = 0; i < dimSizes; i++)
                        {   // Populate matrix
                            string inputMatrix = reader.ReadLine();
                            matrix[i] = inputMatrix.Split(' ').Select(int.Parse).ToArray(); //Populate each array in matrix
                        }

                        int maxSum = GetMaxSum(matrix);
                        writer.WriteLine(maxSum);
                    }
                    finally
                    {
                        writer.Close();
                        reader.Close();
                    }
                }
            }
        }
        private static int GetMaxSum(int[][] matrix)
        {
            int currentSum = 0;
            int maxSum = int.MinValue;  // Ensure correct answer if negative values

            for (int row = 0; row <= matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col <= matrix.GetLength(0) - 2; col++)
                {   // Calculate sum of current 3x3 square
                    currentSum = matrix[row][col] +
                                 matrix[row][col + 1] +
                                 matrix[row + 1][col] +
                                 matrix[row + 1][col + 1];
                    if (maxSum < currentSum)
                    {   // Increase maximal sum
                        maxSum = currentSum;
                    }
                }
            }

            return maxSum;
        }
    }
}