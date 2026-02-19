using System;


public class SimpleGoal : Goal
{
    private bool _isComplete;   // Tracks if goal has been completed


// Simple Goal initializer 
    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {
        // Starts incomplete by definition
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        // only allow completion once
        if (!_isComplete)
        {
            _isComplete = true; // Mark complete
            return _points;
        }
        return 0;       // If already complete no points 
    }


    // Return completion status
    public override bool IsComplete() => _isComplete;
    

    public override string GetStringRepresentation()
    {
        // Format:
        // SimpleGoal|shortName|description|points|isComplete
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}