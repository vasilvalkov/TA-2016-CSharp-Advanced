using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01_Messages
{
    class Messages
    {
        private static Queue<string> SplitIntoChunksLeftToRight(string georgeNumber, int chunkSize)
        {
            Queue<string> binChunks = new Queue<string>();
            string binChunk = string.Empty;

            for (int i = 0; i < georgeNumber.Length; i++)
            {
                binChunk = binChunk + georgeNumber[i];

                if (binChunk.Length == chunkSize)
                {
                    binChunks.Enqueue(binChunk);
                    binChunk = string.Empty;
                }
                if (i == georgeNumber.Length - 1 && binChunk != string.Empty)
                {
                    binChunks.Enqueue(binChunk);
                }
            }

            return binChunks;
        }
        private static char GetDecValue(string s)
        {
            char georgeValue = ' ';
            switch (s)
            {
                case "cad": georgeValue = '0'; break;
                case "xoz": georgeValue = '1'; break;
                case "nop": georgeValue = '2'; break;
                case "cyk": georgeValue = '3'; break;
                case "min": georgeValue = '4'; break;
                case "mar": georgeValue = '5'; break;
                case "kon": georgeValue = '6'; break;
                case "iva": georgeValue = '7'; break;
                case "ogi": georgeValue = '8'; break;
                case "yan": georgeValue = '9'; break;
            }

            return georgeValue;
        }
        private static string GetGeorgeValue(char ch)
        {
            string decValue = string.Empty;

            switch (ch)
            {
                case '0': decValue = "cad"; break;
                case '1': decValue = "xoz"; break;
                case '2': decValue = "nop"; break;
                case '3': decValue = "cyk"; break;
                case '4': decValue = "min"; break;
                case '5': decValue = "mar"; break;
                case '6': decValue = "kon"; break;
                case '7': decValue = "iva"; break;
                case '8': decValue = "ogi"; break;
                case '9': decValue = "yan"; break;
            }

            return decValue;
        }
        private static BigInteger DecryptGeorge(Queue<string> georgeNumbers)
        {
            BigInteger decrypted = 0;

            foreach (var georgeNumber in georgeNumbers)
            {
                decrypted = decrypted * 10 + (GetDecValue(georgeNumber)- '0');
            }

            return decrypted;
        }
        private static string EncryptGeorge(BigInteger number)
        {
            string encrypted = string.Empty;

            foreach (char digit in number.ToString())
            {
                encrypted += GetGeorgeValue(digit);
            }

            return encrypted;
        }

        static void Main()
        {
            string firstNumber = Console.ReadLine();
            string op = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            BigInteger firstDecrypted = DecryptGeorge(SplitIntoChunksLeftToRight(firstNumber, 3));
            BigInteger secondDecrypted = DecryptGeorge(SplitIntoChunksLeftToRight(secondNumber, 3));

            BigInteger result = 0;

            if (op == "-")
            {
                result = firstDecrypted - secondDecrypted;
            }
            else
            {
                result = firstDecrypted + secondDecrypted;
            }

            Console.WriteLine(EncryptGeorge(result));

        }
    }
}
