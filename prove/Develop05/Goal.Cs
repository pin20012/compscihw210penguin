using System;
using System.IO; 

public class Goal
{
    private string _goal;
    private int _score;
    private string _description;
    private bool _status;

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

    public string CreateGoal()
    {
        
        Console.Write($"What is the name of your goal? ");
        _goal = Console.ReadLine();

        Console.Write($"What is a short description of your goal? ");
        _description = Console.ReadLine();

        Console.Write($"What is the amount of points associated with this goal? ");
        _score = int.Parse(Console.ReadLine());

        string assembledGoal = $" [] {_goal} ({_description}))";

        return assembledGoal;
    }
}