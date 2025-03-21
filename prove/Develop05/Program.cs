using System;
using System.IO; 

// To exceed requirements I decided to give a user a level based on their score.
// Lines 154 - 162 give a description and the code to represent a user level

class Program
{

    static void Main(string[] args)
    {
        int userNumber = -1;

        List<Goal> _assembledGoals = new List<Goal>();
        
        int _totalScore = 0;

        int _level = 0;

        // virtual int UpdatedScore()
        // {
        //     _totalScore += score
        // }

        while (userNumber != 6)
        {

           Console.WriteLine();
            Console.WriteLine($"You have {_totalScore} points");
            Console.WriteLine($"Current level: level {_level}");
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string userAction = Console.ReadLine();
            userNumber = int.Parse(userAction);

            if (userNumber == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"The Types of goals are: ");
                Console.WriteLine($"1. Simple Goal");
                Console.WriteLine($"2. Eternal Goal");
                Console.WriteLine($"3. Checklist Goal");
                Console.Write($"Which type of goal would you like to create? ");
                string userGoaltype = Console.ReadLine();
                int goalType = int.Parse(userGoaltype);

                if (goalType == 1)
                {
                    Goal g1 = new Goal();
                    g1.CreateGoal();

                    _assembledGoals.Add(g1);
                }
                
                if (goalType == 2)
                {
                    Eternal e1 = new Eternal();
                    e1.CreateGoal();

                    _assembledGoals.Add(e1);
                }
                if (goalType == 3)
                {
                    Checklist c1 = new Checklist();
                    c1.CreateGoal();

                    _assembledGoals.Add(c1);
                }
            }

            if (userNumber == 2)
            {
                Console.WriteLine();
                Console.WriteLine($"The goals are: ");
                // ChatGPT reminded me to list the goals. I learned
                // this in the past but had forgotten.
                int count = 1;

                foreach (Goal g in _assembledGoals)
                {
                    Console.WriteLine($"{count}. {g}");
                    count++;
                }
            }

            if (userNumber == 3)
            {
                Console.WriteLine();
                Console.Write($"What is the file name for the goal file? ");
                string saveFileName = Console.ReadLine();

                File.SaveGoal(saveFileName, _assembledGoals, _totalScore);
            }

            if (userNumber == 4)
            {
                Console.Write($"What is the name of the file: ");
                string loadFileName = Console.ReadLine();

                _assembledGoals = File.LoadGoal(loadFileName, out _totalScore);
            }

            if (userNumber == 5)
            {
                Console.WriteLine();
                Console.WriteLine($"The goals are: ");
                // ChatGPT reminded me to list the goals. I learned
                // this in the past but had forgotten.
                int count = 1;

                foreach (Goal g in _assembledGoals)
                {
                    Console.WriteLine($"{count}. {g}");
                    count++;
                }
                
                Console.Write($"Which goal did you accomplish? ");
                string userAccomplishedGoal = Console.ReadLine();

                // I learned about this code. Of the if statement the first part tries to see
                // if the user input is even a number. The second part of the if
                // starting with the && checks if the number is a valid number.
                if (int.TryParse(userAccomplishedGoal, out int accomplishedGoalNumber) && accomplishedGoalNumber >= 1 && accomplishedGoalNumber <= _assembledGoals.Count)
                {
                    // The following code gets the right number and then the total
                    // score is updated.
                    Goal finishedGoal = _assembledGoals[accomplishedGoalNumber - 1];

                    _totalScore += finishedGoal.Completed();

                    // every 200 points a user can level up
                    // I originally did multiple if statements to check how many points a user
                    // had. Depending on how many points they had determined their current level
                    // I asked chatGpt for a more simple way to do this. So instead, the level is
                    // calculated this way: the current score is divided by 200 and then 1 is added.
                    // So a user that has 75 or 125 points would be level 1. A level 2 user would
                    // have to have over 200 points but less than 400.
                    _level = (_totalScore / 200) + 1;
                    Console.WriteLine($"Current level: {_level}");

                    Console.WriteLine();
                }
            }
        }
    }
}