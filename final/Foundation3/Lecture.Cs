using System;
using System.IO;

public class Lecture : Event
{
    private string _speaker;
    private int _limitedCapacity;
    public Lecture(string eventTitle, string description, string eventDate, string eventTime, string address, string speaker, int limitedCapacity) : base (eventTitle, description, eventDate, eventTime, address)
    {
        _speaker = speaker;
        _limitedCapacity = limitedCapacity;
    }

    public override string FullDetails()
    {
        return $"Type: Lecture \n{_eventTitle}\n{_description}\n{_eventDate}\n{_eventTime}\n{_address}\n{_speaker}\n{_limitedCapacity}";
    }

    public override string ShortDescription()
    {
        return $"Type: Lecture\n{_eventTitle}\n{_eventDate}";
    }
}

// Lectures, which have a speaker and have a limited capacity.