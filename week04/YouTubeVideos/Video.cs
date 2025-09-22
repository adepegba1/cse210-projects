using System;

// Class to represent a Video
public class Video
{
    // Title of the video
    public string _title; 
    // Author/uploader of the video               
    public string _author; 
    // Length of the video in seconds              
    public int _lengthInSeconds;
    // List of comments on this video         
    public List<Comment> _comments;      

    // Constructor to create a new Video
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        // Always initialize the list
        _comments = new List<Comment>(); 
    }

    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Return the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Display video details + comments
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_lengthInSeconds} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}:");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}