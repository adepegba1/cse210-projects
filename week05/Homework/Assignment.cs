// Import the System namespace, which gives access to basic C# classes like Console
using System;

// Define a class named "Assignment"
public class Assignment
{
    // Private field (variable) to hold the student's name
    private string _studentName;

    // Private field (variable) to hold the topic of the assignment
    private string _topic;

    // Constructor: this special method runs when you create a new Assignment object
    // It takes a student's name and a topic and stores them in the private fields
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    // Method that returns the student's name
    public string GetStudentName()
    {
        return _studentName;
    }

    // Method that returns the assignment topic
    public string GetTopic()
    {
        return _topic;
    }

    // Method that returns a summary (both name and topic together in one string)
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
