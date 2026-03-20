using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What did you do today?",
        "What is your biggest fear?",
        "Who is your favorite BTS member and why?",
        "What was your favorite song you listened to today and why?",
        "Did you make a friend today?",
        "Tell me about your favorite tv show."

    };
    
    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int index = prompt.Next(_prompts.Count);
        return _prompts[index];
    }
}