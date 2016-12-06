using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_BadCat
{
    class BadCat
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            StringBuilder digits = new StringBuilder();
            string[] instructions = new string[linesCount];

            for (int i = 0; i < linesCount; i++)
            {
                instructions[i] = Console.ReadLine();
            }

            digits = RemoveNoShowDigits(instructions);

            Reorder(digits, instructions);

            Console.WriteLine(digits.ToString());
        }

        private static void Reorder(StringBuilder digitsOfNumber, string[] instructions)
        {
            string number = digitsOfNumber.ToString();
            List<char> digits = digitsOfNumber.ToString().ToList();

            foreach (var digit in number)
            {
                foreach (var instruction in instructions)
                {
                    string[] instr = instruction.Split(' ');

                    if (instr[0][0] != digit && instr[3][0] != digit)
                    {
                        continue;
                    }

                    int firstDigit = digits.IndexOf(instr[0][0]);
                    int secondDigit = digits.IndexOf(instr[3][0]);

                    if (instr[2] == "before")
                    {
                        if (firstDigit < secondDigit)
                        {
                            continue;
                        }
                        else
                        {
                            char temp = digits[firstDigit];
                            digits.RemoveAt(firstDigit);
                            digits.Insert(secondDigit, temp);
                        }
                    }
                    else
                    {
                        if (firstDigit > secondDigit)
                        {
                            continue;
                        }
                        else
                        {
                            char temp = digits[secondDigit];
                            digits.RemoveAt(secondDigit);
                            digits.Insert(firstDigit, temp);
                        }
                    }
                }
            }
            digitsOfNumber.Clear();
            foreach (var digit in digits)
            {
                digitsOfNumber.Append(digit);
            }
        }

        private static StringBuilder RemoveNoShowDigits(string[] instructions)
        {
            StringBuilder showingDigits = new StringBuilder();

            foreach (var instruction in instructions)
            {
                foreach (var item in instruction)
                {
                    if (char.IsDigit(item))
                    {
                        showingDigits.Append(item);
                    }
                }
            }
            char[] digits = showingDigits.ToString().ToCharArray().Distinct().ToArray();

            Array.Sort(digits);

            showingDigits.Clear();

            foreach (var digit in digits)
            {
                showingDigits.Append(digit);
            }

            return showingDigits;
        }
    }
}
