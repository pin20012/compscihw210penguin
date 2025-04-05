using System;
using System.IO;

public class Comment
{
   // Attributes
    private string _name;
    private string _comment;

    // Constructor
    public Comment (string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    // Methods
    public void DisplayCommment()
    {
        Console.WriteLine($"{_name} - {_comment}");
    }
}