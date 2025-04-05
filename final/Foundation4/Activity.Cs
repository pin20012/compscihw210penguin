using System;
using System.IO;

public class Activity
{
    // Attributes
    protected string _date;
    protected double _length;
    protected string _activityType;

    // Constructor
    public Activity(string date, double length, string activityType)
    {
        _date = date;
        _length = length;
        _activityType = activityType;
    }

    // Methods Found Below

    // The distance
    // In either case the length of a lap in the lap pool is 50 meters.
    // Math Hints:
    // Distance (km) = swimming laps * 50 / 1000
    // Distance (miles) = swimming laps * 50 / 1000 * 0.62
    public virtual double Distance()
    {
        return 0;
    }

    // The speed (miles per hour or kilometers per hour)
    // Math Hints:
    // Speed (mph or kph) = (distance / minutes) * 60
    // Speed = 60 / pace
    public virtual double Speed()
    {
        return 0;
    }
    // The pace (minutes per mile or minutes per kilometer)
    // Math Hints:
    // Pace (min per mile or min per km)= minutes / distance
    // Pace = 60 / speed
    public virtual double Pace()
    {
        return 0;
    }

    // A summary in the form of:
    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
    // Use either km or miles: program doesn't need to handle both
    // Finally, you should provide a GetSummary method to produce a string with all the summary information.
    // Remember that the summary method can make use of the other methods to produce its result. This method should be available for all classes, so it should be defined in the base class (you can override it in the derived classes if needed, but it may not need to be...).
    public virtual string GetSummary()
    {
        return $"{_date} Running ({_length} min) - Distance {Distance()} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile";
    }

    public virtual string ActivityType()
    {
        _activityType = "Running";
        return _activityType;
    }
}

// Running
// Stationary Bicycles
// Swimming in the lap pool
// For each activity, they want to track the the date and the length of the activity in minutes. Then, for each activity, they would like to also track the following:

// Running: distance
// Cycling: speed
// Swimming: number of laps
// For each activity, they do not want to store this information, but they would like to be able to get following information (by calculation if it is not stored directly):

// You may choose if your program uses miles or kilometers (you do not need to handle both). In either case the length of a lap in the lap pool is 50 meters.