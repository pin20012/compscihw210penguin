// using System;
// using System.IO; 

// public class File
// {
// public static List<Goal> LoadGoal(string fileName)
//     {
//         string[] lines = System.IO.File.ReadAllLines(fileName);

//         List<Goal> goals = new List<Goal>();

//         foreach (string line in lines)
//         {
//             string[] parts = line.Split(",");

//             Goal currentEntry = new Goal();
//             currentEntry._date = parts[0];
//             currentEntry._prompt = parts[1];
//             currentEntry._lastEntry = parts[2];
//             currentEntry._quote = parts[3];

//             entries.Add(currentEntry);
//         }
//         return entries;
//     }
// }