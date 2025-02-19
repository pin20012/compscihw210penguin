using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simpleAssignment = new Assignment("Jonn Doe", "Math");
        Console.WriteLine(simpleAssignment.GetSummary());

        MathAssignment ma1 = new MathAssignment("Logan Thomas", "Math", "3.4", "4-20 odd");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());

        WritingAssignment wa1 = new WritingAssignment("Steven Stone", "Computer Science", "Learning the principle of Encapsulation");
        Console.WriteLine(wa1.GetSummary());
        Console.WriteLine(wa1.GetWritingInformation());

    }
}