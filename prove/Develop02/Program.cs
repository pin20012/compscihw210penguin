using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {


        //Calls the GetRandomPrompt from the Promptgenerator class to get a random prompt
        string randomPrompt = Promptgenerator.GetRandomPrompt();
        //Calls the GetDte from the Entry class to get the current date
        string currentDate = Entry.GetDate();
        //
        // Entry currentEntry = new Entry();

        List<Entry> _entries = new List<Entry>();

        int userNumber = -1;

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

            // MENU OPTION 1
            if (userNumber == 1)
            {
                Console.Write($"{randomPrompt}");
                string response = Console.ReadLine();

                Entry.WholeEntry(currentDate, randomPrompt, "");

                Entry currentEntry = new Entry();
                currentEntry._date = currentDate;
                currentEntry._prompt = randomPrompt;
                currentEntry._lastEntry = response;


                _entries.Add(currentEntry);

            }
            if (userNumber == 2)
            {
                foreach (Entry entry in _entries)
                {
                    entry.DisplayEntry();
                }
            }
            if (userNumber == 3)
            {
                Console.Write($"What is the name of the file: ");
                string loadFileName = Console.ReadLine();

                _entries = Load.LoadEntry(loadFileName);
            }
            if (userNumber == 4)
            {
                Console.WriteLine($"What is the file name? ");
                string saveFileName = Console.ReadLine();

                Save.SaveEntry(saveFileName, _entries);
            }
        }

    }
}