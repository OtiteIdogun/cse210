using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 22, 14);
        Scripture scripture = new Scripture(reference, "And since man had fallen he could not merit anything of himself; but the sufferings and death of Christ atone for their sins, through faith and repentance, and so forth; and that he breaketh the bands of death, that the grave shall have no victory, and that the sting of death should be swallowed up in the hopes of glory...");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit. \n>> ");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break; 
            }

            // Hide a random word
            scripture.HideRandomWords(1); // Hide one word at a time

            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Exiting the program.");
                break; 
            }
        }
    }
}
