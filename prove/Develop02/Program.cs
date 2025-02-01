using System;
using System.IO;

//The Program class is the main class of the whole program
// To exceed requirements I created another variable in the journal which is _quote. A user can now enter a quote into their journal if they would like.
class Program
{
    static void Main(string[] args)
    {


        //Calls the GetRandomPrompt from the Promptgenerator class to get a random prompt
        string randomPrompt = Promptgenerator.GetRandomPrompt();
        //Calls the GetDte from the Entry class to get the current date
        string currentDate = Entry.GetDate();
        // creates a new instance list for a list called _entries
        List<Entry> _entries = new List<Entry>();

        int userNumber = -1;
        // While user number is not equal to 5 then then the program will keep running
        while (userNumber != 5)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? Enter a number from 1-5: ");
            string userAction = Console.ReadLine();
            userNumber = int.Parse(userAction);

            // 1. Write
            if (userNumber == 1)
            {
                Console.Write($"{randomPrompt}");
                string response = Console.ReadLine();

                Console.Write("What is your quote of the day: ");
                string userQuote = Console.ReadLine();

                Entry.WholeEntry(currentDate, randomPrompt, "", "");

                Entry currentEntry = new Entry();
                currentEntry._date = currentDate;
                currentEntry._prompt = randomPrompt;
                currentEntry._lastEntry = response;
                currentEntry._quote = userQuote;


                _entries.Add(currentEntry);

            }
            // 2. Display
            if (userNumber == 2)
            {
                foreach (Entry entry in _entries)
                {
                    entry.DisplayEntry();
                }
            }
            // 3. Load
            if (userNumber == 3)
            {
                Console.Write($"What is the name of the file: ");
                string loadFileName = Console.ReadLine();

                _entries = Load.LoadEntry(loadFileName);
            }
            // 4. Save
            if (userNumber == 4)
            {
                Console.WriteLine($"What is the file name? ");
                string saveFileName = Console.ReadLine();

                Save.SaveEntry(saveFileName, _entries);
            }
        }

    }
}