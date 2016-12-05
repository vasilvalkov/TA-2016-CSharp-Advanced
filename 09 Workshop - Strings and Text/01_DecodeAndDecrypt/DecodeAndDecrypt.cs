using System;

namespace _01_DecodeAndDecrypt
{
    class DecodeAndDecrypt
    {
        static void Main()
        {
            string cipheredText = Console.ReadLine();
            int cipherLen = GetCipherLength(cipheredText);
            string decodedText = Decode(cipheredText, cipherLen);
            string cipher = GetCipher(decodedText, cipherLen);
            string decryptedText = Decrypt(decodedText, cipher);

            Console.WriteLine(decryptedText);
        }

        private static int GetCipherLength(string cipheredText)
        {
            string lenBuilder = string.Empty;

            for (int i = cipheredText.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(cipheredText[i]))
                {
                    lenBuilder = cipheredText[i] + lenBuilder;
                }
                else
                    break;
            }

            return int.Parse(lenBuilder);
        }

        private static string Decode(string encodedText, int cipherLength)
        {
            encodedText = encodedText.Substring(0, (encodedText.Length - cipherLength.ToString().Length));
            string decodedText = string.Empty;

            for (int i = 0; i < encodedText.Length; i++)
            {
                if (char.IsDigit(encodedText[i]))
                {
                    string number = string.Empty;
                    while (true)
                    {
                        number += encodedText[i++];

                        if (char.IsLetter(encodedText[i]) || i == encodedText.Length)
                        {
                            break;
                        }
                    }

                    int count = int.Parse(number);
                    decodedText += new string(encodedText[i], count);
                }
                else
                {
                    decodedText += encodedText[i];
                }
            }

            return decodedText;
        }

        private static string GetCipher(string cipheredText, int cipherLength)
        {
            return cipheredText.Substring(cipheredText.Length - cipherLength);
        }

        private static string Decrypt(string encryptedText, string cipher)
        {
            encryptedText = encryptedText.Substring(0, encryptedText.Length - cipher.Length);
            char[] result = encryptedText.ToCharArray();
            int length = result.Length > cipher.Length ? result.Length : cipher.Length;

            for (int i = 0; i < length; i++)
            {
                var letter = result[i % result.Length] - 'A';
                var code = cipher[i % cipher.Length] - 'A';

                var xor = letter ^ code;

                result[i % result.Length] = (char)(xor + 'A');
            }

            return string.Join("", result);
        }
    }
}
