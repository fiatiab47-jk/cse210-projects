using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ShapeManager
{
    // private fields
    private List<Shape> _shapes;
    private bool _isRunning;

    public ShapeManager()
    {
        _shapes = new List<Shape>();
        _isRunning = true;
    }

    public void Start()
    {
        Console.WriteLine("--- Welcome ot the Shape Manager! ---");

        while (_isRunning)
        {
            DisplayMenu();
            HandleChoice();
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Add Square");
        Console.WriteLine("2. Add Rectangle");
        Console.WriteLine("3. Add Circle");
        Console.WriteLine("4. Display All Shapes");
        Console.WriteLine("5. Exit");
        Console.Write("Enter choice: ");
    }

    private void HandleChoice()
    {
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: AddSquare(); break;
            case 2: AddRectangle(); break;
            case 3:; AddCircle(); break;
            case 4: DisplayShapes(); break;
            case 5:
                _isRunning = false;
                Console.WriteLine("Exiting program...."); break;
            default:
                Console.WriteLine("Invalid Choice. Select a choice form the menu.");
                break;
        }
    }

    private void AddSquare()
    {
        Console.Write("Enter color: ");
        string color = Console.ReadLine();
        double side = GetValidatedDouble("Enter side length: ");

        _shapes.Add(new Square(color, side));
    }

    public void AddRectangle()
    {
        Console.Write("Enter color: ");
        string color = Console.ReadLine();
        double length = GetValidatedDouble("Enter length: ");
        double width = GetValidatedDouble("Enter width: ");

        _shapes.Add(new Rectangle(color, length, width));
    }

    public void AddCircle()
    {
        Console.Write("Enter color: ");
        string color = Console.ReadLine();
        double radius = GetValidatedDouble("Enter radius: ");

        _shapes.Add(new Circle(color, radius));
    }

    private void DisplayShapes()
    {
        if (_shapes.Count == 0)
        {
            Console.WriteLine("No shapes available.");
            return;
        }
        Console.WriteLine("--- Shapes List ---");
        foreach (Shape shape in _shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            Console.WriteLine("----------------------");
        }
    }


    /* This method prompts the user for a number, validates that it is
    a positive double, and keeps asking until  valid input is entered. 
    */
    private double GetValidatedDouble(string message)
    {
        // Stores the parsed numeric value
        double value;
        // tracks whether the input is valid
        bool isValid;

        do
        {
            // Display the prompt message (e.g., "Enter length: ")
            Console.Write(message);
            // Try to convert user input to a double.
            // TryParse prevents exceptions if input is invalid.
           isValid = double.TryParse(Console.ReadLine(), out value);

            // If parsing failed OR number is zero/negative,
            // show error and repeat loop.
            if (!isValid || value <= 0)
            {
                Console.WriteLine("invalid input. please enter a positive number.");
                // Force loop to repeat
                isValid = false;
            }
        } while (!isValid); // Repeat until valid input
        return value;       // Return the validated number
    }
}

