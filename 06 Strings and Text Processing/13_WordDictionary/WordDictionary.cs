using System;

namespace _13_WordDictionary
{
    class WordDictionary
    {
        static string[,] dictionary =
        {
            { ".NET", "platform for applications from Microsoft" },
            { "CLR", "managed execution environment for .NET"},
            { "namespace", "hierarchical organization of classes"}
        };

        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Translate(input));
        }

        private static string Translate(string input)
        {
            for (int i = 0; i < dictionary.GetLength(0); i++)
            {
                if (dictionary[i, 0].Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    return dictionary[i, 1];
                }
            }

            return string.Format("The word '{0}' was not found.", input);
        }
    }
}
