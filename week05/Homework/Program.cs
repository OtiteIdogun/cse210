using System;
using System.Collections.Generic;

namespace Homework 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine($"{assignment1.GetSummary()}\n");

            MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
            Console.WriteLine($"{math1.GetHomeworkList()}\n");

            WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
            Console.WriteLine(writing1.GetWritingInfo());
        }
    }
}

