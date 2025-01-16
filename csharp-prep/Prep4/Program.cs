using System;
using System.Collections.Generic;
using System.Linq;

class Program

// code adds numbers to a list until user is done. When done
// when done, user types a 0
// then the code finds the sum, average of the numbers, and finds the largest number
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        //ask user for numbers and ask user to type 0 when done. Add these numbers to a list
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers. When done enter 0. ");
            string userN = Console.ReadLine();
            userNumber = int.Parse(userN);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //sum
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }

        Console.WriteLine($"Sum: {sum}");

        //average
        int numberCount = numbers.Count();
            int average = sum / numberCount;

        Console.WriteLine($"average: {average}");

        //largest number

        int largestNumber = numbers[0];

        foreach (int i in numbers)
        {
            if (i > largestNumber)
            { 
                largestNumber = i;
            }

        }
        Console.WriteLine($"Largest Number: {largestNumber}");
    }
}