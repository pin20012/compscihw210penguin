using System;

class Program
{
    static void Main(string[] args)
    {   
        // Holds user input
        string userInput = "";

        int userNumber = -1;

        while (userNumber != 4)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userAction = Console.ReadLine();
            userNumber = int.Parse(userAction);


            // 1. Start Breathing Activity
            if (userNumber == 1)
            {
                Console.Clear();

                Activity welcome1 = new Activity();
                welcome1.DisplayWelcome("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                
                Activity timerequest1 = new Activity();
                int duration = timerequest1.UserTimeRequest();
                
                Console.Clear();
                
                //Breathing exercise
                Console.WriteLine($"Get Ready...");
                Activity spin1 = new Activity();
                spin1.Spinner();

                Console.WriteLine();

                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(duration);

                DateTime currentTime = DateTime.Now;
                while (currentTime < futureTime)
                {
                    Breathe breathe1 = new Breathe();
                    breathe1.LoopBreath();

                    currentTime = DateTime.Now;
                }

                Activity exit1 = new Activity();
                exit1.DisplayExit("The Breathing Activity", duration);

            }
            
            // 2. Start Reflecting Activity
             if (userNumber == 2)
            {
                Console.Clear();

                Activity welcome2 = new Activity();
                welcome2.DisplayWelcome("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                
                Activity timerequest2 = new Activity();
                int duration2 = timerequest2.UserTimeRequest();

                Console.Clear();
                
                //Reflecting Activity
                Console.WriteLine($"Get Ready...");
                Activity spin2 = new Activity();
                spin2.Spinner();

                DateTime startTime2 = DateTime.Now;
                DateTime futureTime2 = startTime2.AddSeconds(duration2);


                DateTime currentTime2 = DateTime.Now;
                
                Console.WriteLine();
                Console.WriteLine($"Consider the following prompt: ");

                Console.WriteLine();
                Console.WriteLine(Reflection.RandomPrompt());

                Console.Write($"When you have something in mind press enter: ");

                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Now ponder on each of the following questions as they related to this experience.");
                    Console.Write("You may begin in...");
                    Activity countdown1 = new Activity();
                    countdown1.Countdown();

                    Console.Clear();
                    
                    while (currentTime2 < futureTime2)
                    {
                        Console.Write($"> {Reflection.RandomQuestion()}");
                        Console.WriteLine();
                        Activity longspin1 = new Activity();
                        longspin1.LongerSpinner();

                        currentTime2 = DateTime.Now;
                    }

                    Console.WriteLine();
                    Activity exit2 = new Activity();
                    exit2.DisplayExit("The Reflecting Activity", duration2);
                }

            }

             //3. Start Listing Activity
            if (userNumber == 3)
            {
                Console.Clear();

                Activity welcome3 = new Activity();
                welcome3.DisplayWelcome("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                
                Activity timerequest3 = new Activity();
                int duration3 = timerequest3.UserTimeRequest();

                Console.Clear();
                
                //Listing exercise
                Console.WriteLine($"Get Ready...");
                Activity spin3 = new Activity();
                spin3.Spinner();

                DateTime startTime3 = DateTime.Now;
                DateTime futureTime3 = startTime3.AddSeconds(duration3);

                Console.WriteLine();
                Console.WriteLine($"List as many responses as you can to the following prompt: ");
                Console.WriteLine(ListingActivity.RandomPrompt());

                Console.Write("You may begin in... ");
                Activity countdown2 = new Activity();
                countdown2.Countdown();

                Console.WriteLine();

                DateTime currentTime3 = DateTime.Now;
                while (currentTime3 < futureTime3)
                {
                    Console.Write($"> ");
                    Console.ReadLine();

                    currentTime3 = DateTime.Now;
                }

                Activity exit3 = new Activity();
                exit3.DisplayExit("The Listing Activity", duration3);
            }
        }
    }
}