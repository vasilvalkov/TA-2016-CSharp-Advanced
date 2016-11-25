using System;

namespace _03_SubstringInText
{
    class SubstringInText
    {
        static int PatternCount(string pattern, string text)
        {
            int count = 0;
            int index = 0;

            while (0 <= index && index < text.Length)
            {
                index = text.IndexOf(pattern, index, StringComparison.OrdinalIgnoreCase);

                if (!(index < 0))
                {
                    count++;
                    index += pattern.Length;
                }                
            }

            return count;
        }

        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            Console.WriteLine(PatternCount(pattern, text));
        }
    }
}
