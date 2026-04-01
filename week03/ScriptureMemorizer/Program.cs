using System;

/*An extra class was added to exceed the project's requirements.
The class called ScriptureLibrary handles the responsibility of creating/storing a list
of scriptures and selecting one at random when the program is run. Scriptures could be added
in the future.*/

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit the program");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return;
            }

            scripture.HideRandomWords(3);
        }
        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words hidden.");
    }
}