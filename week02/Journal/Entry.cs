using System;  
// Import the System namespace, which gives access to Console and other basic classes.

public class Entry  
// Define a class named Entry. Each object of this class will represent a single journal entry.
{
    public string _date;  
    // A public field that stores the date of the journal entry as a string.

    public string _PromptText;  
    // A public field that stores the prompt or question for the journal entry.

    public string _EntryText;  
    // A public field that stores the actual text/content of the user's journal response.

    public void Display()  
    // A method inside the Entry class that displays the entry details when called.
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_PromptText}");  
        // Print the entry's date and prompt text in one line using string interpolation.

        Console.WriteLine($"{_EntryText}");  
        // Print the entry's response text on a new line.

        Console.WriteLine();  
        // Print a blank line for spacing between entries (makes the output more readable).
    }
}
