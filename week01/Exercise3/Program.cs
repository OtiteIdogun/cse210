using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World! This is the Exercise2 Project.");

		string answer = "yes";

	    // Keep track of how many guesses the user has made
	    int guessCount = 0;
	    
		while (answer.ToLower() == "yes")
		{
			Random randomGenerator = new Random();
			int magicNumber = randomGenerator.Next(1, 2); // Generate a random number from 1 to 100

			Console.Write("What is the magic number? ");
			string guessInput = Console.ReadLine();
			int guess = int.Parse(guessInput);
			
			guessCount++;

			if (guess > magicNumber)
			{
				Console.WriteLine("Guess lower");
			}
			else if (guess < magicNumber)
			{
				Console.WriteLine("Guess higher");
			}
			else if (guess == magicNumber)
			{
				Console.WriteLine("Guess Correct");

				// Inform them of the number of guesses
				// at the end of the game
				if (guessCount == 1)
				{
				    Console.WriteLine($"It took you a guess.");
				}
				else
				{
				    Console.WriteLine($"It took you {guessCount} guesses.");
				}

				// Ask the user if they want to play again
				Console.Write("Do you wish to continue playing the game (yes or no)? ");
				answer = Console.ReadLine();

				if (answer.ToLower() == "yes")
				{
					// Continue the loop
					// Initialize guessCount to 0
					guessCount = 0;
				}
				else if (answer.ToLower() == "no") 
				{
					Console.WriteLine("Thank you for playing. Goodbye");
				}
				else
				{
				    Console.WriteLine("Invalid input! Terminating program");
				}
			}
			else
			{
				Console.WriteLine("!!! Please enter in numbers not strings");
			}
		}
	}
} 
