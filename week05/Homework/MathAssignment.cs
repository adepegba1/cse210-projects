// Import the System namespace (provides access to basic .NET features)
using System;

// Define a new class called MathAssignment that inherits from the Assignment class
public class MathAssignment : Assignment
{
    // Declare a private field to store which textbook section the math assignment is from
    private string _textbookSection;

    // Declare a private field to store the specific problems to solve
    private string _problems;

    // This is the constructor method for MathAssignment
    // It takes in 4 parameters: name, topic, textbook section, and problem
    // "base(name, topic)" passes the name and topic to the parent (Assignment) constructor
    public MathAssignment(string name, string topic, string textbooksection, string problem) : base(name, topic)
    {
        // Store the textbook section into the private field _textbookSection
        _textbookSection = textbooksection;
        // Store the problem information into the private field _problems
        _problems = problem;
    }

    // A method to return formatted homework details
    public string GetHomeworkList()
    {
        // It returns a string showing which section and problem numbers the student must complete
        return $"Section {_textbookSection} Problem {_problems}";
    }
}
