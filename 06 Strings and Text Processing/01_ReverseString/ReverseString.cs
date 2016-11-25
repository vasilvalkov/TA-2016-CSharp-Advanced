using System;
using System.Linq;
using System.Text;

namespace _01_ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(StringReverse(input));
        }

        private static string StringReverse(string input)
        {
            char[] reversed = input.Reverse().ToArray();
            StringBuilder revStr = new StringBuilder();
            foreach (var ch in reversed)
            {
                revStr.Append(ch);
            }

            return revStr.ToString();
        }
    }
}
