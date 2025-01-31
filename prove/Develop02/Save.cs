using System;
using System.IO;

public class  Save
{
    public static void SaveEntry(string fileName, List<Entry> entries)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._lastEntry}");
            }
        }
    }
}