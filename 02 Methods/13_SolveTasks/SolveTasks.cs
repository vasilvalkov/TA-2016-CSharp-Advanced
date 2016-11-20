using System;
using System.Collections.Generic;
using System.Linq;

class SolveTasks
{
    static string Reverse(string number)
    {
        string reversed = string.Empty;

        for (int i = number.ToString().Length - 1; i >= 0; i--)
        {
            reversed += number[i];
        }

        return reversed;
    }
    static double AverageOfElements(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return (sum / (double)array.Length);
    }
    static double LinearEquate(double a, double b)
    {
        double x = -b / a;
        return x;
    }
    private static List<double> GetCoeficients(string input)
    {
        List<double> coeficients = new List<double>();
        int number;
        string numberBuilder = string.Empty;
        string negativeSign = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-')
            {
                negativeSign = input[i].ToString();
            }
            if (int.TryParse(input[i].ToString(), out number))
            {
                numberBuilder += input[i].ToString();
            }
            else if (numberBuilder != string.Empty)
            {
                AddElement(coeficients, negativeSign += numberBuilder);
                numberBuilder = string.Empty;
                negativeSign = string.Empty;
            }
            if (input[i].ToString() == "=")
                break;
        }

        AddElement(coeficients, negativeSign + numberBuilder);

        if (coeficients.Count == 1)
        {
            coeficients.Add(0);
        }

        return coeficients;
    }
    private static void AddElement(List<double> list, string s)
    {
        if (s != string.Empty)
        {
            list.Add(double.Parse(s));
        }
    }
    private static void DisplayMenu()
    {
        Console.WriteLine("Select a task to solve by its number:");
        Console.WriteLine();
        Console.WriteLine("1. Reverse a number");
        Console.WriteLine("2. Find average of integers");
        Console.WriteLine("3. Find x in 'ax + b = 0'");
    }
    private static void SolveTask1()
    {
        Console.Clear();
        Console.WriteLine("===== Reverse a number =====");
        Console.WriteLine();
        string input;
        int number;

        do
        {   // Read and validate input
            Console.Write("Please enter a positive number: ");
            input = Console.ReadLine();

            if (!(int.TryParse(input, out number)) || number < 0)
            {
                Console.WriteLine("This is not a correct number!");
            }
            else break;
        } while (true);

        Console.WriteLine("The reversed number is: {0}", Reverse(input));
    }
    private static void SolveTask2()
    {
        Console.Clear();
        Console.WriteLine("===== Find average of integers =====");
        Console.WriteLine();
        string input;

        do
        {   // Read and validate input
            Console.Write("Please enter your numbers separated with spaces: ");
            input = Console.ReadLine();

            if (input == string.Empty)
            {
                Console.WriteLine("You have not entered any number!");
                Console.WriteLine();
            }
            else break;
        } while (true);
        // Build array out of the entered numbers
        int[] inputArr = input.Split(' ').Select(int.Parse).ToArray();
        // Calculate result
        Console.WriteLine("The average of your numbers is {0:0.##}", AverageOfElements(inputArr));
    }
    private static void SolveTask3()
    {
        Console.Clear();
        Console.WriteLine("===== Find x in 'ax + b = 0' =====");
        Console.WriteLine();
        string input;
        do
        {   // Read and validate input
            Console.Write("Please enter your equation: ");
            input = Console.ReadLine();
            if (input == string.Empty)
                continue;
            if (input[0] == '0')
            {
                Console.WriteLine("The first coeficient must not be 0!");
                Console.WriteLine();
            }
            else if (input[0] == 'x')
            {
                input = "1" + input;
                break;
            }
            else if (input[0] != '-' && input[0] < '0' || '9' < input[0])
            {
                Console.WriteLine("The first coeficient must be an integer or empty!");
                Console.WriteLine();
            }            
            else break;
                
        } while (true);

        List<double> coeficients = GetCoeficients(input);

        Console.WriteLine("x is {0}", LinearEquate(coeficients[0], coeficients[1]));
    }
    private static void ReturnToTaskMenu()
    {
        Console.WriteLine($"Press \"Enter\" to go back to the tasks menu");
        var choice = Console.ReadKey();

        if (choice.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Main();
        }
    }
    static void Main()
    {
        DisplayMenu();

        var k = Console.ReadKey();
        switch (k.KeyChar)
        {
            case '1': SolveTask1(); break;
            case '2': SolveTask2(); break;
            case '3': SolveTask3(); break;
            default:
                Console.Clear();
                Main();
                break;
        }

        Console.WriteLine();
        ReturnToTaskMenu();
    }
}