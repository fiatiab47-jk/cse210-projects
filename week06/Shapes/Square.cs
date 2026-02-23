using System;

public class Square: Shape
{
    private double _side;


    // Constructor with parameter
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Overridden method
    public override double GetArea() => _side * _side;
    
}