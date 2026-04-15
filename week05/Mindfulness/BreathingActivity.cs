public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "Take a bit to relax with some breathing techniques";
    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);

            Console.Write("\nBreathe out...");
            ShowCountDown(4);
        }

        DisplayEndMessage();
    }
}