
using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n----------------------");
                DisplayPlayerInfo();

                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Record Event");
                Console.WriteLine("  4. Save Goals");
                Console.WriteLine("  5. Load Goals");
                Console.WriteLine("  6. Quit\n");

                Console.Write("Please choose an option: ");
                string choice = Console.ReadLine();
                Console.WriteLine("\n----------------------");


                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        RecordEvent();
                        break;
                    case "4":
                        SaveGoals();
                        break;
                    case "5":
                        LoadGoals();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        continue;
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine($"Level: {CalculateLevel()}");
        }

        private int CalculateLevel()
        {
            // Gamification feature: Level updating system 
            return _score / 1000 + 1;
        }

        public void ListGoalDetails()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("\nNo goals have been created yet.");
                return;
            }

            Console.WriteLine("\nYour Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string type = Console.ReadLine();

            Console.Write("\nWhat is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            try
            {
                switch (type)
                {
                    case "1":
                        _goals.Add(new SimpleGoal(name, description, points));
                        Console.WriteLine("Simple goal created successfully!");
                        break;
                    case "2":
                        _goals.Add(new EternalGoal(name, description, points));
                        Console.WriteLine("Eternal goal created successfully!");
                        break;
                    case "3":
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int bonus = int.Parse(Console.ReadLine());
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                        Console.WriteLine("Checklist goal created successfully!");
                        break;
                    default:
                        Console.WriteLine("Invalid goal type.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numbers for points, target, and bonus.");
            }
        }

        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("\nNo goals available to record.");
                return;
            }


            Console.WriteLine("\nYour goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }
            Console.Write("Which goal did you accomplish? ");
            int index = int.Parse(Console.ReadLine()) - 1;


            if (index >= 0 && index < _goals.Count)
            {
                _goals[index].RecordEvent();
                int earnedPoints = _goals[index].GetPoints();
                _score += earnedPoints;
               
                Console.WriteLine($"\nCongratulations! You have earned {earnedPoints} points!");
                if (_goals[index] is ChecklistGoal checklist && checklist.IsComplete())
                {
                    Console.WriteLine($"You earned a bonus of {checklist.GetBonus()} points!");
                }
                DisplayPlayerInfo();
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }        
        }

        public void SaveGoals()
        {
            Console.Write("\nWhat is the filename for the goal file? ");
            string filename = Console.ReadLine();

            try
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(_score);
                    foreach (var goal in _goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }
                Console.WriteLine("Goals saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving goals: {ex.Message}");
            }
        }

        public void LoadGoals()
        {
            Console.Write("\nWhat is the name of the goal file you wish to load? ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filename);
                _goals.Clear();
                _score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]);
                            var simpleGoal = new SimpleGoal(name, description, points);
                            if (isComplete) simpleGoal.RecordEvent();
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int target = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            int amountCompleted = int.Parse(parts[6]);
                            var checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                            for (int j = 0; j < amountCompleted; j++)
                            {
                                checklistGoal.RecordEvent();
                            }
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
                Console.WriteLine("Goals loaded successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error loading goals: {e.Message}");
            }
        }
    }
}