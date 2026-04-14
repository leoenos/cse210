using System;
//Added confirmation messages and error messages in cases of loading and saving files or the file doesn't exist.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}