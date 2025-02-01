using System;
using System.Collections.Generic;

public class Promptgenerator
{

    public static string GetRandomPrompt()
    {
    // This url reminded me how to make a list: https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-in-C-Sharp/
    List<string> _prompts = new List<string> {"What was your favorite part of the day? ", "What was your favorite activity you did today? ", 
    "What is something you are grateful for? ", "What is something you accomplished today? ", "What challenges are you facing and how can you overcome them? ", "Who was the most interesting person I interacted with today? ",
"What was the best part of my day? ", "How did I see the hand of the Lord in my life today? ", "What was the strongest emotion I felt today? ", "If I had one thing I could do over today, what would it be? "};

    // This url helped me learn how to get a random prompt from a list: https://www.quora.com/How-can-I-make-a-list-of-many-strings-in-C-and-choose-a-random-one-to-write-in-the-console
    // To get a random prompt from the list
    //First: Creat instance of Random
    Random random = new Random();

    // Secondly: random index
    int randomIndex = random.Next(_prompts.Count);

    //Finally Get the random prompt
    string randomPrompt = _prompts[randomIndex];
    Console.WriteLine(randomPrompt);
    return randomPrompt;
    }
}