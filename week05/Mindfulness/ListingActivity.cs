using System;

// This class represents the "ListingActivity"
// It inherits from the base "Activity" class, so it reuses common methods like DisplayStartingMessage, ShowCountDown, etc.
public class ListingActivity : Activity
{
    // Keeps track of how many items the user listed
    private int _count;

    // Stores a collection of prompts (questions to ask the user)
    private List<string> _prompts = new List<string>();
    
    // Constructor: when a new ListingActivity is created, it sets the activity name and description (through the base class)
    // It also fills the _prompts list with different questions
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    // This method runs the full activity
    public void Run()
    {
        // Show the standard starting message (inherited from the base class)
        DisplayStartingMessage();

        // Pick and display a random prompt for the user
        GetRandomPrompt();

        // Let the user type their answers until time runs out
        GetListFromUser();        

        // Tell the user how many items they listed
        Console.WriteLine($"You have listed {_count} items");
        Console.WriteLine();

        // Show the standard ending message (inherited from the base class)
        DisplayEndingMessage();
    }

    // This method chooses a random prompt from the list and shows it to the user
    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt\n");

        // Create a random number generator
        Random rand = new Random();

        // Pick a random index based on how many prompts exist
        int index = rand.Next(_prompts.Count);

        // Display the selected prompt
        Console.WriteLine($"---- {_prompts[index]} ----\n");

        // Give the user a short countdown before they start typing
        Console.Write("You may begin in...");
        ShowCountDown(5);    
    }

    // This method collects answers from the user until the timer runs out
    public List<String> GetListFromUser()
    {
        // A list to hold all of the user's responses
        List<string> answers = new List<string>();

        // Calculate the end time by adding the duration to the current time
        DateTime endtime = GetEndTime();

        Console.WriteLine();

        // Keep asking for responses until the current time passes the end time
        while (DateTime.Now < endtime)
        {
            Console.Write(">"); // prompt symbol
            string answer = Console.ReadLine(); // read the user's input
            answers.Add(answer); // add the input to the answers list
        }        

        // Store how many answers were given
        _count = answers.Count;

        // Return the full list of answers in case it's needed later
        return answers;
    }
}
