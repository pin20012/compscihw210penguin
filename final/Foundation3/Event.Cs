using System;
using System.IO;

public class Event
{
    private string _eventTitle;
    private string _description;
    private  DateTime _eventDate;
    private TimeSpan _eventTime;
    private string _address;

    // Standard details - Lists the title, description, date, time, and address.
    public string StandardDetails()
    {

    }

    // Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
    public string FullDetails()
    {

    }

    // Short description - Lists the type of event, title, and the date.
    public string ShortDescription()
    {
        
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