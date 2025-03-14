using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I learned today that I didn't know before?",
        "What challenges did I face today, and how did I overcome them?",
        "What am I grateful for today, and why does it matter to me?",
        "How did I take care of myself today, both physically and emotionally?",
        "What is a dream or goal I want to focus on moving forward, and what steps can I take to achieve it?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
       
        string prompt = _prompts[index];
        return prompt;
    }
}



