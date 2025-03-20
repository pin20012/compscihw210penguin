using System;
using System.IO; 

public class File
{
    public static void SaveGoal(string fileName, List<Goal> goals, int _totalScore)
        {

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine($"{_totalScore}");

                foreach (Goal goal in goals)
                {
                    outputFile.WriteLine($"{goal.SaveString()}");
                }
            }
        }

// I got a couple of ideas for how to do the load from ChatGPT that
// was useful like the conditions for the goal type to know how to load
// the file. I wrote the code myself.
    public static List<Goal> LoadGoal(string fileName, out int _totalScore)
        {
            List<Goal> goals = new List<Goal>();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            // Read the total score first
            _totalScore = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                
                string[] parts = lines[i].Split(",");

                string goalType = parts[0];
                if (goalType == "Simple Goal:")
                {
                    goals.Add(new Goal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                }
                else if (goalType == "Eternal Goal:")
                {
                    goals.Add(new Eternal(parts[1], parts[2], int.Parse(parts[3]), false));
                }
                else if (goalType == "Checklist Goal:")
                {
                    goals.Add(new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                }
            }
            return goals;
        }
    }