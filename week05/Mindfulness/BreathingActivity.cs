// Import the System namespace so we can use built-in classes like Console and DateTime
using System;


// Define the BreathingActivity class, which inherits from the base Activity class
public class BreathingActivity : Activity
{
    // Constructor: when you create a BreathingActivity, it automatically passes
    // a name ("Breathing") and a description to the parent (Activity) class
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    // The Run method contains the actual logic of what happens when this activity is started
    public void Run()
    {
        // Show the starting message from the base Activity class (welcome, description, ask duration)
        DisplayStartingMessage();

        // Calculate the time when the activity should end, based on the duration entered by the user
        DateTime endtime = GetEndTime();

        // Keep looping until the current time reaches the end time
        while (DateTime.Now < endtime)
        {
            // Display "Breathe In..." and count down from 6 seconds
            Console.Write($"Breathe In ...");
            ShowCountDown(6);

            // Move to the next line
            Console.WriteLine();

            // Display "Breathe Out..." and count down from 6 seconds
            Console.Write($"Breathe Out ...");
            ShowCountDown(6);

            // Add an extra blank line for spacing
            Console.WriteLine("\n");
        }

        // Show the ending message from the base Activity class (congratulations message)
        DisplayEndingMessage();
    }
}
