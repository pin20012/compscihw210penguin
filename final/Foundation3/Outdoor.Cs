using System;
using System.IO;

public class Outdoor : Event
{
    //Attributes
    private string _weatherStatement;

    //Constructor
    public Outdoor(string eventTitle, string description, string eventDate, string eventTime, string address, string weatherStatement) : base (eventTitle, description, eventDate, eventTime, address)
    {
        _weatherStatement = weatherStatement;
    }

    //Methods down Below
    public override string FullDetails()
    {
        return $"Type: Outdoor Gathering \n{_eventTitle}\n{_description}\n{_eventDate}\n{_eventTime}\n{_address}\n{_weatherStatement}";
    }

    public override string ShortDescription()
    {
        return $"Type: Outdoor Gathering\n{_eventTitle}\n{_eventDate}";
    }
}

// Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.