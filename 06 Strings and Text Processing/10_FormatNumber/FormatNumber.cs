using System;

namespace _10_FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.Write("{0,-13}", "Decimal:");
            Console.WriteLine("{0,15}", number);
            Console.Write("{0,-13}", "Hexadecimal:");
            Console.WriteLine("{0,15:X}", number);
            Console.Write("{0,-13}", "Percentage:");
            Console.WriteLine("{0,15:P02}", number / double.Parse('1' + new string('0', number.ToString().Length)));
            Console.Write("{0,-13}", "Scientific:");
            Console.WriteLine("{0,15:E}", number);
        }
    }
}
