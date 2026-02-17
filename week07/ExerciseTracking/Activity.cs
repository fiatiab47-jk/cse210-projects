using System;
using System.Reflection.Metadata.Ecma335;

public abstract class Activity
{
    // Encapsulated member variables
    private string _date;
    private int _minutes;

    // Constructor to initialize shared properties
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Public accessors to private fields
    public string GetDate() => _date;

    public int GetMinutes() => _minutes;


    // Abstract methods 
    // Distance in miles
    public abstract double GetDistance();
    // Speed in mph
    public abstract double GetSpeed();
    // Pace in minutes per mile
    public abstract double GetPace();


    // Shared summary method using Polymorphism
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min) - " +
                $"Distance{GetDistance(): 0.00} miles, " +
                $"Speed {GetSpeed():0.00} mph, " +
                $"Pace: {GetPace():0.00} min per mile";       
    }

} 