using System;

public class Circle : Shape
{
    private double _radius;
    

    // constructor with parameter
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea() =>
        Math.PI * _radius * _radius;
        
}