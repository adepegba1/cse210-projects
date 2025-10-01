// Exceeding Requirements: Keeping a log of how many times activities were performed.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Counters to keep track of how many times each activity is done
        int reflect = 0;
        int list = 0;
        int breathe = 0;

        // Clear the console screen at the start
        Console.Clear();

        // Loop keeps showing the menu until the user chooses to quit
        while (true)
        {
            // Display menu options to the user
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Read the user's choice from the keyboard
            string action = Console.ReadLine();

            // Clear the console after the user makes a choice
            Console.Clear();

            // If the user chooses "4" → end the program
            if (action == "4")
            {
                // Show how many times each activity was performed
                Console.WriteLine($"Breathing activity performed {breathe} time(s).");
                Console.WriteLine($"Reflecting activity performed {reflect} time(s).");
                Console.WriteLine($"Listing activity performed {list} time(s).");

                // Show the total number of activities performed
                Console.WriteLine($"Total activities performed: {list + breathe + reflect}");

                // Break ends the while loop → program stops
                break;
            }
            // If the user chooses "1" → run BreathingActivity
            else if (action == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();              // Run the activity
                breathing.ShowSpinner(5);     // Show spinner for 5 seconds
                breathe++;                    // Increase the breathing counter by 1
            }
            // If the user chooses "2" → run ReflectingActivity
            else if (action == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();             // Run the activity
                reflecting.ShowSpinner(5);    // Show spinner for 5 seconds
                reflect++;                    // Increase the reflecting counter by 1
            }
            // If the user chooses "3" → run ListingActivity
            else if (action == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();                // Run the activity
                listing.ShowSpinner(5);       // Show spinner for 5 seconds
                list++;                       // Increase the listing counter by 1
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(3000);
            }

            // Clear the screen before showing the menu again
            Console.Clear();
        }
    }
}
