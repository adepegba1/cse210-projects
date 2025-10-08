using System;  // Import the System namespace, which provides basic functionalities like Console, String, etc.

// Define a class called 'EnternalGoal' that inherits from the base class 'Goal'
public class EnternalGoal : Goal
{
    // Constructor: called when a new EnternalGoal object is created
    // It takes three parameters (shortName, description, and points)
    // and passes them to the base class (Goal) constructor using 'base()'
    public EnternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        // No extra setup is needed for EnternalGoal, so the constructor body is empty
    }

    // This method overrides the RecordEvent method in the base class (Goal)
    // It defines what happens when the user records progress for this goal
    public override int RecordEvent()
    {
        // For an EnternalGoal, you always earn the set number of points each time it’s recorded
        // It doesn’t get completed, so we just return the goal’s points
        return Getpoint();
    }

    // This method overrides GetDetailsString() from the base class
    // It returns a formatted string showing goal details
    public override string GetDetailsString()
    {
        // The "[]" means the goal can be repeated (never marked complete)
        // It shows the goal’s short name and description in parentheses
        return $"[] {GetshortName()} ({Getdescription()})";
    }

    // This method checks if the goal is complete
    public override bool IsComplete()
    {
        // Enternal goals (like daily tasks) never end,
        // so this always returns false to show it’s ongoing
        return false;
    }

    // This method returns a string version of the goal for saving to a file
    public override string GetStringRepresentation()
    {
        // It stores the goal type and its details separated by colons and pipes
        // Example: EnternalGoal:Read Scriptures|Read daily|50
        return $"EnternalGoal:{GetshortName()}|{Getdescription()}|{Getpoint()}";
    }
}
