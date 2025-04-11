using System;

public class CircleShape : Shape
{
    private double _radius;

    public CircleShape(string colour, double radius) : base(colour)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        //return (float)(
        double circleArea = Math.PI * _radius * _radius;
        double roundedValue = Math.Round(circleArea, 2);
        return roundedValue;
    }
}