using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        do
        {
            Console.Write("Enter a number (0 to quit): ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
                numbers.Add(input);
        } while (input != 0);

        int total = 0;
        foreach (int num in numbers)
            total += num;

        Console.WriteLine($"Sum: {total}");
    }
}
