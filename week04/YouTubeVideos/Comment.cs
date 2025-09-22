using System;

// Class to represent a Comment
public class Comment
{
    // Who made the comment
    public string _personName;

    // The content of the comment
    public string _commentText;

    // Constructor to create a new Comment
    public Comment(string personName, string commentText)
    {
        _personName = personName;
        _commentText = commentText;
    }

    // Method to display a comment
    public void DisplayComment()
    {
        Console.WriteLine($"{_personName}: {_commentText}");
    }
}



