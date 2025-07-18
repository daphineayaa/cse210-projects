using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter number {i}: ");
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine($"Total sum is: {sum}");
    }
}
