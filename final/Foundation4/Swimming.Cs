using System;
using System.IO;

public class Swimming : Activity
{
    // Attributes
    private double _numberOfLaps;

    // Constructor
    public Swimming(string date, double length, double numberOfLaps, string activityType) : base( date, length, activityType)
    {
        _numberOfLaps = numberOfLaps;
    }

    // Methods
    public override double Distance()
    {
        return (_numberOfLaps * 50) / (1000 * .62);
    }

    public override double Speed()
    {
        return (Distance() / _length) * 60;

    }

    public override double Pace()
    {
        return _length / Distance();
    }

    // I used ChatGPT to remind me how to round doubles to two decimal places using Math.Round(Method(), 2
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length} min) - Distance {Math.Round(Distance(), 2)} miles, Speed {Math.Round(Speed(), 2)} mph, Pace: {Math.Round(Pace(), 2)} min per mile";
    }

    public override string ActivityType()
    {
        _activityType = "Swimming";
        return _activityType;
    }
}