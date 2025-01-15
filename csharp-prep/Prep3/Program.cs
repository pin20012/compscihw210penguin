using System;

class Program
{
    static void Main(string[] args)
    {
        //gets the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int guess = -1;

        while (guess != magicNumber)
        {
            // gets the user's guess
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}