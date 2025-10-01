using System;

// The ReflectingActivity class inherits from Activity.
// It guides the user to reflect on past experiences by showing prompts and questions.
public class ReflectingActivity : Activity
{
    // Random object to help us select random prompts and questions.
    Random rand = new Random();

    // A list of prompts that will ask the user to recall meaningful experiences.
    private List<string> _prompts = new List<string>();

    // A list of follow-up questions to help the user reflect on their chosen experience.
    private List<string> _questions = new List<string>();

    // Constructor: when ReflectingActivity is created, it gives the activity a name and description
    // and fills the lists with some prompts and questions.
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        // Add example prompts for the user to think about
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless");

        // Add example reflection questions about the chosen experience
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    // Run() controls the whole activity: start, show a prompt, ask questions, and end.
    public void Run()
    {
        DisplayStartingMessage();   // Show the standard opening message (from Activity class)
        DisplayPrompt();            // Show a random prompt to the user
        DisplayQuestions();         // Show random reflection questions
        Console.WriteLine();
        DisplayEndingMessage();     // Show the standard closing message (from Activity class)
    }

    // Picks a random prompt from the _prompts list.
    public string GetRandomPrompt()
    {
        int index = rand.Next(_prompts.Count);  // choose a random number between 0 and list size
        return _prompts[index];                 // return the prompt at that position
    }

    // Picks a random question from the _questions list.
    public string GetRandomQuestion()
    {
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    // Shows the random prompt to the user and waits for them to press Enter before starting.
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ----"); // Show the chosen prompt
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine(); // Wait until the user presses Enter

        // After pressing Enter, tell the user they will answer reflection questions
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5); // Count down from 5 before starting
        Console.WriteLine("\n"); 
    }

    // Continuously asks random reflection questions until the activity time ends.
    public void DisplayQuestions()
    {
        DateTime endtime = GetEndTime(); // Get the future time when the activity should end
        while (DateTime.Now < endtime)   // Keep looping until the current time reaches that future time
        {
            Console.Write(GetRandomQuestion()); // Show a random question
            ShowSpinner(3);                     // Pause for 3 seconds with a spinner animation
            Console.WriteLine();                // Go to the next line
        }
    }
}
