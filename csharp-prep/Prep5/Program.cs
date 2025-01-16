using System;

class Program
{
    static void Main(string[] args)
        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        // PromptUserName - Asks for and returns the user's name (as a string)
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        // DisplayResult - Accepts the user's name and the squared number and displays them.
    {
        DisplayWelcome();

        string userN = PromptUserName();

        int favN = PromptUserNumber();

        int sqInteger = SquareNumber(favN);

        DisplayResult(userN, sqInteger);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your user name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number? ");
        string favoriteNumber = Console.ReadLine();
        int favNumber = int.Parse(favoriteNumber);
        return favNumber;
    }

    static int SquareNumber(int integer)
    {
        int sqInteger = integer * integer;
        return sqInteger;
    }

    static void DisplayResult(string userName, int squaredInteger)
    {
        Console.WriteLine($"user name: {userName}");
        Console.WriteLine($"Your number squared is {squaredInteger}");
    }
}