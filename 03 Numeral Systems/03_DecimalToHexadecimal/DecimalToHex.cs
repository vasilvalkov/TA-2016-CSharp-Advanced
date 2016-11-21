using System;

class DecimalToHex
{
    static string DecToHex(long number)
    {
        
        //long divident = number;
        //long divisor = 16;
        //long quotient = divident / divisor;
        //string hexValue = string.Empty;
        //string value = string.Empty;
        //long remainder;

        //while (divident >= 1)
        //{   // calculate the remainder
        //    remainder = divident - (quotient * 16);
        //    // get the base 16 value of remainder and assign it to value
        //    switch (remainder)
        //    {
        //        case 0:
        //        case 1:
        //        case 2:
        //        case 3:
        //        case 4:
        //        case 5:
        //        case 6:
        //        case 7:
        //        case 8:
        //        case 9: value = remainder.ToString(); break;
        //        case 10: value = "A"; break;
        //        case 11: value = "B"; break;
        //        case 12: value = "C"; break;
        //        case 13: value = "D"; break;
        //        case 14: value = "E"; break;
        //        case 15: value = "F"; break;
        //        default: break;
        //    }
        //    // always add the value to the hex string at index 0
        //    hexValue = value + hexValue;
        //    // next divident will be the current quotient
        //    divident = quotient;
        //    // calculate the next quotient
        //    quotient = divident / divisor;
        //    // repeat the calculations until divident >= 1

        return hexValue;
    }

    static void Main()
    {
        long input = long.Parse(Console.ReadLine());

        Console.WriteLine(DecToHex(input));
    }
}