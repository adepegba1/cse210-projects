using System;  
// This line allows the program to use basic C# features like Console and other system utilities.

public abstract class Goal  
// 'abstract' means this class cannot be used to create objects directly.
// Instead, it serves as a base class that other goal types (like SimpleGoal, EternalGoal, etc.) will inherit from.
{
    private string _shortName;      // Stores the short name or title of the goal (e.g., "Run 5K")
    private string _description;    // Stores a short explanation of the goal (e.g., "Complete a 5K marathon")
    private int _points;            // Stores the number of points awarded when the goal is completed

    // Constructor – this method is called when a new goal object is created
    // It takes three parameters: shortName, description, and points, and assigns them to the class variables
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;     // Assigns the value of shortName to the private variable _shortName
        _description = description; // Assigns the value of description to _description
        _points = points;           // Assigns the value of points to _points
    }

    // Getter method that returns the short name of the goal
    public string GetshortName()
    {
        return _shortName;          // Returns the value stored in _shortName
    }

    // Getter method that returns the description of the goal
    public string Getdescription()
    {
        return _description;        // Returns the value stored in _description
    }

    // Getter method that returns the points of the goal
    public int Getpoint()
    {
        return _points;             // Returns the value stored in _points
    }

    // Abstract method – must be defined in any class that inherits from Goal
    // This method will handle what happens when a goal event is recorded (e.g., completing a goal)
    public abstract int RecordEvent();

    // Abstract method – must also be defined in any class that inherits from Goal
    // This method checks whether the goal has been completed
    public abstract bool IsComplete();

    // Virtual method – can be used as-is or overridden by a subclass
    // It returns a formatted string showing the goal details
    public virtual string GetDetailsString()
    {
        return $"[] {_shortName}  ({_description})";  
        // Returns a string with empty brackets ([]) followed by the goal name and description
        // Example output: "[] Run 5K (Complete a 5K marathon)"
    }

    // Abstract method – must be implemented in each subclass
    // It should return a text representation of the goal that can be saved to a file
    public abstract string GetStringRepresentation();
}
