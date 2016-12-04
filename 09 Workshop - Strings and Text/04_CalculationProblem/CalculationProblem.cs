using System;

namespace _04_CalculationProblem
{
    class CalculationProblem
    {
        static string digits = "abcdefghijklmnopqrstuvw";

        static int sumInDec = 0;
        static string sumIn23 = string.Empty;

        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');

            CalculateSum(inputArr);

            Console.WriteLine("{0} = {1}", sumIn23, sumInDec);
        }

        private static void CalculateSum(string[] numbers)
        {
            foreach (var number in numbers)
            {
                int tempSum = 0;
                foreach (var digit in number)
                {
                    tempSum = tempSum * 23 + digits.IndexOf(digit);
                }
                sumInDec += tempSum;
            }

            int num = sumInDec;
            do
            {
                int digitValue = num % 23;
                char digit = digits[digitValue];
                num /= 23;
                sumIn23 = digit + sumIn23;
            } while (num > 0);
        }
    }
}
