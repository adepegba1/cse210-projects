using System;  
// Import the System namespace, which provides access to base classes like Random and Console.

public class PromptGenerator  
// Define a class named PromptGenerator. Its purpose is to provide random prompts for the journal.
{
    Random random = new Random();  
    // Create a Random object. This will be used to generate random numbers.

    public List<string> _prompts = new List<string>();  
    // A public list of strings that stores all possible prompts.
    // Example: "What did you learn today?", "What made you happy?"

    public string GetRandomPrompt()  
    // Method that returns a random prompt from the _prompts list.
    {
        int randomIndex = random.Next(_prompts.Count);  
        // Generate a random index number between 0 and the number of prompts in the list (exclusive).

        string randomString = _prompts[randomIndex];  
        // Retrieve the string (prompt) at the randomly generated index.

        return randomString;  
        // Return the randomly chosen prompt to the caller.
    }
}
