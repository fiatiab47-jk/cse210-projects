// Allows basic system functionality (Console, etc.)
using System;


public abstract class Goal
{
    //Protected Shared attributes accessible by derived classes
    protected string _shortName;    //Goal Name
    protected string _description;  // Goal Description
    protected int _points;          // Points awarded per completion


    // Constructor to set the initial state of shared values
    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    // Abstract method forces derived classes to implement their own version
    public abstract int RecordEvent();

    // Abstract method forces derived classes to define completion logic
    public abstract bool IsComplete();

    // Abstract method forces each goal to define how it saves itself
    public abstract string GetStringRepresentation();

    // Virtual method provides default list display format
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";   // Show X if complete
        return $"{status} {_shortName} ({_description})";
    }


}