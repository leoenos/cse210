using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percent: ");
        string grade = Console.ReadLine();
        int finalGrade = int.Parse(grade);

        if (finalGrade >= 90)
        {
            Console.Write("Your grade is an A");
        }
        else if (finalGrade >= 80 && finalGrade < 90)
        {
            Console.Write("Your grade is a B");
        }
        else if (finalGrade >= 70 && finalGrade < 80)
        {
            Console.Write("Your grade is a C");
        }
        else if (finalGrade >= 60 && finalGrade < 70)
        {
            Console.Write("Your grade is a D");
        }
        else
        {
            Console.Write("Your grade is an F");
        }

    }
}