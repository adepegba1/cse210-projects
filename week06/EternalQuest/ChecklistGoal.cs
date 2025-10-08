using System;  
// Importing the System namespace — gives access to basic C# functionality like Console and data types.

// Define a class named ChecklistGoal that inherits from (extends) the Goal class.
public class ChecklistGoal : Goal
{
    // Declare a private field to store how many times this goal has been completed so far.
    private int _amountCompleted;

    // Declare a private field to store how many times the goal must be completed to finish it.
    private int _target;

    // Declare a private field to store the bonus points earned when the goal is fully completed.
    private int _bonus;

    // Constructor for the ChecklistGoal class.
    // It takes the goal name, description, points, target number, and bonus amount.
    // The 'base' keyword calls the constructor of the parent (Goal) class.
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;  // Initialize the number of times completed to zero.
        _target = target;      // Store how many times the goal must be completed.
        _bonus = bonus;        // Store the bonus points for full completion.
    }

    // This method is called each time the goal progress is recorded.
    // It overrides the RecordEvent() method from the parent Goal class.
    public override int RecordEvent()
    {
        _amountCompleted++;  // Increase the completed count by 1 whenever the goal is recorded.

        // Check if the number of completions has reached or exceeded the target.
        if (_amountCompleted >= _target)
        {
            int total = Getpoint() + _bonus; // Add base points and bonus points.
            return total;  // Return the total points earned for completing the goal.
        }
        // If the goal has been completed more times than needed.
        else if (_amountCompleted > _target)
        {
            Console.WriteLine("You have completed the goal"); // Inform the user the goal is already done.
            return 0; // No points are awarded after it's fully completed.
        }
        else
        {
            // If not yet complete, return the normal points.
            return Getpoint();
        }
    }

    // This method checks whether the goal is complete.
    public override bool IsComplete()
    {
        // If the number of completions equals the target, return true.
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            // Otherwise, it’s not yet complete.
            return false;
        }
    }

    // Returns a string representation of this goal — used when saving to a file.
    public override string GetStringRepresentation()
    {
        // Format includes all goal data separated by '|' so it can be reloaded later.
        return $"ChecklistGoal:{GetshortName()}|{Getdescription()}|{Getpoint()}|{_bonus}|{_target}|{_amountCompleted}";
    }

    // Returns a detailed string of the goal — used for displaying to the user.
    public override string GetDetailsString()
    {
        string status;

        // Check if the goal is complete to decide what symbol to show.
        if (IsComplete())
        {
            status = "[X]";  // Shows [X] if completed.
        }
        else
        {
            status = "[]";   // Shows [] if not completed.
        }

        // Show name, description, and how many times it's been completed vs. target.
        return $"{status} {GetshortName()} - ({Getdescription()}) --- Currently completed: {_amountCompleted}/{_target}";
    }

    // This setter method allows the program to set the _amountCompleted value manually.
    // (Useful when loading saved progress from a file.)
    public void SetAmountCompleted(int a)
    {
        _amountCompleted = a;
    }
}
