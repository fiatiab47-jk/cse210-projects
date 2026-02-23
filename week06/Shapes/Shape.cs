using System;
using System.Drawing;

public class Shape
{
    private string _color;

   
    // Constructor with parameter
    public Shape(string color)
    {
        _color = color;
    }


    public string GetColor() => _color;

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea() => 0.00;
}