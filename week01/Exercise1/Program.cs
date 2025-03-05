using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		// Prompt the user for their first name. 
		Console.Write("What is your first name ");
		string f_name = Console.ReadLine();
		
		//Then, prompt them for their last name. 
		Console.Write("What is your last name ");
		string l_name = Console.ReadLine();

		// Display the text back all on one line saying, 
		// "Your name is last-name, first-name, last-name"
		Console.WriteLine($"\nYour name is {l_name}, {f_name} {l_name}");
		
	}
}
