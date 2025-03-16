using System;
using System.IO; 

public class Eternal : Goal
{
    private string _notusedyet;

    public Eternal()
    {

    }

    public Eternal(string goal, int score, string description, bool status) : base (goal, score, description, status)
    {
        
    }

    public override string SaveString()
    {
        return $"Eternal Goal:,{_goal},{_description},{_score}";
    }
}