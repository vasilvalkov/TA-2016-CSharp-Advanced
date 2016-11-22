using System;
using System.Collections.Generic;

class BinaryToHex
{
    private static Queue<string> SplitIntoChunksRightToLeft(string binNumber, int chunkSize)
    {
        Queue<string> binChunks = new Queue<string>();
        string binChunk = string.Empty;

        for (int i = binNumber.Length - 1; i >= 0; i--)
        {
            binChunk = binNumber[i] + binChunk;

            if (binChunk.Length == chunkSize)
            {
                binChunks.Enqueue(binChunk);
                binChunk = string.Empty;
            }
            if (i == 0 && binChunk != string.Empty)
            {
                binChunks.Enqueue(binChunk);
            }
        }

        return binChunks;
    }

    private static char GetHexValue(string s)
    {
        char hexValue = ' ';
        switch (s)
        {
            case "0000": case "0": hexValue = '0'; break;
            case "0001": case "1": hexValue = '1'; break;
            case "0010": case "10": hexValue = '2'; break;
            case "0011": case "11": hexValue = '3'; break;
            case "0100": case "100": hexValue = '4'; break;
            case "0101": case "101": hexValue = '5'; break;
            case "0110": case "110": hexValue = '6'; break;
            case "0111": case "111": hexValue = '7'; break;
            case "1000": hexValue = '8'; break;
            case "1001": hexValue = '9'; break;
            case "1010": hexValue = 'A'; break;
            case "1011": hexValue = 'B'; break;
            case "1100": hexValue = 'C'; break;
            case "1101": hexValue = 'D'; break;
            case "1110": hexValue = 'E'; break;
            case "1111": hexValue = 'F'; break;
        }

        return hexValue;
    }

    static string ConvertBinToHex(string bin)
    {
        var binSplit = SplitIntoChunksRightToLeft(bin, 4);

        string hex = string.Empty;

        foreach (string hexValue in binSplit)
        {
            hex = GetHexValue(hexValue) + hex;
        }

        return hex;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ConvertBinToHex(input));
    }
}