using System;

class DecimalToHex
{
    static string DecToHex(long number)
    {
        string hexValue = string.Empty;
        string hexDigits = "0123456789ABCDEF";

        do
        {
            long digitValue = number % 16;
            char digit = hexDigits[(int)digitValue];
            number /= 16;
            hexValue = digit + hexValue;

        } while (number > 0);

        return hexValue;
    }

    static void Main()
    {
        long input = long.Parse(Console.ReadLine());

        Console.WriteLine(DecToHex(input));
    }
}