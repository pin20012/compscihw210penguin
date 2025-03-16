 using System;
using System.IO; 

public class Checklist : Goal
{
    private int _times;
    private int _bonus;

    private int _timesCompleted = 0;

    public Checklist()
    {

    }

    public Checklist(string goal, int score, string description, bool status, int times, int bonus, int timesCompleted) : base (goal, score, description, status)
    {
        _times = times;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public override string ToString()
    {
        return $"[] {_goal} ({_description})  -- Currently completed: {_timesCompleted}/{_times}";
    }

    public override string SaveString()
    {
        return $"Checklist Goal:,{_goal},{_description},{_score},{_bonus},{_times},{_timesCompleted} ";
    }

    public override string CreateGoal()
    {
        Console.Write($"What is the name of your goal? ");
        _goal = Console.ReadLine();

        Console.Write($"What is a short description of your goal? ");
        _description = Console.ReadLine();

        Console.Write($"What is the amount of points associated with this goal? ");
        _score = int.Parse(Console.ReadLine());

        Console.Write($"How many times does this goal need to be completed to earn a bonus? ");
        _times = int.Parse(Console.ReadLine());

        Console.Write($"What is the bonus for accompishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());

        string assembledGoal = ($" [] {_goal} ({_description})  -- Currently completed: 0/{_times}");

        return assembledGoal.ToString();
    }   
}