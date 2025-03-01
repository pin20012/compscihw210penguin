using System;

public class Activity
{
    //attributes
    private string _activityName;
    private string _description;
    private int _duration;

    //methods

    public Activity()
    {
    }
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayWelcome(string activityName, string description)
    {
        _activityName = activityName;
        Console.WriteLine($"Welcome to the {activityName}!");
        Console.WriteLine();

        _description = description;
        Console.WriteLine(description);
        Console.WriteLine();
    }

    public int UserTimeRequest()
    {
        
        Console.Write("How long, in seconds would you like for your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
        return _duration;
    }

    public void DisplayExit(string activityName, int duration)
    {
        _activityName = activityName;
        _duration = duration;
        
        Console.WriteLine();
        Console.WriteLine($"Well done!");
        Spinner();

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
        Spinner();

        Console.Clear();
    }

    public void Spinner()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void LongerSpinner()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void Countdown()
    {
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
    }
}