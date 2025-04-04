using System;
using System.IO;

public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double length, double speed, string activityType) : base(date, length, activityType)
    {
        _speed = speed;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Distance()
    {
        return _speed * (_length / 60);
    }

    //overide the pace for this class then work on the swimming class
    public override double Pace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min) - Distance {Math.Round(Distance(), 2)} miles, Speed {Speed()} mph, Pace: {Math.Round(Pace(), 2)} min per mile";
    }

    public override string ActivityType()
    {
        _activityType = "Cycling";
        return _activityType;
    }
}