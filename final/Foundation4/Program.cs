using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running r1 = new Running("05 Jun 2025", 30.7, 5.6);
        _activities.Add(r1);

        Cycling c1 = new Cycling("06 Jun 2025", 30.1, 10.5);
        _activities.Add(c1);
        
        Swimming s1 = new Swimming("07 Jun 2025", 30.4, 4.5);
        _activities.Add(s1);

        foreach (Activity a in _activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}

// Program Specification
// Once you have the classes in place, write a program that creates at least one activity of each type. 
// Put each of these activities in the same list. Then iterate through this list and call the GetSummary method on each item and display the results.
