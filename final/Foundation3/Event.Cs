using System;
using System.IO;

public class Event
{
    // Attributes
    protected string _eventTitle;
    protected string _description;
    protected string _eventDate;
    protected string _eventTime;
    protected string _address;

    // Constructor
    public Event(string eventTitle, string description, string eventDate, string eventTime, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _address = address;
    }

    // Methods found below

    // Standard details - Lists the title, description, date, time, and address.
    public string StandardDetails()
    {
        return $"{_eventTitle}\n{_description}\n{_eventDate}\n{_eventTime}\n{_address}";
    }

    // Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
    public virtual string FullDetails()
    {
        return $"{_eventTitle}\n{_description}\n{_eventDate}\n{_eventTime}\n{_address}";
    }

    // Short description - Lists the type of event, title, and the date.
    public virtual string ShortDescription()
    {
        return $"{_eventTitle}\n{_eventDate}";
    }
}

// They need you to write a program to track each of these events and produce the marketing material to distribute on social media.

// Program Specification
// Write a program that has a base Event class along with derived classes for each type of event. These classes should contain the necessary data and provide methods to return strings for each of the messages the company desires.

// Remember that any data or methods that are common among all types of events should be in the base class.

// Once you have the classes in place, write a program that creates at least one event of each type and sets all of their values. Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.

// In addition, your program must:

// Use inheritance to avoid duplicating shared attributes and methods.
// Use an address class for the addresses.
// Follow the principles of encapsulation, making sure each member variable is private.