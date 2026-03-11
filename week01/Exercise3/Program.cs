using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int mNumber = int.Parse(magicNumber);

        Console.Write("What is your guess? ");
        string yourGuess = Console.ReadLine();
        int guess = int.Parse(yourGuess);
        
        while (guess != mNumber)
        {
            if (mNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.Write("You guessed it!");
    }
}