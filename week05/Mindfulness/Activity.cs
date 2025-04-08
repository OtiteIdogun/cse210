using System;
using System.Collections.Generic;
using System.Threading;

public class Activity

{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} \n\n{_description}\n");
        Console.Write("How long would you like to perform this activity? \nEnter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write($"Get ready to begin...\n");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great Job, well done");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} activity.");
        Console.WriteLine($"The activity lasted for {_duration} seconds.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
       
        int index = 0;
        while (DateTime.Now < endTime)
        {
            // Get the current animation string
            string s = animationStrings[index];
            Console.Write(s);
            Thread.Sleep(900);
            Console.Write("\b \b"); // Erase the last character output
           
            index++;
           
            // Reset the index if it exceeds the count of animation strings
            if (index >= animationStrings.Count)
            {
                index = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int idx = 0; idx < seconds; idx++)
        {
            Console.Write($"{idx}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}

