using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Lecture Event
        Address a1 = new Address("458 Cherry Hill", "Casper", "Wyoming", "81112", "United States");
        Lecture l1 = new Lecture("Getting an Internship", "The best strategies to get an internship fast", "April 25, 2025", "3:00 PM", a1.GetAddress(), "John Johnson", 215);
       
        Console.WriteLine();
        Console.WriteLine($"========================================");
        Console.WriteLine($"               Lecture                  ");
        Console.WriteLine($"========================================");
        Console.WriteLine($"Full details: ");
        Console.WriteLine(l1.FullDetails());
        Console.WriteLine();
        Console.WriteLine($"Standard details: ");
        Console.WriteLine(l1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine($"Short Description: ");
        Console.WriteLine(l1.ShortDescription());

        //Reception Event
        Address a2 = new Address("5902 Channing Avenue", "Fort Lauderale", "Florida", "28182", "United States");
        Reception r1 = new Reception($"VHS End of School Year Banquet", "Verlander High Schol Banquet for Seniors", "May 24, 2025", "6:30 PM", a2.GetAddress(), "vrankor@gmail.com");
        
        Console.WriteLine();
        Console.WriteLine($"========================================");
        Console.WriteLine($"              Reception                 ");
        Console.WriteLine($"========================================");
        Console.WriteLine($"Full details: ");
        Console.WriteLine(r1.FullDetails());
        Console.WriteLine();
        Console.WriteLine($"Standard details: ");
        Console.WriteLine(r1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine($"Short Description: ");
        Console.WriteLine(r1.ShortDescription());

        //Outdoor Event
        Address a3 = new Address("59 Hemmingway Avenue", "Fort Worth", "Texas", "34241", "United States");
        Outdoor o1 = new Outdoor($"Fort Worth Farmer's Market", "Many food vendors will be there selling their products", "April 17, 2025", "10 AM - 4 PM", a3.GetAddress(), "Sunny with a high of 82°F");
        
        Console.WriteLine();
        Console.WriteLine($"========================================");
        Console.WriteLine($"                Outdoor                  ");
        Console.WriteLine($"========================================");
        Console.WriteLine($"Full details: ");
        Console.WriteLine(o1.FullDetails());
        Console.WriteLine();
        Console.WriteLine($"Standard details: ");
        Console.WriteLine(o1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine($"Short Description: ");
        Console.WriteLine(o1.ShortDescription());
    }
}