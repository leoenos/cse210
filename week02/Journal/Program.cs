using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Select one of the following options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Stats");
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");

        int _input = 0;

        while (_input != 6)
        {
            if (_input == 1)
            {
                Journal newEntry = new Journal();
            }
        }
    }
}