using System;

namespace _01_SquareRoot
{
    class Program
    {
        static void Main()
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 0)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("{0:F3}", Math.Sqrt(input));
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
