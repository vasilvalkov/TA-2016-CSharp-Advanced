using System;

class HexToBinary
{
    static ulong HexToDec(string number)
    {
        ulong decValue = 0;
        int value = 0;

        foreach (char digit in number)
        {
            if (char.IsDigit(digit))
            {
                value = digit - '0';
            }
            else
            {
                value = digit - 'A' + 10;
            }

            decValue = decValue * 16 + (ulong)value;
        }

        return decValue;
    }

    static string HexToBin(string hex)
    {
        string bin = string.Empty;

        ulong dec = HexToDec(hex);

        while (dec > 0)
        {
            bin = (dec % 2).ToString() + bin;
            dec >>= 1;
        }

        return bin;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(HexToBin(input));
    }
}