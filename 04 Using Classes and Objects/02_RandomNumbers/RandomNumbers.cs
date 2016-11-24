using System;

namespace _02_RandomNumbers
{
    class RandomNumbers
    {
        static Random rand = new Random();

        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(100, 200));
            }
            
        }
    }
}
