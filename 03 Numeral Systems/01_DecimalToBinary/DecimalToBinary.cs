using System;

class DecimalToBinary
{
    static long decNumber;

    static void PrepareInput(string s)
    {
        decNumber = long.Parse(s);
    }

    static string DecToBinary(long number)
    {
        string bin = string.Empty;

        while (number > 0)
        {
            bin = (number % 2).ToString() + bin;
            number >>= 1;
        }

        return bin;
    }

    static void Main()
    {
        PrepareInput(Console.ReadLine());
        Console.WriteLine(DecToBinary(decNumber));
    }
}