using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("First name: ");
        string first = Console.ReadLine();

        Console.Write("Last name: ");
        string last = Console.ReadLine();

        Console.Write($"The name's {last}, {first} {last}.");
    }
}