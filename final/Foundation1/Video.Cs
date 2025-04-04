using System;
using System.IO;

public class Video
{
    private string _title;

    private string _author;

    private int _length;

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    
    public void DisplayVideo()
    {
        Console.WriteLine($"Video: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length} seconds");
    }

}