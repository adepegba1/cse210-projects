// Import the System namespace (gives access to basic .NET features like Console, Strings, etc.)
using System;

// Define a new class called WritingAssignment that inherits from the Assignment class
public class WritingAssignment : Assignment
{
    // Declare a private field to store the title of the writing assignment
    private string _title;

    // This is the constructor method for WritingAssignment
    // It takes in 3 parameters: name, topic, and title
    // "base(name, topic)" passes the name and topic to the parent (Assignment) constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        // Store the title value passed into the constructor inside the private field _title
        _title = title;
    }

    // A method to return formatted information about the writing assignment
    public string GetWritingInformation()
    {
        // It returns a string showing the title of the assignment followed by "by" and the student’s name
        // GetStudentName() comes from the parent Assignment class
        return $"{_title} by {GetStudentName()}";
    }
}