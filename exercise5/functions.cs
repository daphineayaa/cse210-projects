using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        string name = PromptName();
        int number = PromptNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int PromptNumber()
    {
        Console.Write("Enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}
