using System;

class ReverseNumber
{
    static decimal Reverse(decimal number)
    {
        string reversed = string.Empty;

        for (int i = number.ToString().Length - 1; i >= 0 ; i--)
        {
            reversed += number.ToString()[i];
        }

        return decimal.Parse(reversed);
    }

    static void Main()
    {
        decimal input = decimal.Parse(Console.ReadLine());

        decimal reversed = Reverse(input);

        Console.WriteLine(reversed);
    }
}