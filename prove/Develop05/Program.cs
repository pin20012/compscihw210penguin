using System;

class Program
{

    static void Main(string[] args)
    {
        string userInput = "";

        int userNumber = -1;

        List<Goal> _assembledGoals = new List<Goal>();
        
        int _totalScore = 0;

        while (userNumber != 6)
        {

            Console.WriteLine();
            Console.WriteLine($"You have {_totalScore} points");
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

                _assembledGoals = File.LoadGoal(loadFileName, out int totalScore);
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
            }
        }
    }
}