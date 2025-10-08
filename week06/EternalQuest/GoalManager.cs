using System.IO;  
// Import the System.IO namespace to allow reading and writing files (for saving/loading goals)

public class GoalManager
{
    // A list to store all the goals created by the user
    private List<Goal> _goal = new List<Goal>();

    // Variable to store the player's total score
    private int _score = 0;

    // Temporary variables to hold goal details during creation
    // private string _shortName;
    // private string _description;
    // private int _points;

    public GoalManager()
    {
        // Empty constructor – runs when you create a new GoalManager object
    }

    // Main function to run the entire program logic
    public void Start()
    {
        string choice = "0";  // Used to store the user's menu choice

        // Loop until the user selects "6" (Quit)
        while (choice != "6")
        {
            if (_score > 1000)
            {
                Console.WriteLine("🎉Congratulations, you meet the 1,000 points target!!");
                _score = 0;
            }
            // Display current points
            Console.WriteLine($"Your point is {_score}");
            Console.WriteLine();

            // Display menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goals");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Goals");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();  // Get user’s input

            switch (choice)
            {
                // --- Create new goals ---
                case "1":
                    CreateGoal();
                    break;                    

                // --- Display all goals ---
                case "2":
                    ListGoalDetails(); // Show all goals with details
                    break;

                // --- Save goals to a file ---
                case "3":
                    SaveGoals();
                    break;

                // --- Load goals from a file ---
                case "4":
                    LoadGoals();
                    break;

                // --- Record goal completion ---
                case "5":
                    RecordEvent();                    
                    break;

                // --- Exit program ---
                case "6":
                    Console.WriteLine("Program Ended!!");
                    break;

                // --- Invalid input ---
                default:
                    Console.WriteLine("invalid option. Try again!!");
                    break;
            }
        }
    }

    // Returns the player's current total score
    public int DisplayPlayerInfo()
    {
        return _score;
    }

    // Displays the available goal types (Simple, Eternal, Checklist)
    public void ListGoalNames()
    {
        List<string> goalNames = new List<string>();
        goalNames.Add("1. Simple Goal");
        goalNames.Add("2. Eternal Goal");
        goalNames.Add("3. Checklist Goal");

        // Loop through list and display each goal type
        for (int i = 0; i < goalNames.Count; i++)
        {
            Console.WriteLine($"\t{goalNames[i]}");
        }
    }

    // Displays all the goals created with their details
    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        int i = 1;
        foreach (Goal goal in _goal)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    // Collects information from the user to create a goal
    public void CreateGoal()
    {
        ListGoalNames(); // Show types of goals available        
        Console.Write("What type of goal would you like to create: ");
        string goalType = Console.ReadLine(); // Get goal type (1, 2, or 3)
        
        // Ask user for goal details
        Console.Write("What is the name of the goal: ");
        string shortName = Console.ReadLine();

        Console.Write("What is the description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("How many point to give if goal is accomplished: ");
        int points = int.Parse(Console.ReadLine());
        
        switch (goalType)
        {
            case "1": // Create a SimpleGoal                    

                _goal.Add(new SimpleGoal(shortName, description, points)); // Add goal to list
                break;

            case "2": // Create an EternalGoal

                _goal.Add(new EternalGoal(shortName, description, points)); // Add goal to list
                break;

            case "3": // Create a ChecklistGoal

                Console.Write("How many times does this goal need to be accomplished: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus of accomplishing this goal: ");
                int bonus = int.Parse(Console.ReadLine());

                _goal.Add(new ChecklistGoal(shortName, description, points, target, bonus)); // Add goal to list
                break;

            default:
                Console.WriteLine("Incorrect option");
                break;
        }
    }

    // Displays list of goals for the user to select which one they completed
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goal)
        {
            Console.WriteLine($"{i} {goal.GetshortName()}");
            i++;
        }
        Console.Write("Which goal have you completed: ");
        int input = int.Parse(Console.ReadLine()) - 1; // User picks a goal number

        // Ensure input is within valid range
        if (input >= 0 && input <= _goal.Count)
        {
            // Add points from completed goal to total score
            _score += _goal[input].RecordEvent();
        }
    }

    // Saves goals and score to a text file
    public void SaveGoals()
    {
        Console.Write("What name did you want to save the file: ");
        string fileName = Console.ReadLine();

        // Create and write to the file using StreamWriter
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(DisplayPlayerInfo()); // Write total score on first line
            foreach (Goal goal in _goal)
            {
                // Write each goal as a formatted line
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goal saved successfully");
    }

    // Loads goals and score from a previously saved file
    public void LoadGoals()
    {
        Console.Write("What is the name of the goal file: ");
        string filename = Console.ReadLine();

        // Read all lines from the file
        string[] lines = File.ReadAllLines(filename);

        // The first line is the score
        _score = int.Parse(lines[0]);

        // Loop through the remaining lines (each goal)
        for (int i = 1; i < lines.Length; i++)
        {
            // Split line into goal type and data using ':'
            string[] parts = lines[i].Split(':');
            string goalType = parts[0];
            string[] goalData = parts[1].Split("|");

            // Check which type of goal to recreate
            if (goalType == "SimpleGoal")
            {
                SimpleGoal s = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                _goal.Add(s);
                s.SetIscomplete(Convert.ToBoolean(goalData[3])); // Mark as completed if True
            }
            else if (goalType == "EnternalGoal")
            {
                _goal.Add(new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2])));
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal c = new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]),
                                                    int.Parse(goalData[4]), int.Parse(goalData[3]));
                _goal.Add(c);
                c.SetAmountCompleted(int.Parse(goalData[5])); // Restore progress count
            }
        }

        Console.WriteLine("Goals loaded successfully");
    }
}
