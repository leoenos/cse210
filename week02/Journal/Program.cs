using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        Statistics stats = new Statistics();

        int input = 0;

        while (input != 6)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Stats");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string anentry = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString();
                entry._promptText = prompt;
                entry._entryText = anentry;

                journal.AddEntry(entry);
            }

            else if (input == 2)
            {
                journal.DisplayAll();
            }

            else if (input == 3)
            {
                Console.WriteLine("Filename: ");
                string file = Console.ReadLine();
                journal.StringToFile(file);
            }

            else if (input == 4)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            else if (input == 5)
            {
                Console.WriteLine($"Total Entries: {stats.EntryCount(journal)}");
                Console.WriteLine($"Total word count: {stats.TotalWordCount(journal)}");
            }
        }
    }
}