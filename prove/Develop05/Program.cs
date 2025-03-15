using System;

class Program
{

    static void Main(string[] args)
    {
        string userInput = "";

        int userNumber = -1;

        List<Goal> _assembledGoals = new List<Goal>();
        List<int> _scores = new List<int>();

        while (userNumber != 6)
        {

            Console.WriteLine();
            Console.WriteLine($"You have 0 points");
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
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
                userNumber = int.Parse(userGoaltype);

                if (userNumber == 1)
                {
                    Goal g1 = new Goal();
                    g1.CreateGoal();

                    _assembledGoals.Add(g1);
                }
                
                if (userNumber == 2)
                {
                    Console.WriteLine();
                }
                if (userNumber == 3)
                {
                    Console.WriteLine($"");
                }
            }

            if (userNumber == 2)
            {
                Console.WriteLine($"The goals are: ");
                foreach (Goal g in _assembledGoals)
                {
                    Console.WriteLine($"goal: {g}");
                }
            }
        }
    }
}