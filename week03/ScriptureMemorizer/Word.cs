// Import the System namespace, which contains basic classes like Console, String, etc.
using System;  

// Define a class named Word
public class Word
{
    // A private variable to store the actual word text
    private string _text;
    
    // A private variable to track if the word is hidden or not (true = hidden, false = visible)
    private bool _isHidden;
    
    // Constructor: runs when you create a new Word object and takes the word text as input
    public Word(string text)    
    {
        // Store the given text in the _text variable
        _text = text;        
    }

    // Method to hide the word
    public void Hide()
    {
        // Set the hidden flag to true (meaning the word is now hidden)
        _isHidden = true;        
    }
    
    // Method to show the word
    public void Show()
    {
        // Set the hidden flag to false (meaning the word is visible again)
        _isHidden = false;        
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        // Return true if the word is hidden, false otherwise
        return _isHidden;        
    }

    // Method to get what should be displayed for this word
    public string GetDisplayText()
    {
        // If the word is hidden
        if (_isHidden)
        {
            // Return a string of underscores with the same length as the word (e.g., "____")
            return new string('_', _text.Length);            
        }
        // If the word is not hidden
        else
        {
            // Return the actual word text
            return _text;            
        }
    }
}
