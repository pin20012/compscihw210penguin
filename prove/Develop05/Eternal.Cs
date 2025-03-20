using System;
using System.IO; 

public class Eternal : Goal
{
    public Eternal()
    {

    }

    public Eternal(string goal, string description, int score, bool status) : base (goal, description, score, status)
    {
        
    }

    public override string SaveString()
    {
        return $"Eternal Goal:,{_goal},{_description},{_score}";
    }

    public override int Completed()
    {
        return _score;
    }

}