using System;

public class Entry

{
    // attributes
    public string _lastEntry;
    
    public string _prompt;

    public string _date;

    public string _quote;

    public static string GetDate()
    { 
        // url taught me how to get the current date: https://www.geeksforgeeks.org/c-sharp-program-to-display-date-in-string/
         string _date = DateTime.Now.ToString("MM/dd/yyyy");
         Console.WriteLine(_date);
         return _date;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} {_prompt}\n{_lastEntry}\n{_quote}");                                                                                                                       
    }

    public static string WholeEntry(string _date, string prompt, string _lastEntry, string _quote)
    {
        string _entry1 = $"{_date} {prompt}\n{_lastEntry}\n{_quote}";
        return _entry1;
    }
}