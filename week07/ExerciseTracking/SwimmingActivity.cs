using System;

public class SwimmingActivity : Activity
{

    private int _laps;



    // Constructor
    public SwimmingActivity(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }


    // Distance in miles
    public override double GetDistance() =>
        // meters = laps * 50
        // km = meters / 1000
        // miles = km * 0.62
        (_laps * 50 / 1000.0) * 0.62;


    public override double GetSpeed() =>
        (GetDistance() / GetMinutes()) * 60;

    public override double GetPace() =>
        GetMinutes() / GetDistance();


}