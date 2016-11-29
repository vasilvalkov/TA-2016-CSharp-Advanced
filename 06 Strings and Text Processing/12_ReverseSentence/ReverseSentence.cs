using System;
using System.Linq;
using System.Text;

namespace _12_ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            Console.WriteLine(Reverse(sentence));
        }

        private static string Reverse(string sentence)
        {
            StringBuilder reversed = new StringBuilder();
            char[] splitChars;

            ExtractSplitChars(sentence, out splitChars);

            string[] splitSentence = sentence.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

            Swap(splitSentence);

            int smallerLen = splitSentence.Length < splitChars.Length ? splitSentence.Length : splitChars.Length;
            int largerLen = splitSentence.Length > splitChars.Length ? splitSentence.Length : splitChars.Length;

            for (int i = 0, j = 0; i < smallerLen; i++, j++)
            {
                reversed.Append(splitSentence[i]);

                if (splitChars[j] != ' ')
                {
                    reversed.Append(splitChars[j++]);
                }
                if (j == largerLen)
                {
                    break;
                }
                reversed.Append(splitChars[j]);
            }

            return reversed.ToString();
        }

        private static void ExtractSplitChars(string sentence, out char[] splitChars)
        {
            StringBuilder nonLetters = new StringBuilder();

            foreach (var _char in sentence)
            {   // Find non-letter characters in the sentence
                if (!char.IsLetter(_char) &&
                    (_char != '+' && _char != '#' && _char != '@' &&
                     _char != '$' && _char != '%' && _char != '~'))
                {
                    nonLetters.Append(_char);
                }
            }

            splitChars = nonLetters.ToString().ToArray();
        }

        private static void Swap(string[] strArray)
        {
            for (int i = 0; i < strArray.Length / 2; i++)
            {
                string temp = strArray[i];
                strArray[i] = strArray[strArray.Length - 1 - i];
                strArray[strArray.Length - 1 - i] = temp;
            }
        }
    }
}
