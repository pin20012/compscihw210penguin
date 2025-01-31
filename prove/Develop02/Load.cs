using System;
using System.IO; 

public class Load
{
public static List<Entry> LoadEntry(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        List<Entry> entries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry currentEntry = new Entry();
            currentEntry._date = parts[0];
            currentEntry._prompt = parts[1];
            currentEntry._lastEntry = parts[2];

            entries.Add(currentEntry);
        }
        return entries;
    }
}