public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    private Random _random = new Random();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity lets you make a gratitude list of the positive things in your life";
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.WriteLine("Start in");
        ShowSpinner(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
        }

        Console.WriteLine($"You wrote {items.Count} things.");

        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

}