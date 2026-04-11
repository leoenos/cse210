using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Smith", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        Math a2 = new Math("Jane Doe", "Fractions", "6.9", "4-20");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomework());

        Writing a3 = new Writing("Seokjin Kim", "Acting", "Only BTS Graduate");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWriting());
    }
}