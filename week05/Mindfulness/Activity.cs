public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("Enter duration (in sec): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Session Complete!");
        Console.WriteLine($"You completed {_duration} seconds of {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}