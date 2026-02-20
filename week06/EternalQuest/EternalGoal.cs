// Allows basic system functionality (Console, etc.)
using System;

public class EternalGoal : Goal
{
    // Initializes the state of the Eternal goal object
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // always award points
    public override int RecordEvent() => _points;
    

    // Eternal goals are never complete
    public override bool IsComplete() => false;


    // Returns the format of Eternal Goal
    public override string GetStringRepresentation() =>
        $"EternalGoal|{_shortName}|{_description}|{_points}";
   
}