using System;  
// Import the System namespace, needed for Console and general C# classes.

public class Journal  
// Define a class named Journal. This class manages a collection of Entry objects.
{
    public List<Entry> _entries = new List<Entry>();  
    // A list to store all the journal entries. Each element in the list is an Entry object.

    public void AddEntry(Entry newEntry)  
    // Method to add a new Entry object to the journal.
    {
        _entries.Add(newEntry);  
        // Append the newEntry to the _entries list.
    }

    public void DisplayAll()  
    // Method to display all entries in the journal.
    {
        if (_entries.Count == 0)  
        // Check if the list is empty (no entries).
        {
            Console.WriteLine("The journal is empty.");  
            // If no entries exist, print this message.
            return;  
            // Exit the method early since there is nothing to display.
        }
        else
        {
           foreach (Entry entry in _entries)  
           // Loop through each Entry object in the list.
            {
                entry.Display();  
                // Call the Display() method from the Entry class to show the entry details.
            } 
        }
    }

    public void SaveToFile(string file)  
    // Method to save all entries to a file.
    {
        using (StreamWriter outputFile = new StreamWriter(file))  
        // Open a file (create/overwrite). The "using" statement ensures the file is closed after writing.
        {
            foreach (Entry entry in _entries)  
            // Loop through each entry in the journal.
            {
                outputFile.WriteLine($"{entry._date}|{entry._PromptText}|{entry._EntryText}");  
                // Write the entry's fields into the file, separated by "|".
            }
        }
        // File is automatically closed after leaving the using block.
    }

    public void LoadFromFile(string file)  
    // Method to load journal entries from a file.
    {
        string[] lines = System.IO.File.ReadAllLines(file);  
        // Read all lines from the specified file into a string array.

        foreach (string line in lines)  
        // Loop through each line in the file.
        {
            string[] parts = line.Split("|");  
            // Split the line into 3 parts (date, prompt, entry text) using "|" as the separator.

            if (parts.Length == 3)  
            // Only process lines that have exactly 3 parts.
            {
                Entry loadedEntry = new Entry();  
                // Create a new Entry object.

                loadedEntry._date = parts[0];  
                // Assign the first part as the date.
                loadedEntry._PromptText = parts[1];  
                // Assign the second part as the prompt.
                loadedEntry._EntryText = parts[2];  
                // Assign the third part as the entry text.

                _entries.Add(loadedEntry);  
                // Add the loaded entry into the journal's list of entries.
            }
        }
    }
}
