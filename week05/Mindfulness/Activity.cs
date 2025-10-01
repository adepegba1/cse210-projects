using System;

public class Activity
{
    // These are private fields (variables) that belong to the Activity class
    // _name stores the name of the activity
    // _description stores what the activity is about
    // _duration stores how long the activity will last (in seconds)
    private string _name;
    private string _description;
    private int _duration;

    // Constructor: runs when you create a new Activity object.
    // It requires a name and a description for the activity.
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // This method shows a welcome message to the user,
    // explains the activity, and asks how long they want it to run.
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        // Reads input from the user, converts it into an integer, and saves it in _duration
        _duration = int.Parse(Console.ReadLine());

        // Clears the screen to keep things neat
        Console.Clear();

        Console.WriteLine("Get Ready...");

        // Shows a spinner animation for 5 seconds before starting
        ShowSpinner(5);
        Console.WriteLine();
    }

    // This method shows the ending message after the activity is done
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");

        // Show a spinner for a short pause
        ShowSpinner(5);

        // Tell the user how many seconds they completed
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");

        // Show spinner again to give a nice finish
        ShowSpinner(5);
    }

    // This method displays a simple spinner animation for the given number of seconds
    public void ShowSpinner(int seconds)
    {
        // Figure out the time when the spinner should stop
        DateTime endtime = DateTime.Now.AddSeconds(seconds);

        // Create a list of characters to simulate spinning
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        // Keep looping until the endtime is reached
        while (DateTime.Now < endtime)
        {
            // Show each spinner character one after the other
            foreach (string s in spinner)
            {
                Console.Write(s);        // Print spinner character
                Thread.Sleep(500);       // Wait half a second
                Console.Write("\b \b");  // Erase the character
            }
        }
    }

    // This method counts down from a given number to 1 (like a timer)
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);         // Show the current number
            Thread.Sleep(1000);       // Wait for 1 second
            Console.Write("\b \b");   // Erase the number
        }
    }

    // These are "getter methods" that allow other classes to access the private values
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // This helper method calculates the time when the activity should end
    // based on the current time plus the duration
    public DateTime GetEndTime()
    {
        return DateTime.Now.AddSeconds(_duration);
    }
}
