using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A: 100-90");
        Console.WriteLine("B: 90-80");
        Console.WriteLine("C: 80-70");
        Console.WriteLine("D: 70-60");
        Console.WriteLine("F: 60-0");

        Console.Write("What is your grade percentage (ex. 97)? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        string letter = "";

        if (gradePercentage >= 90)
        
        {
            letter = "A";
        }
        
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }

        else if (gradePercentage >= 70)
        {
            letter = "C";
        }

        else if (gradePercentage >= 60)
        {
            letter = "D";
        }

        else if (gradePercentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"You received letter grade: {letter}");

        // if they passed or didn't pass the class
        if (gradePercentage >=70)
        {
            Console.WriteLine("Congrats! You passed the class!!");
        }
        else if (gradePercentage < 60)
        {
            Console.WriteLine("You didn't pass the class! Better luck next time!");
        }
    }

}