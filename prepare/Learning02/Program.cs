using System;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();
    job1._jobTitle = "Software Engineer";
    job1._company = "Microsoft";
    job1._startYear = 2019;
    job1._endYear = 2022;
    
    Job job2 = new Job();
    job2._jobTitle = "Electrical Engineer";
    job2._company = "Apple";
    job2._startYear = 2022;
    job2._endYear = 2023;

    Resume currentResume = new Resume();
    currentResume._name = "Jack Johns";

    currentResume._jobs.Add(job1);
    currentResume._jobs.Add(job2);

    currentResume.Display();
    }
}