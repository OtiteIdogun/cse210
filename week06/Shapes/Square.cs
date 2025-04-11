using System;

public class SquareShape : Shape
{
    private double _side;

    public SquareShape(string colour, double side) : base(colour)
    {
        _side = side;
    }

    public override double GetArea()
    {
        double squareArea = _side * _side;
        double roundedValue = Math.Round(squareArea, 2);
        return roundedValue;
    }
}