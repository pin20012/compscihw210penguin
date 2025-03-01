using System;

public class Breathe : Activity
{
    // Methods

    public Breathe() : base("Breathing Activity", "This activity helps you relax by controlling your breathing.")
    {
    }
    public void LoopBreath()
    {
        Console.Write($"Breathe in...");
        Countdown();

        Console.WriteLine();

        Console.Write($"Now Breathe out...");
        Countdown();

        Console.WriteLine();
    }
}