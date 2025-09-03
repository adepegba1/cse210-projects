/// Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
/// Once you have a list, have your program do the following:
/// Compute the sum, or total, of the numbers in the list.
/// Compute the average of the numbers in the list.
/// Find the maximum, or largest, number in the list.
/// Once the basic functionality is working, allow the user to enter both both positive and negative numbers, 
/// then find the smallest positive number (the positive number that is closest to zero).
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {

        // creating an empty list called numbers
        List<int> numbers = new List<int>();

        // intializing the total and max value to 0
        float total = 0;
        int max = 0;
        int min = 999999999;

        // Printing out the instruction of the code
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Always enter the loop to perform operations
        while (true)
        {
            // printing the enter a number and waiting for the user to enter a number
            Console.Write("Enter a number: ");
            // read the number and save it to a string
            string userString = Console.ReadLine();
            // convert the string to an integer value
            int userNumber = int.Parse(userString);

            // if the number entered is 0, stop the loop
            if (userNumber == 0)
            {
                break;
            }
            // otherwise perform this block of code
            else
            {
                // add the number to the existing list
                numbers.Add(userNumber);
                // adding the value to the total variable
                total += userNumber;
                // getting the maximun value
                if (userNumber > max)
                {
                    max = userNumber;
                }
                // Getting the mininum value greater than 0
                if (userNumber > 0 && userNumber < min)
                {
                    min = userNumber;
                }
            }
        }
        // calculate the average of the list
        float average = total / numbers.Count;
        Console.WriteLine($"The sum is : {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");

        // sorting the list
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}