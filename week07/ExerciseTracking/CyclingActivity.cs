using System;

public class CyclingActivity : Activity
{
    // Private member variable; Speed in mph
    private double _speed;

    // Constructor 
    public CyclingActivity(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // Distance = (speed * GetMinutes())/60
    public override double GetDistance() =>
        (_speed * GetMinutes()) / 60;

    // Speed is already Known
    public override double GetSpeed() => _speed;

    // Pace = 60/speed
    public override double GetPace() => 60 / _speed;

}