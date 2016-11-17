using System;

class SayHello
{
    static void GreetUser()
    {
        string userName = Console.ReadLine();

        Console.WriteLine("Hello, {0}!", userName);
    }

    static void Main()
    {
        GreetUser();
    }
}