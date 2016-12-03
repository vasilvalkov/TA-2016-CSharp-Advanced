using System;

namespace _02_MultiverseCommunication
{
    class MultiverseCommunication
    {
        static string[] codes = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

        static string hexDigits = "0123456789ABC";

        static void Main()
        {
            string message = Console.ReadLine();

            ulong valueToDec = ConvertToDec(message);

            Console.WriteLine(valueToDec);
        }

        private static string GetNumericalValue(string text)
        {
            string numValue = string.Empty;            

            for (int i = 0; i < text.Length; i += 3)
            {
                string code = text.Substring(i, 3);
                numValue += hexDigits[ValueOf(code)];
            }

            return numValue;
        }

        private static ulong ConvertToDec(string message)
        {
            string number = GetNumericalValue(message);
            ulong decValue = 0;

            foreach (char digit in number)
            {
                int hexValue = hexDigits.IndexOf(digit);
                decValue = decValue * 13 + (ulong)hexValue;
            }

            return decValue;
        }

        private static int ValueOf(string code)
        {
            return Array.IndexOf(codes, code);
        }
    }
}
