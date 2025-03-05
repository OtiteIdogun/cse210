using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int number = -1;

        // append each one to a list.
        List<int> numberList = new List<int>();

        while (number != 0)
        {
            // Ask the user for a series of numbers, and
            Console.Write("Enter number (+ or -): ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput); // Or Convert.ToInt32(numberInput) ToInt32 or ToInt64

            numberList.Add(number);

            if (number == 0)
            {
                numberList.Remove(0);
            }
        }

        // Compute the sum, or total, of the numbers in the list.
        int sum = numberList.Sum();
        Console.WriteLine($"Sum of List Numbers = {sum}");

        // Compute the average of the numbers in the list.
        float average = ((float)sum) / numberList.Count; // for Arrays use .Length
        Console.WriteLine($"Average of List Numbers = {average}");

        // Find the maximum, or largest, number in the list.
        int maxNum = numberList[0];

        foreach (int num in numberList)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }
        Console.WriteLine($"Largest Number in List = {maxNum}");

        // Find the smallest positive number
        // (the positive number that is closest to zero).
        int minPositiveNum = numberList[0];

        foreach (int num in numberList)
        {
            if (num > 0)  // The positive number that is closest to and greater than zero
            {
                if (num < minPositiveNum)
                {
                    minPositiveNum = num;
                }
            }
        }
        Console.WriteLine($"Smallest Positive in List = {minPositiveNum}");

        // Sort the numbers in the list and
        numberList.Sort();
        Console.WriteLine($"Sorted Number List:");

        foreach (int num in numberList)
        {
            // Display the new, sorted list.
            Console.WriteLine($"{num}");
        }
    }
}
