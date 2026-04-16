using System;
//Added a tracking counter to let the user know how many times they have done each activity.
class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectCount = 0;
        int listingCount = 0;

        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Stats");
            Console.WriteLine("5. Quit");

            Console.Write("Select one: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                new ReflectingActivity().Run();
                reflectCount++;
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nActivity Stats:");
                Console.WriteLine($"Breathing Activity: {breathingCount}");
                Console.WriteLine($"Refelctin Activity: {reflectCount}");
                Console.WriteLine($"Listing Activity: {listingCount}");
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}