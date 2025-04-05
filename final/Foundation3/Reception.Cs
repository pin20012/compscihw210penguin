using System;
using System.IO;

public class Reception : Event
{
    // Attributes
    private string _email;
    
    // Constructor
    public Reception(string eventTitle, string description, string eventDate, string eventTime, string address, string email) : base (eventTitle, description, eventDate, eventTime, address)
    {
        _email = email;
    }

    // Methods
    public override string FullDetails()
    {
        return $"Type: Reception \n{_eventTitle}\n{_description}\n{_eventDate}\n{_eventTime}\n{_address}\nRSVP Email: {_email}";
    }

    public override string ShortDescription()
    {
        return $"Type: Reception \n{_eventTitle}\n{_eventDate}";
    }
}
// Receptions, which require people to RSVP, or register, beforehand.