using System;

class Program

// STRETCH CHALLENGE: try to randomly select from only 
// those words that are not already hidden. I added code to
// be able to hide words that are not already hidden
{
    static void Main(string[] args)
    {
        // Holds user input
        string userInput = "";

        // Gets the reference and displays it to the screen
        Reference ref1 = new Reference();
        Console.WriteLine(ref1.getRef());

        // Makes the scripture and then displays it to the screen
        Scripture myScripture1 = new Scripture();
        myScripture1.MakeScripture();
        myScripture1.DisplayScripture();

        // While loop that continues until the user types 'quit'
        while (userInput != "quit")
        {

            // allow the user to press enter or type 'quit' to exit the program
            Console.Write($"Press enter to continue or type 'quit' to finish: ");

            // reads input from the console
            userInput = Console.ReadLine();
            //if loop that hides 3 words from the console if the user presses enter
            if (userInput == "")
            {
                // clears the console; I did a google search for how to clear the console.
                Console.Clear();

                // hides 3 words from the scripture
                myScripture1.HideWord();
                myScripture1.HideWord();
                myScripture1.HideWord();
                // displays the scripture
                myScripture1.DisplayScripture();

                // if all the words are hidden, then the program ends
                if (myScripture1.HideWord() == true)
                {
                    break;
                }
            }
        }
    }
}