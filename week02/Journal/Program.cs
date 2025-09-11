using System;  
// Import the System namespace, gives access to basic classes like Console, DateTime, etc.

class Program  
// Define the main Program class that contains the entry point of the application.
{
    static void Main(string[] args)  
    // The Main method: entry point of the application.
    {
        DateTime theCurrentTime = DateTime.Now;  
        // Capture the current system date and time.
        
        Journal ListJournal = new Journal();  
        // Create a new Journal object to store all the entries.

        PromptGenerator prompt = new PromptGenerator();  
        // Create a new PromptGenerator object that will provide random prompts.

        // Add several prompt strings into the _prompts list of the PromptGenerator.
        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("What did you learn today?");
        prompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("If I had one thing I could do over today, what would it be?");

        while (true)  
        // Infinite loop to keep the program running until the user chooses to quit.
        {
            // Show the user a menu of choices.
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            
            string Choice = Console.ReadLine();  
            // Read the user's menu choice from the console.

            if (Choice == "5")  
            // If the user chooses option 5 (Quit)...
            {
                Console.WriteLine("Goodbye!");  
                // Say goodbye...
                break;  
                // Exit the while loop, ending the program.
            }
            else if (Choice == "1")  
            // If the user chooses option 1 (Write)...
            {
                Entry newData = new Entry();  
                // Create a new Entry object to hold the journal entry.

                newData._PromptText = prompt.GetRandomPrompt();  
                // Get a random prompt from the PromptGenerator.

                Console.WriteLine(newData._PromptText);  
                // Display the random prompt to the user.

                newData._date = theCurrentTime.ToShortDateString();  
                // Store the current date (short format, e.g. 09/09/2025).

                newData._EntryText = Console.ReadLine();  
                // Capture the user’s response to the prompt.

                ListJournal.AddEntry(newData);  
                // Add the new Entry object into the Journal.
            }
            else if (Choice == "2")  
            // If the user chooses option 2 (Display)...
            {
                ListJournal.DisplayAll();  
                // Show all entries currently in the Journal.
            }
            else if (Choice == "3")  
            // If the user chooses option 3 (Load)...
            {
                Console.WriteLine("What is the filename? ");  
                // Ask the user for a filename to load.

                string FileName = Console.ReadLine();  
                // Read the filename from the user.

                ListJournal.LoadFromFile(FileName);  
                // Load entries from the file into the Journal.

                Console.WriteLine("Journal Loaded");  
                // Confirm successful load.
            }
            else if (Choice == "4")  
            // If the user chooses option 4 (Save)...
            {
                Console.WriteLine("What is the filename? ");  
                // Ask the user for a filename to save into.

                string SaveName = Console.ReadLine();  
                // Read the filename from the user.

                ListJournal.SaveToFile(SaveName);  
                // Save all journal entries into the file.

                Console.WriteLine("Journal Saved");  
                // Confirm successful save.
            }
            else  
            // If the user types anything else...
            {
                Console.WriteLine("Invalid choice, please try again.");  
                // Show error message.
            }

            Console.WriteLine();  
            // Print an empty line for spacing after each operation.
        }
    }
}
