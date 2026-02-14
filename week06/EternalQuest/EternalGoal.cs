using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        // always award points
        return _points;
    }

    public override bool IsComplete()
    {
        // Eternal goals never complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal|{_shortName}|{_description}|{_points}";
    }
}