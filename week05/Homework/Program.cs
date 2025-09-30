// Import the System namespace, which allows us to use the Console for printing output
using System;

// Define a class called Program
class Program
{
    // The Main method: this is where the program starts running
    static void Main(string[] args)
    {
        // Create a new Assignment object with student name "Samuel Bennett" 
        // and topic "Multiplication"
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");

        // Print the summary of the assignment (student name and topic)
        Console.WriteLine(a1.GetSummary());

        // Create a MathAssignment object (a more specific type of assignment)
        // with student name "Roberto Rodriguez", topic "Fractions",
        // section "7.3" and problems "8-19"
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        // Print the summary for the math assignment (inherited from Assignment)
        Console.WriteLine(a2.GetSummary());

        // Print the homework list (a method specific to MathAssignment)
        Console.WriteLine(a2.GetHomeworkList());

        // Create a WritingAssignment object with student name "Mary Waters", 
        // topic "European History", and title "The Causes of World War II"
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        // Print the summary for the writing assignment (inherited from Assignment)
        Console.WriteLine(a3.GetSummary());

        // Print the writing information (a method specific to WritingAssignment)
        Console.WriteLine(a3.GetWritingInformation());
    }
}
