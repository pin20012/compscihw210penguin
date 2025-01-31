using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Entry

{
    // attributes
    public string _lastEntry;
    
    public string _prompt;

    public string _date;
    // behavior

    public static string GetDate()
    { 
        // url taught me how to get the current date: https://www.geeksforgeeks.org/c-sharp-program-to-display-date-in-string/
         string _date = DateTime.Now.ToString("MM/dd/yyyy");
         Console.WriteLine(_date);
         return _date;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} {_prompt}\n{_lastEntry}");                                                                                                                       
    }

    public static string WholeEntry(string _date, string prompt, string _lastEntry)
    {
        string _entry1 = $"{_date} {prompt}\n{_lastEntry}";
        return _entry1;
    }
}