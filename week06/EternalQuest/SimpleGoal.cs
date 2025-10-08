using System;  // This allows us to use basic C# system functions (like Console, etc.)

// Define a class called 'SimpleGoal' that inherits from another class named 'Goal'
public class SimpleGoal : Goal
{
    // A private variable to store whether the goal is completed or not
    private bool _iscomplete;

    // This is the constructor — it runs automatically when a new SimpleGoal is created
    // It takes three parameters: shortName, description, and points
    // It also calls the base class (Goal) constructor to set up the common data
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _iscomplete = false; // When a new goal is created, it starts as not completed
    }

    // This method overrides (replaces) a method from the parent class 'Goal'
    // It marks the goal as completed and returns the number of points earned
    public override int RecordEvent()
    {
        _iscomplete = true;     // The goal is now marked as completed
        return Getpoint();      // Return the number of points from the base class
    }

    // This method tells whether the goal is completed or not
    public override bool IsComplete()
    {
        return _iscomplete;     // Returns true if the goal is done, false otherwise
    }

    // This method returns a formatted string showing goal details and its status
    public override string GetDetailsString()
    {
        string status;  // Variable to hold whether the goal is checked [X] or not []

        // If the goal is complete, show [X]; otherwise, show []
        if (_iscomplete)
        {
            status = "[X]";
        }
        else
        {
            status = "[]";
        }

        // Return a nicely formatted string showing the goal status, name, and description
        return $"{status} {GetshortName()} ({Getdescription()})";
    }

    // This method prepares the goal data as a single line of text for saving to a file
    public override string GetStringRepresentation()
    {
        // The format is: SimpleGoal:Name|Description|Points|IsComplete
        return $"SimpleGoal:{GetshortName()}|{Getdescription()}|{Getpoint()}|{IsComplete()}";
    }

    // This is a helper method that allows another class to change _iscomplete manually
    // (for example, when loading a saved goal from a file)
    public void SetIscomplete(bool a)
    {
        _iscomplete = a;  // Set _iscomplete to the given value (true or false)
    }
}
