using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        
        DisplayWelcome();
        
        DisplayResult();
    }

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string numberInput = Console.ReadLine();
        int number = Convert.ToInt32(numberInput);
        return number;
    }

    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }

    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult()
    {
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}
