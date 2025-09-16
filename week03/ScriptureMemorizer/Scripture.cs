using System;


public class Scripture
{
    // This variable holds a Reference object (like "John 3:16")
    // It stores the book name, chapter, and verse(s)
    private Reference _reference;

    // This variable is a list of Word objects
    // Each Word object represents one word from the scripture text
    // Having words in a list makes it possible to hide or show them one by one
    private List<Word> _words;



    public Scripture(Reference reference, string text)
    {
        // Save the reference (like "John 3:16") into the private variable _reference
        _reference = reference;

        // Split the text into individual words (e.g., "For God so loved" -> ["For", "God", "so", "loved"])
        // For each word, create a new Word object
        // Then store all these Word objects inside a List<Word>
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        // Create a random number generator
        Random rand = new Random();

        // Count how many words we have hidden so far
        int hiddenCount = 0;

        // Keep looping until we hide the requested number of words
        while (hiddenCount < numberToHide)
        {
            // Pick a random index from the list of words
            int index = rand.Next(_words.Count);

            // Check if the word at that position is already hidden
            if (!_words[index].IsHidden())
            {
                // If it is not hidden, hide it
                _words[index].Hide();

                // Increase the hidden counter
                hiddenCount++;
            }

            // If it is already hidden, the loop will try again
        }
    }

    public string GetDisplayText()
    {
        // Take every Word object in the _words list
        // Call GetDisplayText() on each one
        // If the word is hidden, it returns underscores ("_____")
        // If the word is visible, it returns the real word
        // Then join all the results back into a single string, separated by spaces
        string text = string.Join(" ", _words.Select(word => word.GetDisplayText()));

        // Return the final text to display
        // This includes the reference (like "John 3:16") followed by the scripture words
        return $"{_reference.GetDisplayText()} - {text}";
    }

    public bool IsCompletelyHidden()
    {
        // Check every Word object in the _words list
        // word => word.IsHidden() means: "for each word, check if it's hidden"
        // .All(...) returns true only if *all* the words are hidden
        // If even one word is not hidden, it will return false
        return _words.All(word => word.IsHidden());
    }

}