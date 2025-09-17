/// <summary>
/// This program displays a list of Bible scriptures.
/// A random scripture is chosen and displayed to the user.
/// The user can keep pressing Enter to gradually hide 3 words at a time,
/// making it a memory exercise to recall the scripture.
/// The user can also type "quit" to end the program at any time.
/// Once all words are hidden, the program ends automatically.
/// </summary>
/// <remarks>
/// How it works step by step:
/// 1. A random scripture is picked from the list.
/// 2. The scripture is displayed in the console.
/// 3. The user can press Enter to hide 2 random words.
/// 4. If the user types "quit", the program ends immediately.
/// 5. If all words are hidden, the program tells the user and ends.
/// </remarks>


// Allows us to use basic .NET features like Console, List, Random
using System;

class Program
{
    static void Main(string[] args) // Program starts here
    {
        // Create a random number generator
        Random rand = new Random();

        // Create a list (collection) to store scriptures
        List<Scripture> scriptures = new List<Scripture>();

        // Add different scriptures (Bible verses) to the list
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge Him, and He will make straight your paths."));

        scriptures.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through God who strengthens me"));

        scriptures.Add(new Scripture(new Reference("Joshua", 1, 9), "Have I not commanded you? Be strong and courageous. Do not be afraid; do not be discouraged, for the LORD your God will be with you wherever you go"));

        scriptures.Add(new Scripture(new Reference("2 Corinthians", 4, 16, 18), "So we do not lose heart. Though our outer self is wasting away, our inner self is being renewed day by day. For this light momentary affliction is preparing for us an eternal weight of glory beyond all comparison, as we look not to the things that are seen but to the things that are unseen. For the things that are seen are transient, but the things that are unseen are eternal"));

        scriptures.Add(new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."));

        scriptures.Add(new Scripture(new Reference("Psalm", 23, 1), "The LORD is my shepherd; I shall not want"));

        scriptures.Add(new Scripture(new Reference("Psalm", 34, 8), "Taste and see that the Lord is good; blessed is the one who takes refuge in him."));

        scriptures.Add(new Scripture(new Reference("Jeremiah", 29, 11), "For I know the plans I have for you, declares the LORD, plans to prosper you and not to harm you, plans to give you hope and a future"));

        scriptures.Add(new Scripture(new Reference("John", 16, 33), "I have told you these things, so that in me you may have peace. In this world, you will have trouble. But take heart! I have overcome the world"));

        scriptures.Add(new Scripture(new Reference("Deuteronomy", 31, 6), "Be strong and of good courage. Do not be afraid because of them, for the LORD your God goes with you; he will never leave you nor forsake you"));

        scriptures.Add(new Scripture(new Reference("Isaiah", 41, 10), "So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand"));

        scriptures.Add(new Scripture(new Reference("1 John", 4, 18), "There is no fear in love. But perfect love drives out fear, because fear has to do with punishment. The one who fears is not made perfect in love"));

        // Pick a random scripture from the list
        int index = rand.Next(scriptures.Count);

        // Start an endless loop (we will break out when user types quit or all words are hidden)
        while (true)
        {
            // Clears the console screen so every time we show scripture it looks fresh
            Console.Clear();

            // Show the current scripture with some words hidden (if any)
            Console.WriteLine(scriptures[index].GetDisplayText());

            // Ask the user if they want to continue hiding words or stop
            Console.Write("\nPress Enter to continue or type 'quit' to exit.: ");

            // Read the user’s input (either empty Enter or 'quit')
            string input = Console.ReadLine();


            if (input.ToLower() == "quit")
            {
                // If the user typed "quit", show goodbye message
                Console.WriteLine("Program end successfully");

                // Exit the loop, ending the program
                break;
            }

            // Hide 2 random words from the scripture (or fewer if less are left)
            scriptures[index].HideRandomWords(2);

            // Clear the screen again before showing updated scripture
            Console.Clear();

            // Show the scripture again with more words hidden
            Console.WriteLine(scriptures[index].GetDisplayText());

            if (scriptures[index].IsCompletelyHidden())
            {
                // If every single word is now hidden, tell the user
                Console.WriteLine("\nAll words are hidden");

                // Show a goodbye message
                Console.WriteLine("Program end successfully");

                // Exit the loop because nothing more can be hidden
                break;

            }

        }
    }
}