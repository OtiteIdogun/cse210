using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void Run()
    {
        List<string> prompts = new List<string> { "Breathe in...", "Breathe out..." };
       
        base.DisplayStartingMessage();
       
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(10);
       
        while (DateTime.Now < endTime)
        {
            string prompt = prompts[index];
            Console.Write($"\n{prompt}");
            base.ShowCountDown(4);
            Thread.Sleep(100);
            Console.WriteLine();
           
            index++;
           
            if (index >= prompts.Count)
            {
                index = 0;
            }
        }

        base.DisplayEndingMessage();
    }
}

 