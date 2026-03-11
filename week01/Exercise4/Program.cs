using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter as many numbers as desired. Type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is {sum}");

        double avg = numbers.Average();
        Console.WriteLine($"The average is {avg}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is {max}");

    }
}