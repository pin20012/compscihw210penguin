using System;
using System.IO; 

public class Goal
{
    protected string _goal;
    protected int _score;
    protected string _description;
    protected bool _status;

    public Goal()
    {
    }
    public Goal(string goal, string description, int score, bool status)
    {
        _goal = goal;
        _score = score;
        _description = description;
        _status = status;
    }

// Learned about the ToString() method from chatGPT to help display the goals correctly
    public override string ToString()
    {
        return $"[{Check()}] {_goal} ({_description})";
    }

    public virtual string SaveString()
    {
        return $"Simple Goal:,{_goal},{_description},{_score},{_status}";
    }

    public virtual string CreateGoal()
    {
        
        Console.Write($"What is the name of your goal? ");
        _goal = Console.ReadLine();

        Console.Write($"What is a short description of your goal? ");
        _description = Console.ReadLine();

        Console.Write($"What is the amount of points associated with this goal? ");
        _score = int.Parse(Console.ReadLine());

        string assembledGoal = $" [] {_goal} ({_description}))";

        _status = false;

        return assembledGoal.ToString();
    }

    public int Score()
    {
        return _score;
    }

    // I got some help from chatgpt to get this working
    // Check() returns an X if the status is true
    // This is a ternary operator (condition ? value_if_true : value_if_false).
    // If the status is true, the method returns "X".
    // If the status is false, it returns an empty string ("")
    public virtual string Check()
    {
        return _status ? "X" : "";
    }

    public virtual int Completed()
    {
        if (_status) return 0;
        _status = true;
        return _score;
    }
}