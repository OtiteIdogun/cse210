using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Instruction
        // Ask the user for their grade percentage,

        // Algorithm 1: Display output of prompt question to the console
        Console.Write("Please enter your grade in percentage (%): ");

        // Algorithm 2: Get input of grade on the console
        string gradeInput = Console.ReadLine();

        // Algorithm 3: Convert grade input from default string type
        //              to integer type
        int grade = int.Parse(gradeInput);
        
        char letter;

        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80)
        {
            letter = 'B';
        }
        else if (grade >= 70)
        {
            letter = 'C';
        }
        else if (grade >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        // Print out the appropriate letter grade.
        Console.WriteLine($"Grade: {letter}");

        // * Instruction
        // Add a separate if statement to determine if the user passed the course,

        // * Instruction
        // and if so display a message to congratulate them.
        // If not, display a different message to encourage them for next time.

        // Determine if the user passed the course,
        if (grade >= 60)
        {
            // Print out a display message to congratulate them.
            Console.WriteLine("You passed the class!");
        }
        else
        {
            // Display a different message to encourage them for next time.
            Console.WriteLine("You did not pass the course. Try again next time.");
        }
    }
}
