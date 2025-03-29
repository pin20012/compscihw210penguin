using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        DateTime myDate = new DateTime(2025, 3, 22); // A specific date
        TimeSpan myTime = new TimeSpan(14, 30, 0);   // A specific time (2:30 PM)

        Console.WriteLine($"{myDate} {myTime}");

    }
}