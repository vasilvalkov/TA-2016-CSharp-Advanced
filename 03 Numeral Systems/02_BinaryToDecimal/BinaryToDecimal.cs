using System;

class BinaryToDecmimal
{
    static ulong BinToDec(string bin)
    {
        ulong dec = 0;
        int pow = 0;

        for (int i = bin.Length - 1; i >= 0; i--)
        {
            dec += (ulong)(bin[i] - '0') * (1UL << pow++);
        }

        return dec;
    }

    static void Main()
    {
        string binNumber = Console.ReadLine();

        Console.WriteLine(BinToDec(binNumber));
    }
}