using System;
using System.Text;

namespace _06_EncodeAndDecode
{
    class EncodeAndDecode
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string cipher = Console.ReadLine();

            string encodedText = EncodeOrDecode(text, cipher);
            string decodedText = EncodeOrDecode(encodedText, cipher);

            Console.WriteLine(encodedText);
            Console.WriteLine(decodedText);
        }

        private static string EncodeOrDecode(string text, string cipher)
        {
            StringBuilder encodedText = new StringBuilder();
            int j = 0;  // cipher letter index

            for (int i = 0; i < text.Length; i++)
            {
                int letter = text[i];
                int code = cipher[j];

                char encodedChar = (char)(letter ^ code);

                encodedText.Append(encodedChar);
                j = j != cipher.Length - 1 ? j+1 : 0;
            }

            return encodedText.ToString();
        }        
    }
}
