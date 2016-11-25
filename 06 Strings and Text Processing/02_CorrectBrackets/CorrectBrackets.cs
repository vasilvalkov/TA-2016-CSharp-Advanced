using System;

namespace _02_CorrectBrackets
{
    class CorrectBrackets
    {
        static string AreCorrect(string text)
        {
            int openingBrackets = 0;
            int closingBrackets = 0;

            foreach (var symbol in text)
            {
                if (symbol == '(')
                {
                    openingBrackets++;
                }
                if (symbol == ')')
                {
                    closingBrackets++;
                }
            }

            return openingBrackets == closingBrackets ? "Correct" : "Incorrect";
        }

        static void Main()
        {
            string brackets = Console.ReadLine();

            Console.WriteLine(AreCorrect(brackets));
        }
    }
}
