using System;

public class RectangleShape : Shape
{
    private double _length;
    private double _width;

    public RectangleShape(string colour, double length, double width) : base(colour)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        double RectangleArea = _length * _width;
        double roundedValue = Math.Round(RectangleArea, 2);
        return roundedValue;
    }
}