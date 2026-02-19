using System; 

public class ChecklistGoal : Goal
{
    private int _amountCompleted;   // Times completed so far
    private int _target;            // Required completions      
    private int _bonus;             // Bonus when completed fully

    // Initialize that state of CheckListGoal object
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;       // Set target count
        _bonus = bonus;         // Set bonus 
        _amountCompleted = 0;   // Start at zero completions
    }


    public override int RecordEvent()
    {
        if (_amountCompleted >= _target)
        { 
            // Prevent over scoring
            return 0;
        }
        _amountCompleted++;  // Increase completion count

        if (_amountCompleted == _target)
        {
            return _points + _bonus;    // final bonus
        }
        return _points;     // Otherwise normal points
    }


    public override bool IsComplete() =>
        _amountCompleted >= _target;   // Complete if target reached

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation() =>
        $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
}