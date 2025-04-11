using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new SquareShape("Red", 5));
        shapes.Add(new RectangleShape("Blue", 4, 6));
        shapes.Add(new CircleShape("Green", 3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape} \nColour: {shape.GetColour()}, Area: {shape.GetArea()}\n");
        }
    }
}