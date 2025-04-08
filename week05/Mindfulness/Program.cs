using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit\n");

            Console.Write("Enter selection: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 60);
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 120);
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 60);
                    listingActivity.Run();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
            }
        }
    }
}

