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
    public Goal(string goal, int score, string description, bool status)
    {
        _goal = goal;
        _score = score;
        _description = description;
        _status = status;
    }

// Learned about the ToString() method from chatGPT to help display the goals correctly
    public override string ToString()
    {
        return $"[] {_goal} ({_description})";
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
}