using System;

namespace EternalQuest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Added gamification feature: Updates level based on score
            
            Console.WriteLine("Welcome to Eternal Quest - Your Personal Goal Tracker!");
            Console.WriteLine("Earn points and level up as you complete your goals!");
           
            GoalManager goalManager = new GoalManager();
            goalManager.Start();
        }
    }
}