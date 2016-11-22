using System;

class OneSystemToAnyOther
{
    static long IntegerPower(int number, int exp)
    {
        long result = 1L;
        while (exp != 0)
        {
            if ((exp & 1) != 0) // If exp is odd
                result *= number;
            exp >>= 1;
            number *= number;
        }

        return result;
    }

    static string DecToAll(ulong number, int toBase)
    {
        string bin = string.Empty;

        string hexDigits = "0123456789ABCDEF";

        do
        {
            ulong digitValue = number % (ulong)toBase;
            char digit = hexDigits[(int)digitValue];
            number /= (ulong)toBase;
            bin = digit + bin;

        } while (number > 0);
       
        return bin;
    }
    
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
    
    static string ConvertNumber(string number, ulong fromBase, int toBase)
    {
        string convertedNumber = string.Empty;

        if (fromBase == 10)
        {
            return convertedNumber = DecToAll(ulong.Parse(number), toBase).ToString();
        }        
        else if (toBase == 10)
        {
            return convertedNumber = AllToDec(number, fromBase).ToString();
        }
        else
        {
            ulong decValue = AllToDec(number, fromBase);
            return convertedNumber = DecToAll(decValue, toBase);
        }
    }

    static void Main()
    {
        ulong fromSystem = ulong.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        int toSystem = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertNumber(number, fromSystem, toSystem));
    }
}