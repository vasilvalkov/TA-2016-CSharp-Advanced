using System;

class HexToDecimal
{
    static ulong AllToDec(string number, ulong nBase)
    {
        ulong decValue = 0;
        int value = 0;

        foreach (char digit in number)
        {
            switch (digit)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': value = digit - '0'; break;
                case 'A': value = 10; break;
                case 'B': value = 11; break;
                case 'C': value = 12; break;
                case 'D': value = 13; break;
                case 'E': value = 14; break;
                case 'F': value = 15; break;
                default: break;
            }

            decValue = decValue * nBase + (ulong)value;
        }

        return decValue;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(AllToDec(input, 2));
    }
}