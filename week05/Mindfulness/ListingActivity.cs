using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _count = 0;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
       
        Console.Clear();

        GetRandomPrompt();
        ShowCountDown(5);
       
        GetListFromUser();
       
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
      
        string prompt = _prompts[index];
        Console.WriteLine($"{prompt}");
    }

    private List<string> GetListFromUser()
    {
        List<string> responseList = new List<string>();
       
        DateTime endTime = DateTime.Now.AddSeconds(base._duration);
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responseList.Add(response);
                _count++;
            }
            else
            {
                Console.WriteLine("Error!!! Please enter in a value");
            }
        }
       
        return responseList;
    }
}

