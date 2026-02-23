using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;


    // constructor with parameter
    public Rectangle(String color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }


    public override double GetArea() => _length * _width;
    

}