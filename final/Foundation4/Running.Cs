using System;
using System.IO;

public class Running : Activity
{
    private double _distance;
    public Running(string date, double length, double distance, string activityType) : base(date, length, activityType)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        // return (_distance / _length) * 60;
        return Math.Round((_distance / _length) * 60, 2);
    }

    public override double Pace()
    {
        return Math.Round((_length / _distance), 2);
    }
}