using System;

public class RunningActivity : Activity
{
    // private member variable specific to Running
    // Distance in miles
    private double _distance;

    // Constructor
    public RunningActivity(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    

    public override double GetSpeed() =>
        (_distance / GetMinutes()) * 60;


    public override double GetPace() =>
        GetMinutes() / _distance;
    
}