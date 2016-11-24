using System;

class BinaryShort
{
    static string ShortToBinary(short number)
    {
        string bin = string.Empty;
        short num = number;        

        while (num > 0)
        {            
            bin = (num % 2).ToString() + bin;
            num >>= 1;
        }
        while (num < -1)
        {
            bin = ((num % 2) * -1).ToString() + bin;
            num >>= 1;
        }
        
        return bin.PadLeft(16, (number >= 0) ? '0' : '1');
    }

    static void Main(string[] args)
    {
        short input = short.Parse(Console.ReadLine());

        Console.WriteLine(ShortToBinary(input));
    }
}