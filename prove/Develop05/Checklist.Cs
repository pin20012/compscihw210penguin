 using System;
using System.IO; 

public class Checklist : Goal
{
    private int _bonus;
    private int _times;

    private int _timesCompleted = 0;

    public Checklist()
    {

    }

    public Checklist(string goal, string description, int score, int bonus, int times, int timesCompleted) : base (goal, description, score, false)
    {
        _times = times;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public override string ToString()
    {
        return $"[{Check()}] {_goal} ({_description})  -- Currently completed: {_timesCompleted}/{_times}";
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

        string assembledGoal = $" [] {_goal} ({_description})  -- Currently completed: 0/{_times}";

        return assembledGoal.ToString();
    }

    public int TimesLeft()
    {
        _times -= 1;
        return _times;
    }

    // this checks if a checklist goal has been all the way completed
    public override int Completed()
    {
        if (_status) 
            return 0;
        
        _timesCompleted += 1;

        if (_timesCompleted != _times) 
            return _score;

        _status = true;
        return _score + _bonus;
    }
}