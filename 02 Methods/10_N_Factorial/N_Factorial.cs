using System;
using System.Numerics;
using System.Linq;

class N_Factorial
{
    static BigInteger Factorial(char[] numbers)
    {
        string numberStr = string.Empty;

        for (int i = 0; i < numbers.Length; i++)
        {
            numberStr += numbers[i];
        }

        BigInteger number = BigInteger.Parse(numberStr);
        BigInteger factorial = 1;

        for (BigInteger i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static void Main()
    {
        Console.WriteLine(Factorial(Console.ReadLine().ToArray()));
    }
}