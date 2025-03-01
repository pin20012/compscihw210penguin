using System;

public class ListingActivity: Activity
{
    //Methods
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    public static string RandomPrompt()
    {
        List<string> _promptList = new List<string> {"", 
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"};

        Random rand = new Random();

        int randIndex = rand.Next(_promptList.Count);

        string randprompt = _promptList[randIndex];
        return randprompt;
    }
}